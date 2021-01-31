using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NationalArchive;
using NationalArchive.Client;
using System.Net.Http;

namespace NationalArchive.Test
{
    [TestClass]
    public class TNARecordDetails_UnitTest
    {
        Mock<ILogger<TNARecordDetails>> loggerServiceMock;
 
        public TNARecordDetails_UnitTest()
        {
            loggerServiceMock = new Mock<ILogger<TNARecordDetails>>();
          }
        [TestMethod]
        public void GetTitleOfRecordByRecordId_OK()
        {
            using (TNARecordDetails tnaRecordDetails = new TNARecordDetails(loggerServiceMock.Object))
            {
                string recordId = "f28ea4e6-e76e-4458-8989-f6d9434bbd8d";
                var record = tnaRecordDetails.GetRecordByRecordId(recordId).Result;
                Assert.IsNotNull(record.Title);
            }

        }
        [TestMethod]
        public  void GetTitleOfRecordByRecordId_GetContentDescription()
        {
            using (TNARecordDetails tnaRecordDetails = new TNARecordDetails(loggerServiceMock.Object))
            {
                string recordId = "a147aa58-38c5-45fb-a340-4a348efa01e6";
                string expected = "<p>Titan Tractor</p>";
                var record = tnaRecordDetails.GetRecordByRecordId(recordId).Result;
                Assert.IsNotNull(record.ScopeContent.Description);
                Assert.AreEqual(expected, record.ScopeContent.Description);
            }

        }
        [TestMethod]
        public void GetTitleOfRecordByRecordId_CitableReference_OK()
        {
           //TODO - I dont find record only with CitableReference
            //using (RecordFileAuthorityClient recordFileAuthorityClient = new RecordFileAuthorityClient(loggerServiceMock.Object))
            //{
            //    string recordId = "f28ea4e6-e76e-4458-8989-f6d9434bbd8d";
            //    string expected = "DACHT/Business/";
            //    var record = recordFileAuthorityClient.GetRecordByRecordId(recordId).Result;
            //    Assert.IsNotNull(record.CitableReference);
            // //   Assert.AreEqual(expected, record.CitableReference);
            //}

        }
        [TestMethod]
        public  void GetTitleOfRecordByRecordId_NotSufficientInformation()
        {
            using (TNARecordDetails tnaRecordDetails = new TNARecordDetails(loggerServiceMock.Object))
            {
                string recordId = "a147aa58-38c5-45fb-a340-4a348a01e6";
                string expected = "Not sufficient information";
                var record = tnaRecordDetails.GetRecordByRecordId(recordId).Result;
                Assert.AreEqual(expected, record);
            }
        }


        [TestMethod]
        public  void GetTitleRegister_NotContent()
        {
            using (TNARecordDetails tnaRecordDetails = new TNARecordDetails(loggerServiceMock.Object))
            {
                string recordId = "a147aa58-38c5-45fb-a340-4a348a01e6";
                var record = tnaRecordDetails.GetRecordByRecordId(recordId).Result;
                Assert.IsNull(record);
            }
        }
    }
}

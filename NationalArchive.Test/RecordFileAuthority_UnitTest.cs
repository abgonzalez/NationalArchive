using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NationalArchive;
using System.Net.Http;

namespace NationalArchive.Test
{
    [TestClass]
    public class RecordFileAuthority_UnitTest
    {
        Mock<ILogger<RecordFileAuthorityClient>> loggerServiceMock;
        
        public RecordFileAuthority_UnitTest()
        {
            loggerServiceMock = new Mock<ILogger<RecordFileAuthorityClient>>();
        }
        [TestMethod]
        public void GetTitleOfRecordByRecordId_OK()
        {
            using (RecordFileAuthorityClient recordFileAuthorityClient = new RecordFileAuthorityClient(loggerServiceMock.Object))
            {
                string recordId = "f28ea4e6-e76e-4458-8989-f6d9434bbd8d";
                var record = recordFileAuthorityClient.GetRecordByRecordId(recordId).Result;
                Assert.IsNotNull(record.Title);
            }

        }
        [TestMethod]
        public  void GetTitleOfRecordByRecordId_GetContentDescription()
        {
            using (RecordFileAuthorityClient recordFileAuthorityClient = new RecordFileAuthorityClient(loggerServiceMock.Object))
            {
                string recordId = "a147aa58-38c5-45fb-a340-4a348efa01e6";
                string expected = "<p>Titan Tractor</p>";
                var record = recordFileAuthorityClient.GetRecordByRecordId(recordId).Result;
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
            //TODO -  I dont find record only with this data
            //using (RecordFileAuthorityClient recordFileAuthorityClient = new RecordFileAuthorityClient(loggerServiceMock.Object))
            //{
            //    string recordId = "a147aa58-38c5-45fb-a340-4a348a01e6";
            //    string expected = "Not sufficient information";
            //    var record = recordFileAuthorityClient.GetRecordByRecordId(recordId).Result;
            //    Assert.AreEqual(expected, record);
            //}
        }


        [TestMethod]
        public  void GetTitleRegister_NotContent()
        {
            using (RecordFileAuthorityClient recordFileAuthorityClient = new RecordFileAuthorityClient(loggerServiceMock.Object))
            {
                string recordId = "a147aa58-38c5-45fb-a340-4a348a01e6";
                var record = recordFileAuthorityClient.GetRecordByRecordId(recordId).Result;
                Assert.IsNull(record);
            }
        }
    }
}

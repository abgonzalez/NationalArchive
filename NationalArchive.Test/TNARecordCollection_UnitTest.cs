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
    public class TNARecordCollection_UnitTest
    {
        Mock<ILogger<TNARecordDetails>> loggerRecordDetailsServiceMock;
        Mock<ILogger<TNARecordCollection>> loggerRecordCollectionServiceMock;

        public TNARecordCollection_UnitTest()
        {
            loggerRecordDetailsServiceMock = new Mock<ILogger<TNARecordDetails>>();
            loggerRecordCollectionServiceMock = new Mock<ILogger<TNARecordCollection>>();
        }
      
        [TestMethod]
        public void GetTitleOfRecordByRecordId_CitableReference_OK()
        {
            TNARecordDetails tnaRecordDetails = new TNARecordDetails(loggerRecordDetailsServiceMock.Object);

            using (TNARecordCollection tnaRecordCollection = new TNARecordCollection(loggerRecordCollectionServiceMock.Object, tnaRecordDetails))
            {
                string reference = "HO 334/228/1245";
                var record = tnaRecordCollection.GetIdsWithoutTitleScopeContentByReference(reference);
            }

        }

    }
}

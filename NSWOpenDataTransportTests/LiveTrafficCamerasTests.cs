using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSWOpenDataTransportLibrary;
using NSWOpenDataTransportLibrary.Common;
using System.Threading.Tasks;

namespace NSWOpenDataTransportTests
{
    [TestClass]
    public class LiveTrafficCamerasTests
    {
        /// <summary>
        /// This test methods hits the API and should return a valid response for a valid request
        /// </summary>
        /// <returns>
        /// LiveTrafficCameras
        /// </returns>
        [TestMethod]
        public async Task LoadLiveTrafficCamerasDataMethodShouldReturnValidResponseForValidRequest()
        {
            // First, check if the connection from the client is setup properly
            ApiHelper.InitializeClient();
            Assert.IsNotNull(ApiHelper.ApiClient);
            Assert.AreEqual(ApiHelper.ApiClient.BaseAddress, "https://api.transport.nsw.gov.au/v1/live/cameras");
           
            // Next, check if we have the required response from the API server
            var results = await LiveTrafficCamerasProcessor.LoadData();
            Assert.IsNotNull(results);
            Assert.IsNotNull(results.Rights);
            Assert.IsNotNull(results.Features);
            Assert.AreEqual(results.Type, Constants.Type);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(results.Rights.Copyright));
            Assert.IsTrue(!string.IsNullOrWhiteSpace(results.Rights.Licence));
            Assert.AreEqual(results.Features[0].Type, Constants.FeatureType);        
            Assert.IsTrue(!string.IsNullOrWhiteSpace(results.Features[0].Id));            
            Assert.IsTrue(!string.IsNullOrWhiteSpace(results.Features[0].Geometry.Coordinates[0].ToString()));            
            Assert.IsTrue(!string.IsNullOrWhiteSpace(results.Features[0].Geometry.Coordinates[1].ToString()));            
            Assert.IsTrue(!string.IsNullOrWhiteSpace(results.Features[0].Properties.Direction));            
        }
    }
}

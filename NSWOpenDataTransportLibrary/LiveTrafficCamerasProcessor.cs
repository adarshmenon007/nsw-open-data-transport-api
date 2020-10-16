using NSWOpenDataTransportLibrary.Interfaces;
using NSWOpenDataTransportLibrary.Model;
using NSWOpenDataTransportLibrary.Model.LiveTrafficCameras;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NSWOpenDataTransportLibrary
{
    public class LiveTrafficCamerasProcessor 
    {
        public static async Task<LiveTrafficCamerasResponse> LoadData() 
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(ApiHelper.ApiClient.BaseAddress))
            {
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        LiveTrafficCamerasResponse responseObject = await response.Content.ReadAsAsync<LiveTrafficCamerasResponse>();

                        return responseObject;
                    }
                    catch(Exception e)
                    {
                        throw e;
                    }                    
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }            
        }
    }
}

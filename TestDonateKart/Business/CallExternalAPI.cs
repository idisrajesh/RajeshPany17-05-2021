using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using TestDonateKart.Utils;

namespace TestDonateKart.Business
{
    public class CallExternalAPI
    {

        public TResponse CallGETApi<TResponse>(CampainEndPoints endpointType)
        {
            try
            {
                string endpoint = GetEndPoints(endpointType);
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(endpoint);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "GET";
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    var responseStream = httpResponse.GetResponseStream();
                    if (responseStream != null)
                    {
                        using (var streamReader = new StreamReader(responseStream))
                        {
                            var responseText = streamReader.ReadToEnd();
                            //-- Now deserialize it back to the responseObject
                            var response = JsonConvert.DeserializeObject<TResponse>(responseText);

                            return response;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return (TResponse)Activator.CreateInstance(typeof(TResponse), true);
        }

        public static string GetEndPoints(CampainEndPoints endpointType)
        {
            var endPoint = string.Empty;

            switch (endpointType)
            {
                case CampainEndPoints.testCampaingn:
                    endPoint = CampaingnUtils.TestCampaingnAPI;
                    break;             
            }

            return endPoint;
        }
    }
}
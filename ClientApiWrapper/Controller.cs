using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using ClientApiWrapper.Models;
using IPS.ClientApi.Messages;

namespace ClientApiWrapper
{
    public class Controller
    {
        public static async Task<ApiResponse> PostAccount(Account postData, string accountId, string username, string password, SubmitDataType dataType)
        {
            var serverResponse = new ApiResponse();

            using (var handler = new HttpClientHandler { Credentials = new NetworkCredential(username, password) })
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri("http://712.dnndev.me/");
                client.DefaultRequestHeaders.Accept.Clear();

                switch (dataType)
                {
                    case SubmitDataType.Xml:
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
                        var response =
                            await
                                client.PostAsXmlAsync(
                                    String.Format("/desktopmodules/ClientApi/Api/Transmit/PostAccount/{0}", accountId),
                                    postData);

                        if (response.IsSuccessStatusCode)
                        {
                            serverResponse = await response.Content.ReadAsAsync<ApiResponse>();
                        }
                    }
                        break;
                    case SubmitDataType.Json:
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/json"));
                        var response =
                            await
                                client.PostAsJsonAsync(
                                    String.Format("/desktopmodules/ClientApi/Api/Transmit/PostAccount/{0}", accountId),
                                    postData);

                        if (response.IsSuccessStatusCode)
                        {
                            serverResponse = await response.Content.ReadAsAsync<ApiResponse>();
                        } 
                    }
                        break;
                }


            }

            return serverResponse;

        }

        public enum SubmitDataType
        {
            Xml,
            Json
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
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

            using (var handler = new HttpClientHandler())
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri("https://www.agencyrevolution.com");
                client.DefaultRequestHeaders.Add("AR-Login", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password)));
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
                            else
                            {
                                serverResponse = new ApiResponse()
                                {
                                    Meta =
                                        new ApiResponse.MetaInfo()
                                        {
                                            Error = response.ReasonPhrase,
                                            ResponseCode = response.StatusCode,
                                            Result = false
                                        }
                                };
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
                            else
                            {
                                serverResponse = new ApiResponse()
                                {
                                    Meta =
                                        new ApiResponse.MetaInfo()
                                        {
                                            Error = response.ReasonPhrase,
                                            ResponseCode = response.StatusCode,
                                            Result = false
                                        }
                                };
                            }
                        }
                        break;
                }


            }

            return serverResponse;

        }


        public static async Task<List<ApiResponse>> PostAccounts(List<Account> postData, string accountId, string username, string password, SubmitDataType dataType)
        {
            var allTasks = new List<Task>();
            var allResponses = new List<ApiResponse>();

            var throttler = new SemaphoreSlim(initialCount: 20, maxCount: 20);
            foreach (var account in postData)
            {

                await throttler.WaitAsync();

                allTasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        try
                        {
                            allResponses.Add(await PostAccount(account, accountId, username, password, dataType));
                        }
                        catch (Exception ex)
                        {
                            allResponses.Add(new ApiResponse()
                            {
                                Account = account,
                                Meta = new ApiResponse.MetaInfo()
                            {
                                Error = ex.ToString(),
                                Result = false
                            }
                            });
                        }
                    }
                    finally
                    {
                        throttler.Release();
                    }
                }));
            }

            await Task.WhenAll(allTasks);

            return allResponses;
        }

        public enum SubmitDataType
        {
            Xml,
            Json
        }
    }
}

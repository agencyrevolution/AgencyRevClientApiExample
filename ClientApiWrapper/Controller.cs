using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClientApiWrapper.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ClientApiWrapper
{
    public class Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="postData">The object to send to AR</param>
        /// <param name="entityType">The entity type (string) such as Customer or Employee</param>
        /// <param name="listId">ListId of User</param>
        /// <param name="authKey">Auth key of corresponding ListId</param>
        /// <param name="dataType">XML or JSON?</param>
        /// <param name="keyField">What field name is the primary key for the root entity?</param>
        /// <param name="system">Identify your AMS with a name</param>
        /// <param name="schemaVersion">Optional version if the schema changes</param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostAccount(object postData, string entityType, string listId, string authKey, string keyField, SubmitDataType dataType, string system, short schemaVersion = 1)
        {

            using (var handler = new HttpClientHandler())
            using (var client = new HttpClient(handler))
            {

#if DEBUG
                var rootUrl = "https://ms--api-agencyrevolution-com-3wj686717b74.runscope.net";
#else
                var rootUrl = ""https://ms-api-agencyrevolution.com/";
#endif

                client.BaseAddress = new Uri(rootUrl);
                client.DefaultRequestHeaders.Add("Ar-Auth-Token", authKey);

                var postObject = new RequestWrapper()
                {
                    Data = new object[] {postData},
                    MetaData = new RequestWrapper.MetaDataObject()
                     {
                         DataType = entityType,
                         KeyField = keyField,
                         ListId = listId,
                         SchemaVersion = schemaVersion,
                         System = system
                     }
                };

                switch (dataType)
                {
                    case SubmitDataType.Xml:
                        {
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                            var response =
                                await
                                    client.PostAsXmlAsync(
                                        "/api/v1/sync-data",
                                        postObject);

                            return response.StatusCode;
                        }
                    case SubmitDataType.Json:
                        {
                            var formatter = new JsonMediaTypeFormatter();
                            formatter.SerializerSettings = new JsonSerializerSettings
                            {
                                Formatting = Formatting.Indented,
                                ContractResolver = new CamelCasePropertyNamesContractResolver()
                            };

                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            var response =
                                await
                                    client.PostAsync(
                                        "/api/v1/sync-data",
                                        postObject, formatter);

                            return response.StatusCode;

                        }
                }


            }
            
           throw new Exception("Unsupported dataType");

        }


        public enum SubmitDataType
        {
            Xml,
            Json
        }
    }
}

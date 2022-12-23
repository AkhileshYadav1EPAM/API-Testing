using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;

namespace RestAPIAutomationFramework.Utilities
{
    public class RestClientUtilities
    {
        static RestClient _RestClient;
        static RestRequest _RestRequest;
        public static RestClient RestClient
        {
            get
            {
                if (_RestClient == null)
                {
                    return new RestClient(
                        //ConfigurationManager.AppSettings["BaseUrl"].ToString()
                        "http://localhost:3000/");
                }
                else
                {
                    return _RestClient;
                }
            }
        }

        public static RestRequest CreateRequest(string resourse, Method method)
        {
            if (_RestRequest == null)
            {
                return new RestRequest(resourse, method);
            }
            else
            {
                return _RestRequest;
            }
        }

        //post
        public static T Post<T>(string resourse, string payload)
        {
            var restRequest = CreateRequest(resourse, Method.Post);
            restRequest.AddJsonBody(payload);
            var response = RestClient.Execute(restRequest);

            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<T>(responseBody);
        }


        //delete 
        public static bool Delete(string resourse, HttpStatusCode exepectedStatusCode)
        {
            return RestClient.Execute
                        (
                            CreateRequest(resourse, Method.Delete)
                        )
                        .StatusCode.Equals(exepectedStatusCode);
        }

        //get
        public static T[] Get<T>(string resource)
        {
            RestResponse response = RestClient.Execute
                                    (
                                        CreateRequest(resource, Method.Get)
                                    );
            return JsonConvert.DeserializeObject<T[]>(response.Content);
        }

        //put
        public static T Put<T>(string resourse, string payload)
        {
            var restRequest = CreateRequest(resourse, Method.Put);
            restRequest.AddJsonBody(payload);
            var response = RestClient.Execute(restRequest);

            var responseBody = response.Content;
            return JsonConvert.DeserializeObject<T>(responseBody);
        }


        //patch
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using NUnit.Framework.Internal;
using Newtonsoft.Json;

namespace AppiumTest
{
    internal class QaseAPI
    {
        static HttpClient client = new HttpClient();

        private static string qaseCode = "MSP";
        private static int suiteId;
        //public static int caseid;

        internal static void RunsInfo()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.qase.io/v1/run/" + qaseCode);
            request.Headers.Add("Token", "6f4b17d91bf68cd998eb6612ca2bcbde5918eec35fc319240a5444f25519dde6");
            using HttpResponseMessage response = client.Send(request);

            var responseResult = response.Content.ReadAsStringAsync().Result;
            var json = JObject.Parse(responseResult);
            foreach (var element in json)
            {
                var result = element.Key;
                if (result.Contains("result"))
                {
                    var res = element.Value;
                    var runs = res["entities"];
                    foreach (var el in runs)
                    {
                        if (el["title"].ToObject<string>() == "Test run Auto")
                        {
                            suiteId = el["id"].ToObject<int>();
                        }
                    }
                }
            }
        }

        internal static void RunCaseResult(int CaseId, string Status)
        {
            StringContent content = new StringContent("{\"results\":[{\"status\":\"" + Status + "\",\"case_id\":" + CaseId + "}]}"); //привести в нормальный вид
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://api.qase.io/v1/result/" + qaseCode + "/" + suiteId + "/bulk");
            content.Headers.Add("Token", "6f4b17d91bf68cd998eb6612ca2bcbde5918eec35fc319240a5444f25519dde6");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            request.Content = content;
            using HttpResponseMessage response = client.Send(request);
        }

    }
}


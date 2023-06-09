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
    internal class QaseAPI // для рана мануал
    {
        static HttpClient client = new HttpClient();

        private static string qaseCode = "MSP";
        private static int suiteId = RunsInfo();
        private static string token = "782c2469ce04d736c2ccf36e11f7a4eb0571aabc39ffbae3cda03a94a052e5a4";

        internal static int RunsInfo()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.qase.io/v1/run/" + qaseCode);
            request.Headers.Add("Token", token);
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
                            return suiteId;
                        }
                        else suiteId = -1;
                    }
                }
            }
            return suiteId; 
        }

        internal static void RunCaseResult(int CaseId, string Status, string Comment)
        {
            StringContent content = new StringContent("{\"results\":[{\"status\":\"" + Status + "\",\"case_id\":" + CaseId + ",\"comment\":\"" + Comment + "\"}]}"); //привести в нормальный вид
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://api.qase.io/v1/result/" + qaseCode + "/" + suiteId + "/bulk");
            content.Headers.Add("Token",token);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            request.Content = content;
            using HttpResponseMessage response = client.Send(request);
        }

    }
}


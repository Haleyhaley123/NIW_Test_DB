using Domain;
using Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAPI
{
    public class ScoreConnectAPI
    {
        public static List<Score> GetScore()
        {
            List<Score> result = new List<Score>();
            RequestBase<List<Score>> resultAPI = new RequestBase<List<Score>>();
            string URL = "https://localhost:7035/api/Score/GetAllSCore";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync(URL).Result;
                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsStreamAsync();
                    Stream dataStreamResponse = dataObjects.Result;
                    StreamReader tReader = new StreamReader(dataStreamResponse);
                    string sResponseFromServer = tReader.ReadToEnd();
                    resultAPI = JsonConvert.DeserializeObject<RequestBase<List<Score>>>(sResponseFromServer);
                }
                if (resultAPI.Data != null && resultAPI.Success)
                {
                    result = resultAPI.Data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                return result;
            }
            return result;
        }


        public static bool InsertScore(Score score)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Score/InsertScore");
                using (var wc = new HttpClient())
                {
                    var modelString = JsonConvert.SerializeObject(score);
                    var content = new StringContent(modelString, Encoding.UTF8, "application/json");
                    var jsonResult = wc.PostAsync($@"{urlapi}", content).Result.Content.ReadAsStringAsync().Result;
                    resultAPI = JsonConvert.DeserializeObject<RequestBase<bool>>(jsonResult);
                }
                if (resultAPI.Success)
                {
                    result = resultAPI.Data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                return result;
            }
            return result;
        }
        public static bool EditStudent(Score editscore)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Score/EditScore");
                using (var wc = new HttpClient())
                {
                    var modelString = JsonConvert.SerializeObject(editscore);
                    var content = new StringContent(modelString, Encoding.UTF8, "application/json");
                    var jsonResult = wc.PutAsync($@"{urlapi}", content).Result.Content.ReadAsStringAsync().Result;
                    resultAPI = JsonConvert.DeserializeObject<RequestBase<bool>>(jsonResult);
                }
                if (resultAPI.Success)
                {
                    result = resultAPI.Data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                return result;
            }
            return result;
        }
        public static bool DeleteStudent(int deletescore)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Score/DeleteScore");
                string urlParameters = $"?id={deletescore}";
                using (var wc = new HttpClient())
                {
                    var jsonResult = wc.DeleteAsync($@"{urlapi + urlParameters}").Result.Content.ReadAsStringAsync().Result;
                    resultAPI = JsonConvert.DeserializeObject<RequestBase<bool>>(jsonResult);
                }
                if (resultAPI.Success)
                {
                    result = resultAPI.Data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                return result;
            }
            return result;
        }
    }
}

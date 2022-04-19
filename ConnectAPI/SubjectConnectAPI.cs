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
    public class SubjectConnectAPI
    {
        public static List<Subject> GetSubject()
        {
            List<Subject> result = new List<Subject>();
            RequestBase<List<Subject>> resultAPI = new RequestBase<List<Subject>>();
            string URL = "https://localhost:7035/api/Subject/GetAllSubject";

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
                    resultAPI = JsonConvert.DeserializeObject<RequestBase<List<Subject>>>(sResponseFromServer);
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


        public static bool InsertSubject(Subject subject)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Subject/InsertSubject");
                using (var wc = new HttpClient())
                {
                    var modelString = JsonConvert.SerializeObject(subject);
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
        public static bool EditSubject(Subject editsubject)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Subject/EditSubject");
                using (var wc = new HttpClient())
                {
                    var modelString = JsonConvert.SerializeObject(editsubject);
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
        public static bool DeleteSubject(int deletesubject)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Subject/DeleteSubject");
                string urlParameters = $"?id={deletesubject}";
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

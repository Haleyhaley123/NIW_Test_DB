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
    public class StudentConnectAPI
    {
        public static List<Student> GetStudent()
        {
            List<Student> result = new List<Student>();
            RequestBase<List<Student>> resultAPI = new RequestBase<List<Student>>();
            string URL = "https://localhost:7035/api/Student/GetAllStudent";

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
                    resultAPI = JsonConvert.DeserializeObject<RequestBase<List<Student>>>(sResponseFromServer);
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


        // loại 2
        public static bool InsertStudent(Student student)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Student/InsertStudent");
                using (var wc = new HttpClient())
                {
                    var modelString = JsonConvert.SerializeObject(student);
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
        public static bool EditStudent(Student editstudent)
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Student/EditStudent");
                using (var wc = new HttpClient())
                {
                    var modelString = JsonConvert.SerializeObject(editstudent);
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
        public static bool DeleteStudent(int idStudent )
        {
            bool result = false;
            RequestBase<bool> resultAPI = new RequestBase<bool>();
            try
            {
                Uri urlapi = new Uri("https://localhost:7035/api/Student/DeleteData");
                string urlParameters = $"?id={idStudent}";
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

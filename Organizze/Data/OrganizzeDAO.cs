using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

using RestSharp;
using RestSharp.Authenticators;

namespace Organizze.Data
{
    public class OrganizzeDAO
    {
        const string BASE_URL = "https://api.organizze.com.br/rest/v2";
        const string ORGANIZZE_LOGIN = "daniel.agra@gmail.com";
        const string ORGANIZZE_KEY = "1f3b87321fb0aca7174c9427b9b3da11dd35d1da";

        public OrganizzeDAO()
        {
        }

        /// <summary>
        /// Get data from an end-point of Organizze
        /// </summary>
        /// <returns>The data transformed into project objects.</returns>
        /// <param name="resourceLink">What comes after the baser URL. Ex.: "transactions" or "transactions/3"</param>
        /// <typeparam name="T">The type that will contain the data. Ex.: "List<Transaction>"</typeparam>
        public T GetData<T>(string resourceLink)
            where T : new()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BASE_URL);
            client.Authenticator = new HttpBasicAuthenticator(ORGANIZZE_LOGIN, ORGANIZZE_KEY);

            RestRequest request = new RestRequest();
            request.Resource = resourceLink;

            IRestResponse response = client.Execute(request);

            string jsonResponse = response.Content;

            T data = new T();

            MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonResponse));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(data.GetType());
            //data = serializer.ReadObject(memoryStream) as T;
            data = (T) Convert.ChangeType(serializer.ReadObject(memoryStream), typeof(T));
            memoryStream.Close();

            return data;
        }

        public void CreateData(string resourceLink)
        {
            String username = ORGANIZZE_LOGIN;
            String password = ORGANIZZE_KEY;
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

            HttpWebRequest httpWebRequest = new HttpWebRequest(new Uri(BASE_URL + resourceLink));
            httpWebRequest.Headers.Add("Authorization", "Basic " + encoded);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
        }

    }
}

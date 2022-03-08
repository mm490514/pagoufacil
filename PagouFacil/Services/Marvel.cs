using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PagouFacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace PagouFacil.Services
{
    public class Marvel
    {
        public string BaseUrl = "http://gateway.marvel.com";

        public List<Personagens> GetPersonagens()
        {

            var ts = 1;
            var apiKey = "473da253b3977826288936c4a61c0991";            
            var hash = "8be15a064f1557728066139e0619aaf6";


            try
            {
                List<Personagens> listaObject = new List<Personagens>();

                var model = new Personagens();

                var action = string.Format("/v1/public/characters?ts={0}&apikey={1}&hash={2}", ts, apiKey, hash);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, BaseUrl + action);

                var response = HttpInstance.GetHttpClientInstance().GetAsync(request.RequestUri.AbsoluteUri).Result;

                var jsonString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                model = JsonConvert.DeserializeObject<Personagens>(jsonString);

                listaObject.Add(model);

                

                var arquivo = JsonConvert.SerializeObject(model);
                var caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

                var JsonFormatted = JValue.Parse(arquivo).ToString();
                System.IO.File.WriteAllText(@"" + caminho + "personagensmarvel.txt", JsonFormatted);            


                return listaObject;
            }
            catch (Exception)
            {
                return null;
            }


        }
    }
}
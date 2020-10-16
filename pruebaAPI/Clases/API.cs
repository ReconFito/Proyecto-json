using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace pruebaAPI.Clases
{
    public class Coneccion
    {
        public Result[] results { get; set; }
        public async Task<Dictionary<int, object>> Get()
        {
            HttpClient cliente = new HttpClient();
            string contenido = await cliente.GetStringAsync("https://randomuser.me/api/");
            
            var d = JsonConvert.DeserializeObject(contenido);
            var s = JsonConvert.SerializeObject(d, Formatting.Indented);

            var apiRespuesta = new Dictionary<int, object>() {
                {1, d },
                {2, s }
            };
            return apiRespuesta;
        }
    }

    public class Result
    {
        public string gender { get; set; }
        public Name name { get; set; }
        public Location location { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Picture picture { get; set; }
        public string nat { get; set; }
    }

    public class Name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class Location
    {
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int postcode { get; set; }
    }

    public class Picture
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }
    }

}
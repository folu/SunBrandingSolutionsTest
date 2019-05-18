using Newtonsoft.Json;
using SunBrandingSolutionsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SunBrandingSolutionsTest.Controllers
{
    public class ApiClient
    {
        private const string BaseURL = "https://coding-interview.azurewebsites.net/api/asset/";
        private const string Code = "?code=RDlFQJ0KDI3GbwU6GqoZ/tukFcGGF21lZR8PhiECkLRjIElGaMoafw";

        private HttpClient client;

        public ApiClient ()
        {
            client = new HttpClient();
        }
        public async Task<ApiAsset> GetAsset (int id)
        {
            string url = BaseURL + id + Code;
            var response = await client.GetAsync(new Uri(url));
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                ApiAsset apiAsset = JsonConvert.DeserializeObject<ApiAsset>(result);
                return apiAsset;
            }
            return null; 
        }
    }
}

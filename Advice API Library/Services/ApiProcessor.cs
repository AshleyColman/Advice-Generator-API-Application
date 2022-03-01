using Advice_API_Library.Models;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace Advice_API_Library.Services
{
    public sealed class ApiProcessor : IApiProcessor
    {
        private readonly IHttpClientFactory factory;

        public ApiProcessor(IHttpClientFactory _factory) => factory = _factory;

        public async Task<Advice> LoadAdvice()
        {
            var client = factory.CreateClient("client");
            using HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode == true)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Advice>(jsonString);
            }
            else
            {
                return new Advice();
            }
        }
    }
}

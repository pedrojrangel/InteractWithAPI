
namespace FrontEndAPI.Services
{
    public class APIServices : IAPIServices
    {
        private readonly HttpClient _httpClient;

        public APIServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<string> GetResponseFromApi(string URI)
        {
           var response = await _httpClient.GetStringAsync(URI);
           return response;
        }
    }
}

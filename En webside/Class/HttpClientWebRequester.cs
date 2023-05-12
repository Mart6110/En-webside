using En_webside.Interface;
using System.Net.Http;
using System.Threading.Tasks;

namespace En_webside.Class
{
    public class HttpClientWebRequester : IRequest
    {
        public async Task<string> GetResponse(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Perform a GET request and retrieve the response as a string
                HttpResponseMessage response = await client.GetAsync(url);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}

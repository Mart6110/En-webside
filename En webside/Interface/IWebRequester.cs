using System.Threading.Tasks;

namespace En_webside.Interface
{
    public interface IWebRequester
    {
        // Interface method for performing a web request and returning the response
        Task<string> GetResponse(string url);
    }
}

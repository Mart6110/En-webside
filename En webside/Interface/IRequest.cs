using System.Threading.Tasks;

namespace En_webside.Interface
{
    public interface IRequest
    {
        // Interface method for performing a web request and returning the response
        Task<string> GetResponse(string url);
    }
}

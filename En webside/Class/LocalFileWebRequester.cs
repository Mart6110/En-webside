using En_webside.Interface;
using System.IO;
using System.Threading.Tasks;

namespace En_webside.Class
{
    public class LocalFileWebRequester : IRequest
    {
        public async Task<string> GetResponse(string filePath)
        {
            // Read the content of the local file
            return await ReadFileContentAsync(filePath);
        }

        private async Task<string> ReadFileContentAsync(string filePath)
        {
            // Implement the file reading logic asynchronously here
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}

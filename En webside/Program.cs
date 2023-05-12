using En_webside.Class;
using En_webside.Interface;
using System;
using System.Threading.Tasks;

namespace En_webside
{
    public class Program
    {
        private readonly IRequest request;
        private readonly IRequest requestFile;

        public Program(IRequest request, IRequest requestFile)
        {
            this.request = request;
            this.requestFile = requestFile;
        }

        public async Task RunAsync()
        {
            Console.WriteLine("Enter the URL: ");
            string url = "https://jsonplaceholder.typicode.com/todos/1"; //Console.ReadLine();
            string filePath = "TestFile.txt"; //Console.ReadLine();

            try
            {
                // Call the GetResponse method of the webRequester to retrieve the web response
                string response = await request.GetResponse(url);

                Console.WriteLine("Response from the server:");
                Console.WriteLine(response);

                Console.WriteLine();
                // Call the GetResponse method of the fileRequester to retrieve the file content
                string filePathResponse = await requestFile.GetResponse(filePath);

                Console.WriteLine("Content from the file:");
                Console.WriteLine(filePathResponse);
            }
            catch (Exception ex)
            {
                // Catch any exception that occurs during the web request and display an error message
                Console.WriteLine("Error during request: " + ex.Message);
            }
        }

        public static async Task Main(string[] args)
        {
            // Create an instance of HttpClientWebRequester, which implements IRequest interface
            IRequest webRequester = new HttpClientWebRequester();

            // Create an instance of LocalFileWebRequester, which implements IWebRequester interface
            IRequest fileRequester = new LocalFileWebRequester();

            // Create an instance of Program and pass the webRequester as a dependency
            Program program = new Program(webRequester, fileRequester);

            // Call the RunAsync method to start the program
            await program.RunAsync();
        }
    }
}

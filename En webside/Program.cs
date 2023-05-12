using En_webside.Class;
using En_webside.Interface;
using System;
using System.Threading.Tasks;

namespace En_webside
{
    public class Program
    {
        private readonly IWebRequester webRequester;

        public Program(IWebRequester webRequester)
        {
            this.webRequester = webRequester;
        }

        public async Task RunAsync()
        {
            Console.Write("Enter the URL: ");
            string url = Console.ReadLine();

            try
            {
                // Call the GetResponse method of the webRequester to retrieve the web response
                string response = await webRequester.GetResponse(url);

                Console.WriteLine("Response from the server:");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                // Catch any exception that occurs during the web request and display an error message
                Console.WriteLine("Error during web request: " + ex.Message);
            }
        }

        public static async Task Main(string[] args)
        {
            // Create an instance of HttpClientWebRequester, which implements IWebRequester interface
            IWebRequester webRequester = new HttpClientWebRequester();

            // Create an instance of Program and pass the webRequester as a dependency
            Program program = new Program(webRequester);

            // Call the RunAsync method to start the program
            await program.RunAsync();
        }
    }
}

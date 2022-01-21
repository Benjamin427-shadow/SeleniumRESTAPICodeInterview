using System;

namespace Code_Interview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Selenium. Go to google finance. Look for five stock symbols. 
            GoogleFinance_UI googleFinance = new GoogleFinance_UI();
            googleFinance.SetupExecution();

            // CRUD operation testing. On singular and multiple cases.
            REST_API_Test restAPITest = new REST_API_Test();
            restAPITest.TestResources();
        }
    }
}

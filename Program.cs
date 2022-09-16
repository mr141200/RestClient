using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var client = new RestClient("http://dummy.restapiexample.com/api/v1");
                var request = new RestRequest("employees", Method.GET);
                var content = client.Execute(request).Content;
                Console.WriteLine(content);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

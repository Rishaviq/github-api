using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System;


namespace github_api
{
    internal class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            try
            {
               


                
                
                client.DefaultRequestHeaders.UserAgent.ParseAdd("CSharpApp");
                var whatever = await client.GetFromJsonAsync<List<pEvents>>("https://api.github.com/users/kamranahmedse/events");
                if (whatever == null) { Console.WriteLine("its fucked"); }
                if (whatever[0] == null) { Console.WriteLine("its missing"); }
                if (whatever[0].Id == null) { Console.WriteLine("second too"); }
                Console.WriteLine(whatever[0].Id);
                

                Console.WriteLine("btrhn");
            }
            catch(Exception e) { Console.WriteLine(e.Message); }

        }





    }
}

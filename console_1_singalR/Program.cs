using Microsoft.Owin.Hosting;
using System;

namespace console_1_singalR
{
   public class Program
    {
        const string url = "http://localhost:6789";
       public static void Main(string[] args)
        {
            using(var connect=WebApp.Start(url))
            {
                Console.WriteLine("Start Service On:{0}",url);
                Console.ReadKey();
            }
        }
    }
}

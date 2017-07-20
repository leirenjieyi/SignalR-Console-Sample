using Microsoft.AspNet.SignalR.Client;
using System;

namespace console_1_singalR_client
{
    public class Program
    {
        const string url = "http://localhost:6789/signalr";
        public static void Main(string[] args)
        {
            string id = "";
            Console.Write("Cin a name:");
            id = Console.ReadLine();
            using (var connect = new HubConnection(url))
            {
                IHubProxy proxy = connect.CreateHubProxy("MyHub");
                proxy.On<string, string>("AddMessage", (name, message) => Console.WriteLine($"{name}:{message}"));
                connect.Start().Wait();

                Console.WriteLine($"Connection State:{connect.State.ToString()}");
                string cin = "";
                while(cin!="close")
                {
                    cin = Console.ReadLine();
                    proxy.Invoke("Send",id,cin);
                }
            }
        }
    }
}

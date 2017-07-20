using Microsoft.AspNet.SignalR;

namespace console_1_singalR
{
    public class MyHub:Hub
    {
        public void Send(string name,string message)
        {
            Clients.All.addMessage(name, message);
        }
    }
}

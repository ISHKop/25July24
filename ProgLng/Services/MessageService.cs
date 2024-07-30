using ProgLng.Interfaces;

namespace ProgLng.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the MessageService! 📬";
        }
    }
}

using GlimeshChatViewer.Services.Interfaces;

namespace GlimeshChatViewer.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GlimeshChatViewer.Chat.Interfaces
{
    public interface IChatService
    {
        public Task Start();
        public Task Stop();
        event OnChatReciveEventHandler OnChatRecived;
    }
}

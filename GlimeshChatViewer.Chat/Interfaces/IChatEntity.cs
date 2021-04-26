using System;
using System.Collections.Generic;
using System.Text;

namespace GlimeshChatViewer.Chat.Interfaces
{
    public interface IChatEntity
    {
        public string ID { get; }
        public string ChannelID { get; }
        public string UserID { get; }
        public string UserName { get; }
        public string DisplayName { get; }
        public string AvatarUrl { get; }
        public DateTime ConfirmedAt { get; }
        public string Message { get; }
        public DateTime SentAt { get; }
    }
}

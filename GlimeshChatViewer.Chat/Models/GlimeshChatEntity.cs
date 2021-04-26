using Glimesh.Base.Models.Clients.Chat;
using GlimeshChatViewer.Chat.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlimeshChatViewer.Chat.Models
{
    public class GlimeshChatEntity : IChatEntity
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
        public GlimeshChatEntity(ChatMessagePacketModel e)
        {
            this.ID = e.ID;
            this.ChannelID = e.ChannelID;
            this.UserID = e.User.id;
            this.UserName = e.User.username;
            this.DisplayName = e.User.displayname;
            this.AvatarUrl = e.User.avatarUrl;
            if (DateTime.TryParse(e.User.confirmedAt, out var confirmedAt)) {
                this.ConfirmedAt = confirmedAt;
            }
            this.Message = e.Message;
            if (DateTime.TryParse(e.SentAt, out var sentAt)) {
                this.SentAt = sentAt;
            }
        }
    }
}

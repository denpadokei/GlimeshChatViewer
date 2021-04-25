using Glimesh.Base.Models.Clients.Chat;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlimeshChatViewer
{
    public class OnChatReciveEventArgs : EventArgs
    {
        public string ID { get; private set; }
        public string ChannelID { get; private set; }
        public string UserID { get; private set; }
        public string UserName { get; private set; }
        public string DisplayName { get; private set; }
        public string AvatarUrl { get; private set; }
        public DateTime ConfirmedAt { get; private set; }
        public string Message { get; private set; }
        public DateTime SentAt { get; private set; }

        public OnChatReciveEventArgs(ChatMessagePacketModel e)
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

    public delegate void OnChatReciveEventHandler(object sender, OnChatReciveEventArgs e);
}

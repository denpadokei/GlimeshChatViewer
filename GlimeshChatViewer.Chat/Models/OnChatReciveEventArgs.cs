using Glimesh.Base.Models.Clients.Chat;
using GlimeshChatViewer.Chat.Interfaces;
using GlimeshChatViewer.Chat.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlimeshChatViewer
{
    public class OnChatReciveEventArgs : EventArgs
    {
        public IChatEntity GlimeshChatEntity { get; }
        public OnChatReciveEventArgs(ChatMessagePacketModel e)
        {
            this.GlimeshChatEntity = new GlimeshChatEntity(e);
            
        }
    }

    public delegate void OnChatReciveEventHandler(object sender, OnChatReciveEventArgs e);
}

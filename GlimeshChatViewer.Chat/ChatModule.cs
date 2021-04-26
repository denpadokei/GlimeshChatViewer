using GlimeshChatViewer.Chat.Interfaces;
using GlimeshChatViewer.Chat.Models;
using GlimeshChatViewer.Chat.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace GlimeshChatViewer.Chat
{
    public class ChatModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IChatService, GlimeshChatService>();
        }
    }
}
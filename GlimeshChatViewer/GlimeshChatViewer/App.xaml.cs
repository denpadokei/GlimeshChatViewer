using GlimeshChatViewer.Chat;
using GlimeshChatViewer.Core;
using GlimeshChatViewer.Modules.ModuleName;
using GlimeshChatViewer.Services;
using GlimeshChatViewer.Services.Interfaces;
using GlimeshChatViewer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;

namespace GlimeshChatViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
            containerRegistry.RegisterSingleton<IVoiceroid2Service, Voiceroid2Service>();
        }

        protected override void Initialize()
        {
            base.Initialize();
            var nav = this.Container.Resolve<IRegionManager>();
            nav.RegisterViewWithRegion(RegionNames.MainChatView, typeof(MainChatView));
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
            moduleCatalog.AddModule<ChatModule>();
        }
    }
}

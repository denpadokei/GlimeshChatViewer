using GlimeshChatViewer.Modules.ModuleName;
using GlimeshChatViewer.Services;
using GlimeshChatViewer.Services.Interfaces;
using GlimeshChatViewer.Views;
using Prism.Ioc;
using Prism.Modularity;
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
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}

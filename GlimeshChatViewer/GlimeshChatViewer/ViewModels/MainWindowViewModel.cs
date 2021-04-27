using GlimeshChatViewer.Core.Mvvm;
using GlimeshChatViewer.Services.Interfaces;
using Prism.Mvvm;

namespace GlimeshChatViewer.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        
        public MainWindowViewModel()
        {
            this.Title = "Glimesh Chat Viewer";
        }
    }
}

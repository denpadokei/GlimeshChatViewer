using GlimeshChatViewer.Services.Interfaces.Models;
using StatefulModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace GlimeshChatViewer.Services.Interfaces
{
    public interface IVoiceroid2Service : INotifyPropertyChanged, IDisposable
    {
        ObservableSynchronizedCollection<VoiceroidEntity> Voiceroids { get; }
        VoiceroidEntity CurrentVoiceroid { get; set; }
        bool IsConnected { get; }
        Task Initializze();
        Task Reconnect();
        Task Talk(string message);
    }
}

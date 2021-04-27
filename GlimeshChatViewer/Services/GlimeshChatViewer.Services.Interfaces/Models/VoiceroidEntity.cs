using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlimeshChatViewer.Services.Interfaces.Models
{
    public class VoiceroidEntity : BindableBase
    {
        /// <summary>説明 を取得、設定</summary>
        private string voiceroidName_;
        /// <summary>説明 を取得、設定</summary>
        public string VoiceroidName
        {
            get => this.voiceroidName_;

            set => this.SetProperty(ref this.voiceroidName_, value);
        }

        /// <summary>説明 を取得、設定</summary>
        private string command_;
        /// <summary>説明 を取得、設定</summary>
        public string Command
        {
            get => this.command_;

            set => this.SetProperty(ref this.command_, value);
        }

        public VoiceroidEntity(string name, string command)
        {
            this.VoiceroidName = name;
            this.Command = command;
        }
    }
}

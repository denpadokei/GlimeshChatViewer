using GlimeshChatViewer.Core.Interfaces;
using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace GlimeshChatViewer.Core.Behaviors
{
    public class DataContextInitialize : TriggerAction<FrameworkElement>
    {
        protected override async void Invoke(object parameter)
        {
            if (this.AssociatedObject.DataContext is IInitializable dc) {
                dc.Initialize();
                await dc.InitializeAsyc();
            }
        }
    }
}

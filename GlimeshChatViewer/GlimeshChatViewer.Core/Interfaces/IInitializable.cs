using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GlimeshChatViewer.Core.Interfaces
{
    public interface IInitializable
    {
        public void Initialize();
        public Task InitializeAsyc();
    }
}

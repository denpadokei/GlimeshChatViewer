using GlimeshChatViewer.Core.Interfaces;
using Prism.Mvvm;
using Prism.Navigation;
using System.Threading.Tasks;

namespace GlimeshChatViewer.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible, IInitializable
    {
        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }

        public virtual void Initialize()
        {

        }

        public virtual Task InitializeAsyc()
        {
            return Task.CompletedTask;
        }
    }
}

using System.Threading.Tasks;
using ToyProject.Core.Service;

namespace ToyProject.Presenter
{
    public abstract class PresenterBase
    {
        public PresenterBase(MessageService messageService = null)
        {
            _messageService = messageService;
        }

        protected MessageService _messageService;

        public virtual Task Refresh()
        {
            return Task.CompletedTask;
        }
    }
}

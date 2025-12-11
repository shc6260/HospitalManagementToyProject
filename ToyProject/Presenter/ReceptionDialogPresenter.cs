using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Core.Events;
using ToyProject.Core.Helper;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class ReceptionDialogPresenter : PresenterBase
    {
        public ReceptionDialogPresenter(IReceptionDialogView view, MessageService messageService) : base(messageService)
        {
            _view = view;

            _view.SaveReceptionRequest += ViewSaveReceptionRequest;
            _view.CancelReceptionRequest += ViewCancelReceptionRequest;
            _view.LoadRequest += OnLoadRequest;

            _receptionControlPresenter = new ReceptionControlPresenter(_view.IReceptionControlView, _messageService);
        }

        private readonly IReceptionDialogView _view;
        private readonly ReceptionControlPresenter _receptionControlPresenter;
        private Patient _selectedPatient;


        private async void OnLoadRequest(object sender, Patient e)
        {
            _selectedPatient = e;
            await _receptionControlPresenter.LoadAsync();

        }


        private void ViewCancelReceptionRequest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void ViewSaveReceptionRequest(object sender, EventArgs e)
        {
            if (_selectedPatient.Id == null)
                return;

            await _receptionControlPresenter.SaveReception(_selectedPatient.Id.Value);
            EventBus.Instance.Publish(new ReceptionChangedEventArgs());
        }
    }
}

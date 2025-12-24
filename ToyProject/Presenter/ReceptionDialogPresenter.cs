using System;
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
            _view.LoadRequestByPatient += OnLoadRequest;
            _view.LoadRequestByReceptionSimple += ViewLoadRequestByReceptionSimple;

            _receptionControlPresenter = new ReceptionControlPresenter(_view.IReceptionControlView, _messageService);
        }

        private readonly IReceptionDialogView _view;
        private readonly ReceptionControlPresenter _receptionControlPresenter;


        private void OnLoadRequest(object sender, Patient e)
        {
            _receptionControlPresenter.Load(e.Id.Value);
        }

        private async void ViewLoadRequestByReceptionSimple(object sender, ReceptionWithPatientSimpleResponse e)
        {
            await _messageService.RunInProgressPopupAsync(() => _receptionControlPresenter.LoadAsync(e.Id));

        }


        private async void ViewCancelReceptionRequest(object sender, EventArgs e)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _receptionControlPresenter.DeleteReception();
                EventBus.Instance.Publish(new ReceptionChangedEventArgs());
            });
        }

        private async void ViewSaveReceptionRequest(object sender, EventArgs e)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
           {
               await _receptionControlPresenter.SaveReception();
               EventBus.Instance.Publish(new ReceptionChangedEventArgs());
               _view.Close();
           });
        }

        public override void Dispose()
        {
            _view.SaveReceptionRequest -= ViewSaveReceptionRequest;
            _view.CancelReceptionRequest -= ViewCancelReceptionRequest;
            _view.LoadRequestByPatient -= OnLoadRequest;
            _view.LoadRequestByReceptionSimple -= ViewLoadRequestByReceptionSimple;
            _receptionControlPresenter.Dispose();
            base.Dispose();
        }
    }
}

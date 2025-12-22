using DevExpress.XtraEditors.Controls;
using System;
using System.Threading.Tasks;
using ToyProject.Core.Events;
using ToyProject.Core.Factotry;
using ToyProject.Core.Helper;
using ToyProject.Core.Service;
using ToyProject.View.IView.MainContent;

namespace ToyProject.Presenter.MainContent
{
    public class MainContentPresenter : PresenterBase
    {
        public MainContentPresenter(IMainContentControlView view, MessageService messageService) : base(messageService)
        {
            _receptionService = ServiceFactory.GetReceptionService();

            _view = view;

            _view.SearchReceptionRequest += ViewSearchReceptionRequest;

            EventBus.Instance.Subscribe(OnTesterUpdated);
        }

        private IMainContentControlView _view;
        private readonly ReceptionService _receptionService;

        public override async Task Refresh()
        {
            await SetReception(DateRangeHelper.ToDayRange());
        }

        private async void ViewSearchReceptionRequest(object sender, DevExpress.XtraEditors.Controls.DateRange e)
        {
            await _messageService.RunInProgressPopupAsync(() => SetReception(e));
        }

        private async Task SetReception(DateRange dateRange)
        {
            var receptions = await _receptionService.GetRecepionWithPatientInfo(dateRange);
            _view.SetReceptionList(receptions);
        }

        private async void OnTesterUpdated(object sender, EventArgs e)
        {
            if (e is ReceptionChangedEventArgs)
            {
                try
                {
                    await _messageService.RunInProgressPopupAsync(Refresh);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public override void Dispose()
        {
            EventBus.Instance.Unsubscribe(OnTesterUpdated);
            _view.SearchReceptionRequest -= ViewSearchReceptionRequest;
            base.Dispose();
        }
    }
}

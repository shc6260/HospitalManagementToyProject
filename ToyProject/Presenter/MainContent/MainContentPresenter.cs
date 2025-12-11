using DevExpress.XtraEditors.Controls;
using System;
using System.Threading.Tasks;
using ToyProject.Core.Events;
using ToyProject.Core.Helper;
using ToyProject.Core.Repositories;
using ToyProject.Core.Service;
using ToyProject.View.IView.MainContent;

namespace ToyProject.Presenter.MainContent
{
    public class MainContentPresenter : PresenterBase, IDisposable
    {
        public MainContentPresenter(IMainContentControlView view, MessageService messageService) : base(messageService)
        {
            _receptionService = new ReceptionService(new ReceptionRepository());

            _view = view;

            _view.SearchReceptionRequest += ViewSearchReceptionRequest;

            EventBus.Instance.Subscribe(OnTesterUpdated);
        }

        private IMainContentControlView _view;
        private ReceptionService _receptionService;

        public override async Task Refresh()
        {
            await SetReception(DateRangeHelper.Today());
        }

        private async void ViewSearchReceptionRequest(object sender, DevExpress.XtraEditors.Controls.DateRange e)
        {
            await SetReception(e);
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
                await Refresh();
            }
        }

        public void Dispose()
        {

        }
    }
}

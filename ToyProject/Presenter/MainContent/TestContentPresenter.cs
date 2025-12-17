using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View.IView.MainContent;

namespace ToyProject.Presenter.MainContent
{
    public class TestContentPresenter : PresenterBase
    {
        public TestContentPresenter(ITestContentControlView view, MessageService messageService) : base(messageService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _testService = ServiceFactory.GetTestService();

            _view.RefreshRequested += OnRefreshRequested;
            _view.SaveRequested += OnSaveRequested;
        }

        private readonly ITestContentControlView _view;
        private readonly TestService _testService;
        private IEnumerable<TestDetail> _tests = new List<TestDetail>();

        public override async Task Refresh()
        {
            _tests = await _testService.GetTestsAsync(Model.Type.StatusType.Reception);
            _view.SetTestList(_tests);
        }

        private async void OnRefreshRequested(object sender, EventArgs e)
        {
            await Refresh();
        }

        private async void OnSaveRequested(object sender, IEnumerable<DataTableChange<TestResult>> changes)
        {
            await _testService.SaveChangesAsync(changes);
            await Refresh();
        }
    }
}

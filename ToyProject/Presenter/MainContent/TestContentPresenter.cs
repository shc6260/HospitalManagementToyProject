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
            _view.UpdateTestRequested += OnUpdateTestRequested;
            _view.DeleteTestRequested += OnDeleteTestRequested;
            _view.ToggleStatusRequested += OnToggleStatusRequested;
        }

        private readonly ITestContentControlView _view;
        private readonly TestService _testService;
        private IEnumerable<Test> _tests = new List<Test>();

        public override async Task Refresh()
        {
            _tests = await _testService.GetTestsAsync();
            _view.SetTestList(_tests);
        }

        private async void OnRefreshRequested(object sender, EventArgs e)
        {
            await Refresh();
        }

        private async void OnUpdateTestRequested(object sender, Test test)
        {
            await _testService.SaveTestAsync(test);
            await Refresh();
        }

        private async void OnDeleteTestRequested(object sender, Test test)
        {
            if (test == null)
                return;

            await _testService.DeleteTestAsync(test);
            await Refresh();
        }

        private async void OnToggleStatusRequested(object sender, Test test)
        {
            if (test == null)
                return;

            await _testService.ToggleStatusAsync(test);
            await Refresh();
        }
    }
}

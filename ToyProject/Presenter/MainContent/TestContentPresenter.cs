using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Model.Type;
using ToyProject.View.IView.MainContent;

namespace ToyProject.Presenter.MainContent
{
    public class TestContentPresenter : PresenterBase
    {
        public TestContentPresenter(ITestContentControlView view, MessageService messageService) : base(messageService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _testService = ServiceFactory.GetTestService();
            _equipmentService = ServiceFactory.GetEquipmentService();
            _testerService = ServiceFactory.GetTesterService();

            _view.RefreshRequested += OnRefreshRequested;
            _view.SaveRequested += OnSaveRequested;
        }

        private readonly ITestContentControlView _view;
        private readonly TestService _testService;
        private readonly EquipmentService _equipmentService;
        private readonly TesterService _testerService;
        private IEnumerable<TestDetail> _tests = new List<TestDetail>();

        public override async Task Refresh()
        {
            _tests = await _testService.GetTestsAsync(Model.Type.StatusType.Reception);
            _view.SetTestList(_tests);

            var equipments = await _equipmentService.GetAllEquipmentAsync();
            var testers = await _testerService.GetAllTesterAsync();

            _view.SetData(equipments, testers);
        }

        private async void OnRefreshRequested(object sender, EventArgs e)
        {
            await _messageService.RunInProgressPopupAsync(Refresh);
        }

        private async void OnSaveRequested(object sender, (IEnumerable<DataTableChange<TestResult>> resultChanges, IEnumerable<(string Code, StatusType Status)> testChanges) change)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _testService.SaveChangesAsync(change.resultChanges, change.testChanges);
                await Refresh();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View.IView.MainContent;

namespace ToyProject.Presenter.MainContent
{
    public class TestItemContentPresenter : PresenterBase
    {
        public TestItemContentPresenter(ITestItemContentControlView view, MessageService messageService) : base(messageService)
        {
            _testItemService = ServiceFactory.GetTestItemService();

            _view = view;

            _view.UpdateTestItemRequested += OnUpdateEquipRequested;
            _view.ToggleActiveRequested += OnToggleActiveRequested;
            _view.DeleteTestItemRequested += OnDeleteEquipRequested;
        }


        private readonly ITestItemContentControlView _view;
        private IEnumerable<TestItem> _testItem;
        private readonly TestItemService _testItemService;


        private async void OnLoaded(object sender, EventArgs e)
        {
            await Refresh();
        }

        public override async Task Refresh()
        {
            _testItem = await GetTestItems();
            _view.SetTestItemList(_testItem);
        }

        private async void OnDeleteEquipRequested(object sender, TestItem e)
        {
            if (e.Id == null)
                return;

            if (true)
            {
                _messageService.Confirm("삭제가 불가능한 항목입니다.");
                return;
            }

            await _testItemService.DeleteTestItemAsync(e.Id.Value);
            await Refresh();
        }

        private async void OnToggleActiveRequested(object sender, TestItem e)
        {
            if (e.Id == null)
                return;

            await _testItemService.SetEnabledTestItemAsync(e.Id.Value, !e.IsEnabled);
            await Refresh();
        }

        private async void OnUpdateEquipRequested(object sender, TestItem e)
        {
            await _testItemService.SaveTestItemAsync(e);
            await Refresh();
        }

        private async Task<IEnumerable<TestItem>> GetTestItems()
        {
            return await _testItemService.GetAllTestItemAsync();
        }
    }
}

using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Core.Validation;
using ToyProject.Model;
using ToyProject.Properties;
using ToyProject.View.IView.MainContent;

namespace ToyProject.Presenter.MainContent
{
    public class TestItemContentPresenter : PresenterBase
    {
        public TestItemContentPresenter(ITestItemContentControlView view, MessageService messageService) : base(messageService)
        {
            _testItemService = ServiceFactory.GetTestItemService();

            _view = view;

            _view.UpdateTestItemRequested += OnUpdateTestItemRequested;
            _view.ToggleActiveRequested += OnToggleActiveRequested;
            _view.DeleteTestItemRequested += OnDeleteEquipRequested;
        }


        private readonly ITestItemContentControlView _view;
        private IEnumerable<TestItem> _testItem;
        private readonly TestItemService _testItemService;


        private async void OnLoaded(object sender, EventArgs e)
        {
            await _messageService.RunInProgressPopupAsync(Refresh);
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

            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _testItemService.DeleteTestItemAsync(e.Id.Value);
                await Refresh();
            });
        }

        private async void OnToggleActiveRequested(object sender, TestItem e)
        {
            if (e.Id == null)
                return;

            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _testItemService.SetEnabledTestItemAsync(e.Id.Value, !e.IsEnabled);
                await Refresh();
            });
        }

        private async void OnUpdateTestItemRequested(object sender, TestItem e)
        {
            var validationResult = GetValidationResult(e);
            _view.ShowErrors(validationResult);

            if (validationResult.IsValid == false)
            {
                _messageService.ShowError(validationResult.ErrorMessage);
                return;
            }


            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _testItemService.SaveTestItemAsync(e);
                await Refresh();
            },
            Resources.strings_successMessage);
        }

        private static ValidationResult GetValidationResult(TestItem testItem)
        {
            var result = new ValidationResult();
            result.AddRequired(nameof(testItem.Name), testItem.Name);
            result.AddRequired(nameof(testItem.TestItemCode), testItem.TestItemCode);
            result.AddRequired(nameof(testItem.ReferenceMinValue), testItem.ReferenceMinValue?.ToString());
            result.AddRequired(nameof(testItem.ReferenceMaxValue), testItem.ReferenceMaxValue?.ToString());

            return result;
        }

        private async Task<IEnumerable<TestItem>> GetTestItems()
        {
            return await _testItemService.GetAllTestItemAsync();
        }

        public override void Dispose()
        {
            _view.UpdateTestItemRequested -= OnUpdateTestItemRequested;
            _view.ToggleActiveRequested -= OnToggleActiveRequested;
            _view.DeleteTestItemRequested -= OnDeleteEquipRequested;
            base.Dispose();
        }
    }
}

using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class CreateTestDialogPresenter : PresenterBase
    {
        public CreateTestDialogPresenter(ICreateTestDialogView view, MessageService messageService) : base(messageService)
        {
            _testItemService = ServiceFactory.GetTestItemService();

            _view = view;
            _view.LoadRequest += ViewLoadRequest;

        }

        private readonly ICreateTestDialogView _view;
        private readonly TestItemService _testItemService;


        private async void ViewLoadRequest(object sender, Model.Test e)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
            {
                var result = await _testItemService.GetAllTestItemAsync();
                _view.SetTestItems(result, e?.TestItems);
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class TesterContentPresenter : PresenterBase
    {
        public TesterContentPresenter(ITesterContentControlView view, MessageService messageService) : base(messageService)
        {
            _testerService = ServiceFactory.GetTesterService();

            _view = view;

            _view.UpdateTesterRequested += OnUpdateTesterRequested;
            _view.ToggleActiveRequested += OnToggleActiveRequested;
            _view.TesterDeleteRequested += OnTesterDeleteRequested;
        }

        private readonly ITesterContentControlView _view;
        private IEnumerable<Tester> _testers;
        private readonly TesterService _testerService;

        private async void OnLoaded(object sender, EventArgs e)
        {
            await Refresh();
        }

        public override async Task Refresh()
        {
            _testers = await GetTesters();
            _view.SetTesterList(_testers);
        }

        private async void OnTesterDeleteRequested(object sender, Tester e)
        {
            if (e.Id == null)
                return;

            if (true)
            {
                _messageService.Confirm("삭제가 불가능한 검사자입니다.");
                return;
            }

            await _testerService.DeleteTesterAsync(e.Id.Value);
            await Refresh();
        }

        private async void OnToggleActiveRequested(object sender, Tester e)
        {
            if (e.Id == null)
                return;

            await _testerService.SetEnabledTesterAsync(e.Id.Value, !e.IsEnabled);
            await Refresh();
        }

        private async void OnUpdateTesterRequested(object sender, Tester e)
        {
            await _testerService.SaveTesterAsync(e);
            await Refresh();
        }

        private async Task<IEnumerable<Tester>> GetTesters()
        {
            return await _testerService.GetAllTesterAsync();
        }
    }
}

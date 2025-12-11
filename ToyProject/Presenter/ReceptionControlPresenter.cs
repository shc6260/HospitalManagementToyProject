using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Core.Service;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class ReceptionControlPresenter : PresenterBase
    {
        public ReceptionControlPresenter(IReceptionControlView view, MessageService messageService) : base(messageService)
        {
            _view = view;

            _receptionService = new ReceptionService(new ReceptionRepository());
            _testItemService = new TestItemService(new TestItemRepository());
        }

        private readonly IReceptionControlView _view;
        private readonly ReceptionService _receptionService;
        private readonly TestItemService _testItemService;

        public async Task LoadAsync()
        {
            var testItems = await _testItemService.GetAllTestItemAsync();
            _view.SetData(testItems);
        }

        public async Task SaveReception(long patientId)
        {
            var reception = _view.GetReception().WithPatientId(patientId);
            await _receptionService.SaveReception(reception);
        }
    }
}

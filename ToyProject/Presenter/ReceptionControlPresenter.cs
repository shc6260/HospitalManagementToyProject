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
        }

        private readonly IReceptionControlView _view;
        private readonly ReceptionService _receptionService;
        private long _selectedPatientId;

        public void Load(long patientId)
        {
            _selectedPatientId = patientId;
        }

        public async Task LoadAsync(long receptionId)
        {
            var reception = await _receptionService.FindReceptionById(receptionId);
            _view.SetData(reception);
        }

        public async Task SaveReception()
        {
            var reception = _view.GetReception().WithPatientId(_selectedPatientId);
            await _receptionService.SaveReception(reception);
        }
    }
}

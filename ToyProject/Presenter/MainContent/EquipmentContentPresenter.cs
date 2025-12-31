using System.Collections.Generic;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Properties;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class EquipmentContentPresenter : PresenterBase
    {
        public EquipmentContentPresenter(IEquipmentContentControlView view, MessageService messageService) : base(messageService)
        {
            _equipmentService = ServiceFactory.GetEquipmentService();

            _view = view;

            _view.UpdateEquipRequested += OnUpdateEquipRequested;
            _view.ToggleActiveRequested += OnToggleActiveRequested;
            _view.DeleteEquipRequested += OnDeleteEquipRequested;
        }

        private readonly IEquipmentContentControlView _view;
        private IEnumerable<Equipment> _equipments;
        private readonly EquipmentService _equipmentService;

        public override async Task Refresh()
        {
            _equipments = await GetTesters();
            _view.SetEquipmentsList(_equipments);
        }

        private async void OnDeleteEquipRequested(object sender, Equipment e)
        {
            if (e.Id == null)
                return;


            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _equipmentService.DeleteEquipmentAsync(e.Id.Value);
                await Refresh();
            });
        }

        private async void OnToggleActiveRequested(object sender, Equipment e)
        {
            if (e.Id == null)
                return;

            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _equipmentService.SetEnabledEquipmentAsync(e.Id.Value, !e.IsEnabled);
                await Refresh();
            });
        }

        private async void OnUpdateEquipRequested(object sender, Equipment e)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _equipmentService.SaveEquipmentAsync(e);
                await Refresh();
            },
            Resources.strings_successMessage);
        }

        private async Task<IEnumerable<Equipment>> GetTesters()
        {
            return await _equipmentService.GetAllEquipmentAsync();
        }

        public override void Dispose()
        {
            _view.UpdateEquipRequested -= OnUpdateEquipRequested;
            _view.ToggleActiveRequested -= OnToggleActiveRequested;
            _view.DeleteEquipRequested -= OnDeleteEquipRequested;
            base.Dispose();
        }
    }
}

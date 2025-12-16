using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
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

            if (true)
            {
                _messageService.Confirm("삭제가 불가능한 검사자입니다.");
                return;
            }

            await _equipmentService.DeleteEquipmentAsync(e.Id.Value);
            await Refresh();
        }

        private async void OnToggleActiveRequested(object sender, Equipment e)
        {
            if (e.Id == null)
                return;

            await _equipmentService.SetEnabledEquipmentAsync(e.Id.Value, !e.IsEnabled);
            await Refresh();
        }

        private async void OnUpdateEquipRequested(object sender, Equipment e)
        {
            await _equipmentService.SaveEquipmentAsync(e);
            await Refresh();
        }

        private async Task<IEnumerable<Equipment>> GetTesters()
        {
            return await _equipmentService.GetAllEquipmentAsync();
        }
    }
}

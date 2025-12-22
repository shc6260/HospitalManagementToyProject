using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Class;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Service
{
    public class EquipmentService
    {
        public EquipmentService(EquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
            _equipmentListCache = new SimpleCache<IEnumerable<Equipment>>(args => _equipmentRepository.HasChanged(args), GetChacheListAsync);
        }


        private EquipmentRepository _equipmentRepository;
        private SimpleCache<IEnumerable<Equipment>> _equipmentListCache;


        public async Task<IEnumerable<Equipment>> GetAllEquipmentAsync(bool? isEnabled = null)
        {
            var result = await _equipmentListCache.GetAsync();
            return isEnabled == null ? result : result.Where(i => i.IsEnabled == isEnabled).ToList();
        }

        public async Task<IEnumerable<Equipment>> GetChacheListAsync()
        {
            var result = await _equipmentRepository.FindAll();
            return result.Select(Equipment.From);
        }

        public Task SaveEquipmentAsync(Equipment data)
        {
            if (data == null)
                return Task.CompletedTask;

            if (data.Id == null)
                return _equipmentRepository.AddEquipment(data.ToAddRequestDto());

            return _equipmentRepository.ModifyEquipment(data.ToRequestDto());
        }

        public Task DeleteEquipmentAsync(long id)
        {
            //todo 삭제 가능여부 확인 로직

            return _equipmentRepository.DeleteEquipment(id);
        }

        public Task SetEnabledEquipmentAsync(long id, bool enabled)
        {
            return _equipmentRepository.ModifyEquipment
            (
                new EquipmentRequestDto()
                {
                    Id = id,
                    Enabled = enabled
                }
            );
        }
    }
}

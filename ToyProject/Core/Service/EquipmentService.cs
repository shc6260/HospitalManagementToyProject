using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Service
{
    public class EquipmentService
    {
        private EquipmentRepository _equipmentRepository;

        public EquipmentService(EquipmentRepository EquipmentRepository)
        {
            _equipmentRepository = EquipmentRepository;
        }

        public Task<IEnumerable<Equipment>> GetAllEquipmentAsync()
        {
            return Task.Run(async () =>
            {
                var result = await _equipmentRepository.FindAll();
                return result.Select(Equipment.From);
            });
        }

        public Task UpdateEquipmentAsync(Equipment data)
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

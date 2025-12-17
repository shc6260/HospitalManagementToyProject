using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyProject.Model.Dto
{
    public class TestResultRequestDto
    {
        public long? Id { get; set; }
        public long TestId { get; set; }
        public string Desison { get; set; }
        public string JudgementValue { get; set; }
        public long? EquipmentId { get; set; }
        public long? TesterId { get; set; }
        public DateTime? TestDt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyProject.Model.Dto
{
    public class TestAddRequestDto
    {
        public long Reception_Id { get; set; }

        public string Test_Name { get; set; }

        public IEnumerable<long> TestItem_Ids { get; set; }
    }
}

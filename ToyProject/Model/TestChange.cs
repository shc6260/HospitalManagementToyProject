using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyProject.Model
{
    public class DataTableChange<T>
    {
        public DataTableChange(DataRowState changeType, T data)
        {
            ChangeType = changeType;
            Data = data;
        }

        public DataRowState ChangeType { get; }

        public T Data { get; }
    }
}

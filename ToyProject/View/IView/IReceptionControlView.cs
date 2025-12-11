using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IReceptionControlView
    {
        void SetData(IEnumerable<TestItem> testItems);

        Reception GetReception();
    }
}

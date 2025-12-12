using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IReceptionControlView
    {
        void SetData(Reception testItems);

        Reception GetReception();
    }
}

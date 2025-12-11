using System;
using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface ITesterContentControlView 
    {
        void SetTesterList(IEnumerable<Tester> items);

        event EventHandler<Tester> UpdateTesterRequested;
        event EventHandler<Tester> TesterDeleteRequested;
        event EventHandler<Tester> ToggleActiveRequested;
    }
}

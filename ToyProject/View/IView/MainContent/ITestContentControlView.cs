using System;
using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView.MainContent
{
    public interface ITestContentControlView
    {
        void SetTestList(IEnumerable<Test> items);

        event EventHandler RefreshRequested;
        event EventHandler<Test> UpdateTestRequested;
        event EventHandler<Test> DeleteTestRequested;
        event EventHandler<Test> ToggleStatusRequested;
    }
}

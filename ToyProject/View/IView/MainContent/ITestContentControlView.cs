using System;
using System.Collections.Generic;
using ToyProject.Model;
using ToyProject.Model.Dto;

namespace ToyProject.View.IView.MainContent
{
    public interface ITestContentControlView
    {
        void SetTestList(IEnumerable<TestDetail> items);

        event EventHandler RefreshRequested;
        event EventHandler<IEnumerable<DataTableChange<TestResult>>> SaveRequested;
    }
}

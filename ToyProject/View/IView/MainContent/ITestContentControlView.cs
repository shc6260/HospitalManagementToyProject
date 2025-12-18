using System;
using System.Collections.Generic;
using ToyProject.Model;
using ToyProject.Model.Type;

namespace ToyProject.View.IView.MainContent
{
    public interface ITestContentControlView
    {
        void SetTestList(IEnumerable<TestDetail> items);

        void SetData(IEnumerable<Equipment> equipments, IEnumerable<Tester> testers);

        event EventHandler RefreshRequested;
        event EventHandler<(IEnumerable<DataTableChange<TestResult>> resultChanges, IEnumerable<(string Code, StatusType Status)> testChanges)> SaveRequested;
    }
}

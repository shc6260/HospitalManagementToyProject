using System;
using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface ICreateTestDialogView
    {
        void SetTestItems(IEnumerable<TestItem> testItems, IEnumerable<TestItem> selectedItems = null);

        event EventHandler<Test> LoadRequest;
    }
}

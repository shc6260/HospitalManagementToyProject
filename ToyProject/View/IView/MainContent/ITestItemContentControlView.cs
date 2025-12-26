using System;
using System.Collections.Generic;
using ToyProject.Core.Validation;
using ToyProject.Model;

namespace ToyProject.View.IView.MainContent
{
    public interface ITestItemContentControlView
    {
        void SetTestItemList(IEnumerable<TestItem> items);

        event EventHandler<TestItem> UpdateTestItemRequested;
        event EventHandler<TestItem> DeleteTestItemRequested;
        event EventHandler<TestItem> ToggleActiveRequested;

        void ShowErrors(ValidationResult validationResult);
    }
}

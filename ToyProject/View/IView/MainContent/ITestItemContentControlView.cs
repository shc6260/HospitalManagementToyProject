using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Model;

namespace ToyProject.View.IView.MainContent
{
    public interface ITestItemContentControlView : ILoadableViewBase
    {
        void SetTestItemList(IEnumerable<TestItem> items);

        event EventHandler<TestItem> UpdateTestItemRequested;
        event EventHandler<TestItem> DeleteTestItemRequested;
        event EventHandler<TestItem> ToggleActiveRequested;
    }
}

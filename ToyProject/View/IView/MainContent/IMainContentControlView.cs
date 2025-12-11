using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView.MainContent
{
    public interface IMainContentControlView
    {
        void SetReceptionList(IEnumerable<ReceptionWithPatientSimpleResponse> items);

        event EventHandler<DateRange> SearchReceptionRequest;
    }
}

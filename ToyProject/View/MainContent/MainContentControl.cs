using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.View.IView.MainContent;

namespace ToyProject.View
{
    public partial class MainContentControl : UserControl, IMainContentControlView
    {
        public MainContentControl()
        {
            InitializeComponent();
        }

        #region Init Control

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitReceptionGridControl();
        }

        private void InitReceptionGridControl()
        {
            fromDateEdit.DateTime = DateTime.Now;
            toDateEdit.DateTime = DateTime.Now;

            nameColumn.FieldName = nameof(ReceptionWithPatientSimpleResponse.PatientName);
            chartNumberColumn.FieldName = nameof(ReceptionWithPatientSimpleResponse.Chartnumber);
            receptionDtColumn.FieldName = nameof(ReceptionWithPatientSimpleResponse.Reception_dt);
        }

        #endregion


        #region Helpers

        private void todayButton_Click(object sender, EventArgs e)
        {
            fromDateEdit.DateTime = DateTime.Now;
            toDateEdit.DateTime = DateTime.Now;

            OnSearchReceptionRequest();
        }

        private void receptionSearchButton_Click(object sender, EventArgs e)
        {
            OnSearchReceptionRequest();
        }

        private DateRange GetDateRange()
        {
            return new DateRange(fromDateEdit.DateTime, toDateEdit.DateTime);
        }

        #endregion


        #region IMainContentControlView

        public event EventHandler<DateRange> SearchReceptionRequest;

        private void OnSearchReceptionRequest()
        {
            SearchReceptionRequest?.Invoke(this, GetDateRange());
        }

        public void SetReceptionList(IEnumerable<ReceptionWithPatientSimpleResponse> items)
        {
            receptionGridControl.DataSource = new BindingList<ReceptionWithPatientSimpleResponse>(items.ToArray());
        }

        #endregion
    }
}

using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

        private void ReceptionGridViewMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

            if (hitInfo.InRow || hitInfo.InRowCell)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                equipRowContextMenu.Show(Control.MousePosition);
            }
        }

        private void TodayButtonClick(object sender, EventArgs e)
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

        private void EditReceptionMenuClick(object sender, EventArgs e)
        {
            var row = receptionGridView.GetFocusedRow() as ReceptionWithPatientSimpleResponse;
            if (row == null)
                return;

            this.ShowReceptionDialog(row);
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            if (toDateEdit.DateTime >= DateTime.Today)
                return;


            fromDateEdit.DateTime = fromDateEdit.DateTime.AddDays(1);
            toDateEdit.DateTime = toDateEdit.DateTime.AddDays(1);
        }

        private void PrevButtonClick(object sender, EventArgs e)
        {
            fromDateEdit.DateTime = fromDateEdit.DateTime.AddDays(-1);
            toDateEdit.DateTime = toDateEdit.DateTime.AddDays(-1);
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

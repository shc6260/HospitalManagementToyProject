using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using ToyProject.Model;
using ToyProject.Model.Type;
using ToyProject.View.IView;

namespace ToyProject.View
{
    public partial class PatientDetailDialogForm : DevExpress.XtraEditors.XtraForm, IPatientDetailDialogView
    {
        public PatientDetailDialogForm()
        {
            InitializeComponent();
            InitGridView();
        }

        #region Init Control

        private void InitGridView()
        {
            //testGridView Column
            receptionDateColumn.FieldName = nameof(TestDetail.ReceptionDate);
            testCodeColumn.FieldName = nameof(TestDetail.TestCode);
            testNameColumn.FieldName = nameof(TestDetail.TestName);
            testItemName.FieldName = nameof(TestDetail.TestItemName);
            referenceValueColumn.FieldName = nameof(TestDetail.DisplayReferenceValue);

            //testResultView Column
            desisionColumn.FieldName = nameof(TestResult.Decision);
            judgementColumn.FieldName = nameof(TestResult.JudgementValue);
            testDateColumn.FieldName = nameof(TestResult.TestDate);
            equipmentColumn.FieldName = nameof(TestResult.EquipmentId);
            testerColumn.FieldName = nameof(TestResult.TesterId);

            testGridView.OptionsDetail.EnableMasterViewMode = true;
            testGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            testGridView.OptionsDetail.ShowDetailTabs = false;

            // Ensure master-detail relation uses the Results collection
            testGridControl.LevelTree.Nodes.Clear();
            var levelNode = new GridLevelNode
            {
                RelationName = nameof(TestDetail.Results),
                LevelTemplate = testResultView
            };
            testGridControl.LevelTree.Nodes.Add(levelNode);

            testGridView.MasterRowGetRelationCount += (s, e) => e.RelationCount = 1;
            testGridView.MasterRowGetRelationName += (s, e) => e.RelationName = nameof(TestDetail.Results);
            testGridView.MasterRowGetChildList += (s, e) =>
            {
                var row = testGridView.GetRow(e.RowHandle) as TestDetail;
                e.ChildList = row?.Results.ToArray();
            };
        }

        private void TestGridViewCustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            var view = sender as GridView;
            if (view == null)
                return;

            if (view.DataRowCount > 0)
                return;

            var text = "조회된 데이터가 없습니다.";
            using (var font = new Font("맑은 고딕", 10f))
            using (var brush = new SolidBrush(Color.Gray))
            {
                var rect = e.Bounds;
                var size = e.Graphics.MeasureString(text, font);

                var x = rect.Left + (rect.Width - size.Width) / 2;
                var y = rect.Top + (rect.Height - size.Height) / 2;

                e.Graphics.DrawString(text, font, brush, x, y);
            }
        }

        private void TestGridViewCustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            var view = sender as GridView;
            if (view == null)
                return;

            var groupInfo = e.Info as GridGroupRowInfo;
            if (groupInfo == null)
                return;

            int level = view.GetRowLevel(e.RowHandle);

            if (level == 1)
            {
                var childRow = view.GetRow(e.RowHandle) as TestDetail;
                if (childRow == null)
                    return;

                groupInfo.GroupText = $"{childRow.TestName} / {childRow.Status?.ToDisplayText()}";
            }
        }

        #endregion


        #region Helpers

        public void LoadView(Patient patient)
        {
            OnLoadRequest(patient);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OnSavePatient();
        } 

        #endregion


        #region IPatientDetailDialogView

        public IPatientEditControl PatientEditControl => patientEditControl;


        public event EventHandler SavePatient;

        private void OnSavePatient()
        {
            SavePatient?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<Patient> LoadRequest;

        public void OnLoadRequest(Patient args)
        {
            LoadRequest?.Invoke(this, args);
        }

        public void SetTestItems(IEnumerable<TestDetail> testITems)
        {
            testGridControl.DataSource = new BindingList<TestDetail>(testITems.ToArray());
        }

        #endregion
    }
}

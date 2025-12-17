using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.Model.Type;
using ToyProject.View.IView.MainContent;

namespace ToyProject.View
{
    public partial class TestContentControl : UserControl, ITestContentControlView
    {
        public TestContentControl()
        {
            InitializeComponent();
            InitGridView();
        }

        private const string RelationName = "TestResults";
        private const string MainTableName = "Main";
        private const string ResultTableName = "Result";
        private DataSet _testDataSet;
        private DataTable _mainTable;
        private DataTable _resulsTable;

        #region Init Control

        private void InitGridView()
        {
            //testGridView Column
            receptionDateColumn.FieldName = nameof(TestDetail.ReceptionDate);
            testCodeColumn.FieldName = nameof(TestDetail.TestCode);
            patientNameColumn.FieldName = nameof(TestDetail.PatientName);
            testNameColumn.FieldName = nameof(TestDetail.TestName);
            testItemName.FieldName = nameof(TestDetail.TestItemName);
            referenceValueColumn.FieldName = nameof(TestDetail.DisplayReferenceValue);

            //testResultView Column
            desisionColumn.FieldName = nameof(TestResult.Decision);
            judgementColumn.FieldName = nameof(TestResult.JudgementValue);
            testDateColumn.FieldName = nameof(TestResult.TestDate);
            equipmentColumn.FieldName = nameof(TestResult.EquipmentName);
            testerColumn.FieldName = nameof(TestResult.TesterName);

            _mainTable = new DataTable(MainTableName);
            _mainTable.Columns.Add(nameof(TestDetail.Id), typeof(long));
            _mainTable.Columns.Add(nameof(TestDetail.Status), typeof(string));
            _mainTable.Columns.Add(nameof(TestDetail.TestItemId), typeof(long));
            _mainTable.Columns.Add(nameof(TestDetail.TestName), typeof(string));
            _mainTable.Columns.Add(nameof(TestDetail.TestCode), typeof(string));
            _mainTable.Columns.Add(nameof(TestDetail.TestItemName), typeof(string));
            _mainTable.Columns.Add(nameof(TestDetail.ReferenceMaxValue), typeof(decimal));
            _mainTable.Columns.Add(nameof(TestDetail.ReferenceMinValue), typeof(decimal));
            _mainTable.Columns.Add(nameof(TestDetail.DisplayReferenceValue), typeof(string));
            _mainTable.Columns.Add(nameof(TestDetail.ReceptionId), typeof(long));
            _mainTable.Columns.Add(nameof(TestDetail.ReceptionDate), typeof(DateTime));
            _mainTable.Columns.Add(nameof(TestDetail.PatientId), typeof(long));
            _mainTable.Columns.Add(nameof(TestDetail.PatientName), typeof(string));

            _resulsTable = new DataTable(ResultTableName);
            _resulsTable.Columns.Add(nameof(TestResult.Id), typeof(long));
            _resulsTable.Columns.Add(nameof(TestResult.TestId), typeof(long));
            _resulsTable.Columns.Add(nameof(TestResult.Decision), typeof(string));
            _resulsTable.Columns.Add(nameof(TestResult.TestDate), typeof(DateTime));
            _resulsTable.Columns.Add(nameof(TestResult.JudgementValue), typeof(string));
            _resulsTable.Columns.Add(nameof(TestResult.EquipmentId), typeof(long));
            _resulsTable.Columns.Add(nameof(TestResult.EquipmentCode), typeof(string));
            _resulsTable.Columns.Add(nameof(TestResult.EquipmentName), typeof(string));
            _resulsTable.Columns.Add(nameof(TestResult.TesterId), typeof(long));
            _resulsTable.Columns.Add(nameof(TestResult.TesterName), typeof(string));
            _resulsTable.Columns.Add(nameof(TestResult.LicenseNumber), typeof(string));

            _testDataSet = new DataSet();
            _testDataSet.Tables.Add(_mainTable);
            _testDataSet.Tables.Add(_resulsTable);
            _testDataSet.Relations.Add(RelationName, _mainTable.Columns[nameof(TestDetail.Id)], _resulsTable.Columns[nameof(TestResult.TestId)]);
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
                int childRowHandle = view.GetChildRowHandle(e.RowHandle, 0);
                if (childRowHandle < 0)
                    return;

                var patientName = Convert.ToString(view.GetRowCellValue(childRowHandle, nameof(TestDetail.PatientName)));
                var testName = Convert.ToString(view.GetRowCellValue(childRowHandle, nameof(TestDetail.TestName)));

                groupInfo.GroupText = $"{patientName} / {testName}";
            }
        }

        #endregion

        #region Helpers

        private IEnumerable<DataTableChange<TestResult>> GetResultChanges()
        {
            var list = new List<DataTableChange<TestResult>>();

            var changeTable = _resulsTable.GetChanges();
            if (changeTable == null)
                return list;

            foreach (DataRow row in changeTable.Rows)
            {
                if (row.RowState != DataRowState.Added && row.RowState != DataRowState.Modified && row.RowState != DataRowState.Modified)
                    continue;

                list.Add(new DataTableChange<TestResult>
                    (
                        changeType: row.RowState,
                        data: TestResult.FromDataRow(row, row.RowState == DataRowState.Deleted ? DataRowVersion.Original : DataRowVersion.Current)
                    ));
            }

            return list;
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            OnRefreshRequested();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var changes = GetResultChanges();
            OnSaveRequested(changes);
        }

        #endregion

        #region ITestContentControlView

        public event EventHandler RefreshRequested;

        private void OnRefreshRequested()
        {
            RefreshRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<IEnumerable<DataTableChange<TestResult>>> SaveRequested;


        private void OnSaveRequested(IEnumerable<DataTableChange<TestResult>> changes)
        {
            SaveRequested?.Invoke(this, changes);
        }

        public void SetTestList(IEnumerable<TestDetail> items)
        {
            _resulsTable.Clear();
            _mainTable.Clear();
            ;
            foreach (var item in items ?? Enumerable.Empty<TestDetail>())
            {
                var mainRow = _mainTable.NewRow();
                mainRow[nameof(TestDetail.Id)] = item.Id;
                mainRow[nameof(TestDetail.Status)] = item.Status ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.TestItemId)] = item.TestItemId ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.TestName)] = item.TestName ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.TestCode)] = item.TestCode?.ToString() ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.TestItemName)] = item.TestItemName ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.ReferenceMaxValue)] = item.ReferenceMaxValue ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.ReferenceMinValue)] = item.ReferenceMinValue ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.DisplayReferenceValue)] = item.DisplayReferenceValue ?? (object)DBNull.Value;
                mainRow[nameof(TestDetail.ReceptionId)] = item.ReceptionId;
                mainRow[nameof(TestDetail.ReceptionDate)] = item.ReceptionDate;
                mainRow[nameof(TestDetail.PatientId)] = item.PatientId;
                mainRow[nameof(TestDetail.PatientName)] = item.PatientName ?? (object)DBNull.Value;

                _mainTable.Rows.Add(mainRow);

                foreach (var result in item.Results ?? Enumerable.Empty<TestResult>())
                {
                    var resultRow = _resulsTable.NewRow();

                    resultRow[nameof(TestResult.Id)] = result?.Id ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.TestId)] = result?.TestId ?? item.Id;
                    resultRow[nameof(TestResult.Decision)] = result?.Decision ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.TestDate)] = result?.TestDate ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.JudgementValue)] = result?.JudgementValue ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.EquipmentId)] = result?.EquipmentId ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.EquipmentCode)] = result?.EquipmentCode ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.EquipmentName)] = result?.EquipmentName ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.TesterId)] = result?.TesterId ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.TesterName)] = result?.TesterName ?? (object)DBNull.Value;
                    resultRow[nameof(TestResult.LicenseNumber)] = result?.LicenseNumber ?? (object)DBNull.Value;

                    _resulsTable.Rows.Add(resultRow);

                    if (result?.Id != null)
                        resultRow.AcceptChanges();
                }
            }

            testGridControl.DataSource = _testDataSet;
            testGridControl.DataMember = MainTableName;
            _mainTable.AcceptChanges();
        }

        #endregion
    }
}

using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Core.Helper;
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
            InitStatusComboBox();
        }

        private const string RelationName = "TestResults";
        private const string MainTableName = "Main";
        private const string ResultTableName = "Result";
        private int _contextMenuRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
        private DataSet _testDataSet;
        private DataTable _mainTable;
        private DataTable _resulsTable;

        #region Init Control

        private void InitStatusComboBox()
        {
            statusCheckedComboBox.Properties.Items.Clear();

            foreach (StatusType status in Enum.GetValues(typeof(StatusType)))
            {
                var item = new CheckedListBoxItem(status, status.ToDisplayText());
                statusCheckedComboBox.Properties.Items.Add(item);

                if (status == StatusType.Reception || status == StatusType.Progress)
                    item.CheckState = CheckState.Checked;
            }
        }

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
            equipmentColumn.FieldName = nameof(TestResult.EquipmentId);
            testerColumn.FieldName = nameof(TestResult.TesterId);

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
                var status = Convert.ToString(view.GetRowCellValue(childRowHandle, nameof(TestDetail.Status)));

                groupInfo.GroupText = $"{patientName} / {testName} / {status.ToStatusType().ToDisplayText()}";
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
                if (row.RowState != DataRowState.Added && row.RowState != DataRowState.Modified && row.RowState != DataRowState.Deleted)
                    continue;

                list.Add(new DataTableChange<TestResult>
                    (
                        changeType: row.RowState,
                        data: TestResult.FromDataRow(row, row.RowState == DataRowState.Deleted ? DataRowVersion.Original : DataRowVersion.Current)
                    ));
            }

            return list.Where(i => string.IsNullOrEmpty(i.Data.Decision) == false).ToArray();
        }

        private IEnumerable<(string Code, StatusType Status)> GetTestChanges()
        {
            var list = new List<(string Code, StatusType Status)>();

            var changeTable = _mainTable.GetChanges();
            if (changeTable == null)
                return list;

            foreach (DataRow row in changeTable.Rows)
            {
                if (row.RowState != DataRowState.Modified)
                    continue;

                var code = row.GetString(nameof(TestDetail.TestCode), DataRowVersion.Current);

                if (list.Any(i => i.Code == code))
                    continue;

                list.Add(
                (
                    code,
                    row.GetString(nameof(TestDetail.Status), DataRowVersion.Current).ToStatusType()
                ));
            }

            return list;
        }

        private void StatusCheckedComboBoxEditValueChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void FilterGrid()
        {
            var checkedStatuses = statusCheckedComboBox.Properties.Items
                            .GetCheckedValues()
                            .Cast<object>()
                            .Select(v => v.ToString())
                            .Where(v => string.IsNullOrWhiteSpace(v) == false)
                            .ToArray();

            if (checkedStatuses.Any() == false)
            {
                testGridView.ActiveFilterString = string.Empty;
                return;
            }

            var statusFilter = string.Join(",", checkedStatuses.Select(s => $"'{s}'"));
            testGridView.ActiveFilterString = $"[{nameof(TestDetail.Status)}] IN ({statusFilter})";
        }


        private void TestGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;
            if (view == null)
                return;

            if (e.HitInfo.InGroupRow == false)
                return;

            int groupLevel = view.GetRowLevel(e.HitInfo.RowHandle);

            if (groupLevel == 1)
            {
                _contextMenuRowHandle = e.HitInfo.RowHandle;
                view.FocusedRowHandle = e.HitInfo.RowHandle;
                testContextMenu.Show(Control.MousePosition);
            }
        }

        private void SetStatusForContextRow(StatusType status)
        {
            var view = testGridView;
            if (view == null)
                return;

            var rowHandle = _contextMenuRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle
                ? _contextMenuRowHandle
                : view.FocusedRowHandle;

            if (rowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                return;

            var statusValue = status.ToString();

            void SetStatusOnDataRow(int dataRowHandle)
            {
                var dataRow = view.GetDataRow(dataRowHandle);
                if (dataRow == null)
                    return;

                dataRow[nameof(TestDetail.Status)] = statusValue;
            }

            void ApplyRecursively(int handle)
            {
                if (view.IsGroupRow(handle))
                {
                    var childCount = view.GetChildRowCount(handle);
                    for (int i = 0; i < childCount; i++)
                    {
                        int childHandle = view.GetChildRowHandle(handle, i);
                        if (childHandle < 0)
                            continue;

                        ApplyRecursively(childHandle);
                    }

                    return;
                }

                SetStatusOnDataRow(handle);
            }

            ApplyRecursively(rowHandle);

            view.RefreshData();
            _contextMenuRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
        }

        private void RepositoryItemButtonEditButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var view = testGridControl.FocusedView as GridView;
            if (view == null)
                return;

            var rowHandle = view.FocusedRowHandle;
            if (rowHandle < 0 || view.IsGroupRow(rowHandle))
                return;

            var mainRow = view.GetDataRow(rowHandle);
            if (mainRow == null)
                return;

            var testId = (long)mainRow[nameof(TestDetail.Id)];

            var newResultRow = _resulsTable.NewRow();
            newResultRow[nameof(TestResult.TestId)] = testId;

            _resulsTable.Rows.Add(newResultRow);

            testGridControl.RefreshDataSource();
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            OnRefreshRequested();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var changes = GetResultChanges();
            var testChanges = GetTestChanges();
            OnSaveRequested(changes, testChanges);
        }

        private void ProgressMenuClick(object sender, EventArgs e)
        {
            SetStatusForContextRow(StatusType.Progress);
        }

        private void CompleteMenuClick(object sender, EventArgs e)
        {
            SetStatusForContextRow(StatusType.Complete);
        }

        #endregion


        #region ITestContentControlView

        public event EventHandler RefreshRequested;

        private void OnRefreshRequested()
        {
            RefreshRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<(IEnumerable<DataTableChange<TestResult>> resultChanges, IEnumerable<(string Code, StatusType Status)> testChanges)> SaveRequested;


        private void OnSaveRequested(IEnumerable<DataTableChange<TestResult>> changes, IEnumerable<(string Code, StatusType Status)> testChanges)
        {
            SaveRequested?.Invoke(this, (changes, testChanges));
        }

        public void SetTestList(IEnumerable<TestDetail> items)
        {
            _resulsTable.Clear();
            _mainTable.Clear();

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
                    resultRow[nameof(TestResult.TestDate)] = result?.TestDate ?? DateTime.Now;
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
            FilterGrid();
        }

        public void SetData(IEnumerable<Equipment> equipments, IEnumerable<Tester> testers)
        {
            equipmentComboboxEdit.Items.Clear();
            testerComboboxEdit.Items.Clear();

            equipmentComboboxEdit.Items.AddRange(equipments.Select(i
                => new ImageComboBoxItem(description: i.Name, value: i.Id))
                .ToArray());
            testerComboboxEdit.Items.AddRange(testers.Select(i
                => new ImageComboBoxItem(description: i.Name, value: i.Id))
                .ToArray());
        }

        #endregion
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Repositories.InMemory;
using ToyProject.Model;
using ToyProject.Model.Type;
using ToyProject.View.IView.MainContent;

namespace ToyProjectTest.Presenter
{
    [TestFixture]
    public class TestContentPresenterTest
    {
        [Test]
        public async Task Refresh_ShouldPopulateViewWithSeedData()
        {
            var context = new InMemoryRepositoryContext();
            var view = new FakeTestContentView();

            var presenter = new ToyProject.Presenter.MainContent.TestContentPresenter(
                view,
                messageService: null
            );

            await presenter.Refresh();

            Assert.That(view.Tests, Is.Not.Null.And.Not.Empty, "테스트 목록이 설정되어야 합니다.");
            Assert.That(view.Equipments, Is.Not.Null.And.Not.Empty, "장비 목록이 설정되어야 합니다.");
            Assert.That(view.Testers, Is.Not.Null.And.Not.Empty, "검사자 목록이 설정되어야 합니다.");

            var expectedEquipmentIds = context.Equipments.Select(e => e.Id);
            Assert.That(view.Equipments.Select(e => e.Id), Is.EquivalentTo(expectedEquipmentIds), "장비 데이터가 메모리 컨텍스트와 일치해야 합니다.");
        }

        [Test]
        public async Task SaveRequested_ShouldPersistResultAndRefreshStatus()
        {
            var view = new FakeTestContentView();

            var presenter = new ToyProject.Presenter.MainContent.TestContentPresenter(
                view,
                messageService: null
            );

            await presenter.Refresh();

            var targetTest = view.Tests.First();
            var targetCode = targetTest.TestCode?.ToString();
            var targetEquipment = view.Equipments.First();
            var targetTester = view.Testers.First();

            var change = (
                resultChanges: new[]
                {
                    new DataTableChange<TestResult>(
                        DataRowState.Added,
                        new TestResult(
                            id: null,
                            testId: targetTest.Id,
                            decision: "정상",
                            testDate: DateTime.Now,
                            judgementValue: "1.0",
                            equipmentId: targetEquipment.Id,
                            equipmentCode: targetEquipment.EquipmentCode,
                            equipmentName: targetEquipment.Name,
                            testerId: targetTester.Id,
                            testerName: targetTester.Name,
                            licenseNumber: targetTester.LicenseNumber))
                },
                testChanges: new[] { (Code: targetCode, Status: StatusType.Complete) }
            );

            var updated = view.ExpectUpdate();
            view.RaiseSaveRequested(change);
            await updated;

            var refreshedTest = view.Tests.First(t => t.Id == targetTest.Id);
            Assert.That(refreshedTest.Status, Is.EqualTo(StatusType.Complete), "저장 후 상태가 갱신되어야 합니다.");
            Assert.That(refreshedTest.Results.Any(r => r.Decision == "정상"), Is.True, "새 결과가 반영되어야 합니다.");
        }

        private class FakeTestContentView : ITestContentControlView
        {
            public IReadOnlyList<TestDetail> Tests { get; private set; } = new List<TestDetail>();
            public IReadOnlyList<Equipment> Equipments { get; private set; } = new List<Equipment>();
            public IReadOnlyList<Tester> Testers { get; private set; } = new List<Tester>();

            public event EventHandler RefreshRequested;
            public event EventHandler<(IEnumerable<DataTableChange<TestResult>> resultChanges, IEnumerable<(string Code, StatusType Status)> testChanges)> SaveRequested;

            private TaskCompletionSource<bool> _updatedTcs = new TaskCompletionSource<bool>();

            public void SetTestList(IEnumerable<TestDetail> items)
            {
                Tests = items?.ToList() ?? new List<TestDetail>();
                _updatedTcs.TrySetResult(true);
            }

            public void SetData(IEnumerable<Equipment> equipments, IEnumerable<Tester> testers)
            {
                Equipments = equipments?.ToList() ?? new List<Equipment>();
                Testers = testers?.ToList() ?? new List<Tester>();
            }

            public Task ExpectUpdate()
            {
                _updatedTcs = new TaskCompletionSource<bool>();
                return _updatedTcs.Task;
            }

            public void RaiseSaveRequested((IEnumerable<DataTableChange<TestResult>> resultChanges, IEnumerable<(string Code, StatusType Status)> testChanges) change)
            {
                SaveRequested?.Invoke(this, change);
            }
        }
    }
}

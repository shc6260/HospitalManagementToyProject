using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToyProject.Model;
using ToyProject.Model.Dto;
using ToyProject.Model.Type;

namespace ToyProject.Core.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<PatientResponseDto>> FindPatientsForGnbAsync(string searchText);
        Task<long> AddPatientsAsync(PatientAddRequestDto dto);
        Task<long> ModifyPatientsAsync(PatientRequestDto dto);
    }

    public interface ITesterRepository
    {
        Task<IEnumerable<TesterResponseDto>> FindAll();
        Task<bool> HasChanged(DateTime checkTime);
        Task AddTester(TesterAddRequestDto dto);
        Task ModifyTester(TesterRequestDto dto);
        Task DeleteTester(long id);
    }

    public interface ITestItemRepository
    {
        Task<IEnumerable<TestItemResponseDto>> FindAll();
        Task<bool> HasChanged(DateTime checkTime);
        Task AddTestItem(TestItemAddRequestDto dto);
        Task ModifyTestItem(TestItemRequestDto dto);
        Task DeleteTestItem(long id);
    }

    public interface IEquipmentRepository
    {
        Task<IEnumerable<EquipmentResponseDto>> FindAll();
        Task<bool> HasChanged(DateTime checkTime);
        Task AddEquipment(EquipmentAddRequestDto dto);
        Task ModifyEquipment(EquipmentRequestDto dto);
        Task DeleteEquipment(long id);
    }

    public interface IReceptionRepository
    {
        Task<IEnumerable<ReceptionWithPatientSimpleResponseDto>> FindReceptionWithPatientInfo(DateTime from, DateTime to);
        Task<IEnumerable<ReceptionResponseDto>> FindReceptionWithTests(long id);
        Task AddReception(ReceptionAddRequestDto dto, IEnumerable<TestAddRequestDto> tests);
        Task ModifyReception(ReceptionModifyRequestDto dto);
        Task DeleteReception(long id);
    }

    public interface ITestRepository
    {
        Task<IEnumerable<TestDetailDto>> GetTestsAsync(StatusType? status = null, long? patientId = null);
        Task AddTestsAsync(IEnumerable<TestAddRequestDto> tests, long receptionId);
        Task ModifyTestsAsync(IEnumerable<TestModifyRequestDto> tests);
        Task DeleteTestsAsync(IEnumerable<string> codes);
    }

    public interface ITestResultRepository
    {
        Task AddTestResultsAsync(IEnumerable<TestResultRequestDto> results);
        Task ModifyTestResultsAsync(IEnumerable<TestResultRequestDto> results);
    }
}

using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Model;

namespace ToyProject.Core.Service
{
    public class ReceptionService
    {
        public ReceptionService(ReceptionRepository receptionRepository)
        {
            _receptionRepository = receptionRepository;
        }

        private ReceptionRepository _receptionRepository;


        public Task<IEnumerable<ReceptionWithPatientSimpleResponse>> GetRecepionWithPatientInfo(DateRange dateRange)
        {
            return Task.Run(async () =>
            {
                var result = await _receptionRepository.FindRecepionWithPatientInfo(dateRange.StartDate, dateRange.EndDate);
                return result.Select(ReceptionWithPatientSimpleResponse.From);
            });
        }

        public Task<Reception> FindReceptionById(long id)
        {
            return Task.Run(async () =>
            {
                var result = await _receptionRepository.FindReceptionWithTests(id);
                return Reception.From(result);
            });
        }

        public Task SaveReception(Reception data)
        {
            return Task.Run(async () =>
            {
                await _receptionRepository.AddReception(data.ToAddRequestDto());
            });
        }
    }
}

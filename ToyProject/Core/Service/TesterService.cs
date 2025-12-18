using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Class;
using ToyProject.Core.Helper;
using ToyProject.Core.Repositories;
using ToyProject.Model;

namespace ToyProject.Core.Service
{
    public class TesterService
    {

        public TesterService(TesterRepository testerRepository)
        {
            _testerRepository = testerRepository;
            _testerListCache = new SimpleCache<IEnumerable<Tester>>(args => _testerRepository.HasChanged(args), GetChacheListAsync);
        }

        private TesterRepository _testerRepository;
        private SimpleCache<IEnumerable<Tester>> _testerListCache;

        public async Task<IEnumerable<Tester>> GetAllTesterAsync()
        {
            return await _testerListCache.GetAsync();
        }

        private async Task<IEnumerable<Tester>> GetChacheListAsync()
        {
            var result = await _testerRepository.FindAll();
            return result.Select(Tester.From);
        }

        public Task SaveTesterAsync(Tester data)
        {
            if (data == null)
                return Task.CompletedTask;

            if (data.Id == null)
                return _testerRepository.AddTester(data.ToAddRequestDto());

            return _testerRepository.ModifyTester(data.ToRequestDto());
        }

        public Task DeleteTesterAsync(long id)
        {
            //todo 삭제 가능여부 확인 로직

            return _testerRepository.DeleteTester(id);
        }

        public Task SetEnabledTesterAsync(long id, bool enabled)
        {
            return _testerRepository.ModifyTester
            (
                new TesterRequestDto()
                {
                    Id = id,
                    Enabled = enabled
                }
            );
        }
    }
}

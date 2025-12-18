using System;
using System.Threading;
using System.Threading.Tasks;

namespace ToyProject.Core.Class
{
    public class SimpleCache<T>
    {
        public SimpleCache(Func<DateTime, Task<bool>> isRefreshFunc, Func<Task<T>> setFunc)
        {
            _isRefreshFunc = isRefreshFunc;
            _loadFunc = setFunc;
        }

        private T _data = default;
        private DateTime? _cachedTime;
        private Func<DateTime, Task<bool>> _isRefreshFunc;
        private Func<Task<T>> _loadFunc;

        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);

        public async Task<T> GetAsync()
        {
            await _lock.WaitAsync();

            try
            {
                if (_cachedTime == null || await _isRefreshFunc(_cachedTime.Value))
                    return await SetAsync();

                return _data;
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task<T> SetAsync()
        {
            _data = await _loadFunc();
            _cachedTime = DateTime.UtcNow;
            return _data;
        }
    }
}

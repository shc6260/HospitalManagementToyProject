using System;
using System.Threading;
using System.Threading.Tasks;

namespace ToyProject.Core.Helper
{
    public class DelayInvoker : IDisposable
    {
        private CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly object _lock = new object();

        private int _delayMilliseconds;
        private Func<Task> _action;

        public DelayInvoker(int delayMilliseconds, Func<Task> action)
        {
            _delayMilliseconds = delayMilliseconds;
            _action = action;
        }


        public void Invoke()
        {
            lock (_lock)
            {
                _cts.Cancel();
                _cts.Dispose();
                _cts = new CancellationTokenSource();
            }

            var token = _cts.Token;

            _ = RunAsync(_delayMilliseconds, _action, token);
        }

        private async Task RunAsync(int delay, Func<Task> action, CancellationToken token)
        {
            try
            {
                await Task.Delay(delay, token);

                if (token.IsCancellationRequested == false)
                    await action();
            }
            catch (TaskCanceledException)
            {

            }
        }

        public void Cancel()
        {
            lock (_lock)
            {
                _cts.Cancel();
                _cts.Dispose();
                _cts = new CancellationTokenSource();
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts.Dispose();
        }
    }
}

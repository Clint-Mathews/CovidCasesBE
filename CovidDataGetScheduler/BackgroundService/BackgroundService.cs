using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CovidDataGetScheduler.BackgroundService
{
    public abstract class BackgroundService : IHostedService
    {
        private Task _executingTask;
        private readonly CancellationTokenSource _stopingToken = new CancellationTokenSource();
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _executingTask = ExecuteAync(_stopingToken.Token);
            if(_executingTask.IsCompleted)
            {
                return _executingTask;
            }
            return Task.CompletedTask;
        }

        public virtual async Task StopAsync(CancellationToken cancellationToken)
        {
            if(_executingTask == null)
            {
                return;
            }
            try
            {
                _stopingToken.Cancel();
            }
            finally
            {
                await Task.WhenAny(_executingTask, Task.Delay( Timeout.Infinite, cancellationToken));
            }
        }


        protected virtual async Task ExecuteAync(CancellationToken cancellationToken)
        {
            do
            {
               await Process();
               await Task.Delay(5000, cancellationToken);

            } while (!cancellationToken.IsCancellationRequested);
        }

        protected abstract Task Process();
    }
}

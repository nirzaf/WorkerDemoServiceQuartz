using Quartz;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WorkerDemoService.Jobs
{
    public class LoggerJob : IJob
    {
        private readonly ILogger<LoggerJob> _logger;
        public LoggerJob(ILogger<LoggerJob> logger)
        {
            this._logger = logger;
        }
        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation($"This Job Logged: at {DateTime.Now} and Job Type: {context.JobDetail.JobType}");
            return Task.CompletedTask;
        }
    }
}

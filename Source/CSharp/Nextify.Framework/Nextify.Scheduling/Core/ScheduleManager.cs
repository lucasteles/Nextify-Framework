using FluentScheduler;
using Nextify.Abstraction.IOC;
using Nextify.Abstraction.Logging;
using Nextify.Abstraction.Scheduling;
using Nextify.IOC;
using System;
using System.Collections.Generic;

namespace Nextify.Scheduling
{
    public class ScheduleManager : IScheduleManager
    {
        internal static IContainer Container;

        public void Start(IContainer container, Registry register)
        {

            Container = container;

            var log = Container.Resolve<ILogger>();

            JobManager.Initialize(register);

            JobManager.JobException += (JobExceptionInfo obj) =>
                log.Warn($@"An error happened with a scheduled 
                            task: {obj.Name}; Error: {obj.Exception.Message} | 
                            InnerException: {obj.Exception.InnerException?.Message ?? string.Empty}");

        }

        public void AddJob(Action job, Action<Schedule> schedule)
        {
            JobManager.AddJob(job, schedule);
        }

        public void AddJob(IJob job, Action<Schedule> schedule)
        {
            JobManager.AddJob(job, schedule);

        }

        /// <summary>
        /// Collection of the currently running schedules.
        /// </summary>
        public IEnumerable<Schedule> GetRunningSchedules()
        {
            return JobManager.RunningSchedules;

        }

        /// <summary>
        /// Collection of all schedules.
        /// </summary>
        public IEnumerable<Schedule> GetAllSchedules()
        {

            // returning a shallow copy
            return JobManager.AllSchedules;
        }

        /// <summary>
        /// Removes the schedule of the given name.
        /// </summary>
        /// <param name="name">Name of the schedule.</param>
        public void RemoveJob(string name)
        {
            JobManager.RemoveJob(name);
        }

        public void SetDiContainer(IContainer container)
        {
            Container = container;
        }

        public void Stop()
        {
            JobManager.StopAndBlock();
        }

    }
}

using FluentScheduler;
using Nextify.Abstraction.IOC;

using System;
using System.Collections.Generic;

namespace Nextify.Abstraction.Scheduling
{
    public interface IScheduleManager
    {
        IEnumerable<Schedule> GetAllSchedules();
        IEnumerable<Schedule> GetRunningSchedules();

        void SetDiContainer(IContainer container);

        void AddJob(IJob job, Action<Schedule> schedule);
        void AddJob(Action job, Action<Schedule> schedule);
        void RemoveJob(string name);
        void Start(IContainer container, Registry register);

        void Stop();
    }
}
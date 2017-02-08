using FluentScheduler;
using System;

namespace Nextify.App.Scheduling
{
    public class PingJob : IJob
    {
        public void Execute()
        {

            Console.WriteLine("ping...");

        }
    }
}

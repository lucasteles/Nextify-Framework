using FluentScheduler;
using System;


namespace Pragma.App.Scheduling
{
    public class PingJob : IJob
    {
        public void Execute()
        {

            Console.WriteLine("ping...");

        }
    }
}

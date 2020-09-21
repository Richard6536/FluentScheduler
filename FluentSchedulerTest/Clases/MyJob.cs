using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FluentSchedulerTest.Clases
{
    public class MyJob : IJob
    {
        void IJob.Execute()
        {
            Trace.WriteLine("El tiempo ahora es: " + DateTime.Now);

        }
    }
}
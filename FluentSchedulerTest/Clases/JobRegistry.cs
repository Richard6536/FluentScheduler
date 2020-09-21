using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FluentSchedulerTest.Clases
{
    public class JobRegistry : Registry
    {
        public JobRegistry()
        {
            //Incluí FluentScheduler desde Nuget.
            //Para este caso, inicializo la programación en Global.asax.cs, cuando la aplicación inicia y llama a esta clase.
            //La clase MyJob contiene el método que llamo desde mi Schedule.
            


            //Se ejecuta cada 5 segundos (Se puede especificar segundos, minutos, horas, días, meses, etc)
            //Llama a la clase MyJob que tiene una función
            //Schedule<MyJob>().ToRunNow().AndEvery(5).Seconds();

            //Se ejecuta con un delay de 5 segundos
            //Llama a la clase MyJob que tiene una función
            //Schedule<MyJob>().ToRunOnceIn(5).Seconds();

            //Se ejecuta en un tiempo específico, en este caso, todos los días a las 10:15 pm
            Schedule(() => Trace.WriteLine("Son las 10:15 pm!")).ToRunEvery(1).Days().At(22, 15);

            //También puedo ejecutar un método todos los días a las 10:15 pm
            //Schedule<MyJob>().ToRunEvery(1).Days().At(22, 15);
        }
    }
}
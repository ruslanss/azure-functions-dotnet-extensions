using System;

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest
{
    public class Log
    {
        public Func<string> OnProcessing { get; set; }
        public Func<string> OnProcessed { get; set; }
        public Func<string> OnError { get; set; }
    }
}

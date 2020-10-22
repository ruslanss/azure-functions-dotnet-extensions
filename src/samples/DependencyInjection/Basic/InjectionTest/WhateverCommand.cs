namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest
{
    public class WhateverCommand : DomainCommand, ILockIdentifier, ILogWriter
    {
        public string LockId { get => $""; }

        [Newtonsoft.Json.JsonIgnore]
        public Log Log
        {
            get
            {
                var message = $"";
                return new Log
                {
                    OnProcessing = () => message,
                    OnError = () => message
                };
            }
        }
    }
}

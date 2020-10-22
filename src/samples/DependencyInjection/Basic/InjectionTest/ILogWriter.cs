namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest
{
    public interface ILogWriter
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public Log Log { get; }
    }
}

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest
{
    public interface IValidator<in T> where T : ICommand
    {
    }
}

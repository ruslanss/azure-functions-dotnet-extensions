using System.Threading.Tasks;

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest
{
    public interface IValidator<in T> where T : ICommand
    {
        Task<ValidationResult> Validate(T item);
    }
}

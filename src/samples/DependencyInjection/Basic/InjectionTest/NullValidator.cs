using System.Threading.Tasks;

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest
{
    public class NullValidator : IValidator<DomainCommand>
    {
        public Task<ValidationResult> Validate(DomainCommand item)
        {
            return Task.FromResult(new ValidationResult());
        }
    }
}

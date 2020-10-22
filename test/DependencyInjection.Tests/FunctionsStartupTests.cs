// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Xunit;

namespace DependencyInjection.Tests
{
    public partial class FunctionsHostBuilderTests
    {
        [Fact]
        public void Configure_ConfiguresServices()
        {
            var builder = new TestStartup();

            var webJobsBuilder = new TestWebJobsBuilder();
            builder.Configure(webJobsBuilder);

            var thingy = webJobsBuilder.Services.First(x => x.ImplementationType == typeof(NullValidator));

            Assert.NotNull(thingy);

            //            Assert.Collection(webJobsBuilder.Services, t => Assert.Equal(typeof(Foo), t.ImplementationType));

        }

        private class TestStartup : FunctionsStartup
        {
            public override void Configure(IFunctionsHostBuilder builder)
            {
                builder.Services.AddSingleton<IFoo, Foo>();
                builder.Services.AddSingleton<IValidator<CreateIncentiveCommand>, NullValidator>();
            }
        }

        public interface IFoo
        {
        }

        public class Foo : IFoo
        {
        }

        public interface IValidator<in T> where T : ICommand
        {
            //Task<ValidationResult> Validate(T item);
        }

        public interface ICommand
        {
        }

        public abstract class DomainCommand : ICommand
        {
        }

        public class CreateIncentiveCommand : DomainCommand
        {
        }

        public class NullValidator : IValidator<DomainCommand>
        {
        }
    }
}

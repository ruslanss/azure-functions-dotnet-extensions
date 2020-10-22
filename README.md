# .NET Extensions for Azure Functions

|Branch|Status|
|---|---|
|main|[![Build Status](https://azfunc.visualstudio.com/Azure%20Functions/_apis/build/status/azure-functions-dotnet-extensions-ci?branchName=main)](https://azfunc.visualstudio.com/Azure%20Functions/_build/latest?definitionId=6&branchName=main)

The .NET Extensions for Azure Functions is an open-source, cross-platform set of APIs for commonly used programming patterns and utilities, in Azure Functions.



## Dependency Regiatration issue:

--powershell, --custom]
Can't determine project language from files. Please use one of [--csharp, --javascript, --typescript, --java, --python, --powershell, --custom]
[2020-10-22T19:57:18.555] A host error has occurred during startup operation '1e4e3d26-638b-4c5d-8b82-297ea579fc41'.
[2020-10-22T19:57:18.558] Microsoft.Azure.WebJobs.Script.WebHost: Registering implementation type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.NullValidator is not assignable to service type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.IValidator<Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.WhateverCommand>.
Value cannot be null. (Parameter 'provider')
Press any to continue....[2020-10-22T19:57:19.603] Hosting environment: Production
Content root path: C:\git\rnd\azure-functions-dotnet-extensions-rus\src\samples\DependencyInjection\Basic\bin\Debug\netcoreapp3.1
Now listening on: http://0.0.0.0:7071
Application started. Press Ctrl+C to shut down.
A host error has occurred during startup operation 'bcaa3ba8-73f5-448a-807a-cc3207be51a0'.
[2020-10-22T19:57:19.606] Microsoft.Azure.WebJobs.Script.WebHost: Registering implementation type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.NullValidator is not assignable to service type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.IValidator<Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.WhateverCommand>.
[2020-10-22T19:57:21.662] A host error has occurred during startup operation 'a9c85a21-33e2-4768-90c7-d96413df6287'.
[2020-10-22T19:57:21.664] Microsoft.Azure.WebJobs.Script.WebHost: Registering implementation type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.NullValidator is not assignable to service type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.IValidator<Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.WhateverCommand>.
[2020-10-22T19:57:25.710] A host error has occurred during startup operation 'ffacacea-ec74-4c90-b15d-f24163d72e14'.
[2020-10-22T19:57:25.713] Microsoft.Azure.WebJobs.Script.WebHost: Registering implementation type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.NullValidator is not assignable to service type Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.IValidator<Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.InjectionTest.WhateverCommand>.

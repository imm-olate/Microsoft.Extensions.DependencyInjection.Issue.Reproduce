Project reproduces failure of unit test due to the error below.

Initialization method Unit.Test.UnitTest1.Initialise threw exception. System.MissingMethodException: Method not found: 'Microsoft.Extensions.DependencyInjection.ServiceProvider Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(Microsoft.Extensions.DependencyInjection.IServiceCollection)'..

The Desktop project runs successfully without throwing an error.

This error only occurs when using Microsoft.Extensions.DependencyInjection.Abstractions 8.0.1, version 8.0.0 does not produce this error.

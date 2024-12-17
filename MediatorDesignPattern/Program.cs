using System;
using System.Threading.Tasks;
using MediatorDesignPattern.Handlers;
using MediatorDesignPattern.Messages;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static async Task Main(string[] args)
    {
        // Setup Dependency Injection
        var services = new ServiceCollection();

        // Register MediatR
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

        // Register Handlers
        services.AddScoped<IRequestHandler<DeveloperTaskCompletedMessage, Unit>, DeveloperHandler>();
        services.AddScoped<IRequestHandler<TesterTaskCompletedMessage, Unit>, TesterHandler>();
        services.AddScoped<IRequestHandler<DesignerTaskCompletedMessage, Unit>, DesignerHandler>();

        // Build the service provider
        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        // Start the workflow
        Console.WriteLine("Workflow started...");
        await mediator.Send(new DeveloperTaskCompletedMessage { TaskName = "Coding" });
        Console.WriteLine("Workflow completed.");
    }
}

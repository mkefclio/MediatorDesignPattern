using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorDesignPattern.Messages;
using MediatR;

namespace MediatorDesignPattern.Handlers
{
    public class DeveloperHandler : IRequestHandler<DeveloperTaskCompletedMessage, Unit>
    {
        private readonly IMediator _mediator;

        public DeveloperHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(DeveloperTaskCompletedMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Developer completed: {request.TaskName}");
            // Notify the Tester
            await _mediator.Send(new TesterTaskCompletedMessage { TaskName = "Start Testing" }, cancellationToken);
            return Unit.Value;
        }
    }
}

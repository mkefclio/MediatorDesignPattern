using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorDesignPattern.Messages;
using MediatR;

namespace MediatorDesignPattern.Handlers
{
    public class TesterHandler : IRequestHandler<TesterTaskCompletedMessage, Unit>
    {
        private readonly IMediator _mediator;

        public TesterHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(TesterTaskCompletedMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Tester completed: {request.TaskName}");
            // Notify the Designer
            await _mediator.Send(new DesignerTaskCompletedMessage { TaskName = "Update UI" }, cancellationToken);
            return Unit.Value;
        }
    }
}

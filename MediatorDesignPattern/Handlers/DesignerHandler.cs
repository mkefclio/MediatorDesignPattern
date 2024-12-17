using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorDesignPattern.Messages;
using MediatR;

namespace MediatorDesignPattern.Handlers
{
    public class DesignerHandler : IRequestHandler<DesignerTaskCompletedMessage, Unit>
    {
        public Task<Unit> Handle(DesignerTaskCompletedMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Designer completed: {request.TaskName}");
            return Task.FromResult(Unit.Value);
        }
    }
}

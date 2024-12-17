using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MediatorDesignPattern.Messages
{
    public class DeveloperTaskCompletedMessage : IRequest<Unit>
    {
        public string TaskName { get; set; }
    }

}

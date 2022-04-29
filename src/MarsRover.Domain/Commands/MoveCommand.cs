using EventFlow.Commands;
using EventFlow.Core;
using MarsRover.Domain.Aggregates;
using MarsRover.Domain.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Commands
{
    public class MoveCommand : Command<RoverAggregate, Identity>
    {
        public MoveCommand(Identity aggregateId) : base(aggregateId)
        {
        }

        public MoveCommand(Identity aggregateId, ISourceId sourceId) : base(aggregateId, sourceId)
        {
        }
    }
}

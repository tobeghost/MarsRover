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
    public class TurnLeftCommand : Command<RoverAggregate, Identity>
    {
        public TurnLeftCommand(Identity aggregateId) : base(aggregateId)
        {
        }

        public TurnLeftCommand(Identity aggregateId, ISourceId sourceId) : base(aggregateId, sourceId)
        {
        }
    }
}

using EventFlow.Aggregates;
using MarsRover.Domain.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Aggregates
{
    public class RoverAggregate : AggregateRoot<RoverAggregate, Identity>
    {
        public RoverAggregate(Identity id) : base(id)
        {
        }
    }
}

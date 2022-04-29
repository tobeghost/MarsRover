using EventFlow.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.ComplexTypes
{
    public class Identity : Identity<Identity>
    {
        public Identity(string value) : base(value)
        {
        }
    }
}

using MarsRover.Core.DTOs;
using MarsRover.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Commands
{
    public class MoveRoverCommand : INotification
    {
        public Rover Rover { get; set; }
        public Movement Movement { get; set; }
    }
}

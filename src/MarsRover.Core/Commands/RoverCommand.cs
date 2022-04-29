using MarsRover.Core.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Commands
{
    public class RoverCommand : INotification
    {
        public Rover Rover { get; set; }
        public string NewCommand { get; set; } = "";
    }
}

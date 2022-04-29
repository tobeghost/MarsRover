using MarsRover.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.DTOs
{
    public class Rover
    {
        public SurfaceSize Size { get; set; } = new SurfaceSize(0, 0);
        public RoverPosition Position { get; set; } = new RoverPosition();
    }
}

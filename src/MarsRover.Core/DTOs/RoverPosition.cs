using MarsRover.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.DTOs
{
    public class RoverPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public RoverDirection Direction { get; set; }

        public static implicit operator RoverPosition(string value)
        {
            var size = value.Split(' ');
            var result = new RoverPosition();
            result.X = int.Parse(size[0]);
            result.Y = int.Parse(size[1]);
            result.Direction = Enum.Parse<RoverDirection>(size[2]);
            return result;
        }
    }
}

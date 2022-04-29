using MarsRover.Core.DTOs;
using MarsRover.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Handlers
{
    public class RoverHandler
    {
        public void Handle(Rover Rover, string NewCommand)
        {
            if (!string.IsNullOrEmpty(NewCommand))
            {
                foreach (var item in NewCommand.ToUpper())
                {
                    switch (item)
                    {
                        case 'L':
                            new MoveRoverHandler().Handle(Rover, Movement.L);
                            break;

                        case 'R':
                            new MoveRoverHandler().Handle(Rover, Movement.R);
                            break;

                        case 'M':
                            new MoveRoverHandler().Handle(Rover, Movement.M);
                            break;
                    }
                }
            }
        }
    }
}

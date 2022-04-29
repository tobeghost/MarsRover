using MarsRover.Core.DTOs;
using MarsRover.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Handlers
{
    public class MoveRoverHandler
    {
        public void Handle(Rover Rover, Movement Movement)
        {
            if (Movement == Movement.L)
            {
                TurnLeft(Rover);
            }
            else if (Movement == Movement.R)
            {
                TurnRight(Rover);
            }
            else if (Movement == Movement.M)
            {
                Move(Rover);
            }
        }

        private void TurnLeft(Rover rover)
        {
            if ((rover.Position.Direction - 1) < RoverDirection.N)
            {
                rover.Position.Direction = RoverDirection.W;
            }
            else
            {
                rover.Position.Direction = rover.Position.Direction - 1;
            }
        }

        private void TurnRight(Rover rover)
        {
            if ((rover.Position.Direction + 1) > RoverDirection.W)
            {
                rover.Position.Direction = RoverDirection.N;
            }
            else
            {
                rover.Position.Direction = rover.Position.Direction + 1;
            }
        }

        private void Move(Rover rover)
        {
            int roverX = rover.Position.X;
            int roverY = rover.Position.Y;

            switch (rover.Position.Direction)
            {
                case RoverDirection.N: rover.Position.Y++; break;
                case RoverDirection.S: rover.Position.Y--; break;
                case RoverDirection.W: rover.Position.X--; break;
                case RoverDirection.E: rover.Position.X++; break;
                default:
                    throw new InvalidOperationException();
            }

            if (!IsRoverInsideBoundaries(rover))
            {
                rover.Position.X = roverX;
                rover.Position.Y = roverY;
            }
        }

        private bool IsRoverInsideBoundaries(Rover rover)
        {
            if (rover.Position.X > rover.Size.Width || rover.Position.X < 0 || rover.Position.Y > rover.Size.Height || rover.Position.Y < 0)
            {
                return false;
            }

            return true;
        }
    }
}

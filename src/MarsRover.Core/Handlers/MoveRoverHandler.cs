using MarsRover.Core.Commands;
using MarsRover.Core.DTOs;
using MarsRover.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Handlers
{
    public class MoveRoverHandler : INotificationHandler<MoveRoverCommand>
    {
        public Task Handle(MoveRoverCommand notification, CancellationToken cancellationToken)
        {
            if (notification.Movement == Movement.L)
            {
                TurnLeft(notification.Rover);
            }
            else if (notification.Movement == Movement.R)
            {
                TurnRight(notification.Rover);
            }
            else if (notification.Movement == Movement.M)
            {
                Move(notification.Rover);
            }

            return Task.CompletedTask;
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
                case RoverDirection.N: roverY++; break;
                case RoverDirection.S: roverY--; break;
                case RoverDirection.W: roverX--; break;
                case RoverDirection.E: roverX++; break;
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

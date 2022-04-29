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
    public class RoverHandler : INotificationHandler<RoverCommand>
    {
        private readonly IMediator _mediator;

        public RoverHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task Handle(RoverCommand notification, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(notification.NewCommand))
            {
                foreach (var item in notification.NewCommand.ToUpper())
                {
                    switch (item)
                    {
                        case 'L': _mediator.Send(new MoveRoverCommand() { Rover = notification.Rover, Movement = Movement.L }); break;
                        case 'R': _mediator.Send(new MoveRoverCommand() { Rover = notification.Rover, Movement = Movement.R }); break;
                        case 'M': _mediator.Send(new MoveRoverCommand() { Rover = notification.Rover, Movement = Movement.M }); break;
                    }
                }
            }

            return Task.CompletedTask;
        }
    }
}

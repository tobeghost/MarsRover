using MarsRover.Core.Commands;
using MarsRover.Core.DTOs;
using MarsRover.Core.Enums;
using MarsRover.Core.Handlers;
using MediatR;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MarsRover.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new object[] { "5 5", "1 2 N", "LMLMLMLMM", 1, 3, RoverDirection.N })]
        [InlineData(new object[] { "5 5", "3 3 E", "MMRMMRMRRM", 5, 1, RoverDirection.E })]
        public async Task Test1(string plateauSurfaceSize,
            string roverPosition,
            string roverCommand,
            int expectedX,
            int exceptedY,
            RoverDirection expectedDirection)
        {
            //Arange
            var mediator = new Mock<IMediator>();

            var command = new RoverCommand()
            {
                Rover = new Rover()
                {
                    Size = new SurfaceSize(5, 5),
                    Position = new RoverPosition(RoverDirection.N, 1, 3)
                }
            };
            var handler = new RoverHandler(mediator.Object);

            //Act
            await handler.Handle(command, new CancellationToken());
        }
    }
}
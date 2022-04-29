using MarsRover.Core.DTOs;
using MarsRover.Core.Enums;
using MarsRover.Core.Handlers;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTest
    {
        [Theory]
        [InlineData(new object[] { "5 5", "1 2 N", "LMLMLMLMM", 1, 3, RoverDirection.N })]
        [InlineData(new object[] { "5 5", "3 3 E", "MMRMMRMRRM", 5, 1, RoverDirection.E })]
        public async Task GeneratePlataue(string plateauSurfaceSize,
            string roverPosition,
            string roverCommand,
            int expectedX,
            int exceptedY,
            RoverDirection expectedDirection)
        {
            //define inputs
            SurfaceSize size = plateauSurfaceSize;
            RoverPosition position = roverPosition;

            //define command
            var rover = new Rover() { Size = size, Position = position };

            //define handler
            var handler = new RoverHandler();

            //Act
            handler.Handle(rover, roverCommand);

            //Assert
            Assert.Equal(expectedX, rover.Position.X);
            Assert.Equal(exceptedY, rover.Position.Y);
            Assert.Equal(expectedDirection, rover.Position.Direction);
        }
    }
}
namespace MarsRover.Core.DTOs
{
    public class SurfaceSize
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public static implicit operator SurfaceSize(string value)
        {
            var size = value.Split(' ');
            var result = new SurfaceSize();
            result.Width = int.Parse(size[0]);
            result.Height = int.Parse(size[1]);
            return result;
        }
    }
}

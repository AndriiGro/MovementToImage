using System.Collections.Generic;

namespace MovementToImage
{
    public class MovementData
    {
        public MovementData()
        {
            stringDataX = new List<string>();
            stringDataY = new List<string>();
            stringDataZ = new List<string>();

            doubleDataX = new List<double>();
            doubleDataY = new List<double>();
            doubleDataZ = new List<double>();
        }

        public List<string> stringDataX { get; set; }
        public List<string> stringDataY { get; set; }
        public List<string> stringDataZ { get; set; }

        public List<double> doubleDataX { get; set; }
        public List<double> doubleDataY { get; set; }
        public List<double> doubleDataZ { get; set; }
    }
}

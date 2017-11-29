using System.Collections.Generic;
using System.Linq;

namespace MovementToImage
{
    public class MovementForDistanceCoeffitient
    {
        public List<double> Movement1Data { get; set; }
        public List<double> Movement2Data { get; set; }
        public DataBounds Bounds { get; set; }
        public int Lenght { get; set; }

        public MovementForDistanceCoeffitient(List<double> data1, List<double> data2)
        {
            Movement1Data = data1;
            Movement2Data = data2;
            Lenght = data1.Count;
            Bounds = CalculateLimits(Movement1Data, Movement2Data);
        }

        private DataBounds CalculateLimits(List<double> data1, List<double> data2)
        {
            List<double> merge = new List<double>();
            merge.AddRange(data1);
            merge.AddRange(data2);

            DataBounds bounds = new DataBounds();
            bounds.Lower = merge.Min();
            bounds.Upper = merge.Max();

            return bounds;
        }

        public class DataBounds
        {
            public double Lower { get; set; }
            public double Upper { get; set; }
        }
    }
}

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MovementToImage
{
    public class CorrelationCalculation
    {
        Form1 form1;

        public CorrelationCalculation() { }
        public CorrelationCalculation(Form1 formInstance)
        {
            form1 = formInstance;
        }

        internal void ProcessData(string movementData1, string movementData2)
        {
            MovementData movement1Pre = ConvertInputDataToMovementData(movementData1);
            MovementData movement2Pre = ConvertInputDataToMovementData(movementData2);

            MovementData movement1 = Helper.GetShorterMovement(movement1Pre, movement2Pre);
            MovementData movement2 = Helper.GetLongerMovement(movement1Pre, movement2Pre);

            PlotModel plotModelX = GeneratePlotModelForTwoArrays(movement1.doubleDataX, movement2.doubleDataX);
            PlotModel plotModelY = GeneratePlotModelForTwoArrays(movement1.doubleDataY, movement2.doubleDataY);
            PlotModel plotModelZ = GeneratePlotModelForTwoArrays(movement1.doubleDataZ, movement2.doubleDataZ);

            form1.SetPlotCorrX(plotModelX);
            form1.SetPlotCorrY(plotModelY);
            form1.SetPlotCorrZ(plotModelZ);

            double correlationX = GetCorrelationForTwoArrays(movement1.doubleDataX, movement2.doubleDataX);
            double correlationY = GetCorrelationForTwoArrays(movement1.doubleDataY, movement2.doubleDataY);
            double correlationZ = GetCorrelationForTwoArrays(movement1.doubleDataZ, movement2.doubleDataZ);
            double correlationAverage = (correlationX + correlationY + correlationZ) / 3.0;

            form1.SetCorrelationResultX(correlationX.ToString("0.####"));
            form1.SetCorrelationResultY(correlationY.ToString("0.####"));
            form1.SetCorrelationResultZ(correlationZ.ToString("0.####"));
            form1.SetCorrelationResultAverage(correlationAverage.ToString("0.####"));

            double energyCoefX = CalculateEnergyDifferenceCoef(movement1.doubleDataX, movement2.doubleDataX);
            double energyCoefY = CalculateEnergyDifferenceCoef(movement1.doubleDataY, movement2.doubleDataY);
            double energyCoefZ = CalculateEnergyDifferenceCoef(movement1.doubleDataZ, movement2.doubleDataZ);
            double energyCoefAverage = (energyCoefX + energyCoefY + energyCoefZ) / 3.0;

            form1.SetEnergyCoefficientX(energyCoefX.ToString("0.####"));
            form1.SetEnergyCoefficientY(energyCoefY.ToString("0.####"));
            form1.SetEnergyCoefficientZ(energyCoefZ.ToString("0.####"));
            form1.SetEnergyCoefficientAverage(energyCoefAverage.ToString("0.####"));
        }

        private double CalculateEnergyDifferenceCoef(List<double> doubleData1, List<double> doubleData2)
        {
            double energy1 = CalculateEnergyOfArray(doubleData1);
            double energy2 = CalculateEnergyOfArray(doubleData2);

            List<double> merge = new List<double>();
            merge.AddRange(doubleData1);
            merge.AddRange(doubleData2);

            double maxEnergyDifference = Math.Pow((merge.Max() - merge.Min()), 2) * doubleData2.Count;

            return 1 - (Math.Abs(energy1 - energy2) / maxEnergyDifference);
        }

        private double CalculateEnergyOfArray(List<double> doubleData)
        {
            double energy = 0;
            doubleData.ForEach(value => energy += Math.Abs(value) * Math.Abs(value));
            return energy;
        }

        private double GetCorrelationForTwoArrays(List<double> list1, List<double> list2)
        {
            double[] array1 = list1.ToArray();
            List<double> part = list2.GetRange(0, array1.Length);
            double[] array2 = part.ToArray();
            double[] array_xy = new double[array1.Length];
            double[] array_xPower2 = new double[array1.Length];
            double[] array_yPower2 = new double[array1.Length];
            double sum_x = 0;
            double sum_y = 0;
            double sum_xy = 0;
            double sum_xpow2 = 0;
            double sum_ypow2 = 0;

            for (int i = 0; i < array1.Length; i++)
                array_xy[i] = array1[i] * array2[i];

            for (int i = 0; i < array1.Length; i++)
                array_xPower2[i] = Math.Pow(array1[i], 2.0);

            for (int i = 0; i < array1.Length; i++)
                array_yPower2[i] = Math.Pow(array2[i], 2.0);

            foreach (double n in array1)
                sum_x += n;

            foreach (double n in array2)
                sum_y += n;

            foreach (double n in array_xy)
                sum_xy += n;

            foreach (double n in array_xPower2)
                sum_xpow2 += n;

            foreach (double n in array_yPower2)
                sum_ypow2 += n;

            double xSumPower2 = Math.Pow(sum_x, 2.00);
            double ySumPower2 = Math.Pow(sum_y, 2.00);

            double correlation =
            (array1.Length * sum_xy - sum_x * sum_y) /
            Math.Sqrt((array1.Length * sum_xpow2 - xSumPower2) * (array1.Length * sum_ypow2 - ySumPower2));

            return correlation;
        }

        private PlotModel GeneratePlotModelForTwoArrays(PlotModel plotModel, List<double> doubleData1, List<double> doubleData2)
        {
            var plotSeries1 = new LineSeries { StrokeThickness = 1, MarkerSize = 1, Color = OxyColor.FromRgb(255, 0, 0) };
            var plotSeries2 = new LineSeries { StrokeThickness = 1, MarkerSize = 1, Color = OxyColor.FromRgb(255, 0, 0) };

            for (int i = 0; i < doubleData1.Count; i++)
            {
                plotSeries1.Points.Add(new DataPoint(i, doubleData1[i]));
                plotSeries2.Points.Add(new DataPoint(i, doubleData2[i]));
            }

            plotModel.Series.Add(plotSeries1);
            plotModel.Series.Add(plotSeries2);

            return plotModel;
        }

        public PlotModel GeneratePlotModelForTwoArrays(List<double> doubleData1, List<double> doubleData2)
        {
            PlotModel plotModel = new PlotModel();

            return GeneratePlotModelForTwoArrays(plotModel, doubleData1, doubleData2);
        }

        public PlotModel GeneratePlotModelForTwoArraysWithoutAxis(List<double> doubleData1, List<double> doubleData2)
        {
            PlotModel plotModel = new PlotModel();
            plotModel.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                IsAxisVisible = false
            });

            plotModel.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Left,
                IsAxisVisible = false
            });

            return GeneratePlotModelForTwoArrays(plotModel, doubleData1, doubleData2);
        }

        internal MovementData ConvertInputDataToMovementData(string movementData)
        {
            MovementData movement = new MovementData();

            List<string> stringInputDataXYZ = movementData.Split(Environment.NewLine.ToCharArray()).ToList();
            stringInputDataXYZ = stringInputDataXYZ.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            foreach (var dataXYZ in stringInputDataXYZ)
            {
                string[] temp = new string[3];
                temp = dataXYZ.Split('\t');
                movement.stringDataX.Add(temp[0]);
                movement.stringDataY.Add(temp[1]);
                movement.stringDataZ.Add(temp[2]);
            }

            double parsedNumber = 0;
            movement.doubleDataX = movement.stringDataX.Where(number => double.TryParse(number, out parsedNumber)).Select(number => parsedNumber).ToList();
            movement.doubleDataY = movement.stringDataY.Where(number => double.TryParse(number, out parsedNumber)).Select(number => parsedNumber).ToList();
            movement.doubleDataZ = movement.stringDataZ.Where(number => double.TryParse(number, out parsedNumber)).Select(number => parsedNumber).ToList();

            return movement;
        }
    }
}

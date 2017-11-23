using AForge.Imaging.Filters;
using MetroFramework.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            MovementData movement1 = ConvertInputDataToMovementData(movementData1);
            MovementData movement2 = ConvertInputDataToMovementData(movementData2);

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

            double maxEnergyDifference = Math.Abs(merge.Min()) * Math.Abs(merge.Max()) * doubleData1.Count;

            return 1 - (Math.Abs(energy1 - energy2) / maxEnergyDifference);
        }

        private double CalculateEnergyOfArray(List<double> doubleData)
        {
            double energy = 0;
            doubleData.ForEach(value => energy += Math.Abs(value) * Math.Abs(value));
            return energy;
        }

        private double GetCorrelationForTwoArrays(List<double> array1, List<double> array2)
        {
            double[] array_xy = new double[array1.Count];
            double[] array_xp2 = new double[array1.Count];
            double[] array_yp2 = new double[array1.Count];
            for (int i = 0; i < array1.Count; i++)
                array_xy[i] = array1[i] * array2[i];

            for (int i = 0; i < array1.Count; i++)
                array_xp2[i] = Math.Pow(array1[i], 2.0);

            for (int i = 0; i < array1.Count; i++)
                array_yp2[i] = Math.Pow(array2[i], 2.0);

            double sum_x = 0;
            double sum_y = 0;

            foreach (double n in array1)
                sum_x += n;

            foreach (double n in array2)
                sum_y += n;

            double sum_xy = 0;

            foreach (double n in array_xy)
                sum_xy += n;

            double sum_xpow2 = 0;

            foreach (double n in array_xp2)
                sum_xpow2 += n;

            double sum_ypow2 = 0;

            foreach (double n in array_yp2)
                sum_ypow2 += n;

            double Ex2 = Math.Pow(sum_x, 2.00);
            double Ey2 = Math.Pow(sum_y, 2.00);

            double correl =
            (array1.Count * sum_xy - sum_x * sum_y) /
            Math.Sqrt((array1.Count * sum_xpow2 - Ex2) * (array1.Count * sum_ypow2 - Ey2));

            return correl;
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
            stringInputDataXYZ = stringInputDataXYZ.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

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

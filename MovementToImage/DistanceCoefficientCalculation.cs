﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace MovementToImage
{
    public class DistanceCoefficientCalculation
    {
        Form1 mainForm;
        Color plotBackgroundColor = Color.White;
        Color plotColor = Color.Red;
        Color differenceFillingColor = Color.Red;
        CorrelationCalculation helper;

        public DistanceCoefficientCalculation(Form1 formInstance)
        {
            mainForm = formInstance;
            helper = new CorrelationCalculation();
        }

        internal void ProcessData(string movementData1, string movementData2)
        {
            MovementData movement1Pre = helper.ConvertInputDataToMovementData(movementData1);
            MovementData movement2Pre = helper.ConvertInputDataToMovementData(movementData2);

            MovementData movement1 = Helper.GetShorterMovement(movement1Pre, movement2Pre);
            MovementData movement2 = Helper.GetLongerMovement(movement1Pre, movement2Pre);

            MovementForDistanceCoeffitient movementX = new MovementForDistanceCoeffitient(movement1.doubleDataX, movement2.doubleDataX);
            MovementForDistanceCoeffitient movementY = new MovementForDistanceCoeffitient(movement1.doubleDataY, movement2.doubleDataY);
            MovementForDistanceCoeffitient movementZ = new MovementForDistanceCoeffitient(movement1.doubleDataZ, movement2.doubleDataZ);

            List<DataForCountingDifference> differencesX = GetDifferences(movementX);
            List<DataForCountingDifference> differencesY = GetDifferences(movementY);
            List<DataForCountingDifference> differencesZ = GetDifferences(movementZ);

            double distanceCoefX = CalculateDistanceCoefficient(differencesX);
            double distanceCoefY = CalculateDistanceCoefficient(differencesY);
            double distanceCoefZ = CalculateDistanceCoefficient(differencesZ);
            double distanceCoefAverage = (distanceCoefX + distanceCoefY + distanceCoefZ) / 3.0;

            mainForm.SetTab3DistanceCoefficientX(distanceCoefX.ToString("0.####"));
            mainForm.SetTab3DistanceCoefficientY(distanceCoefY.ToString("0.####"));
            mainForm.SetTab3DistanceCoefficientZ(distanceCoefZ.ToString("0.####"));
            mainForm.SetTab3DistanceCoefficientAverage(distanceCoefAverage.ToString("0.####"));

            Bitmap visualizationX = GenerateDifferencesVisualizationImage(differencesX);
            Bitmap visualizationY = GenerateDifferencesVisualizationImage(differencesY);
            Bitmap visualizationZ = GenerateDifferencesVisualizationImage(differencesZ);

            mainForm.SetTab3PictureX(visualizationX);
            mainForm.SetTab3PictureY(visualizationY);
            mainForm.SetTab3PictureZ(visualizationZ);
        }

        private Bitmap GenerateDifferencesVisualizationImage(List<DataForCountingDifference> differences)
        {
            Bitmap visualization = new Bitmap(differences.Count, (int)(differences.Count * 0.7));

            for (int i = 0; i < visualization.Width; i++)
            {
                List<Color> verticalImageLine = new List<Color>();
                double maxRange = Math.Abs(differences[i].MinValue) + Math.Abs(differences[i].MaxValue);
                int differencePixels = (int)((differences[i].Difference / maxRange) * visualization.Height);
                differencePixels = differencePixels == 0 ? 1 : differencePixels;

                int startPixels = (int)((Math.Abs(differences[i].StartValue) / maxRange) * visualization.Height);
                verticalImageLine = Enumerable.Repeat(plotBackgroundColor, startPixels).ToList();

                for (int j = 0; j < differencePixels; j++)
                {
                    verticalImageLine.Add(differenceFillingColor);
                }

                for (int y = 0; y < (visualization.Height - differencePixels - startPixels); y++)
                {
                    verticalImageLine.Add(plotBackgroundColor);
                }

                for (int z = 0; z < visualization.Height; z++)
                {
                    visualization.SetPixel(i, z, verticalImageLine[visualization.Height - z - 1]);
                }
            }

            return visualization;
        }

        private double CalculateDistanceCoefficient(List<DataForCountingDifference> differences)
        {
            double differencesSum = 0;
            foreach (DataForCountingDifference difference in differences)
            {
                differencesSum += difference.Difference;
            }

            double maxSum = differences.Count * Math.Abs(differences[0].MaxValue - differences[0].MinValue);

            return 1 - (differencesSum / maxSum);
        }

        private List<DataForCountingDifference> GetDifferences(MovementForDistanceCoeffitient movement)
        {
            List<DataForCountingDifference> differences = new List<DataForCountingDifference>();
            for (int i = 0; i < movement.Lenght; i++)
            {
                DataForCountingDifference data = new DataForCountingDifference();
                data.MinValue = movement.Bounds.Lower;
                data.MaxValue = movement.Bounds.Upper;
                data.Difference = Math.Abs(movement.Movement1Data[i] - movement.Movement2Data[i]);
                data.StartValue = Math.Min(movement.Movement1Data[i], movement.Movement2Data[i]);
                differences.Add(data);
            }

            return differences;
        }

        private double CalculateDistanceCoefficientInPlot(Bitmap plot)
        {
            int plotPixelsCount = CountPixelsOfColor(plot, plotColor);
            int distanceFillingPixelsCount = CountPixelsOfColor(plot, differenceFillingColor);
            int backgroundPixelsCount
                = ((plot.Width * plot.Height) - plotPixelsCount - distanceFillingPixelsCount);

            return (double)distanceFillingPixelsCount / (backgroundPixelsCount - plotPixelsCount);
        }

        private int CountPixelsOfColor(Bitmap bm, Color target_color)
        {
            int matches = 0;
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (bm.GetPixel(x, y) == target_color) matches++;
                }
            }
            return matches;
        }

        private Bitmap FillDifferenceWithColor(Bitmap srcBitmap)
        {
            Bitmap newBitmap = new Bitmap(srcBitmap.Width, srcBitmap.Height);
            for (int i = 0; i < srcBitmap.Width; i++)
            {
                List<Color> verticalImageLine = new List<Color>();
                for (int j = 0; j < srcBitmap.Height; j++)
                {
                    verticalImageLine.Add(srcBitmap.GetPixel(i, j));
                }

                int plotCrossingsInLine = verticalImageLine.Where(c => c.ToArgb() == plotColor.ToArgb()).Count();
                switch (plotCrossingsInLine)
                {
                    case 1:
                        break;
                    case 2:
                        verticalImageLine = FillDifferenceWithColorInLine(verticalImageLine);
                        break;
                    default:
                        if (plotCrossingsInLine > 2 || plotCrossingsInLine < 1)
                        {
                            throw new Exception($"Plot crossings: {plotCrossingsInLine}");
                        }
                        break;
                }

                for (int j = 0; j < srcBitmap.Height; j++)
                {
                    newBitmap.SetPixel(i, j, verticalImageLine[j]);
                }
            }

            return newBitmap;
        }

        private List<Color> FillDifferenceWithColorInLine(List<Color> line)
        {
            int firstPlotPosition = line.FindIndex(c => c.ToArgb() == plotColor.ToArgb());
            if (firstPlotPosition == 0 && line[firstPlotPosition + 1].ToArgb() == plotColor.ToArgb())
                return line;
            if (firstPlotPosition == (line.Count - 1) && line[firstPlotPosition - 1].ToArgb() == plotColor.ToArgb())
                return line;
            if (line[firstPlotPosition - 1].ToArgb() == plotColor.ToArgb() || line[firstPlotPosition + 1].ToArgb() == plotColor.ToArgb())
                return line;

            List<Color> filledLine = new List<Color>();
            bool isBetweenPlot = false;
            for (int i = 0; i < line.Count; i++)
            {
                if (line[i].ToArgb() == plotBackgroundColor.ToArgb())
                {
                    filledLine.Add(isBetweenPlot ? differenceFillingColor : plotBackgroundColor);
                    continue;
                }

                if (line[i].ToArgb() == plotColor.ToArgb())
                {
                    filledLine.Add(plotColor);
                    isBetweenPlot = !isBetweenPlot;
                }
            }

            return filledLine;
        }

        private class DataForCountingDifference
        {
            public double StartValue { get; set; }
            public double Difference { get; set; }
            public double MinValue { get; set; }
            public double MaxValue { get; set; }
        }

    }
}

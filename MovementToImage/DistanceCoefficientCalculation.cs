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
    public class DistanceCoefficientCalculation
    {
        Form1 mainForm;
        Color plotBackgroundColor = Color.White;
        Color plotColor = Color.Red;
        Color distanceFillingColor = Color.Gold;
        CorrelationCalculation helper;

        public DistanceCoefficientCalculation(Form1 formInstance)
        {
            mainForm = formInstance;
            helper = new CorrelationCalculation();
        }

        internal void ProcessData(string movementData1, string movementData2)
        {
            MovementData movement1 = helper.ConvertInputDataToMovementData(movementData1);
            MovementData movement2 = helper.ConvertInputDataToMovementData(movementData2);

            PlotModel plotModelX = helper.GeneratePlotModelForTwoArraysWithoutAxis(movement1.doubleDataX, movement2.doubleDataX);
            PlotModel plotModelY = helper.GeneratePlotModelForTwoArraysWithoutAxis(movement1.doubleDataY, movement2.doubleDataY);
            PlotModel plotModelZ = helper.GeneratePlotModelForTwoArraysWithoutAxis(movement1.doubleDataZ, movement2.doubleDataZ);

            Bitmap plotX = Form1.Crop(mainForm.ChangeBitmapColor(mainForm.ExportModelAsBitmap(plotModelX), Color.Black, Color.White));
            Bitmap plotY = Form1.Crop(mainForm.ChangeBitmapColor(mainForm.ExportModelAsBitmap(plotModelY), Color.Black, Color.White));
            Bitmap plotZ = Form1.Crop(mainForm.ChangeBitmapColor(mainForm.ExportModelAsBitmap(plotModelZ), Color.Black, Color.White));
            
            mainForm.setTab3PictureX(plotX);
            mainForm.setTab3PictureY(plotY);
            mainForm.setTab3PictureZ(plotZ);

            plotX = FillDifferenceWithColor(plotX);
            plotY = FillDifferenceWithColor(plotY);
            plotZ = FillDifferenceWithColor(plotZ);

            mainForm.setTab3PictureX(plotX);
            mainForm.setTab3PictureY(plotY);
            mainForm.setTab3PictureZ(plotZ);

            double distanceCoefX = CalculateDistanceCoefficientInPlot(plotX);
            double distanceCoefY = CalculateDistanceCoefficientInPlot(plotY);
            double distanceCoefZ = CalculateDistanceCoefficientInPlot(plotZ);
            double distanceCoefAverage = (distanceCoefX + distanceCoefX + distanceCoefX) / 3.0;

            mainForm.setTab3DistanceCoefficientX(distanceCoefX.ToString("0.####"));
            mainForm.setTab3DistanceCoefficientY(distanceCoefY.ToString("0.####"));
            mainForm.setTab3DistanceCoefficientZ(distanceCoefZ.ToString("0.####"));
            mainForm.setTab3DistanceCoefficientAverage(distanceCoefAverage.ToString("0.####"));
        }

        private double CalculateDistanceCoefficientInPlot(Bitmap plot)
        {
            int plotPixelsCount = CountPixelsOfColor(plot, plotColor);
            int distanceFillingPixelsCount = CountPixelsOfColor(plot, distanceFillingColor);
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
                    filledLine.Add(isBetweenPlot ? distanceFillingColor : plotBackgroundColor);
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
    }
}

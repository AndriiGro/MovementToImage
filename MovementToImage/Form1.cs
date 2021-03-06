﻿using AForge.Imaging.Filters;
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
    public partial class Form1 : MetroForm
    {
        private List<string> stringInputDataX;
        private List<double> doubleInputDataX;
        private List<string> stringInputDataY;
        private List<double> doubleInputDataY;
        private List<string> stringInputDataZ;
        private List<double> doubleInputDataZ;
        private List<double> allInputData = new List<double>();
        private static PlotModel myModel = null;

        private string delimiter;

        public int xSize = 150;
        public int ySize = 60;

        private static ParsingManager parser;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Plot_Click(object sender, EventArgs e)
        {
            try
            {
                InitPlotModel();
                ParseData();
                ParseParameters();

                int min, max;
                min = (int)allInputData.Min();
                max = (int)allInputData.Max();
                var plotSeriesX = new LineSeries { StrokeThickness = 1, MarkerSize = 1, Color = OxyColor.FromRgb(255, 0, 0) };
                var plotSeriesY = new LineSeries { StrokeThickness = 1, MarkerSize = 1, Color = OxyColor.FromRgb(255, 0, 0) };
                var plotSeriesZ = new LineSeries { StrokeThickness = 1, MarkerSize = 1, Color = OxyColor.FromRgb(255, 0, 0) };

                for (int i = 0; i < doubleInputDataX.Count; i++)
                {
                    plotSeriesX.Points.Add(new DataPoint(i, doubleInputDataX[i]));
                    plotSeriesY.Points.Add(new DataPoint(i, doubleInputDataY[i]));
                    plotSeriesZ.Points.Add(new DataPoint(i, doubleInputDataZ[i]));
                }

                myModel.Series.Add(plotSeriesX);
                myModel.Series.Add(plotSeriesY);
                myModel.Series.Add(plotSeriesZ);
                plotView.Model = myModel;

                Bitmap graph = ExportModelAsBitmap(myModel);

                graph = ChangeBitmapColor(graph, Color.Black, Color.White);
                graph = Crop(graph);
                ResizeBilinear filter = new ResizeBilinear(xSize, ySize);
                graph = filter.Apply(graph);

                resultPictureBox.Image = graph;

                List<int> data = GetBitmapDataAsList(graph);
                finalPixelData.Text = string.Join(delimiter, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception happens ;)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal Bitmap ExportModelAsBitmap(PlotModel model)
        {
            var pngExporter = new PngExporter { Width = xSize, Height = ySize, Background = OxyColors.White };
            Bitmap graph = pngExporter.ExportToBitmap(model);
            return graph;
        }

        public static Bitmap Crop(Bitmap bmp)
        {
            int w = bmp.Width;
            int h = bmp.Height;

            Func<int, bool> allWhiteRow = row =>
            {
                for (int i = 0; i < w; ++i)
                    if (bmp.GetPixel(i, row).ToArgb() != Color.White.ToArgb())
                        return false;
                return true;
            };

            Func<int, bool> allWhiteColumn = col =>
            {
                for (int i = 0; i < h; ++i)
                    if (bmp.GetPixel(col, i).ToArgb() != Color.White.ToArgb())
                        return false;
                return true;
            };

            int topmost = 0;
            for (int row = 0; row < h; ++row)
            {
                if (allWhiteRow(row))
                    topmost = row;
                else break;
            }

            int bottommost = 0;
            for (int row = h - 1; row >= 0; --row)
            {
                if (allWhiteRow(row))
                    bottommost = row;
                else break;
            }

            int leftmost = 0, rightmost = 0;
            for (int col = 0; col < w; ++col)
            {
                if (allWhiteColumn(col))
                    leftmost = col;
                else
                    break;
            }

            for (int col = w - 1; col >= 0; --col)
            {
                if (allWhiteColumn(col))
                    rightmost = col;
                else
                    break;
            }

            if (rightmost == 0) rightmost = w;
            if (bottommost == 0) bottommost = h;
            int croppedWidth = rightmost - leftmost;
            int croppedHeight = bottommost - topmost;

            if (croppedWidth == 0)
            {
                leftmost = 0;
                croppedWidth = w;
            }

            if (croppedHeight == 0)
            {
                topmost = 0;
                croppedHeight = h;
            }

            try
            {
                var target = new Bitmap(croppedWidth, croppedHeight);
                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(bmp,
                      new RectangleF(0, 0, croppedWidth, croppedHeight),
                      new RectangleF(leftmost, topmost, croppedWidth, croppedHeight),
                      GraphicsUnit.Pixel);
                }
                return target;
            }
            catch (Exception ex)
            {
                throw new Exception(
                  string.Format("Values are topmost={0} bottom={1} left={2} right={3} croppedWidth={4} croppedHeight={5}", topmost, bottommost, leftmost, rightmost, croppedWidth, croppedHeight),
                  ex);
            }
        }

        public static List<int> GetBitmapDataAsList(Bitmap srcBitmap)
        {
            List<int> data = new List<int>();
            Color actualColor;
            for (int i = 0; i < srcBitmap.Width; i++)
            {
                for (int j = 0; j < srcBitmap.Height; j++)
                {
                    actualColor = srcBitmap.GetPixel(i, j);
                    if (actualColor.ToArgb() != Color.White.ToArgb())
                        data.Add(255);
                    else
                        data.Add(0);
                }
            }

            return data;
        }

        internal Bitmap ChangeBitmapColor(Bitmap srcBitmap, Color oldColor, Color newColor)
        {
            Color actualColor;
            Bitmap newBitmap = new Bitmap(srcBitmap.Width, srcBitmap.Height);
            for (int j = 0; j < srcBitmap.Height; j++)
            {
                for (int i = 0; i < srcBitmap.Width; i++)
                {
                    actualColor = srcBitmap.GetPixel(i, j);
                    if (actualColor.ToArgb() == oldColor.ToArgb())
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }

            return newBitmap;
        }


        private static void InitPlotModel()
        {
            if (myModel == null)
            {
                myModel = new PlotModel();
                myModel.Axes.Add(new LinearAxis()
                {
                    Position = AxisPosition.Bottom,
                    IsAxisVisible = false
                });

                myModel.Axes.Add(new LinearAxis()
                {
                    Position = AxisPosition.Left,
                    IsAxisVisible = false
                });
            }
        }

        private void ParseParameters()
        {
            xSize = int.Parse(xSizeTextBox.Text);
            ySize = int.Parse(ySizeTextBox.Text);
            delimiter = delimiterTextBox.Text;
        }

        private void ParseData()
        {
            stringInputDataX = new List<string>();
            doubleInputDataX = new List<double>();
            stringInputDataY = new List<string>();
            doubleInputDataY = new List<double>();
            stringInputDataZ = new List<string>();
            doubleInputDataZ = new List<double>();
            List<string> stringInputDataXYZ = dataTextBox.Text.Split(Environment.NewLine.ToCharArray()).ToList();
            stringInputDataXYZ = stringInputDataXYZ.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            foreach (var dataXYZ in stringInputDataXYZ)
            {
                string[] temp = new string[3];
                temp = dataXYZ.Split('\t');
                stringInputDataX.Add(temp[0]);
                stringInputDataY.Add(temp[1]);
                stringInputDataZ.Add(temp[2]);
            }
            double parsedNumber = 0;
            doubleInputDataX = stringInputDataX.Where(number => double.TryParse(number, out parsedNumber)).Select(number => parsedNumber).ToList();
            doubleInputDataY = stringInputDataY.Where(number => double.TryParse(number, out parsedNumber)).Select(number => parsedNumber).ToList();
            doubleInputDataZ = stringInputDataZ.Where(number => double.TryParse(number, out parsedNumber)).Select(number => parsedNumber).ToList();
            allInputData.AddRange(doubleInputDataX);
            allInputData.AddRange(doubleInputDataY);
            allInputData.AddRange(doubleInputDataZ);
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            myModel = null;
            dataTextBox.Text = string.Empty;
            finalPixelData.Text = string.Empty;
            allInputData = new List<double>();
        }

        private void btn_calculateCorrelation_Click(object sender, EventArgs e)
        {
            try
            {
                tab3_Movement1.Text = txt_Movement1.Text;
                tab3_Movement2.Text = txt_Movement2.Text;

                var correlationDataManager = new CorrelationCalculation(this);
                correlationDataManager.ProcessData(txt_Movement1.Text, txt_Movement2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błędy się zdarzają ;)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tab Correlation and Energy calculation
        public void SetPlotCorrX(PlotModel model) { plotCorrX.Model = model; }
        public void SetPlotCorrY(PlotModel model) { plotCorrY.Model = model; }
        public void SetPlotCorrZ(PlotModel model) { plotCorrZ.Model = model; }
        public void SetCorrelationResultX(string result) { txt_corrResultX.Text = result; }
        public void SetCorrelationResultY(string result) { txt_corrResultY.Text = result; }
        public void SetCorrelationResultZ(string result) { txt_corrResultZ.Text = result; }
        public void SetCorrelationResultAverage(string result) { txt_CorrResult.Text = result; }
        public void SetEnergyCoefficientX(string result) { tab2_EnergyCoefX.Text = result; }
        public void SetEnergyCoefficientY(string result) { tab2_EnergyCoefY.Text = result; }
        public void SetEnergyCoefficientZ(string result) { tab2_EnergyCoefZ.Text = result; }
        public void SetEnergyCoefficientAverage(string result) { tab2_EnergyCoefAverage.Text = result; }

        //Tab Distance coefficient
        public void SetTab3PictureX(Image image) { tab3_pictureX.Image = image; }
        public void SetTab3PictureY(Image image) { tab3_pictureY.Image = image; }
        public void SetTab3PictureZ(Image image) { tab3_pictureZ.Image = image; }
        public void SetTab3DistanceCoefficientX(string result) { tab3_coefX.Text = result; }
        public void SetTab3DistanceCoefficientY(string result) { tab3_coefY.Text = result; }
        public void SetTab3DistanceCoefficientZ(string result) { tab3_coefZ.Text = result; }
        public void SetTab3DistanceCoefficientAverage(string result) { tab3_coefAverage.Text = result; }

        //Tab Parsing
        public void SetTab4LabelFilePath(string path) { tab4_labelFilePath.Text = path; }
        public string GetTab4Ranges() { return tab4_txtMovesRanges.Text; }

        private void btn_clearCorrelationData_Click(object sender, EventArgs e)
        {
            txt_Movement1.Text = string.Empty;
            txt_Movement2.Text = string.Empty;
        }

        private void tab3_calculateCoef_Click(object sender, EventArgs e)
        {
            try
            {
                var distanceCoefficientDataManager = new DistanceCoefficientCalculation(this);
                distanceCoefficientDataManager.ProcessData(tab3_Movement1.Text, tab3_Movement2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception happens ;)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab3_cleanData_Click(object sender, EventArgs e)
        {
            tab3_Movement1.Text = string.Empty;
            tab3_Movement2.Text = string.Empty;
        }

        private void tab4_btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                parser = new ParsingManager(this);
                parser.OpenFileAndGetDataFromIt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception happens ;)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab4_btnParseData_Click(object sender, EventArgs e)
        {
            try
            {                
                parser.ParseData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception happens ;)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

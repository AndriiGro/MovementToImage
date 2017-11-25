using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MovementToImage
{
    public class ParsingManager
    {
        Form1 mainForm;
        string filePath;
        List<string> fileData;
        List<string> stringRanges;
        List<Point> ranges;

        List<string> columnsToParse = new List<string> {
            "Acc_X",
            "Acc_Y",
            "Acc_Z",
            "Gyr_X",
            "Gyr_Y",
            "Gyr_Z",
            "OriInc_q1",
            "OriInc_q2",
            "OriInc_q3"
        };
        string counterColumn = "Frame";
        List<string> dataColumns;
        string[,] parsedData;
        string[][] parsedCSV;
        string timeLabel;

        public ParsingManager(Form1 form)
        {
            mainForm = form;
        }

        internal void OpenFileAndGetDataFromIt()
        {
            fileData = OpenAndGetFileData();
            mainForm.SetTab4LabelFilePath(filePath);
        }

        private List<string> OpenAndGetFileData()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = false
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
            }

            List<string> result = new List<string>();
            string value;
            using (TextReader fileReader = File.OpenText(filePath))
            {
                var csv = new CsvReader(fileReader);
                csv.Configuration.HasHeaderRecord = false;
                while (csv.Read())
                {
                    for (int i = 0; csv.TryGetField<string>(i, out value); i++)
                    {
                        result.Add(value);
                    }
                }
            }

            result.RemoveRange(0, 4);
            return result;
        }

        internal void ParseData()
        {
            timeLabel = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
            ParseRanges();
            ParseColumns();
            Parse();
            SaveParsedFiles();
        }

        private void SaveParsedFiles()
        {
            string filePathWithoutTxtType = filePath.Substring(0, filePath.Length - 4);
            string fileName = filePathWithoutTxtType + "_Parsed_at_" + timeLabel + ".csv";
            using (StreamWriter outfile = new StreamWriter(fileName))
            {
                for (int x = 0; x < parsedData.GetLength(1); x++)
                {
                    string content = "";
                    for (int y = 0; y < parsedData.GetLength(0); y++)
                    {
                        content += (parsedData[y, x]?.ToString() ?? "") 
                            + (y == (parsedData.GetLength(0) - 1) ? string.Empty : ",");
                    }

                    outfile.WriteLine(content);
                }
            }

            MessageBox.Show($"Dane zastały sparsowane do:{Environment.NewLine} {filePath}", "Udało się!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Parse()
        {
            parsedCSV = new string[fileData.Count][];
            for (int i = 0; i < fileData.Count; i++)
            {
                parsedCSV[i] = fileData[i].Split('\t');
            }

            int counterColumnNumber = GetColumnPosition(counterColumn);
            int maxRange = ranges.Max(r => r.Y);
            parsedData = new string[columnsToParse.Count, (maxRange + ranges.Count * 5)];
            int currentRow = 0;
            for (int i = 0; i < ranges.Count; i++)
            {
                parsedData[0, currentRow] = $"Zakres ruchu N{i + 1}: {stringRanges[i]}";
                currentRow++;

                for (int j = 0; j < columnsToParse.Count; j++)
                {
                    parsedData[j, currentRow] = columnsToParse[j];
                }

                currentRow++;

                Point currentRange = ranges[i];
                int rangeStartRowInData = -1;
                for (int y = 0; y < parsedCSV.GetLength(0); y++)
                {
                    if (parsedCSV[y][counterColumnNumber] != currentRange.X.ToString())
                        continue;

                    rangeStartRowInData = y;
                    break;
                }

                for (int t = 0; t < currentRange.Y - currentRange.X; t++)
                {
                    for (int p = 0; p < columnsToParse.Count; p++)
                    {
                        parsedData[p, currentRow] =
                            parsedCSV[rangeStartRowInData + t][GetColumnPosition(columnsToParse[p])];
                    }

                    currentRow++;
                }

            }
        }

        private void ParseColumns()
        {
            dataColumns = fileData[0].Split('\t').ToList();
        }

        private int GetColumnPosition(string columnName)
        {
            return dataColumns.FindIndex(c => c == columnName);
        }

        private void ParseRanges()
        {
            ranges = new List<Point>();
            stringRanges = mainForm.GetTab4Ranges().Split(Environment.NewLine.ToCharArray()).ToList();
            stringRanges = stringRanges.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            foreach (string stringRange in stringRanges)
            {
                string[] range = stringRange.Split('-');
                int start = int.Parse(range[0]);
                int end = int.Parse(range[1]);

                ranges.Add(new Point(start, end));
            }
        }
    }
}

using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovementToImage
{
    public class ParsingManager
    {
        Form1 mainForm;
        string filePath;
        List<string> fileData;
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
        string counterColumn = "PacketCounter";
        List<string> dataColumns;
        string[][] parsedData;

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
            ParseRanges();
            ParseColumns();
            Parse();
        }

        private void Parse()
        {
            for (int i = 0; i < ranges.Count; i++)
            {


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
            List<string> stringRanges = mainForm.GetTab4Ranges().Split(Environment.NewLine.ToCharArray()).ToList();
            stringRanges = stringRanges.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            foreach (string stringRange in stringRanges)
            {
                string[] range = stringRange.Split('-');
                int start = int.Parse(range[0]) - 1;
                int end = int.Parse(range[1]) - 1;

                ranges.Add(new Point(start, end));
            }
        }
    }
}

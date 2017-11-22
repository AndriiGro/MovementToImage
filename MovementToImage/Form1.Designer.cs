namespace MovementToImage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.dataTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.xSizeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ySizeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_Plot = new MetroFramework.Controls.MetroButton();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.finalPixelData = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.delimiterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btn_Clean = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.tab3_pictureZ = new System.Windows.Forms.PictureBox();
            this.tab3_pictureX = new System.Windows.Forms.PictureBox();
            this.tab3_pictureY = new System.Windows.Forms.PictureBox();
            this.tab3_coefAverage = new MetroFramework.Controls.MetroTextBox();
            this.tab3_cleanData = new MetroFramework.Controls.MetroButton();
            this.tab3_calculateCoef = new MetroFramework.Controls.MetroButton();
            this.tab3_coefZ = new MetroFramework.Controls.MetroTextBox();
            this.tab3_coefY = new MetroFramework.Controls.MetroTextBox();
            this.tab3_coefX = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.tab3_Movement2 = new MetroFramework.Controls.MetroTextBox();
            this.tab3_Movement1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txt_corrResultZ = new MetroFramework.Controls.MetroTextBox();
            this.txt_corrResultY = new MetroFramework.Controls.MetroTextBox();
            this.txt_corrResultX = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.plotCorrZ = new OxyPlot.WindowsForms.PlotView();
            this.plotCorrY = new OxyPlot.WindowsForms.PlotView();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btn_clearCorrelationData = new MetroFramework.Controls.MetroButton();
            this.txt_CorrResult = new MetroFramework.Controls.MetroTextBox();
            this.btn_calculateCorrelation = new MetroFramework.Controls.MetroButton();
            this.plotCorrX = new OxyPlot.WindowsForms.PlotView();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_Movement2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Movement1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pictureZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pictureX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pictureY)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plotView
            // 
            this.plotView.BackColor = System.Drawing.Color.Gainsboro;
            this.plotView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plotView.Location = new System.Drawing.Point(545, 3);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(384, 238);
            this.plotView.TabIndex = 0;
            this.plotView.Text = "plotView";
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(135, 3);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataTextBox.Size = new System.Drawing.Size(404, 238);
            this.dataTextBox.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Dane wejściowe";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 258);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Wyjściowy rozmiar";
            // 
            // xSizeTextBox
            // 
            this.xSizeTextBox.Location = new System.Drawing.Point(135, 254);
            this.xSizeTextBox.Name = "xSizeTextBox";
            this.xSizeTextBox.Size = new System.Drawing.Size(42, 23);
            this.xSizeTextBox.TabIndex = 4;
            this.xSizeTextBox.Text = "150";
            // 
            // ySizeTextBox
            // 
            this.ySizeTextBox.Location = new System.Drawing.Point(206, 254);
            this.ySizeTextBox.Name = "ySizeTextBox";
            this.ySizeTextBox.Size = new System.Drawing.Size(75, 23);
            this.ySizeTextBox.TabIndex = 5;
            this.ySizeTextBox.Text = "60";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(183, 258);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(17, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "X";
            // 
            // btn_Plot
            // 
            this.btn_Plot.Location = new System.Drawing.Point(135, 297);
            this.btn_Plot.Name = "btn_Plot";
            this.btn_Plot.Size = new System.Drawing.Size(186, 23);
            this.btn_Plot.TabIndex = 7;
            this.btn_Plot.Text = "Narysuj wykres i przekonwertuj";
            this.btn_Plot.Click += new System.EventHandler(this.btn_Plot_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resultPictureBox.Location = new System.Drawing.Point(545, 254);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(384, 240);
            this.resultPictureBox.TabIndex = 9;
            this.resultPictureBox.TabStop = false;
            // 
            // finalPixelData
            // 
            this.finalPixelData.Location = new System.Drawing.Point(135, 388);
            this.finalPixelData.MaxLength = 627670;
            this.finalPixelData.Multiline = true;
            this.finalPixelData.Name = "finalPixelData";
            this.finalPixelData.ReadOnly = true;
            this.finalPixelData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finalPixelData.Size = new System.Drawing.Size(404, 106);
            this.finalPixelData.TabIndex = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 393);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Przekonwertowany";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(5, 345);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Separator";
            // 
            // delimiterTextBox
            // 
            this.delimiterTextBox.Location = new System.Drawing.Point(135, 345);
            this.delimiterTextBox.MaxLength = 1;
            this.delimiterTextBox.Name = "delimiterTextBox";
            this.delimiterTextBox.Size = new System.Drawing.Size(52, 23);
            this.delimiterTextBox.TabIndex = 13;
            this.delimiterTextBox.Text = ",";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Location = new System.Drawing.Point(327, 297);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(102, 23);
            this.btn_Clean.TabIndex = 14;
            this.btn_Clean.Text = "Wyczyść dane";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 113);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(944, 539);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 15;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this.btn_Clean);
            this.metroTabPage1.Controls.Add(this.ySizeTextBox);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.resultPictureBox);
            this.metroTabPage1.Controls.Add(this.finalPixelData);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.delimiterTextBox);
            this.metroTabPage1.Controls.Add(this.plotView);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.dataTextBox);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.xSizeTextBox);
            this.metroTabPage1.Controls.Add(this.btn_Plot);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(936, 500);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Sieć neuronowa";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(5, 416);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(47, 19);
            this.metroLabel15.TabIndex = 15;
            this.metroLabel15.Text = "wykres";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.tab3_pictureZ);
            this.metroTabPage3.Controls.Add(this.tab3_pictureX);
            this.metroTabPage3.Controls.Add(this.tab3_pictureY);
            this.metroTabPage3.Controls.Add(this.tab3_coefAverage);
            this.metroTabPage3.Controls.Add(this.tab3_cleanData);
            this.metroTabPage3.Controls.Add(this.tab3_calculateCoef);
            this.metroTabPage3.Controls.Add(this.tab3_coefZ);
            this.metroTabPage3.Controls.Add(this.tab3_coefY);
            this.metroTabPage3.Controls.Add(this.tab3_coefX);
            this.metroTabPage3.Controls.Add(this.metroLabel25);
            this.metroTabPage3.Controls.Add(this.metroLabel24);
            this.metroTabPage3.Controls.Add(this.metroLabel23);
            this.metroTabPage3.Controls.Add(this.metroLabel22);
            this.metroTabPage3.Controls.Add(this.metroLabel21);
            this.metroTabPage3.Controls.Add(this.metroLabel20);
            this.metroTabPage3.Controls.Add(this.metroLabel19);
            this.metroTabPage3.Controls.Add(this.metroLabel17);
            this.metroTabPage3.Controls.Add(this.metroLabel16);
            this.metroTabPage3.Controls.Add(this.tab3_Movement2);
            this.metroTabPage3.Controls.Add(this.tab3_Movement1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(936, 500);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Odległośći bezwzględne";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // tab3_pictureZ
            // 
            this.tab3_pictureZ.Location = new System.Drawing.Point(512, 314);
            this.tab3_pictureZ.Name = "tab3_pictureZ";
            this.tab3_pictureZ.Size = new System.Drawing.Size(236, 141);
            this.tab3_pictureZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab3_pictureZ.TabIndex = 26;
            this.tab3_pictureZ.TabStop = false;
            // 
            // tab3_pictureX
            // 
            this.tab3_pictureX.Location = new System.Drawing.Point(512, 21);
            this.tab3_pictureX.Name = "tab3_pictureX";
            this.tab3_pictureX.Size = new System.Drawing.Size(236, 140);
            this.tab3_pictureX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab3_pictureX.TabIndex = 25;
            this.tab3_pictureX.TabStop = false;
            // 
            // tab3_pictureY
            // 
            this.tab3_pictureY.Location = new System.Drawing.Point(512, 167);
            this.tab3_pictureY.Name = "tab3_pictureY";
            this.tab3_pictureY.Size = new System.Drawing.Size(236, 141);
            this.tab3_pictureY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab3_pictureY.TabIndex = 24;
            this.tab3_pictureY.TabStop = false;
            // 
            // tab3_coefAverage
            // 
            this.tab3_coefAverage.Location = new System.Drawing.Point(695, 471);
            this.tab3_coefAverage.Name = "tab3_coefAverage";
            this.tab3_coefAverage.ReadOnly = true;
            this.tab3_coefAverage.Size = new System.Drawing.Size(89, 23);
            this.tab3_coefAverage.TabIndex = 23;
            // 
            // tab3_cleanData
            // 
            this.tab3_cleanData.Location = new System.Drawing.Point(822, 470);
            this.tab3_cleanData.Name = "tab3_cleanData";
            this.tab3_cleanData.Size = new System.Drawing.Size(91, 23);
            this.tab3_cleanData.TabIndex = 22;
            this.tab3_cleanData.Text = "Wyczyść dane";
            this.tab3_cleanData.Click += new System.EventHandler(this.tab3_cleanData_Click);
            // 
            // tab3_calculateCoef
            // 
            this.tab3_calculateCoef.Location = new System.Drawing.Point(509, 471);
            this.tab3_calculateCoef.Name = "tab3_calculateCoef";
            this.tab3_calculateCoef.Size = new System.Drawing.Size(103, 23);
            this.tab3_calculateCoef.Style = MetroFramework.MetroColorStyle.Red;
            this.tab3_calculateCoef.TabIndex = 21;
            this.tab3_calculateCoef.Text = "Oblicz koeficjent";
            this.tab3_calculateCoef.Click += new System.EventHandler(this.tab3_calculateCoef_Click);
            // 
            // tab3_coefZ
            // 
            this.tab3_coefZ.Location = new System.Drawing.Point(770, 336);
            this.tab3_coefZ.Name = "tab3_coefZ";
            this.tab3_coefZ.ReadOnly = true;
            this.tab3_coefZ.Size = new System.Drawing.Size(143, 23);
            this.tab3_coefZ.TabIndex = 20;
            // 
            // tab3_coefY
            // 
            this.tab3_coefY.Location = new System.Drawing.Point(770, 190);
            this.tab3_coefY.Name = "tab3_coefY";
            this.tab3_coefY.ReadOnly = true;
            this.tab3_coefY.Size = new System.Drawing.Size(143, 23);
            this.tab3_coefY.TabIndex = 19;
            // 
            // tab3_coefX
            // 
            this.tab3_coefX.Location = new System.Drawing.Point(770, 43);
            this.tab3_coefX.Name = "tab3_coefX";
            this.tab3_coefX.ReadOnly = true;
            this.tab3_coefX.Size = new System.Drawing.Size(143, 23);
            this.tab3_coefX.TabIndex = 18;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(618, 474);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(82, 19);
            this.metroLabel25.TabIndex = 17;
            this.metroLabel25.Text = "Koeficjent = ";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(476, 20);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(17, 19);
            this.metroLabel24.TabIndex = 16;
            this.metroLabel24.Text = "X";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(486, 314);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(17, 19);
            this.metroLabel23.TabIndex = 15;
            this.metroLabel23.Text = "Z";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(486, 168);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(17, 19);
            this.metroLabel22.TabIndex = 14;
            this.metroLabel22.Text = "Y";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(770, 314);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(102, 19);
            this.metroLabel21.TabIndex = 13;
            this.metroLabel21.Text = "Koeficjent dla Z:";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(770, 168);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(102, 19);
            this.metroLabel20.TabIndex = 12;
            this.metroLabel20.Text = "Koeficjent dla Y:";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(770, 21);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(102, 19);
            this.metroLabel19.TabIndex = 11;
            this.metroLabel19.Text = "Koeficjent dla X:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 266);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(89, 19);
            this.metroLabel17.TabIndex = 6;
            this.metroLabel17.Text = "Dane Ruchu 2";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 21);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(87, 19);
            this.metroLabel16.TabIndex = 5;
            this.metroLabel16.Text = "Dane Ruchu 1";
            // 
            // tab3_Movement2
            // 
            this.tab3_Movement2.Location = new System.Drawing.Point(130, 266);
            this.tab3_Movement2.Multiline = true;
            this.tab3_Movement2.Name = "tab3_Movement2";
            this.tab3_Movement2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tab3_Movement2.Size = new System.Drawing.Size(329, 228);
            this.tab3_Movement2.TabIndex = 3;
            // 
            // tab3_Movement1
            // 
            this.tab3_Movement1.Location = new System.Drawing.Point(130, 21);
            this.tab3_Movement1.Multiline = true;
            this.tab3_Movement1.Name = "tab3_Movement1";
            this.tab3_Movement1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tab3_Movement1.Size = new System.Drawing.Size(329, 239);
            this.tab3_Movement1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTextBox4);
            this.metroTabPage2.Controls.Add(this.metroTextBox3);
            this.metroTabPage2.Controls.Add(this.metroTextBox2);
            this.metroTabPage2.Controls.Add(this.metroLabel28);
            this.metroTabPage2.Controls.Add(this.metroLabel27);
            this.metroTabPage2.Controls.Add(this.metroLabel26);
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.metroLabel18);
            this.metroTabPage2.Controls.Add(this.txt_corrResultZ);
            this.metroTabPage2.Controls.Add(this.txt_corrResultY);
            this.metroTabPage2.Controls.Add(this.txt_corrResultX);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.plotCorrZ);
            this.metroTabPage2.Controls.Add(this.plotCorrY);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.btn_clearCorrelationData);
            this.metroTabPage2.Controls.Add(this.txt_CorrResult);
            this.metroTabPage2.Controls.Add(this.btn_calculateCorrelation);
            this.metroTabPage2.Controls.Add(this.plotCorrX);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.txt_Movement2);
            this.metroTabPage2.Controls.Add(this.txt_Movement1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(936, 500);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Korelacja i Róźnica energii";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // txt_corrResultZ
            // 
            this.txt_corrResultZ.Location = new System.Drawing.Point(705, 360);
            this.txt_corrResultZ.Name = "txt_corrResultZ";
            this.txt_corrResultZ.ReadOnly = true;
            this.txt_corrResultZ.Size = new System.Drawing.Size(125, 23);
            this.txt_corrResultZ.TabIndex = 21;
            // 
            // txt_corrResultY
            // 
            this.txt_corrResultY.Location = new System.Drawing.Point(705, 191);
            this.txt_corrResultY.Name = "txt_corrResultY";
            this.txt_corrResultY.ReadOnly = true;
            this.txt_corrResultY.Size = new System.Drawing.Size(125, 23);
            this.txt_corrResultY.TabIndex = 20;
            // 
            // txt_corrResultX
            // 
            this.txt_corrResultX.Location = new System.Drawing.Point(705, 44);
            this.txt_corrResultX.Name = "txt_corrResultX";
            this.txt_corrResultX.ReadOnly = true;
            this.txt_corrResultX.Size = new System.Drawing.Size(125, 23);
            this.txt_corrResultX.TabIndex = 19;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(705, 337);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 19);
            this.metroLabel14.TabIndex = 18;
            this.metroLabel14.Text = "Korelacja Z: ";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(705, 168);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(81, 19);
            this.metroLabel13.TabIndex = 17;
            this.metroLabel13.Text = "Korelacja Y: ";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(705, 21);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(81, 19);
            this.metroLabel12.TabIndex = 16;
            this.metroLabel12.Text = "Korelacja X: ";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(433, 337);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(17, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Z";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(433, 168);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(17, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Y";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(433, 21);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(17, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "X";
            // 
            // plotCorrZ
            // 
            this.plotCorrZ.Location = new System.Drawing.Point(456, 337);
            this.plotCorrZ.Name = "plotCorrZ";
            this.plotCorrZ.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotCorrZ.Size = new System.Drawing.Size(239, 132);
            this.plotCorrZ.TabIndex = 12;
            this.plotCorrZ.Text = "plotView2";
            this.plotCorrZ.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotCorrZ.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotCorrZ.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotCorrY
            // 
            this.plotCorrY.Location = new System.Drawing.Point(456, 168);
            this.plotCorrY.Name = "plotCorrY";
            this.plotCorrY.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotCorrY.Size = new System.Drawing.Size(239, 163);
            this.plotCorrY.TabIndex = 11;
            this.plotCorrY.Text = "plotView1";
            this.plotCorrY.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotCorrY.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotCorrY.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(523, 481);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(79, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Korelacja = ";
            // 
            // btn_clearCorrelationData
            // 
            this.btn_clearCorrelationData.Location = new System.Drawing.Point(-4, 481);
            this.btn_clearCorrelationData.Name = "btn_clearCorrelationData";
            this.btn_clearCorrelationData.Size = new System.Drawing.Size(96, 23);
            this.btn_clearCorrelationData.TabIndex = 10;
            this.btn_clearCorrelationData.Text = "Wyczyść dane";
            this.btn_clearCorrelationData.Visible = false;
            this.btn_clearCorrelationData.Click += new System.EventHandler(this.btn_clearCorrelationData_Click);
            // 
            // txt_CorrResult
            // 
            this.txt_CorrResult.Location = new System.Drawing.Point(608, 477);
            this.txt_CorrResult.Name = "txt_CorrResult";
            this.txt_CorrResult.ReadOnly = true;
            this.txt_CorrResult.Size = new System.Drawing.Size(87, 23);
            this.txt_CorrResult.TabIndex = 9;
            // 
            // btn_calculateCorrelation
            // 
            this.btn_calculateCorrelation.Location = new System.Drawing.Point(456, 475);
            this.btn_calculateCorrelation.Name = "btn_calculateCorrelation";
            this.btn_calculateCorrelation.Size = new System.Drawing.Size(61, 25);
            this.btn_calculateCorrelation.TabIndex = 7;
            this.btn_calculateCorrelation.Text = "Oblicz";
            this.btn_calculateCorrelation.Click += new System.EventHandler(this.btn_calculateCorrelation_Click);
            // 
            // plotCorrX
            // 
            this.plotCorrX.Location = new System.Drawing.Point(456, 21);
            this.plotCorrX.Name = "plotCorrX";
            this.plotCorrX.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotCorrX.Size = new System.Drawing.Size(239, 141);
            this.plotCorrX.TabIndex = 6;
            this.plotCorrX.Text = "plotViewCorrelation";
            this.plotCorrX.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotCorrX.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotCorrX.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 266);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(89, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Dane Ruchu 2";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 21);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Dane Ruchu 1";
            // 
            // txt_Movement2
            // 
            this.txt_Movement2.Location = new System.Drawing.Point(96, 265);
            this.txt_Movement2.Multiline = true;
            this.txt_Movement2.Name = "txt_Movement2";
            this.txt_Movement2.Size = new System.Drawing.Size(329, 235);
            this.txt_Movement2.TabIndex = 3;
            // 
            // txt_Movement1
            // 
            this.txt_Movement1.Location = new System.Drawing.Point(96, 21);
            this.txt_Movement1.Multiline = true;
            this.txt_Movement1.Name = "txt_Movement1";
            this.txt_Movement1.Size = new System.Drawing.Size(329, 239);
            this.txt_Movement1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(701, 481);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(127, 19);
            this.metroLabel18.TabIndex = 22;
            this.metroLabel18.Text = "Koeficjent róźnicy = ";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(834, 477);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.Size = new System.Drawing.Size(97, 23);
            this.metroTextBox1.TabIndex = 23;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(705, 80);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(129, 19);
            this.metroLabel26.TabIndex = 24;
            this.metroLabel26.Text = "Koeficjent róźnicy X: ";
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(703, 226);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(129, 19);
            this.metroLabel27.TabIndex = 25;
            this.metroLabel27.Text = "Koeficjent róźnicy Y: ";
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Location = new System.Drawing.Point(705, 395);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(129, 19);
            this.metroLabel28.TabIndex = 26;
            this.metroLabel28.Text = "Koeficjent róźnicy Z: ";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(705, 103);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(125, 23);
            this.metroTextBox2.TabIndex = 27;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(705, 249);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(125, 23);
            this.metroTextBox3.TabIndex = 28;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(705, 418);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(125, 23);
            this.metroTextBox4.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Analiza dopasowania";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pictureZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pictureX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pictureY)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView;
        private MetroFramework.Controls.MetroTextBox dataTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox xSizeTextBox;
        private MetroFramework.Controls.MetroTextBox ySizeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_Plot;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private MetroFramework.Controls.MetroTextBox finalPixelData;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox delimiterTextBox;
        private MetroFramework.Controls.MetroButton btn_Clean;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_Movement2;
        private MetroFramework.Controls.MetroTextBox txt_Movement1;
        private OxyPlot.WindowsForms.PlotView plotCorrX;
        private MetroFramework.Controls.MetroTextBox txt_CorrResult;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btn_calculateCorrelation;
        private MetroFramework.Controls.MetroButton btn_clearCorrelationData;
        private OxyPlot.WindowsForms.PlotView plotCorrZ;
        private OxyPlot.WindowsForms.PlotView plotCorrY;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_corrResultZ;
        private MetroFramework.Controls.MetroTextBox txt_corrResultY;
        private MetroFramework.Controls.MetroTextBox txt_corrResultX;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton tab3_cleanData;
        private MetroFramework.Controls.MetroButton tab3_calculateCoef;
        private MetroFramework.Controls.MetroTextBox tab3_coefZ;
        private MetroFramework.Controls.MetroTextBox tab3_coefY;
        private MetroFramework.Controls.MetroTextBox tab3_coefX;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox tab3_Movement2;
        private MetroFramework.Controls.MetroTextBox tab3_Movement1;
        private MetroFramework.Controls.MetroTextBox tab3_coefAverage;
        private System.Windows.Forms.PictureBox tab3_pictureZ;
        private System.Windows.Forms.PictureBox tab3_pictureX;
        private System.Windows.Forms.PictureBox tab3_pictureY;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel18;
    }
}


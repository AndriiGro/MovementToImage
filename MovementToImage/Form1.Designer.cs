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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txt_CorrResult = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btn_calculateCorrelation = new MetroFramework.Controls.MetroButton();
            this.plotCorrX = new OxyPlot.WindowsForms.PlotView();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_Movement2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Movement1 = new MetroFramework.Controls.MetroTextBox();
            this.btn_clearCorrelationData = new MetroFramework.Controls.MetroButton();
            this.plotCorrY = new OxyPlot.WindowsForms.PlotView();
            this.plotCorrZ = new OxyPlot.WindowsForms.PlotView();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_corrResultX = new MetroFramework.Controls.MetroTextBox();
            this.txt_corrResultY = new MetroFramework.Controls.MetroTextBox();
            this.txt_corrResultZ = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
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
            this.metroTabControl1.SelectedIndex = 2;
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
            // metroTabPage2
            // 
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
            this.metroTabPage2.Text = "Korelacja";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // txt_CorrResult
            // 
            this.txt_CorrResult.Location = new System.Drawing.Point(701, 475);
            this.txt_CorrResult.Name = "txt_CorrResult";
            this.txt_CorrResult.ReadOnly = true;
            this.txt_CorrResult.Size = new System.Drawing.Size(108, 23);
            this.txt_CorrResult.TabIndex = 9;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(627, 475);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(79, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Korelacja = ";
            // 
            // btn_calculateCorrelation
            // 
            this.btn_calculateCorrelation.Location = new System.Drawing.Point(490, 475);
            this.btn_calculateCorrelation.Name = "btn_calculateCorrelation";
            this.btn_calculateCorrelation.Size = new System.Drawing.Size(120, 19);
            this.btn_calculateCorrelation.TabIndex = 7;
            this.btn_calculateCorrelation.Text = "Oblicz korelację";
            this.btn_calculateCorrelation.Click += new System.EventHandler(this.btn_calculateCorrelation_Click);
            // 
            // plotCorrX
            // 
            this.plotCorrX.Location = new System.Drawing.Point(490, 21);
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
            this.txt_Movement2.Location = new System.Drawing.Point(130, 266);
            this.txt_Movement2.Multiline = true;
            this.txt_Movement2.Name = "txt_Movement2";
            this.txt_Movement2.Size = new System.Drawing.Size(329, 228);
            this.txt_Movement2.TabIndex = 3;
            // 
            // txt_Movement1
            // 
            this.txt_Movement1.Location = new System.Drawing.Point(130, 21);
            this.txt_Movement1.Multiline = true;
            this.txt_Movement1.Name = "txt_Movement1";
            this.txt_Movement1.Size = new System.Drawing.Size(329, 239);
            this.txt_Movement1.TabIndex = 2;
            // 
            // btn_clearCorrelationData
            // 
            this.btn_clearCorrelationData.Location = new System.Drawing.Point(837, 475);
            this.btn_clearCorrelationData.Name = "btn_clearCorrelationData";
            this.btn_clearCorrelationData.Size = new System.Drawing.Size(96, 23);
            this.btn_clearCorrelationData.TabIndex = 10;
            this.btn_clearCorrelationData.Text = "Wyczyść dane";
            this.btn_clearCorrelationData.Click += new System.EventHandler(this.btn_clearCorrelationData_Click);
            // 
            // plotCorrY
            // 
            this.plotCorrY.Location = new System.Drawing.Point(490, 168);
            this.plotCorrY.Name = "plotCorrY";
            this.plotCorrY.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotCorrY.Size = new System.Drawing.Size(239, 163);
            this.plotCorrY.TabIndex = 11;
            this.plotCorrY.Text = "plotView1";
            this.plotCorrY.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotCorrY.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotCorrY.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotCorrZ
            // 
            this.plotCorrZ.Location = new System.Drawing.Point(490, 337);
            this.plotCorrZ.Name = "plotCorrZ";
            this.plotCorrZ.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotCorrZ.Size = new System.Drawing.Size(239, 132);
            this.plotCorrZ.TabIndex = 12;
            this.plotCorrZ.Text = "plotView2";
            this.plotCorrZ.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotCorrZ.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotCorrZ.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(467, 21);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(17, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "X";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(467, 168);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(17, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Y";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(467, 337);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(17, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Z";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(739, 21);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(81, 19);
            this.metroLabel12.TabIndex = 16;
            this.metroLabel12.Text = "Korelacja X: ";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(739, 168);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(81, 19);
            this.metroLabel13.TabIndex = 17;
            this.metroLabel13.Text = "Korelacja Y: ";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(739, 337);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 19);
            this.metroLabel14.TabIndex = 18;
            this.metroLabel14.Text = "Korelacja Z: ";
            // 
            // txt_corrResultX
            // 
            this.txt_corrResultX.Location = new System.Drawing.Point(739, 44);
            this.txt_corrResultX.Name = "txt_corrResultX";
            this.txt_corrResultX.ReadOnly = true;
            this.txt_corrResultX.Size = new System.Drawing.Size(125, 23);
            this.txt_corrResultX.TabIndex = 19;
            // 
            // txt_corrResultY
            // 
            this.txt_corrResultY.Location = new System.Drawing.Point(739, 191);
            this.txt_corrResultY.Name = "txt_corrResultY";
            this.txt_corrResultY.ReadOnly = true;
            this.txt_corrResultY.Size = new System.Drawing.Size(125, 23);
            this.txt_corrResultY.TabIndex = 20;
            // 
            // txt_corrResultZ
            // 
            this.txt_corrResultZ.Location = new System.Drawing.Point(739, 360);
            this.txt_corrResultZ.Name = "txt_corrResultZ";
            this.txt_corrResultZ.ReadOnly = true;
            this.txt_corrResultZ.Size = new System.Drawing.Size(125, 23);
            this.txt_corrResultZ.TabIndex = 21;
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
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(936, 500);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Odległośći bezwzględne";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
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
    }
}


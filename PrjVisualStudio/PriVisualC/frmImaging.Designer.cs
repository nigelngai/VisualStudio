namespace ImagingApp
{
    partial class frmImaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImaging));
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.BtnImportImage = new System.Windows.Forms.Button();
            this.Lbl_SelectedImage = new System.Windows.Forms.Label();
            this.LblImagePath = new System.Windows.Forms.Label();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.picSelectedColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMoveY = new System.Windows.Forms.Label();
            this.lblMoveX = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.lblLineEndY = new System.Windows.Forms.Label();
            this.lblLineEndX = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLineStartY = new System.Windows.Forms.Label();
            this.lblLineStartX = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTransparent = new System.Windows.Forms.Button();
            this.buttonDrawRectangle = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonScreen = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonOpenFileLocation = new System.Windows.Forms.Button();
            this.buttonLinearGradient = new System.Windows.Forms.Button();
            this.buttonGradientMode = new System.Windows.Forms.Button();
            this.lstBoxPrinters = new System.Windows.Forms.ListBox();
            this.buttonDrawText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPictureBox.Location = new System.Drawing.Point(25, 85);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(1018, 615);
            this.myPictureBox.TabIndex = 3;
            this.myPictureBox.TabStop = false;
            this.myPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myPictureBox_MouseClick);
            //this.myPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPictureBox_MouseDown);
            this.myPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myPictureBox_MouseMove);
            //this.myPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myPictureBox_MouseUp);
            // 
            // BtnImportImage
            // 
            this.BtnImportImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnImportImage.Location = new System.Drawing.Point(25, 12);
            this.BtnImportImage.Name = "BtnImportImage";
            this.BtnImportImage.Size = new System.Drawing.Size(105, 35);
            this.BtnImportImage.TabIndex = 1;
            this.BtnImportImage.Text = "Import Image";
            this.BtnImportImage.UseVisualStyleBackColor = true;
            this.BtnImportImage.Click += new System.EventHandler(this.BtnImportImage_Click);
            // 
            // Lbl_SelectedImage
            // 
            this.Lbl_SelectedImage.AutoSize = true;
            this.Lbl_SelectedImage.ForeColor = System.Drawing.Color.Black;
            this.Lbl_SelectedImage.Location = new System.Drawing.Point(32, 59);
            this.Lbl_SelectedImage.Name = "Lbl_SelectedImage";
            this.Lbl_SelectedImage.Size = new System.Drawing.Size(34, 12);
            this.Lbl_SelectedImage.TabIndex = 6;
            this.Lbl_SelectedImage.Text = "Path : ";
            // 
            // LblImagePath
            // 
            this.LblImagePath.AutoSize = true;
            this.LblImagePath.ForeColor = System.Drawing.Color.Blue;
            this.LblImagePath.Location = new System.Drawing.Point(80, 59);
            this.LblImagePath.Name = "LblImagePath";
            this.LblImagePath.Size = new System.Drawing.Size(49, 12);
            this.LblImagePath.TabIndex = 7;
            this.LblImagePath.Text = "-----------";
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "myOpenFileDialog";
            // 
            // picSelectedColor
            // 
            this.picSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelectedColor.Location = new System.Drawing.Point(313, 48);
            this.picSelectedColor.Name = "picSelectedColor";
            this.picSelectedColor.Size = new System.Drawing.Size(37, 34);
            this.picSelectedColor.TabIndex = 9;
            this.picSelectedColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(358, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "R : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(358, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "G : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(358, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "B : ";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.ForeColor = System.Drawing.Color.Blue;
            this.lblR.Location = new System.Drawing.Point(386, 12);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(17, 12);
            this.lblR.TabIndex = 13;
            this.lblR.Text = "---";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.ForeColor = System.Drawing.Color.Blue;
            this.lblG.Location = new System.Drawing.Point(386, 35);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(17, 12);
            this.lblG.TabIndex = 14;
            this.lblG.Text = "---";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.ForeColor = System.Drawing.Color.Blue;
            this.lblB.Location = new System.Drawing.Point(386, 57);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 12);
            this.lblB.TabIndex = 15;
            this.lblB.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(511, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "X : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(511, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y : ";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.Blue;
            this.lblY.Location = new System.Drawing.Point(533, 57);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 12);
            this.lblY.TabIndex = 19;
            this.lblY.Text = "---";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.Blue;
            this.lblX.Location = new System.Drawing.Point(533, 35);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 12);
            this.lblX.TabIndex = 18;
            this.lblX.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(423, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(423, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "Height:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.ForeColor = System.Drawing.Color.Blue;
            this.lblHeight.Location = new System.Drawing.Point(475, 57);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(17, 12);
            this.lblHeight.TabIndex = 23;
            this.lblHeight.Text = "---";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.ForeColor = System.Drawing.Color.Blue;
            this.lblWidth.Location = new System.Drawing.Point(475, 35);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(17, 12);
            this.lblWidth.TabIndex = 22;
            this.lblWidth.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(423, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pixel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(511, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Position:";
            // 
            // lblMoveY
            // 
            this.lblMoveY.AutoSize = true;
            this.lblMoveY.ForeColor = System.Drawing.Color.Blue;
            this.lblMoveY.Location = new System.Drawing.Point(603, 57);
            this.lblMoveY.Name = "lblMoveY";
            this.lblMoveY.Size = new System.Drawing.Size(17, 12);
            this.lblMoveY.TabIndex = 29;
            this.lblMoveY.Text = "---";
            // 
            // lblMoveX
            // 
            this.lblMoveX.AutoSize = true;
            this.lblMoveX.ForeColor = System.Drawing.Color.Blue;
            this.lblMoveX.Location = new System.Drawing.Point(603, 35);
            this.lblMoveX.Name = "lblMoveX";
            this.lblMoveX.Size = new System.Drawing.Size(17, 12);
            this.lblMoveX.TabIndex = 28;
            this.lblMoveX.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(581, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "Y : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(581, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "X : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(581, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "Current";
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDrawLine.Location = new System.Drawing.Point(1168, 380);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(105, 35);
            this.buttonDrawLine.TabIndex = 31;
            this.buttonDrawLine.Text = "Draw Line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // lblLineEndY
            // 
            this.lblLineEndY.AutoSize = true;
            this.lblLineEndY.ForeColor = System.Drawing.Color.Blue;
            this.lblLineEndY.Location = new System.Drawing.Point(862, 56);
            this.lblLineEndY.Name = "lblLineEndY";
            this.lblLineEndY.Size = new System.Drawing.Size(17, 12);
            this.lblLineEndY.TabIndex = 39;
            this.lblLineEndY.Text = "---";
            // 
            // lblLineEndX
            // 
            this.lblLineEndX.AutoSize = true;
            this.lblLineEndX.ForeColor = System.Drawing.Color.Blue;
            this.lblLineEndX.Location = new System.Drawing.Point(862, 34);
            this.lblLineEndX.Name = "lblLineEndX";
            this.lblLineEndX.Size = new System.Drawing.Size(17, 12);
            this.lblLineEndX.TabIndex = 38;
            this.lblLineEndX.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(840, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "Y : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(840, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "X : ";
            // 
            // lblLineStartY
            // 
            this.lblLineStartY.AutoSize = true;
            this.lblLineStartY.ForeColor = System.Drawing.Color.Blue;
            this.lblLineStartY.Location = new System.Drawing.Point(792, 56);
            this.lblLineStartY.Name = "lblLineStartY";
            this.lblLineStartY.Size = new System.Drawing.Size(17, 12);
            this.lblLineStartY.TabIndex = 35;
            this.lblLineStartY.Text = "---";
            // 
            // lblLineStartX
            // 
            this.lblLineStartX.AutoSize = true;
            this.lblLineStartX.ForeColor = System.Drawing.Color.Blue;
            this.lblLineStartX.Location = new System.Drawing.Point(792, 34);
            this.lblLineStartX.Name = "lblLineStartX";
            this.lblLineStartX.Size = new System.Drawing.Size(17, 12);
            this.lblLineStartX.TabIndex = 34;
            this.lblLineStartX.Text = "---";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(770, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 12);
            this.label19.TabIndex = 33;
            this.label19.Text = "Y : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(770, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 12);
            this.label20.TabIndex = 32;
            this.label20.Text = "X : ";
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Location = new System.Drawing.Point(921, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 35);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTransparent
            // 
            this.buttonTransparent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTransparent.Location = new System.Drawing.Point(1053, 11);
            this.buttonTransparent.Name = "buttonTransparent";
            this.buttonTransparent.Size = new System.Drawing.Size(105, 35);
            this.buttonTransparent.TabIndex = 41;
            this.buttonTransparent.Text = "Transparent";
            this.buttonTransparent.UseVisualStyleBackColor = true;
            this.buttonTransparent.Click += new System.EventHandler(this.buttonTransparent_Click);
            // 
            // buttonDrawRectangle
            // 
            this.buttonDrawRectangle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDrawRectangle.Location = new System.Drawing.Point(1053, 59);
            this.buttonDrawRectangle.Name = "buttonDrawRectangle";
            this.buttonDrawRectangle.Size = new System.Drawing.Size(105, 35);
            this.buttonDrawRectangle.TabIndex = 42;
            this.buttonDrawRectangle.Text = "Rectangle";
            this.buttonDrawRectangle.UseVisualStyleBackColor = true;
            this.buttonDrawRectangle.Click += new System.EventHandler(this.buttonDrawRectangle_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRotate.Location = new System.Drawing.Point(1053, 112);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(105, 35);
            this.btnRotate.TabIndex = 43;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNew.Location = new System.Drawing.Point(136, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(105, 35);
            this.buttonNew.TabIndex = 44;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonScreen
            // 
            this.buttonScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonScreen.Location = new System.Drawing.Point(1053, 167);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(105, 35);
            this.buttonScreen.TabIndex = 45;
            this.buttonScreen.Text = "Screen";
            this.buttonScreen.UseVisualStyleBackColor = true;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCircle.Location = new System.Drawing.Point(1053, 275);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(105, 35);
            this.buttonCircle.TabIndex = 46;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPrint.Location = new System.Drawing.Point(1053, 224);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(105, 35);
            this.buttonPrint.TabIndex = 47;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // buttonOpenFileLocation
            // 
            this.buttonOpenFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpenFileLocation.Location = new System.Drawing.Point(1053, 328);
            this.buttonOpenFileLocation.Name = "buttonOpenFileLocation";
            this.buttonOpenFileLocation.Size = new System.Drawing.Size(105, 35);
            this.buttonOpenFileLocation.TabIndex = 48;
            this.buttonOpenFileLocation.Text = "FileOpen";
            this.buttonOpenFileLocation.UseVisualStyleBackColor = true;
            this.buttonOpenFileLocation.Click += new System.EventHandler(this.buttonOpenFileLocation_Click);
            // 
            // buttonLinearGradient
            // 
            this.buttonLinearGradient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLinearGradient.Location = new System.Drawing.Point(1053, 380);
            this.buttonLinearGradient.Name = "buttonLinearGradient";
            this.buttonLinearGradient.Size = new System.Drawing.Size(105, 35);
            this.buttonLinearGradient.TabIndex = 49;
            this.buttonLinearGradient.Text = "LinearGradient";
            this.buttonLinearGradient.UseVisualStyleBackColor = true;
            this.buttonLinearGradient.Click += new System.EventHandler(this.buttonLinearGradient_Click);
            // 
            // buttonGradientMode
            // 
            this.buttonGradientMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGradientMode.Location = new System.Drawing.Point(1053, 435);
            this.buttonGradientMode.Name = "buttonGradientMode";
            this.buttonGradientMode.Size = new System.Drawing.Size(105, 35);
            this.buttonGradientMode.TabIndex = 50;
            this.buttonGradientMode.Text = "GradientMode";
            this.buttonGradientMode.UseVisualStyleBackColor = true;
            this.buttonGradientMode.Click += new System.EventHandler(this.buttonGradientMode_Click);
            // 
            // lstBoxPrinters
            // 
            this.lstBoxPrinters.FormattingEnabled = true;
            this.lstBoxPrinters.ItemHeight = 12;
            this.lstBoxPrinters.Location = new System.Drawing.Point(1168, 12);
            this.lstBoxPrinters.Name = "lstBoxPrinters";
            this.lstBoxPrinters.Size = new System.Drawing.Size(120, 316);
            this.lstBoxPrinters.TabIndex = 51;
            // 
            // buttonDrawText
            // 
            this.buttonDrawText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDrawText.Location = new System.Drawing.Point(1168, 435);
            this.buttonDrawText.Name = "buttonDrawText";
            this.buttonDrawText.Size = new System.Drawing.Size(105, 35);
            this.buttonDrawText.TabIndex = 52;
            this.buttonDrawText.Text = "Draw String";
            this.buttonDrawText.UseVisualStyleBackColor = true;
            this.buttonDrawText.Click += new System.EventHandler(this.buttonDrawText_Click);
            // 
            // frmImaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.buttonDrawText);
            this.Controls.Add(this.lstBoxPrinters);
            this.Controls.Add(this.buttonGradientMode);
            this.Controls.Add(this.buttonLinearGradient);
            this.Controls.Add(this.buttonOpenFileLocation);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonScreen);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.buttonDrawRectangle);
            this.Controls.Add(this.buttonTransparent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.lblLineEndY);
            this.Controls.Add(this.lblLineEndX);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblLineStartY);
            this.Controls.Add(this.lblLineStartX);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonDrawLine);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMoveY);
            this.Controls.Add(this.lblMoveX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSelectedColor);
            this.Controls.Add(this.LblImagePath);
            this.Controls.Add(this.Lbl_SelectedImage);
            this.Controls.Add(this.BtnImportImage);
            this.Controls.Add(this.myPictureBox);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmImaging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoadImage";
            this.Load += new System.EventHandler(this.frmImaging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.Button BtnImportImage;
        private System.Windows.Forms.Label Lbl_SelectedImage;
        private System.Windows.Forms.Label LblImagePath;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.PictureBox picSelectedColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMoveY;
        private System.Windows.Forms.Label lblMoveX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Label lblLineEndY;
        private System.Windows.Forms.Label lblLineEndX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLineStartY;
        private System.Windows.Forms.Label lblLineStartX;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTransparent;
        private System.Windows.Forms.Button buttonDrawRectangle;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonScreen;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonOpenFileLocation;
        private System.Windows.Forms.Button buttonLinearGradient;
        private System.Windows.Forms.Button buttonGradientMode;
        private System.Windows.Forms.ListBox lstBoxPrinters;
        private System.Windows.Forms.Button buttonDrawText;
    }
}
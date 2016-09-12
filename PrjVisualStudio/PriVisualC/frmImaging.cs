using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

using System.Runtime.InteropServices;



using System.Drawing.Drawing2D;

namespace ImagingApp
{
    public partial class frmImaging : Form
    {
        public frmImaging()
        {
            InitializeComponent();
        }



        #region LISTEN CLIPBOARD
     
        //  http://www.fluxbytes.com/csharp/monitor-clipboard-in-c/

         
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        private const int WM_DRAWCLIPBOARD = 0x0308;        // WM_DRAWCLIPBOARD message
        private IntPtr _clipboardViewerNext;                // Our variable that will hold the value to identify

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    string text = (string)iData.GetData(DataFormats.Text);      // Clipboard text
                    // do something with it
                }
                else if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap);   // Clipboard image
                    myPictureBox.Image = image;
                    // do something with it
                }
            }
        }


        #endregion


        private void frmImaging_Load(object sender, EventArgs e)
        {
            //_clipboardViewerNext = SetClipboardViewer(this.Handle); 

            GetPrinterList();

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Gray,
                                                                       Color.Black,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }



         private void GetPrinterList()
         {
           foreach (string sPrinters in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    lstBoxPrinters.Items.Add(sPrinters);
                }
         }




        private void frmImaging_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Removes our from the chain of clipboard viewers when the form closes.
            ChangeClipboardChain(this.Handle, _clipboardViewerNext);        
        }





        private void BtnImportImage_Click(object sender, EventArgs e)
        {

            try
            {
                //Clean
                LblImagePath.Text = "";
                myPictureBox.Image = null;

                //Choose File selection
                DialogResult IsResultOK = myOpenFileDialog.ShowDialog();


                if (IsResultOK == System.Windows.Forms.DialogResult.OK)
                {
                    //Get File name
                    LblImagePath.Text = myOpenFileDialog.FileName;

                    //Load Image into a picture box
                    if (myOpenFileDialog.ValidateNames == true)
                    {
                        myPictureBox.Image = Image.FromFile(LblImagePath.Text);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblMoveX.Text = e.X.ToString();
            lblMoveY.Text = e.Y.ToString();
                        
        }


        //private Boolean DrawingMode = false;

        //private void myPictureBox_MouseDown(object sender, MouseEventArgs e)
        //{
        //    DrawingMode = true;
        //}

        //private void myPictureBox_MouseUp(object sender, MouseEventArgs e)
        //{
        //    DrawingMode = false;
        //}









        private void myPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            
            //Get bmp Dimension
            Bitmap bmp = (Bitmap)myPictureBox.Image;

            lblWidth.Text = bmp.Width.ToString();
            lblHeight.Text = bmp.Height.ToString();
            
            //Get Selected Color
            Color SelectedColor = bmp.GetPixel(e.X, e.Y);
            picSelectedColor.BackColor = SelectedColor;
            
            //Get MouseClick Position
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();

            //Get RGB Color
            lblR.Text = SelectedColor.R.ToString();
            lblG.Text = SelectedColor.G.ToString();
            lblB.Text = SelectedColor.B.ToString();


            if ( DrawLineMode == true )
            {
                if ( lblLineStartX.Text == "---")
                { 
                    lblLineStartX.Text = e.X.ToString();
                    lblLineStartY.Text = e.Y.ToString();
                }
                else
                {
                    lblLineEndX.Text = e.X.ToString();
                    lblLineEndY.Text = e.Y.ToString();


                    Pen blackPen = new Pen(Color.Red, 3);


                    int intSX = int.Parse(lblLineStartX.Text);
                    int intSY = int.Parse(lblLineStartY.Text);

                    int intEX = int.Parse(lblLineEndX.Text);
                    int intEY = int.Parse(lblLineEndY.Text);



                    using (var graphics = Graphics.FromImage(bmp))
                    {
                        graphics.DrawLine(blackPen, intSX, intSY, intEX, intEY);
                    }
                    myPictureBox.Image = bmp;

                    lblLineStartX.Text = "---";
                    lblLineEndX.Text = "---";
                    lblLineStartY.Text = "---";
                    lblLineEndY.Text = "---";

                }

            }

        }





        private void DrawLineToMyPic()
        {

            Pen blackPen = new Pen(Color.Red, 3);

            int x1 = 100;
            int y1 = 150;
            int x2 = 500;
            int y2 = 100;

            // Draw line to screen.
            Bitmap bmp = (Bitmap)myPictureBox.Image;
            using (var graphics = Graphics.FromImage(bmp))

            {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }
            myPictureBox.Image = bmp;

        }


        private Boolean DrawLineMode = false;
              

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            DrawLineMode = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp = (Bitmap)myPictureBox.Image;
            bmp.Save("F:\\PictureTest1.png", System.Drawing.Imaging.ImageFormat.Png);

        }


        private void buttonTransparent_Click(object sender, EventArgs e)
        {

            Bitmap bmp = (Bitmap)myPictureBox.Image;

            int X = int.Parse(lblX.Text) ;
            int Y = int.Parse(lblY.Text) ;
            Color SelectedColor = bmp.GetPixel(X,Y );

            bmp.MakeTransparent(Color.FromArgb(SelectedColor.R, SelectedColor.G, SelectedColor.B));    // Change a color to be transparent
            
            myPictureBox.Image = bmp;
  
        }

        private void buttonDrawRectangle_Click(object sender, EventArgs e)
        {
            // Create pen.
            Pen myPen = new Pen(Color.RoyalBlue, 3);

            // Create location and size of rectangle.

            int x = 110;
            int y = 20;
            int width = 500;
            int height = 200;

            Bitmap bmp = (Bitmap)myPictureBox.Image;
            using (var graphics = Graphics.FromImage(bmp))
            // Draw rectangle to screen.
            {
                graphics.DrawRectangle(myPen, x, y, width, height);
            }

            myPictureBox.Image = bmp;
        }


        private void btnRotate_Click(object sender, EventArgs e)
        {
            //Get Original bmp
            Bitmap bmp = (Bitmap)myPictureBox.Image;
            //Prepare new bmp
            Bitmap newbmp = new Bitmap(bmp.Height,bmp.Width);

            Color PixelColor = Color.White;
            //For New position
            int newy =0 ; 
         
            for (int x = 1; x < bmp.Width ; ++x)
            {
                for (int y = 1; y < bmp.Height; ++y )
                {
                    //Pick the Pixel color from original bitmap
                    PixelColor = bmp.GetPixel(x, y);
                    //Calculate New Y position
                    newy = bmp.Height - y;
                    // Exchange the X and Y positon
                    newbmp.SetPixel(newy, x, PixelColor);
                 }
            }
            
            myPictureBox.Image = newbmp;
                 
        }




        private void buttonNew_Click(object sender, EventArgs e)

        {

            Bitmap bmp = new Bitmap(400, 400);

            for (int x = 0; x < bmp.Height; ++x)
                for (int y = 0; y < bmp.Width; ++y)
                    bmp.SetPixel(x, y, Color.White);

            //for (int x = 0; x < bmp.Height / 2; ++x)
            //    for (int y = 0; y < bmp.Width / 2; ++y)
            //        bmp.SetPixel(x, y, Color.Blue);

            //for (int x = 0; x < bmp.Height / 4; ++x)
            //    for (int y = 0; y < bmp.Width / 4; ++y)
            //        bmp.SetPixel(x, y, Color.Orange);

            myPictureBox.Image = bmp;

        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {

            Bitmap memoryImage;
            Graphics myGraphics = this.CreateGraphics();

            //Size s = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Size s = new Size(750, 600);
            
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            //------------

            //Capture This 
            //Size s = this.Size;
            //memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            
            //------------

            //The x-coordinate of the point at the upper-left corner of the source rectangle.
            //The y-coordinate of the point at the upper-left corner of the source rectangle.

            //The x-coordinate of the point at the upper-left corner of the destination 
            //The y-coordinate of the point at the upper-left corner of the destination rectangle.

            //The size of the area to be transferred.

            memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);

            memoryGraphics.DrawImage(memoryImage, 0, 0);

            myPictureBox.Image = memoryImage;


            //Clipboard.SetImage(memoryImage);
   


        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {

            //Get Image
            Bitmap bmp = (Bitmap)myPictureBox.Image;

            //Define Pen and Color
            Pen myPen = new Pen(Color.Orange, 5);
            SolidBrush myBrush = new SolidBrush(Color.LightGray);

            //Center Position
            int x = 100;
            int y = 100;

            //Draw
            using (var graphics = Graphics.FromImage(bmp))

            {
                graphics.FillEllipse(myBrush, x, y, 150, 150);
                graphics.DrawEllipse(myPen, x, y, 150, 150);
            }
            myPictureBox.Image = bmp;

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument1.OriginAtMargins = true;
            printDocument1.DocumentName = "IMAGE PRINTING";
   
            //printDialog1.Document = printDocument1;
          
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //    printDocument1.Print();


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(myPictureBox.Image, 0, 0);
        }


   
        private void buttonOpenFileLocation_Click(object sender, EventArgs e)
        {
            string Filepath = "F:\\ExcelSample\\";

            if (Directory.Exists(Filepath))
            {

                //Directory.CreateDirectory(Filepath);
                Process.Start("explorer.exe", Filepath);

            }

        }

        private void buttonLinearGradient_Click(object sender, EventArgs e)
        {
            //Get Image
            Bitmap bmp = (Bitmap)myPictureBox.Image;

            //LinearGradientBrush linGrBrush = new LinearGradientBrush(
            //   new Point(0, 10),
            //   new Point(200, 10),
            //   Color.FromArgb(255, 255, 0, 0),   // Opaque red
            //   Color.FromArgb(255, 0, 0, 255));  // Opaque blue

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
               new Point(0, 10),
               new Point(300, 10),
               Color.DarkGreen,  
               Color.LightBlue);  
    
            Pen pen = new Pen(linGrBrush);

            //Draw
            using (var graphics = Graphics.FromImage(bmp))

            {
                graphics.DrawLine(pen, 0, 10, 300, 10);
                graphics.DrawLine(pen, 0, 10, 300, 40);

                graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);

                graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);

            }
            myPictureBox.Image = bmp;
        }

        private void buttonGradientMode_Click(object sender, EventArgs e)
        {

            ////Get Image
            //Bitmap bmp = (Bitmap)myPictureBox.Image;
            
            //LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20),
            //                                                            new Point(450, 20),
            //                                                            Color.DarkGreen,
            //                                                            Color.LightBlue);
            ////Draw
            //using (var graphics = Graphics.FromImage(bmp))
            //{
            //    graphics.FillRectangle(lgb, 20, 20, 430, 180);
            //}
            //myPictureBox.Image = bmp;

            Bitmap bmp = (Bitmap)myPictureBox.Image;

            Rectangle rect = new Rectangle(10, 10, 470, 300);
            LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.DarkOrange, Color.White,LinearGradientMode.Vertical);
            
            using (var graphics = Graphics.FromImage(bmp))
            {
            graphics.FillRectangle(lgb, 10, 10, 450, 280);
            }
            myPictureBox.Image = bmp;

        }

        private void buttonDrawText_Click(object sender, EventArgs e)
        {
            // Create string to draw.
            String drawString = "My Drawing Text";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(150.0F, 150.0F);

            // Draw string to screen.
            //e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
            Bitmap bmp = (Bitmap)myPictureBox.Image;

            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
            }
            myPictureBox.Image = bmp;

        }





        //private void myPictureBox_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Bitmap bmp = (Bitmap)myPictureBox.Image;
        //    int X = int.Parse(lblX.Text);
        //    int Y = int.Parse(lblY.Text);
        //    //Color SelectedColor =
        //    bmp.SetPixel(X, Y, Color.DarkOrange);
        //    myPictureBox.Image = bmp;
        //}



        //private void buttonBW_Click(object sender, EventArgs e)
        //{



        //    Bitmap img = (Bitmap)myPictureBox.Image;

        //    BitmapSource img = (BitmapSource)(CurrentPhoto.Source);
        //    UndoStack.Push(img);
        //    CurrentPhoto.Source = new FormatConvertedBitmap(img, PixelFormats.Gray8, BitmapPalettes.Gray256, 1.0);

        //}





    }
}

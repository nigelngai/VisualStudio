using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagingApp
{
    public partial class frmRGB : Form
    {
        public frmRGB()
        {
            InitializeComponent();
        }

        private void frmRGB_Load(object sender, EventArgs e)
        {


            //Color myRgbColor = new Color();
            //myRgbColor = Color.FromArgb(0, 255, 0);


            //int count = 4;
            //for (int i = 1; i < = count; i++)
            //{
            //    MessageBox.Show("Current value of i is - " + i);
            //}


            int R = 255;
            int G = 255;
            int B = 0;

            Bitmap bmp = new Bitmap(600, 600);
            
            int y = 1;
            int x = 1;

            //int Line = 1;

            //for ( Line = 1; Line < 256; y++, G--)
            //{

            //for (y = 1; y < 256; y++  )
            //{ 
            //    //R = 255;
            //    for (x = 1; x < 256; x++, R--)
            //    {
            //        //R += 1 ;
            //        bmp.SetPixel(x, y, Color.FromArgb(R, G, B));
            //    }

            //}

                //R = 0;
                //for (int x = 256; x < 511; ++x, ++B)
                //{ bmp.SetPixel(x, y, Color.FromArgb(R, G, B)); }

           //}



            //for (y = 256; y < 511; ++y, ++B)
            //{

            //    R = 255;
            //    for (int x = 1; x < 256; ++x, --R)
            //    { bmp.SetPixel(x, y, Color.FromArgb(R, G, B)); }

            //    R = 0;
            //    for (int x = 256; x < 511; ++x, ++R)
            //    { bmp.SetPixel(x, y, Color.FromArgb(R, G, B)); }

            //}



            //for (y = 256; y < 511; ++y, ++B)
            //{


            //    for (int x = 1; x < 256; ++x, --R)
            //    {

            //        //for (int y = 1; y < bmp.Height; ++y)

            //        bmp.SetPixel(x, y, Color.FromArgb(R, G, B));
            //        // }

            //    }

            //    for (int x = 256; x < 511; ++x, ++R)
            //    {
            //        bmp.SetPixel(x, y, Color.FromArgb(R, G, B));
            //    }

            //}





            //for (int x = 0; x < bmp.Height / 2; ++x)
            //    for (int y = 0; y < bmp.Width / 2; ++y)
            //        bmp.SetPixel(x, y, Color.Blue);

            //for (int x = 0; x < bmp.Height / 4; ++x)
            //    for (int y = 0; y < bmp.Width / 4; ++y)
            //        bmp.SetPixel(x, y, Color.Orange);

            myPictureBox.Image = bmp;





             //Color.FromArgb(255, 0, 0, 255))






    //return myRgbColor;


        }
    }
}

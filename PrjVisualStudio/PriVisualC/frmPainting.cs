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
    public partial class frmPainting : Form
    {
        public frmPainting()
        {
            InitializeComponent();
        }


        private Graphics m_objGraphics;

        Pen p = new Pen(Color.Black);

        private void frmPainting_Load(object sender, EventArgs e)
        {
            m_objGraphics = this.CreateGraphics();
        }

        private void frmPainting_MouseMove(object sender, MouseEventArgs e)
        {

            Rectangle rectEllipse = new Rectangle();
            if (e.Button != MouseButtons.Left) return;

            rectEllipse.X = e.X - 1;
            rectEllipse.Y = e.Y - 1;

            rectEllipse.Width = 5;
            rectEllipse.Height = 5;

            m_objGraphics.DrawEllipse(p, rectEllipse);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //p.Color = Color.Purple;
            p.Color = pictureBox1.BackColor;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            p.Color = pictureBox2.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            p.Color = pictureBox3.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            p.Color = pictureBox6.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            p.Color = pictureBox5.BackColor;
        }




    }
}

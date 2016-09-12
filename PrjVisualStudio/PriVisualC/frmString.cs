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
    public partial class frmString : Form
    {
        public frmString()
        {
            InitializeComponent();
        }

        private void btnConvertDecToHex_Click(object sender, EventArgs e)
        {
            string input = txtDec.Text;
            string hexOutput = string.Empty;
            char[] values = input.ToCharArray();
            foreach (char letter in values)
            {
            // Get the integral value of the character.
            int value = Convert.ToInt32(letter);
            // Convert the decimal value to a hexadecimal value in string form.
            hexOutput = hexOutput + "" + String.Format("{0:X}", value);

            //Console.WriteLine(“Hexadecimal value of {0} is {1}”, letter, hexOutput);
            }
            txtHex.Text = hexOutput;
        }

        private void frmString_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertHexToDec_Click(object sender, EventArgs e)
        {
            string hexValues = "48 65 6C 6C 6F 20 57 6F 72 6C 64 21";
            string[] hexValuesSplit = hexValues.Split(' ');
            string Output = string.Empty;
            foreach (String hex in hexValuesSplit)
            {
                // Convert the number expressed in base-16 to an integer.
                int value = Convert.ToInt32(hex, 16);
                // Get the character corresponding to the integral value.
                string stringValue = Char.ConvertFromUtf32(value);

                Output += stringValue;
                txtDec.Text = Output;
                //char charValue = (char)value;
                //Console.WriteLine("hexadecimal value = {0}, int value = {1}, char value = {2} or {3}",
                //                    hex, value, stringValue, charValue);
            }
        }

        private void frmString_Load_1(object sender, EventArgs e)
        {

        }








  


    }
}

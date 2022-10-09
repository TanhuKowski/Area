using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form_Rectangular : Form
    {
        public Form_Rectangular()
        {
            InitializeComponent();
        }
        #region Useless Lines
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Rectangular_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {

                if (float.Parse(textBox2.Text) > 0 && float.Parse(textBox1.Text) > 0)
                {
                    float Perimeter = 2 * (float.Parse(textBox2.Text) + float.Parse(textBox1.Text));
                    label2.Text = Perimeter.ToString();
                }
                else
                {
                    MessageBox.Show("Enter the number greater than 0 !");
                }
            }
            catch
            {
                MessageBox.Show("Enter the number in true format !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(textBox2.Text) > 0 && float.Parse(textBox1.Text) > 0)
                {
                    float Area = float.Parse(textBox2.Text) * float.Parse(textBox1.Text);
                    label3.Text = Area.ToString();
                }
                else
                {
                    MessageBox.Show("Enter the number greater than 0 !");
                }
            }
            catch
            {
                MessageBox.Show("Enter the number in true format !");
            }
        }
    }
}

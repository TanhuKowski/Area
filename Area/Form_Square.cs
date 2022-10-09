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
    public partial class Form_Square : Form
    {
        public Form_Square()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(textBox2.Text) > 0)
                {
                    float Perimeter = 4 * float.Parse(textBox2.Text);
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
                if (float.Parse(textBox2.Text) > 0)
                {
                    float Area = float.Parse(textBox2.Text) * float.Parse(textBox2.Text);
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
        #region Useless Lines
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Square_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

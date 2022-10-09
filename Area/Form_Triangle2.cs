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
    public partial class Form_Triangle2 : Form
    {
        public Form_Triangle2()
        {
            InitializeComponent();
        }
        #region Useless Lines
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Triangle2_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(textBox2.Text) > 0 && float.Parse(textBox1.Text) > 0 && float.Parse(textBox3.Text) > 0)
                {

                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double c = double.Parse(textBox3.Text);

                    if (a + b > c && a + c > b && b + c > a)
                    {
                        double Perimeter = double.Parse(textBox3.Text) + double.Parse(textBox2.Text) + double.Parse(textBox1.Text);
                        label2.Text = Perimeter.ToString();
                    }

                    else
                    {
                        MessageBox.Show("The sides of triangle don't fit in theory !");
                    }
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
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                if (float.Parse(textBox2.Text) > 0 && float.Parse(textBox1.Text) > 0 && float.Parse(textBox3.Text) > 0)
                {

                    if (a + b > c && a + c > b && b + c > a)
                    {
                        double P = (double.Parse(textBox3.Text) + double.Parse(textBox2.Text) + double.Parse(textBox1.Text)) / 2;
                        double Area = Math.Sqrt(P * (P - double.Parse(textBox1.Text)) * (P - double.Parse(textBox2.Text)) * (P - double.Parse(textBox3.Text)));
                        label3.Text = Area.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The sides of triangle don't fit in theory !");
                    }
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

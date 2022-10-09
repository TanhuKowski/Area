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
    public partial class Form_Triangle : Form
    {
        public Form_Triangle()
        {
            InitializeComponent();
        }

        private void Form_Triangle_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                if (a + b > c && a + c > b && b + c > a) {
                    double Perimeter = double.Parse(textBox3.Text) + double.Parse(textBox2.Text) + double.Parse(textBox1.Text);
                    label2.Text = Perimeter.ToString();
                }
            }

            catch
            {
                MessageBox.Show("Enter the number in true format !");
            }
            
           

        private void button2_Click(object sender, EventArgs e)
        {
            try
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double c = double.Parse(textBox3.Text);


                    if (a + b > c && a + c > b && b + c > a) {
                        double P = (double.Parse(textBox3.Text) + double.Parse(textBox2.Text) + double.Parse(textBox1.Text)) / 2;
                        double Area = Math.Sqrt(P * (P - double.Parse(textBox1.Text)) * (P - double.Parse(textBox2.Text)) * (P - double.Parse(textBox3.Text)));
                        label2.Text = Area.ToString();
                    }
            }
            catch
            {
                MessageBox.Show("Enter the number in true format !");
            }
        }

    }
}

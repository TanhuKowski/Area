namespace Area
{
    public partial class Form_Area : Form
    {
        public Form_Area()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Circle")
            {
                Form_Circle frm = new Form_Circle();
                frm.ShowDialog();
            }

            if (comboBox1.Text == "Rectangular")
            {
                Form_Rectangular frm = new Form_Rectangular();
                frm.ShowDialog();
            }

            if (comboBox1.Text == "Triangle")
            {
                Form_Triangle2 frm = new Form_Triangle2();
                frm.ShowDialog();
            }

            if (comboBox1.Text == "Square")
            {
                Form_Square frm = new Form_Square();
                frm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
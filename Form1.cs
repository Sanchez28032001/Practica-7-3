namespace Practica_7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal = double.Parse(C1.Text);
            cal = double.Parse(C2.Text);
            cal = double.Parse(C3.Text);
            cal = double.Parse(C4.Text);


            if (cal > 6) MessageBox.Show(" REPROBADO "); else MessageBox.Show(" APROBADO ");
        }
    }
}
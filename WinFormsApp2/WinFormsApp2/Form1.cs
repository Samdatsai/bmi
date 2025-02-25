namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (double.Parse(textBox2.Text) / double.Parse(textBox1.Text) / double.Parse(textBox1.Text)).ToString();
       }
    }
}
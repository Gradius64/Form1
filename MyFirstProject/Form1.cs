namespace MyFirstProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			String text = textBox1.Text;
			MessageBox.Show("You entered : " + text);
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}

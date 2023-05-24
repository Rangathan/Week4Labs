namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(textBox1.Text);
            double value2 = double.Parse(textBox2.Text);
            double result = 0;
            
            for (int i = 1; i <= value2; i++)
            {
                result += value1;
                listBox1.Items.Add($"After hour {i}, the distance is {result}");
            }


            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
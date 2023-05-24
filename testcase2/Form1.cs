namespace testcase2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double organisms;
            double time;
            double average;

            if( double.TryParse(textBox1.Text, out organisms) && double.TryParse(textBox2.Text, out average) && double.TryParse(textBox3.Text, out time)) 
            {
                listBox1.Items.Add("Days \t Organisms");
                double counter = 1;
                average = average / 100;
                double result = organisms;
                for (int i = 0; i < time; i++) 
                {
                    
                    listBox1.Items.Add($"{counter}\t{result}");
                    result = result * (1 + average);
                    counter++;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
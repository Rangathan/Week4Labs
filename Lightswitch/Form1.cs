namespace Lightswitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void turnLightOn()
        {
            label1.Text = "ON";
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

        }

        private void turnLightOff()
        {
            label1.Text = "OFF";
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible)
            {
                turnLightOff();
            }
            else
            {
                turnLightOn();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
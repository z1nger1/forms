namespace хуета
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balls = 0;
            if (radioButton2.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton3.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton5.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton7.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton10.Checked)
            {
                balls++;
            }
            else
            {
            }
            if (radioButton11.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton14.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton16.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton17.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton20.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton21.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton23.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton26.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton27.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            if (radioButton30.Checked)
            {
                balls = balls + 1;
            }
            else
            {
            }
            label16.Text = $"Ваш результат: {balls}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }       
    }
}
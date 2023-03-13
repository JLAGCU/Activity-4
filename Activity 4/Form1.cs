//JARED ABRAMS//CST-150//12MARCH2023//THIS IS MY OWN WORK

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Output.Text = "";
                double input = double.Parse(textBox_Input.Text);

                if (input >= 86400)
                {
                    textBox_Output.Text = (Math.Round(input / 86400, 3)).ToString() + " Day(s)";
                }

                else if (input >= 3600)
                {
                    textBox_Output.Text = (Math.Round(input / 3600, 3)).ToString() + " Hour(s)";
                }

                else if (input >= 60)
                {
                    textBox_Output.Text = (Math.Round(input / 60, 3)).ToString() + " Minute(s)";
                }
                else
                {
                    textBox_Output.Text = "Input is less than 60.";
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter only a number.");
            }




        }
    }
}
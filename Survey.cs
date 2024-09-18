using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentForm
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            bool age = (today.Year - birthday.Value.Year >= 35);
            Console.WriteLine(today.Year - birthday.Value.Year);
            bool residency = ResidencyDial.Value >= 14;
            Console.WriteLine(ResidencyDial.Value);
            bool terms = termDial.Value < 2;
            Console.WriteLine(termDial.Value);
            bool not_reblled = !rebel.Checked;
            Console.WriteLine(rebel.Checked);
            bool citizen = CitizenCheckBox.Checked;
            Console.WriteLine(CitizenCheckBox.Checked);
            if (age && residency && citizen && terms && not_reblled)
            {
                result.Text = "You are eligible to be President!";
            }
            else
            {
                result.Text = "Unfortunately, you are not eligible to be president.";
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

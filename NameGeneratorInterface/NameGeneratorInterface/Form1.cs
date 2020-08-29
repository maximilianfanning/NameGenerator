using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGeneratorInterface
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Execute_BTN_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            if (string.IsNullOrEmpty(minLengthInput.Text))
            {
                ResultLabel.Text = "Enter a value for your minimum characters!";
            }
            else if (string.IsNullOrEmpty(maxLengthInput.Text))
            {
                ResultLabel.Text = "Enter a value for your maximum characters!";
            }
            else
            {
                Generation g = new Generation(@"C:\Users\maxfa\source\repos\GeneratorFiles\SerializedLetterData.txt", @"C:\Users\maxfa\source\repos\GeneratorFiles\SerializedFirstLetterData.txt", minLengthInput.Text, maxLengthInput.Text);
                ResultLabel.Text = g.finalWord;
            }
        }
    }
}

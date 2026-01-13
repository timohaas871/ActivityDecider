//Timo Haase
//ActivityDecider
//created on January 7th 2026
//program to help friends decide what they want to do together

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityDecider
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }


        private void goToEnterNameButton_Click(object sender, EventArgs e)
        {
            NamesForm form2 = new NamesForm(); //creates a variable for NamesForm
            form2.Show(); //opens form2
            this.Hide(); //hides this form (first form can't be closed, otherwise program crashes)
        }
    }
}

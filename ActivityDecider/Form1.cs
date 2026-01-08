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
        NamesForm form2 = new NamesForm(); //creates a variable form NamesForm
        public OptionsForm()
        {
            InitializeComponent();
        }


        private void goToEnterNameButton_Click(object sender, EventArgs e)
        {
            form2.Show(); //opens form2
            this.Hide(); //hides this form
        }
    }
}

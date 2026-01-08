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
    public partial class NamesForm : Form
    {
        public NamesForm()
        {
            InitializeComponent();
        }

        private void NamesForm_Load(object sender, EventArgs e)
        {

        }

        private void enterNameButton_Click(object sender, EventArgs e)
        {
            
            //check for duplicates! with if it is good then do if not than error with same label as confirmLabel where it reads the names
            SharedData.friends.Add(nameTextBox.Text); //adds the name to the List
            nameTextBox.Text = ""; //removing the old text
        }

        private void checkNamesButton_Click(object sender, EventArgs e)
        {
            enterNameLabel.Text = "Are those names correct?"; //changing the text to confirm
            checkNamesButton.Visible = false; //turns the button invisible and other buttons visible
            goToVoteButton.Visible = true;
            
            for (int i = 0; i < SharedData.friends.Count; i++) //outputs all of the names
            {
                enterNameLabel.Text += SharedData.friends[i] + "\n";
            }

            //redo names button
        }
    }
}

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

            checkDuplicate(); //runs checkDuplicate() which checks if the name already is in the list

        }


        private async void checkDuplicate()
        {
            String name = nameTextBox.Text; //creates string name for the content of the textBox

            if (!SharedData.friends.Contains(name)) //if friends doesn't contain name
            {
                SharedData.friends.Add(nameTextBox.Text); //adds the name to the List
                nameTextBox.Text = ""; //removing the old text
            }

            else //if friends already contains the name
            {
                nameTextBox.Text = ""; //resets the text in the textBox
                enterNameLabel.Text = "You can't add a name twice!"; //and tells the friend they can't add their name twice
                await Task.Delay(4000); //waits 4 seconds before changing the text back
                enterNameLabel.Text = "Now please enter your name and hit the Got it button, if you are the last one also check if all of the names are correct";
            }
        }




        private void checkNamesButton_Click(object sender, EventArgs e)
        {
            checkNamesLabel.Visible = true;
            checkNamesLabel.Text = "Are the names correct?\n"; //changing the text to confirm names
            checkNamesButton.Visible = false; //turns buttons visible and invisible
            goToVoteButton.Visible = true;
            enterNameButton.Visible = false;
            redoNamesButton.Visible = true;
            
            for (int i = 0; i < SharedData.friends.Count; i++) //outputs all of the names
            {
                checkNamesLabel.Text += SharedData.friends[i] + "    "; //outputs the name and then spaces
            }
        }


        private void redoNamesButton_Click(object sender, EventArgs e)
        {
            SharedData.friends.Clear(); //removes all names from the list

            checkNamesLabel.Visible = false; // does the opposite of checkNamesButton, restoring everything to normal
            checkNamesButton.Visible = true; //turns buttons visible and invisible
            goToVoteButton.Visible = false;
            enterNameButton.Visible = true;
            redoNamesButton.Visible = false;
        }

        private void goToVoteButton_Click(object sender, EventArgs e)
        {
            VoteForm form3 = new VoteForm(); //creates a variable for VoteForm
            form3.Show(); //shows form3
            this.Close(); //closes this form
        }
    }
}

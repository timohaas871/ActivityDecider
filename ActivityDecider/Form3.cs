using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ActivityDecider
{
    public partial class VoteForm : Form
    {

        int vote; //variable to count the votes
        public VoteForm()
        {
            InitializeComponent();
        }

        private async void option1PictureBox_Click(object sender, EventArgs e) //when option1 is clicked
        {
            string name = nameTextBox.Text; //the text from nameTextBox is used as the value for name

            //if name is in the friends list but not in the list for friends that have already voted and name is not nothing
            if (((SharedData.friends.Contains(name))&&(!SharedData.friendsVoted.Contains(name)))&&(nameTextBox.Text != ""))
            {
                SharedData.poolVote++; //poolVote goes up by one
                vote++; //amount of votes in general goes up
                SharedData.friendsVoted.Add(name); //adds name to the list
                nameTextBox.Text = "";
                this.BackColor = Color.YellowGreen; //turns background color green
                voteLabel.Text = name + ", you successfully voted for going to the pool!"; //output for a successful vote
                option1PictureBox.Enabled = false; //disabling options so you can't immediately click again
                option2PictureBox.Enabled = false;
                option3PictureBox.Enabled = false;
                await Task.Delay(4000); //waiting 4 seconds before
                option1PictureBox.Enabled = true; //enabling options again so the next person can vote
                option2PictureBox.Enabled = true;
                option3PictureBox.Enabled = true;
                this.BackColor = Color.Black; //turning the background color black again
                voteLabel.Text = "It is time to vote! Enter the name and click on the image that you want to vote for. But don't cheat..."; //and resetting the label's text
                checkVoteCompleted(); //checks if everyone has voted
            }

            else if (nameTextBox.Text == "") //if no name is entered
                nameTextBox.Visible = true; //something is done that has no effect


            else
            {
                cheatConsequences(); //consequences for cheating
            }
        }


        private async void option2PictureBox_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text; //the text from nameTextBox is used as the value for name

            //if name is in the friends list but not in the list for friends that have already voted and name is not nothing
            if (((SharedData.friends.Contains(name))&&(!SharedData.friendsVoted.Contains(name)))&&(nameTextBox.Text != ""))
            {
                SharedData.cinemaVote++; //cinemaVote goes up by one
                vote++; //amount of votes in general goes up
                SharedData.friendsVoted.Add(name); //adds name to the list
                nameTextBox.Text = "";
                this.BackColor = Color.YellowGreen; //turns background color green
                voteLabel.Text = name + ", you successfully voted for watching a movie at the cinema!";
                option1PictureBox.Enabled = false; //disabling options so you can't immediately click again
                option2PictureBox.Enabled = false;
                option3PictureBox.Enabled = false;
                await Task.Delay(4000); //waiting 4 seconds before
                option1PictureBox.Enabled = true; //enabling options again so the next person can vote
                option2PictureBox.Enabled = true;
                option3PictureBox.Enabled = true;
                this.BackColor = Color.Black; //turning the background color black again
                voteLabel.Text = "It is time to vote! Enter the name and click on the image that you want to vote for. But don't cheat..."; //and resetting the label's text
                checkVoteCompleted(); //checks if everyone has voted
            }

            else if (nameTextBox.Text == "") //if no name is entered
                nameTextBox.Visible = true; //something is done that has no effect


            else
            {
                cheatConsequences(); //consequences for cheating
            }
        }
        

        private async void option3PictureBox_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text; //the text from nameTextBox is used as the value for name

            //if name is in the friends list but not in the list for friends that have already voted and name is not nothing
            if (((SharedData.friends.Contains(name))&&(!SharedData.friendsVoted.Contains(name)))&&(nameTextBox.Text != ""))
            {
                SharedData.gameNightVote++; //movieNightVote goes up by one
                vote++; //amount of votes in general goes up
                SharedData.friendsVoted.Add(name); //adds name to the list
                nameTextBox.Text = "";
                this.BackColor = Color.YellowGreen; //turns background color green
                voteLabel.Text = name + ", you successfully voted for doing a game night!"; //output for a successful vote
                option1PictureBox.Enabled = false; //disabling options so you can't immediately click again
                option2PictureBox.Enabled = false;
                option3PictureBox.Enabled = false;
                await Task.Delay(4000); //waiting 4 seconds before
                option1PictureBox.Enabled = true; //enabling options again so the next person can vote
                option2PictureBox.Enabled = true;
                option3PictureBox.Enabled = true;
                this.BackColor = Color.Black; //turning the background color black again
                voteLabel.Text = "It is time to vote! Enter the name and click on the image that you want to vote for. But don't cheat..."; //and resetting the label's text
                checkVoteCompleted(); //checks if everyone has voted
            }

            else if (nameTextBox.Text == "") //if no name is entered
                nameTextBox.Visible = true; //something is done that has no effect


            else
            {
                cheatConsequences(); //consequences for cheating
            }
        }






        public async void cheatConsequences() //method for consequences for cheating
        {
            string name = nameTextBox.Text; //the text from nameTextBox is used as the value for name

            if (!SharedData.friendsCheated.Contains(name)) //if the list doesn't contain the name
            {
                SharedData.friendsCheated.Add(name); //add name to the list
            }

            if (SharedData.friendsVoted.Contains(name)) //if the voted list contains the name
                voteLabel.Text = name + ", you tried to cheat! You already voted!"; //output cheating

            else  if (!SharedData.friendsVoted.Contains(name)) //if the voted list doesn't contain the name
                voteLabel.Text = name + ", you tried to cheat! This name wasn't entered before!"; //output cheating

            this.BackColor = Color.Red; //turning the form's background color red
            nameTextBox.Text = ""; //resetting the entered text
            await Task.Delay(3000); //waiting 3 seconds before
            voteLabel.Text = "It is time to vote! Enter the name and click on the image that you want to vote for. But don't cheat..."; //changing the text back to normal
            this.BackColor = Color.Black; //changing the background color back to black
        }


        private void checkVoteCompleted() //method to check if everyone has voted
        {
            if (vote == SharedData.friends.Count) //if the amount of votes are the same as the amount of friends
            {
                option1PictureBox.Visible = false; //turning the options invisible no new votes can be submitted
                option2PictureBox.Visible = false;
                option3PictureBox.Visible = false;
                nameTextBox.Visible = false; //textBox and Label for the aesthetics
                yourNameLabel.Visible = false;

                voteLabel.Text = "Everyone has voted! Now let's see what the results are.";
                revealVotesButton.Visible = true; //making the button visible to open new form
            }
        }

        private void revealVotesButton_Click(object sender, EventArgs e)
        {
            RevealForm form4 = new RevealForm(); //creates a variable for RevealForm
            form4.Show(); //opens form4
            this.Close(); //closes this form
        }

        private void VoteForm_Load(object sender, EventArgs e)
        {

        }
    }
}

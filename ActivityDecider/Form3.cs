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
        
        public VoteForm()
        {
            InitializeComponent();
        }

        private void option1PictureBox_Click(object sender, EventArgs e) //when option1 is clicked
        {
            string name = nameTextBox.Text; //the text from nameTextBox is used as the value for name

            //if name is in the friends list but not in the list for friends that have already voted
            if ((SharedData.friends.Contains(name)) && (!SharedData.friendsVoted.Contains(name)))
            {
                SharedData.poolVote++; //poolVote goes up by one
                SharedData.friendsVoted.Add(name); //adds name to the list
                nameTextBox.Text = "";
            }


            else
            {
                cheatConsequences();
            }
        }


        private void option2PictureBox_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text; //the text from nameTextBox is used as the value for name

            //if name is in the friends list but not in the list for friends that have already voted
            if ((SharedData.friends.Contains(name)) && (!SharedData.friendsVoted.Contains(name)))
            {
                SharedData.cinemaVote++; //cinemaVote goes up by one
                SharedData.friendsVoted.Add(name); //adds name to the list
                nameTextBox.Text = "";
            }


            else
            {
                cheatConsequences();
            }
        }
        

        private void option3PictureBox_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text; //the text from nameTextBox is used as the value for name

            //if name is in the friends list but not in the list for friends that have already voted
            if ((SharedData.friends.Contains(name)) && (!SharedData.friendsVoted.Contains(name)))
            {
                SharedData.gameNightVote++; //movieNightVote goes up by one
                SharedData.friendsVoted.Add(name); //adds name to the list
                nameTextBox.Text = "";
            }


            else
            {
                cheatConsequences();
            }
        }

        


        public async void cheatConsequences()
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
            await Task.Delay(3000); //waiting three seconds before
            voteLabel.Text = "It is time to vote! Enter the name and click on the image that you want to vote for. But don't cheat..."; //changing the text back to normal
            nameTextBox.Text = "";
            this.BackColor = Color.Black; //changing the background color back to black
        }


    }
}

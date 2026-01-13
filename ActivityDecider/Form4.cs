using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace ActivityDecider
{
    public partial class RevealForm : Form
    {
        Random randGen = new Random(); //number generator to determine the winner if there is a tie

        public RevealForm()
        {
            InitializeComponent();
        }

        private async void RevealForm_Load(object sender, EventArgs e)
        {
            await Task.Delay(5000); //waiting 5 seconds before outputting the text
            revealLabel.Text = "Now let’s reveal the votes. " + SharedData.poolVote + " of you voted for going to the pool, " + SharedData.cinemaVote + " voted for watching a movie at the cinema and " + SharedData.gameNightVote + " votes were submitted for going a game night at home. This means ";

            if ((SharedData.poolVote > SharedData.cinemaVote) && (SharedData.poolVote > SharedData.gameNightVote))
            {
                revealLabel.Text += "going to the pool got the most votes with " + SharedData.poolVote + " votes! Have fun :)"; //output if going to the pool got the most votes
            }
            else if ((SharedData.cinemaVote > SharedData.gameNightVote) && (SharedData.cinemaVote > SharedData.poolVote))
            {
                revealLabel.Text += "watching a movie at the cinema got the most votes with " + SharedData.gameNightVote + " votes! Have fun :)"; //output if going to the cinema got the most votes
            }
            else if ((SharedData.gameNightVote > SharedData.cinemaVote) && (SharedData.gameNightVote > SharedData.poolVote))
            {
                revealLabel.Text += "doing a game night at home got the most votes with " + SharedData.gameNightVote + " votes! Have fun :)"; //output if having a game night got the most votes
            }



            //the next four else if are if there is a tied winner
            else if ((SharedData.poolVote == SharedData.cinemaVote) && (SharedData.poolVote > SharedData.gameNightVote))
            {
                int random = randGen.Next(1, 3); //random number between 1 and 2
                
                revealLabel.Text += "going to the pool and watching a movie at the cinema were tied, the random winner is ";
                if (random == 1)
                    revealLabel.Text += "going to the pool! Have fun :)";
                else if (random == 2)
                    revealLabel.Text += "watching a movie at the cinema! Have fun :)";
            }

            else if ((SharedData.poolVote == SharedData.gameNightVote) && (SharedData.poolVote > SharedData.cinemaVote))
            {
                int random = randGen.Next(1, 3); //random number between 1 and 2

                revealLabel.Text += "going to the pool and doing a game night at home were tied, the random winner is ";
                if (random == 1)
                    revealLabel.Text += "going to the pool! Have fun :)";
                else if (random == 2)
                    revealLabel.Text += "doing a game night at home! Have fun :)";
            }

            else if ((SharedData.cinemaVote == SharedData.gameNightVote) && (SharedData.cinemaVote > SharedData.poolVote))
            {
                int random = randGen.Next(1, 3); //random number between 1 and 2

                revealLabel.Text += "watching a movie at the cinema and doing a game night at home were tied, the random winner is ";
                if (random == 1)
                    revealLabel.Text += "watching a movie at the cinema! Have fun :)";
                else if (random == 2)
                    revealLabel.Text += "doing a game night at home! Have fun :)";
            }

            //if all three votes are tied
            else if ((SharedData.poolVote == SharedData.gameNightVote) && (SharedData.poolVote == SharedData.cinemaVote))
            {
                int random = randGen.Next(1, 4); //random number between 1 and 3

                revealLabel.Text += "you were very in tune today, all three options are tied! The random winner is ";
                if (random == 1)
                    revealLabel.Text += "going to the pool! Have fun :)";
                else if (random == 2)
                    revealLabel.Text += "watching a movie at the cinema! Have fun :)";
                else if (random == 3)
                    revealLabel.Text += "doing a game night at home! Have fun :)";
            }

            await Task.Delay(3000); //waiting 3 seconds
            revealLabel.Text += "\nNow let's reveal the cheaters!";
            revealCheatersButton.Visible = true;
        }

        private void revealCheatersButton_Click(object sender, EventArgs e)
        {
            if (SharedData.friendsCheated.Count == 0) //output if there were no cheaters
                revealLabel.Text = "There were no cheaters!";
            
            else if (SharedData.friendsCheated.Count == 1) //output if there was one cheater
                revealLabel.Text = "The cheater was " + SharedData.friendsCheated + ". Shame on you!!";

            else
            {
                for (int i = 0; i++; i < SharedData.friendsCheated.Count)
                {

                }
            }
            
        }
    }
}

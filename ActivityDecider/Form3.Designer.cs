namespace ActivityDecider
{
    partial class VoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.voteLabel = new System.Windows.Forms.Label();
            this.option1PictureBox = new System.Windows.Forms.PictureBox();
            this.option2PictureBox = new System.Windows.Forms.PictureBox();
            this.option3PictureBox = new System.Windows.Forms.PictureBox();
            this.yourNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.option1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // voteLabel
            // 
            this.voteLabel.BackColor = System.Drawing.Color.Transparent;
            this.voteLabel.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteLabel.ForeColor = System.Drawing.Color.White;
            this.voteLabel.Location = new System.Drawing.Point(133, 30);
            this.voteLabel.Name = "voteLabel";
            this.voteLabel.Size = new System.Drawing.Size(546, 125);
            this.voteLabel.TabIndex = 2;
            this.voteLabel.Text = "It is time to vote! Enter the name and click on the image that you want to vote f" +
    "or. But don\'t cheat...";
            this.voteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1PictureBox
            // 
            this.option1PictureBox.Image = global::ActivityDecider.Properties.Resources.pool2_1024x656;
            this.option1PictureBox.Location = new System.Drawing.Point(73, 250);
            this.option1PictureBox.Name = "option1PictureBox";
            this.option1PictureBox.Size = new System.Drawing.Size(181, 142);
            this.option1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option1PictureBox.TabIndex = 3;
            this.option1PictureBox.TabStop = false;
            this.option1PictureBox.Click += new System.EventHandler(this.option1PictureBox_Click);
            // 
            // option2PictureBox
            // 
            this.option2PictureBox.Image = global::ActivityDecider.Properties.Resources._002;
            this.option2PictureBox.Location = new System.Drawing.Point(326, 250);
            this.option2PictureBox.Name = "option2PictureBox";
            this.option2PictureBox.Size = new System.Drawing.Size(183, 142);
            this.option2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option2PictureBox.TabIndex = 4;
            this.option2PictureBox.TabStop = false;
            // 
            // option3PictureBox
            // 
            this.option3PictureBox.Image = global::ActivityDecider.Properties.Resources.stock_custom_stock_2022_11_custom_stock_games_puzzle_0240_edit;
            this.option3PictureBox.Location = new System.Drawing.Point(584, 250);
            this.option3PictureBox.Name = "option3PictureBox";
            this.option3PictureBox.Size = new System.Drawing.Size(176, 142);
            this.option3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option3PictureBox.TabIndex = 5;
            this.option3PictureBox.TabStop = false;
            // 
            // yourNameLabel
            // 
            this.yourNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.yourNameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourNameLabel.ForeColor = System.Drawing.Color.White;
            this.yourNameLabel.Location = new System.Drawing.Point(125, 176);
            this.yourNameLabel.Name = "yourNameLabel";
            this.yourNameLabel.Size = new System.Drawing.Size(175, 41);
            this.yourNameLabel.TabIndex = 6;
            this.yourNameLabel.Text = "Your name:";
            this.yourNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(371, 181);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 36);
            this.nameTextBox.TabIndex = 7;
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.yourNameLabel);
            this.Controls.Add(this.option3PictureBox);
            this.Controls.Add(this.option2PictureBox);
            this.Controls.Add(this.option1PictureBox);
            this.Controls.Add(this.voteLabel);
            this.Name = "VoteForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.option1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label voteLabel;
        private System.Windows.Forms.PictureBox option1PictureBox;
        private System.Windows.Forms.PictureBox option2PictureBox;
        private System.Windows.Forms.PictureBox option3PictureBox;
        private System.Windows.Forms.Label yourNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}
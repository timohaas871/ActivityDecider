namespace ActivityDecider
{
    partial class NamesForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enterNameButton = new System.Windows.Forms.Button();
            this.goToVoteButton = new System.Windows.Forms.Button();
            this.checkNamesButton = new System.Windows.Forms.Button();
            this.checkNamesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(378, 171);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 36);
            this.nameTextBox.TabIndex = 0;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterNameLabel.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLabel.ForeColor = System.Drawing.Color.White;
            this.enterNameLabel.Location = new System.Drawing.Point(141, 21);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(546, 137);
            this.enterNameLabel.TabIndex = 1;
            this.enterNameLabel.Text = "Now please enter your name and hit the Got it button, if you are the last one als" +
    "o check if all of the names are correct";
            this.enterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterNameButton
            // 
            this.enterNameButton.BackColor = System.Drawing.Color.Black;
            this.enterNameButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameButton.ForeColor = System.Drawing.Color.White;
            this.enterNameButton.Location = new System.Drawing.Point(323, 236);
            this.enterNameButton.Name = "enterNameButton";
            this.enterNameButton.Size = new System.Drawing.Size(130, 74);
            this.enterNameButton.TabIndex = 9;
            this.enterNameButton.Text = "Got it";
            this.enterNameButton.UseVisualStyleBackColor = false;
            this.enterNameButton.Click += new System.EventHandler(this.enterNameButton_Click);
            // 
            // goToVoteButton
            // 
            this.goToVoteButton.BackColor = System.Drawing.Color.Black;
            this.goToVoteButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToVoteButton.ForeColor = System.Drawing.Color.White;
            this.goToVoteButton.Location = new System.Drawing.Point(652, 161);
            this.goToVoteButton.Name = "goToVoteButton";
            this.goToVoteButton.Size = new System.Drawing.Size(136, 74);
            this.goToVoteButton.TabIndex = 10;
            this.goToVoteButton.Text = "Go to vote!";
            this.goToVoteButton.UseVisualStyleBackColor = false;
            // 
            // checkNamesButton
            // 
            this.checkNamesButton.BackColor = System.Drawing.Color.Black;
            this.checkNamesButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNamesButton.ForeColor = System.Drawing.Color.White;
            this.checkNamesButton.Location = new System.Drawing.Point(323, 350);
            this.checkNamesButton.Name = "checkNamesButton";
            this.checkNamesButton.Size = new System.Drawing.Size(136, 88);
            this.checkNamesButton.TabIndex = 11;
            this.checkNamesButton.Text = "Check names";
            this.checkNamesButton.UseVisualStyleBackColor = false;
            this.checkNamesButton.Click += new System.EventHandler(this.checkNamesButton_Click);
            // 
            // checkNamesLabel
            // 
            this.checkNamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkNamesLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNamesLabel.ForeColor = System.Drawing.Color.White;
            this.checkNamesLabel.Location = new System.Drawing.Point(57, 256);
            this.checkNamesLabel.Name = "checkNamesLabel";
            this.checkNamesLabel.Size = new System.Drawing.Size(713, 156);
            this.checkNamesLabel.TabIndex = 12;
            this.checkNamesLabel.Text = "here are the names dispayed";
            this.checkNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkNamesLabel.Visible = false;
            // 
            // NamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkNamesButton);
            this.Controls.Add(this.goToVoteButton);
            this.Controls.Add(this.enterNameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.checkNamesLabel);
            this.Name = "NamesForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.NamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterNameButton;
        private System.Windows.Forms.Button goToVoteButton;
        private System.Windows.Forms.Button checkNamesButton;
        private System.Windows.Forms.Label checkNamesLabel;
    }
}
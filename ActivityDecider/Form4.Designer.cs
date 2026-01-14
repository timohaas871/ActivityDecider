namespace ActivityDecider
{
    partial class RevealForm
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
            this.revealLabel = new System.Windows.Forms.Label();
            this.revealCheatersButton = new System.Windows.Forms.Button();
            this.closeProgramButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // revealLabel
            // 
            this.revealLabel.BackColor = System.Drawing.Color.Transparent;
            this.revealLabel.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealLabel.ForeColor = System.Drawing.Color.White;
            this.revealLabel.Location = new System.Drawing.Point(131, 19);
            this.revealLabel.Name = "revealLabel";
            this.revealLabel.Size = new System.Drawing.Size(576, 307);
            this.revealLabel.TabIndex = 3;
            this.revealLabel.Text = "Are you ready?";
            this.revealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.revealLabel.Click += new System.EventHandler(this.revealLabel_Click);
            // 
            // revealCheatersButton
            // 
            this.revealCheatersButton.BackColor = System.Drawing.Color.Black;
            this.revealCheatersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealCheatersButton.ForeColor = System.Drawing.Color.White;
            this.revealCheatersButton.Location = new System.Drawing.Point(328, 329);
            this.revealCheatersButton.Name = "revealCheatersButton";
            this.revealCheatersButton.Size = new System.Drawing.Size(137, 99);
            this.revealCheatersButton.TabIndex = 12;
            this.revealCheatersButton.Text = "Reveal cheaters";
            this.revealCheatersButton.UseVisualStyleBackColor = false;
            this.revealCheatersButton.Visible = false;
            this.revealCheatersButton.Click += new System.EventHandler(this.revealCheatersButton_Click);
            // 
            // closeProgramButton
            // 
            this.closeProgramButton.BackColor = System.Drawing.Color.Black;
            this.closeProgramButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeProgramButton.ForeColor = System.Drawing.Color.White;
            this.closeProgramButton.Location = new System.Drawing.Point(328, 329);
            this.closeProgramButton.Name = "closeProgramButton";
            this.closeProgramButton.Size = new System.Drawing.Size(137, 99);
            this.closeProgramButton.TabIndex = 13;
            this.closeProgramButton.Text = "Have fun!";
            this.closeProgramButton.UseVisualStyleBackColor = false;
            this.closeProgramButton.Visible = false;
            this.closeProgramButton.Click += new System.EventHandler(this.closeProgramButton_Click);
            // 
            // RevealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeProgramButton);
            this.Controls.Add(this.revealCheatersButton);
            this.Controls.Add(this.revealLabel);
            this.Name = "RevealForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.RevealForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label revealLabel;
        private System.Windows.Forms.Button revealCheatersButton;
        private System.Windows.Forms.Button closeProgramButton;
    }
}
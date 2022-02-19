namespace CodenamesGroupProjectWinForms
{
    partial class MainRulesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRulesPage));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.lblRule4 = new System.Windows.Forms.Label();
            this.lblRule5 = new System.Windows.Forms.Label();
            this.lblRule6 = new System.Windows.Forms.Label();
            this.lblRule7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(670, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RULES";
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule1.Location = new System.Drawing.Point(38, 136);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(528, 49);
            this.lblRule1.TabIndex = 1;
            this.lblRule1.Text = "1. Split teams evenly into two";
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule2.Location = new System.Drawing.Point(38, 210);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(1156, 49);
            this.lblRule2.TabIndex = 2;
            this.lblRule2.Text = "2. Decide on one person from each team who will be the spymaster";
            // 
            // lblRule3
            // 
            this.lblRule3.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule3.Location = new System.Drawing.Point(38, 289);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(1523, 103);
            this.lblRule3.TabIndex = 3;
            this.lblRule3.Text = "3. The board will have 25 cards; 1 assassin,  7 bystanders, 8 field agents on eac" +
    "h team and one double agent";
            // 
            // lblRule4
            // 
            this.lblRule4.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule4.Location = new System.Drawing.Point(38, 412);
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.Size = new System.Drawing.Size(1523, 141);
            this.lblRule4.TabIndex = 4;
            this.lblRule4.Text = resources.GetString("lblRule4.Text");
            // 
            // lblRule5
            // 
            this.lblRule5.AutoSize = true;
            this.lblRule5.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule5.Location = new System.Drawing.Point(38, 576);
            this.lblRule5.Name = "lblRule5";
            this.lblRule5.Size = new System.Drawing.Size(1397, 49);
            this.lblRule5.TabIndex = 5;
            this.lblRule5.Text = "5. the spymaster cannot give a clue about a word that is still visible on the boa" +
    "rd ";
            // 
            // lblRule6
            // 
            this.lblRule6.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule6.Location = new System.Drawing.Point(38, 654);
            this.lblRule6.Name = "lblRule6";
            this.lblRule6.Size = new System.Drawing.Size(1523, 100);
            this.lblRule6.TabIndex = 6;
            this.lblRule6.Text = "6. The spymaster gives a number with the clue that tells his field operatives how" +
    " many guesses they can make, as long as they guess once they can decide to stop " +
    "guessing";
            // 
            // lblRule7
            // 
            this.lblRule7.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule7.Location = new System.Drawing.Point(38, 783);
            this.lblRule7.Name = "lblRule7";
            this.lblRule7.Size = new System.Drawing.Size(1523, 44);
            this.lblRule7.TabIndex = 7;
            this.lblRule7.Text = "7. the teams wins if the field operatives guess all the correct field agents, if " +
    "they guess a bystander the turn ends, if they guess an assassing the game ends a" +
    "nd their team loses.";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 869);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1515, 44);
            this.label9.TabIndex = 8;
            this.label9.Text = "When ready to play, click start!";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Snow;
            this.btnStartGame.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(685, 979);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(256, 79);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // MainRulesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1674, 1559);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRule7);
            this.Controls.Add(this.lblRule6);
            this.Controls.Add(this.lblRule5);
            this.Controls.Add(this.lblRule4);
            this.Controls.Add(this.lblRule3);
            this.Controls.Add(this.lblRule2);
            this.Controls.Add(this.lblRule1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainRulesPage";
            this.Text = "MainRulesPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Label lblRule4;
        private System.Windows.Forms.Label lblRule5;
        private System.Windows.Forms.Label lblRule6;
        private System.Windows.Forms.Label lblRule7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStartGame;
    }
}
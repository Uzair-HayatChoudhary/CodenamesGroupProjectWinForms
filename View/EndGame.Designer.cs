namespace CodenamesGroupProjectWinForms.View
{
    partial class EndGame
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
            this.lblWinningTeamTitlePlaceholder = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinningTeamTitlePlaceholder
            // 
            this.lblWinningTeamTitlePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningTeamTitlePlaceholder.Location = new System.Drawing.Point(12, 161);
            this.lblWinningTeamTitlePlaceholder.Name = "lblWinningTeamTitlePlaceholder";
            this.lblWinningTeamTitlePlaceholder.Size = new System.Drawing.Size(1232, 303);
            this.lblWinningTeamTitlePlaceholder.TabIndex = 0;
            this.lblWinningTeamTitlePlaceholder.Text = "Placeholder winning team";
            this.lblWinningTeamTitlePlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(339, 497);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(214, 71);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(670, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 71);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 849);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblWinningTeamTitlePlaceholder);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWinningTeamTitlePlaceholder;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
    }
}
namespace Coin_Flipping_Sim
{
    partial class Form1
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
            this.lblUsernameQuestion = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtnPlayGameNo = new System.Windows.Forms.RadioButton();
            this.rdbtnPlayGameYes = new System.Windows.Forms.RadioButton();
            this.lblAsktoPlay = new System.Windows.Forms.Label();
            this.pnlNoToGame = new System.Windows.Forms.Panel();
            this.lblCoward = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.rdbtnPickTails = new System.Windows.Forms.RadioButton();
            this.rdbtnPickHead = new System.Windows.Forms.RadioButton();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.lblPickSide = new System.Windows.Forms.Label();
            this.pnlGameResults = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTurnsLeft = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlNoToGame.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.pnlGameResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsernameQuestion
            // 
            this.lblUsernameQuestion.AutoSize = true;
            this.lblUsernameQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUsernameQuestion.Location = new System.Drawing.Point(92, 65);
            this.lblUsernameQuestion.Name = "lblUsernameQuestion";
            this.lblUsernameQuestion.Size = new System.Drawing.Size(125, 25);
            this.lblUsernameQuestion.TabIndex = 0;
            this.lblUsernameQuestion.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(97, 120);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbtnPlayGameNo);
            this.panel1.Controls.Add(this.rdbtnPlayGameYes);
            this.panel1.Controls.Add(this.lblAsktoPlay);
            this.panel1.Location = new System.Drawing.Point(97, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 129);
            this.panel1.TabIndex = 2;
            // 
            // rdbtnPlayGameNo
            // 
            this.rdbtnPlayGameNo.AutoSize = true;
            this.rdbtnPlayGameNo.Location = new System.Drawing.Point(41, 74);
            this.rdbtnPlayGameNo.Name = "rdbtnPlayGameNo";
            this.rdbtnPlayGameNo.Size = new System.Drawing.Size(39, 17);
            this.rdbtnPlayGameNo.TabIndex = 2;
            this.rdbtnPlayGameNo.TabStop = true;
            this.rdbtnPlayGameNo.Text = "No";
            this.rdbtnPlayGameNo.UseVisualStyleBackColor = true;
            this.rdbtnPlayGameNo.CheckedChanged += new System.EventHandler(this.rdbtnPlayGameNo_CheckedChanged);
            // 
            // rdbtnPlayGameYes
            // 
            this.rdbtnPlayGameYes.AutoSize = true;
            this.rdbtnPlayGameYes.Location = new System.Drawing.Point(41, 51);
            this.rdbtnPlayGameYes.Name = "rdbtnPlayGameYes";
            this.rdbtnPlayGameYes.Size = new System.Drawing.Size(43, 17);
            this.rdbtnPlayGameYes.TabIndex = 1;
            this.rdbtnPlayGameYes.TabStop = true;
            this.rdbtnPlayGameYes.Text = "Yes";
            this.rdbtnPlayGameYes.UseVisualStyleBackColor = true;
            this.rdbtnPlayGameYes.CheckedChanged += new System.EventHandler(this.rdbtnPlayGameYes_CheckedChanged);
            // 
            // lblAsktoPlay
            // 
            this.lblAsktoPlay.AutoSize = true;
            this.lblAsktoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsktoPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAsktoPlay.Location = new System.Drawing.Point(34, 7);
            this.lblAsktoPlay.Name = "lblAsktoPlay";
            this.lblAsktoPlay.Size = new System.Drawing.Size(176, 36);
            this.lblAsktoPlay.TabIndex = 0;
            this.lblAsktoPlay.Text = "\r\nPlease Enter User Name:";
            this.lblAsktoPlay.Click += new System.EventHandler(this.lblAsktoPlay_Click);
            // 
            // pnlNoToGame
            // 
            this.pnlNoToGame.Controls.Add(this.lblCoward);
            this.pnlNoToGame.Location = new System.Drawing.Point(461, 324);
            this.pnlNoToGame.Name = "pnlNoToGame";
            this.pnlNoToGame.Size = new System.Drawing.Size(289, 231);
            this.pnlNoToGame.TabIndex = 3;
            this.pnlNoToGame.TabStop = true;
            this.pnlNoToGame.Visible = false;
            this.pnlNoToGame.Paint += new System.Windows.Forms.PaintEventHandler(this.rdbtnPickHeads_Paint);
            // 
            // lblCoward
            // 
            this.lblCoward.AutoSize = true;
            this.lblCoward.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCoward.Location = new System.Drawing.Point(82, 82);
            this.lblCoward.Name = "lblCoward";
            this.lblCoward.Size = new System.Drawing.Size(144, 45);
            this.lblCoward.TabIndex = 0;
            this.lblCoward.Text = "Coward!";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(697, 581);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.button2);
            this.pnlGame.Controls.Add(this.rdbtnPickTails);
            this.pnlGame.Controls.Add(this.rdbtnPickHead);
            this.pnlGame.Controls.Add(this.lblGameTitle);
            this.pnlGame.Controls.Add(this.lblPickSide);
            this.pnlGame.Location = new System.Drawing.Point(461, 55);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(289, 249);
            this.pnlGame.TabIndex = 5;
            this.pnlGame.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Fuchsia;
            this.button2.Location = new System.Drawing.Point(155, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Flip Coin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdbtnPickTails
            // 
            this.rdbtnPickTails.AutoSize = true;
            this.rdbtnPickTails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPickTails.ForeColor = System.Drawing.Color.Fuchsia;
            this.rdbtnPickTails.Location = new System.Drawing.Point(50, 166);
            this.rdbtnPickTails.Name = "rdbtnPickTails";
            this.rdbtnPickTails.Size = new System.Drawing.Size(81, 29);
            this.rdbtnPickTails.TabIndex = 3;
            this.rdbtnPickTails.TabStop = true;
            this.rdbtnPickTails.Text = "Tails";
            this.rdbtnPickTails.UseVisualStyleBackColor = true;
            // 
            // rdbtnPickHead
            // 
            this.rdbtnPickHead.AutoSize = true;
            this.rdbtnPickHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPickHead.ForeColor = System.Drawing.Color.Fuchsia;
            this.rdbtnPickHead.Location = new System.Drawing.Point(50, 120);
            this.rdbtnPickHead.Name = "rdbtnPickHead";
            this.rdbtnPickHead.Size = new System.Drawing.Size(97, 29);
            this.rdbtnPickHead.TabIndex = 2;
            this.rdbtnPickHead.TabStop = true;
            this.rdbtnPickHead.Text = "Heads";
            this.rdbtnPickHead.UseVisualStyleBackColor = true;
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGameTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGameTitle.Location = new System.Drawing.Point(77, 30);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(163, 31);
            this.lblGameTitle.TabIndex = 1;
            this.lblGameTitle.Text = "Heads or Tails";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPickSide
            // 
            this.lblPickSide.AutoSize = true;
            this.lblPickSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickSide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPickSide.Location = new System.Drawing.Point(8, 78);
            this.lblPickSide.Name = "lblPickSide";
            this.lblPickSide.Size = new System.Drawing.Size(273, 20);
            this.lblPickSide.TabIndex = 0;
            this.lblPickSide.Text = "Choose head or tails and flip the coin.";
            // 
            // pnlGameResults
            // 
            this.pnlGameResults.Controls.Add(this.lblPoints);
            this.pnlGameResults.Controls.Add(this.lblTurnsLeft);
            this.pnlGameResults.Controls.Add(this.lblResult);
            this.pnlGameResults.Location = new System.Drawing.Point(97, 324);
            this.pnlGameResults.Name = "pnlGameResults";
            this.pnlGameResults.Size = new System.Drawing.Size(339, 231);
            this.pnlGameResults.TabIndex = 6;
            this.pnlGameResults.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblPoints.Location = new System.Drawing.Point(220, 112);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(13, 29);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "\r\n";
            // 
            // lblTurnsLeft
            // 
            this.lblTurnsLeft.AutoSize = true;
            this.lblTurnsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTurnsLeft.Location = new System.Drawing.Point(42, 165);
            this.lblTurnsLeft.Name = "lblTurnsLeft";
            this.lblTurnsLeft.Size = new System.Drawing.Size(38, 25);
            this.lblTurnsLeft.TabIndex = 1;
            this.lblTurnsLeft.Text = "10";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblResult.Location = new System.Drawing.Point(19, 15);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(242, 43);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Please Flip Coin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 627);
            this.Controls.Add(this.pnlGameResults);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlNoToGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsernameQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNoToGame.ResumeLayout(false);
            this.pnlNoToGame.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.pnlGameResults.ResumeLayout(false);
            this.pnlGameResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameQuestion;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtnPlayGameNo;
        private System.Windows.Forms.RadioButton rdbtnPlayGameYes;
        private System.Windows.Forms.Label lblAsktoPlay;
        private System.Windows.Forms.Panel pnlNoToGame;
        private System.Windows.Forms.Label lblCoward;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbtnPickTails;
        private System.Windows.Forms.RadioButton rdbtnPickHead;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Label lblPickSide;
        private System.Windows.Forms.Panel pnlGameResults;
        private System.Windows.Forms.Label lblTurnsLeft;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPoints;
    }
}


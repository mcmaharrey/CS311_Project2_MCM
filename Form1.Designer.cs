namespace CS311_Project2_MCM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDie1 = new Label();
            lblDie2 = new Label();
            lblBalance = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblGameResult = new Label();
            lblBal = new Label();
            SuspendLayout();
            // 
            // lblDie1
            // 
            lblDie1.AutoSize = true;
            lblDie1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDie1.Location = new Point(62, 143);
            lblDie1.Name = "lblDie1";
            lblDie1.Size = new Size(0, 21);
            lblDie1.TabIndex = 0;
            // 
            // lblDie2
            // 
            lblDie2.AutoSize = true;
            lblDie2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDie2.Location = new Point(205, 143);
            lblDie2.Name = "lblDie2";
            lblDie2.Size = new Size(0, 21);
            lblDie2.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(104, 37);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(0, 21);
            lblBalance.TabIndex = 2;
            // 
            // txtBet
            // 
            txtBet.Location = new Point(221, 39);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "Enter Your Bet!";
            txtBet.Size = new Size(116, 23);
            txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.Location = new Point(407, 27);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(81, 41);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblGameResult
            // 
            lblGameResult.AutoSize = true;
            lblGameResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGameResult.Location = new Point(376, 143);
            lblGameResult.Name = "lblGameResult";
            lblGameResult.Size = new Size(112, 21);
            lblGameResult.TabIndex = 5;
            lblGameResult.Text = "Game Results";
            // 
            // lblBal
            // 
            lblBal.AutoSize = true;
            lblBal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBal.Location = new Point(24, 37);
            lblBal.Name = "lblBal";
            lblBal.Size = new Size(74, 21);
            lblBal.TabIndex = 6;
            lblBal.Text = "Balance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBal);
            Controls.Add(lblGameResult);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBalance);
            Controls.Add(lblDie2);
            Controls.Add(lblDie1);
            Name = "Form1";
            Text = "Craps";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private Label lblBalance;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblGameResult;
        private Label lblBal;
    }
}
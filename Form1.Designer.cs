namespace CounterGame
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
            components = new System.ComponentModel.Container();
            btnClickMe = new Button();
            btnStart = new Button();
            lblScore = new Label();
            lblTime = new Label();
            timerMove = new System.Windows.Forms.Timer(components);
            timerGame = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = Color.Yellow;
            btnClickMe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClickMe.ForeColor = Color.Firebrick;
            btnClickMe.Location = new Point(398, 271);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(129, 69);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me!";
            btnClickMe.UseVisualStyleBackColor = false;
            btnClickMe.Click += btnClickMe_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Yellow;
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStart.ForeColor = Color.Firebrick;
            btnStart.Location = new Point(297, 135);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(327, 68);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblScore.Location = new Point(16, 59);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(105, 32);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score: 0";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTime.Location = new Point(12, 21);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(130, 32);
            lblTime.TabIndex = 3;
            lblTime.Text = "Time: 30 s";
            // 
            // timerMove
            // 
            timerMove.Interval = 1500;
            // 
            // timerGame
            // 
            timerGame.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(927, 600);
            Controls.Add(lblTime);
            Controls.Add(lblScore);
            Controls.Add(btnStart);
            Controls.Add(btnClickMe);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CounterGame";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickMe;
        private Button btnStart;
        private Label lblScore;
        private Label lblTime;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Timer timerGame;
    }
}

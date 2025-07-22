using System.Media;

namespace CounterGame
{
    public partial class Form1 : Form
    {
        int score = 0;
        int timeLeft = 30;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            btnClickMe.Visible = false;
            timerMove.Tick += timerMove_Tick;
    timerGame.Tick += timerGame_Tick;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnClickMe.Visible = true;
            score = 0;
            timeLeft = 30;
            lblScore.Text = "Score: 0";
            lblTime.Text = "Time: 30";

            btnClickMe.Enabled = true;

            timerMove.Start();
            timerGame.Start();

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
          
          
            score++;
            lblScore.Text= "Score: " + score.ToString();
        }
        private void timerMove_Tick(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - btnClickMe.Width;
            int maxY = this.ClientSize.Height - btnClickMe.Height;

            int newX = rand.Next(0, maxX);
            int newY = rand.Next(50, maxY);

            btnClickMe.Location = new Point(newX, newY);
        }
        private void timerGame_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTime.Text = "Time: " + timeLeft.ToString();

            if (timeLeft <= 0)
            {
                timerGame.Stop();
                timerMove.Stop();
                btnClickMe.Enabled = false;
                MessageBox.Show("Time's up! Your Score: " + score, "Game Over");
            }
            

        }


    }
}

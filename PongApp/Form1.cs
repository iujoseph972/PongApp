namespace PongApp
{
    public partial class Pong : Form
    {       
        
        //Location Variables
        int cpuDirection = 5;

        static int ballSpeed = 10;
        int ballXCoordinate = ballSpeed;
        int ballYCoordinate = ballSpeed;

        //Score Variable
        int playerScore = 0;
        int cpuScore = 0;
        // Size Variables
        int bottomBoundary;
        int centerPoint;
        int xMidPoint;
        int yMidPoint;
        //Dectection Variables
        bool playerDectedUp;
        bool playerDectedDown;
        // Special Keys
        int spaceBarClicked = 0;



        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height;
            xMidPoint = ClientSize.Width / 2;
            yMidPoint = ClientSize.Height / 2;
        }





        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100,ClientSize.Height -100);
            //Adjust where the ball is
            pongBall.Top -= ballYCoordinate;
            pongBall.Left -= ballXCoordinate;
            // Make the CPU move
            NeuralNetwork nn = new NeuralNetwork();
            cpuPlayer.Top += cpuDirection * nn.network(pongBall.Top, pongBall.Top, cpuPlayer.Top, ballSpeed);
            // Check if CPU has reached top or bottom
            if (cpuPlayer.Top < 0 ) { cpuPlayer.Top += cpuDirection; }
            if (cpuPlayer.Top > bottomBoundary) { cpuPlayer.Top -= cpuDirection; }


            //// Check if CPU has reached top or bottom
            //if(cpuPlayer.Top < 0 || cpuPlayer.Top  > bottomBoundary) { cpuDirection = -cpuDirection; }

            // Make CPU Move Medium Dificulty 
            //if (cpuPlayer.Top > pongBall.Top && !(cpuPlayer.Top < 0)) { cpuPlayer.Top -= (int)(Math.Abs(ballYCoordinate) * 0.99); }
            //if (cpuPlayer.Top < pongBall.Top && !(cpuPlayer.Top > bottomBoundary)) { cpuPlayer.Top += (int)(Math.Abs(ballYCoordinate) * 0.99); }





            // Check if ball has exited left side of screen
            if (pongBall.Left < 0)
            {
                pongBall.Left = xMidPoint;
                pongBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                cpuScore++;
                cpuScoreLabel.Text = cpuScore.ToString();
            }

            // Check if ball has exited right side of the screen
            if(pongBall.Left + pongBall.Width > ClientSize.Width)
            {
                pongBall.Left = xMidPoint;
                pongBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                playerScoreLabel.Text = playerScore.ToString();
            }

            //Ensure the ball is within the boundaries of the screen
            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height) { ballYCoordinate = -ballYCoordinate; }
            
            //Check if the ball hits the player or CPU paddle
            if(pongBall.Bounds.IntersectsWith(player1.Bounds) || pongBall.Bounds.IntersectsWith(cpuPlayer.Bounds)) { 
                
                // Send ball opposite direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move Player up
            if(playerDectedUp == true && player1.Top > 0) { player1.Top -= 10; }
            // Move Player down
            if (playerDectedDown == true && player1.Top < bottomBoundary) { player1.Top += 10; }

            // check for winner
            if (playerScore >= 10 ) { pongTimer.Stop(); }


        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if(e.KeyCode == Keys.Up) { playerDectedUp = true; }
            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Down) { playerDectedDown = true; }
            
            // If player press the C Key, open character selection screen
            if(e.KeyCode == Keys.C)
            {
                Form character = new CharacterForm();
                character.Owner = this;
                pongTimer.Stop();
                character.Show();
            }


            // If player press spacebar pause the game
            if (e.KeyCode == Keys.Space)
            {
                spaceBarClicked++;
                if(spaceBarClicked % 2 == 0) {
                    pongTimer.Stop();
                }
                else
                {
                    pongTimer.Start();
                }

            }

        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {

            // If player releases the up arrow, stop moving paddle upwards
            if (e.KeyCode == Keys.Up) { playerDectedUp = false; }
            // If player releases the down arrow,stop moving paddle upwards
            if (e.KeyCode == Keys.Down) { playerDectedDown = false; }

        }
    }
}
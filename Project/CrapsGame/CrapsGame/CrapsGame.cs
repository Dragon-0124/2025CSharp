namespace CrapsGame
{
    public partial class CrapsGame : Form
    {
        int myPoint, mydie1, mydie2;
        
        const int SNAKE_EYES = 2;
        const int TREY = 3;
        const int BOX_CARS = 12;
        const int SEVEN_OUT = 7;
        const int YO_LEVEN = 11;
        public CrapsGame()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            gbPoint.Text = "Point";
            lbStatus.Text = "";
            pbFirstPoint.Image = null;
            pbSecondPoint.Image = null;

            myPoint = 0;
            myPoint = RollDice();
            gbPoint.Text = "Point is " + myPoint;
            switch (myPoint)
            {
                case SEVEN_OUT:
                    lbStatus.Text = "Results : (SEVEN_OUT)\nYou Win!";
                    btRoll.Enabled = false;
                    break;
                case YO_LEVEN:
                    lbStatus.Text = "Results : (YO_LEVEN)\nYou Win!";
                    btRoll.Enabled = false;
                    break;
                case SNAKE_EYES:
                    lbStatus.Text = "Results : (SNAKE_EYES)\nYou Lose!";
                    btRoll.Enabled = false;
                    break;
                case TREY:
                    lbStatus.Text = "Results : (TREY)\nYou Lose!";
                    btRoll.Enabled = false;
                    break;
                case BOX_CARS:
                    lbStatus.Text = "Results : (BOX_CARS)\nYou Lose!";
                    btRoll.Enabled = false;
                    break;
                default:
                    btPlay.Enabled = false;
                    btRoll.Enabled = true;
                    lbStatus.Text = "Results : (ANY_CRAPS)\nRoll Again";
                    DisplayDie(pbFirstPoint, mydie1);
                    DisplayDie(pbSecondPoint, mydie2);
                    break;
            }
        }

        public int RollDice()
        {
            int die1, die2, dieSum = 0;
            Random rd = new Random();
            die1 = rd.Next(1, 7);
            die2 = rd.Next(1, 7);
            dieSum = die1 + die2;

            mydie1 = die1;
            mydie2 = die2;

            DisplayDie(pbFirstDie, mydie1);
            DisplayDie(pbSecondDie, mydie2);

            return dieSum;
        }

        public void DisplayDie(PictureBox pic, int face)
        {
            pic.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images" + "\\die" + face + ".gif");
        }
        private void btRoll_Click(object sender, EventArgs e)
        {
            int RollPoint = RollDice();
            if (RollPoint == myPoint)
            {
                lbStatus.Text = "Results : " + RollPoint + "\nYou Win!(Lucky!)";
                btRoll.Enabled = false;
            }
            else if (RollPoint == SEVEN_OUT)
            {
                lbStatus.Text = "Results : " + RollPoint + "\nYou Lose!(UnLucky..)";
                btRoll.Enabled = false;
            }
            else
            {
                lbStatus.Text = "Results : " + RollPoint + "\nRoll Again";
            }
        }


        private void btReset_Click(object sender, EventArgs e)
        {
            gbPoint.Text = "Point";
            myPoint = 0;
            mydie1 = 0;
            mydie2 = 0;
            pbFirstDie.Image = null;
            pbSecondDie.Image = null;
            pbFirstPoint.Image = null;
            pbSecondPoint.Image = null;
            lbStatus.Text = "°á°ú : ";
            btPlay.Enabled = true;
            btRoll.Enabled = false;
        }
    }
}

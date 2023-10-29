using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;

namespace CS311_Project2_MCM
{
    public partial class Form1 : Form
    {
        private decimal balance = 100.00m;
        private int point = 0;
        public Form1()
        {
            InitializeComponent();

            lblBalance.Text = balance.ToString("C");// sets initial balance to 100
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBet.Text, out decimal bet) && bet > 0)
            {
                if (bet <= balance)
                {
                    lblGameResult.Text = "";

                    Random random = new Random();
                    int die1 = random.Next(1, 7);
                    int die2 = random.Next(1, 7);
                    int sum = die1 + die2;

                    lblDie1.Text = die1.ToString();
                    lblDie2.Text = die2.ToString();

                    Calculate_Score(sum, bet);
                }
                else
                {
                    MessageBox.Show("Insufficient balance.");
                }
            }
            else
            {
                MessageBox.Show("Invalid bet amount.");
            }
        }//end Roll_Click

        private void Calculate_Score(int sum, decimal bet)
        {
            if (point == 0) // This will be the first roll
            {
                switch (sum)
                {
                    case 7:
                    case 11:
                        balance += bet;
                        lblGameResult.Text = "You Win!";
                        break;
                    case 2:
                    case 3:
                    case 12:
                        balance -= bet;
                        lblGameResult.Text = "You Lose!";
                        break;
                    default:
                        point = sum; //Sets the point value
                        lblGameResult.Text = "Point is " + point;
                        break;
                }
            }
            else
            {
                if (sum == point)
                {
                    balance += bet;
                    lblGameResult.Text = "You Win!";
                    point = 0; //Resets the point value
                }
                else if (sum == 7)
                {
                    balance -= bet;
                    lblGameResult.Text = "You Lose!";
                    point = 0; //Resets the point value
                }
            }

            lblBalance.Text = balance.ToString("C"); //Shows the balance as money
        }//end Calculate_Score

        enum GameStatus
        {
            Win,
            Lose,
            Point
        }//end enum

    }//end class
}//end namespace
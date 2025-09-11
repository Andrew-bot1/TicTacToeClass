namespace TicTacToeClass
{
    public partial class Form1 : Form
    {
        
        public int curPlayer = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpLeft_Click(object sender, EventArgs e)
        {
            //int curPlayer = 1;
            TicTacToeGame.switchPlayer(curPlayer);
            if (TicTacToeGame.switchPlayer == 1)
            {

            }
            btnUpLeft.Image = Properties.Resources.blackx;

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

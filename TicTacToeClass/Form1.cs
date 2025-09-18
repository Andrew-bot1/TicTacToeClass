namespace TicTacToeClass
{
    public partial class Form1 : Form
    {

        //public int curPlayer = 1;
        TicTacToeGame player1;
        TicTacToeGame player2;
        TicTacToeGame curPlayer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnUpLeft, curPlayer);
            }


        }

        private void btnUpMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnUpMid, curPlayer);
            }
                
        }

        private void btnUpRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnUpRight, curPlayer);
            }
                
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnMidLeft, curPlayer);
            }
            
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnMid, curPlayer);
            }
            
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnMidRight, curPlayer);
            }
            
        }

        private void btnLowLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnLowLeft, curPlayer);
            }
            
        }

        private void btnLowMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(btnLowMid, curPlayer);
            }
            
        }

        private void bntLowRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                TicTacToeGame.placePiece(bntLowRight, curPlayer);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radBtnSing_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnMulti.Checked== false)
            {
                player1 = new TicTacToeGame(1, "x", "real");
                player2 = new TicTacToeGame(2, "o", "fake");
                curPlayer = player1;
            }
            else
            {
                radBtnSing.Checked = false;
            }
            
        }

        private void radBtnMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == false)
            {
                player1 = new TicTacToeGame(1, "x", "real");
                player2 = new TicTacToeGame(2, "o", "real");
                curPlayer = player1;
            }
            else
            {
                radBtnMulti.Checked = false;
            }
        }
    }
}

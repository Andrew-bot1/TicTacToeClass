namespace TicTacToeClass
{
    public partial class Form1 : Form
    {

        //public int curPlayer = 1;
        TicTacToeGame player1;
        TicTacToeGame player2;
        TicTacToeGame curPlayer;
        TicTacToeGame game = new TicTacToeGame();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnUpLeft, curPlayer, 0, 0);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
            else
            {
                game.switchPlayer(curPlayer);
            }

            // game.checkWinner(game.board);


        }

        private void btnUpMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnUpMid, curPlayer, 0, 1);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
        }

        private void btnUpRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnUpRight, curPlayer, 0, 2);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
            else
            {
                game.switchPlayer(curPlayer);
            }
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnMidLeft, curPlayer, 1, 0);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
            else
            {
                game.switchPlayer(curPlayer);
            }

        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnMid, curPlayer, 1, 1);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
            else
            {
                game.switchPlayer(curPlayer);
            }
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnMidRight, curPlayer, 1, 2);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
        }

        private void btnLowLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnLowLeft, curPlayer, 2, 0);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
            else
            {
                game.switchPlayer(curPlayer);
            }
        }

        private void btnLowMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(btnLowMid, curPlayer, 2, 1);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
            else
            {
                game.switchPlayer(curPlayer);
            }
        }

        private void bntLowRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                game.placePiece(bntLowRight, curPlayer, 2, 2);
            }
            if (game.gameOver)
            {
                clearBoard();
            }
            else
            {
                game.switchPlayer(curPlayer);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radBtnSing_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnMulti.Checked == false)
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

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBoard()
        {
            if (curPlayer.Player == 1)
            MessageBox.Show($"WInner is {curPlayer.Syms}");
            btnUpLeft.Text = "";
            btnUpMid.Text = "";
            btnUpRight.Text = "";
            btnMidLeft.Text = "";
            btnMid.Text = "";
            btnMidRight.Text = "";
            btnLowLeft.Text = "";
            btnLowMid.Text = "";
            bntLowRight.Text = "";
        }
    }
}
namespace TicTacToeClass
{
    public partial class Form1 : Form
    {

        //public int curPlayer = 1;
        TicTacToeGame player1;
        TicTacToeGame player2;
        
        TicTacToeGame game = new TicTacToeGame();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnUpLeft, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(game.curPlayer);
                    
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);

                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnUpLeft, curPlayer, 0, 0);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                }
                clearBoard();

            }

            // game.checkWinner(game.board);


        }

        private void btnUpMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnUpMid, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(curPlayer);
                    
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);

                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnUpMid, curPlayer, 0, 1);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                }
                clearBoard();
            }
        }

        private void btnUpRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnUpRight, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(curPlayer);
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);

                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnUpRight, curPlayer, 0, 2);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                }
                clearBoard();
            }
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnMidLeft, curPlayer, 2, 2);
                   clearBoard();
                        game.switchPlayer(curPlayer);
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);

                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnMidLeft, curPlayer, 1, 0);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                }
                clearBoard();
            }

        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnMid, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(curPlayer);
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);

                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnMid, curPlayer, 1, 1);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                }
                clearBoard();
            }
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnMidRight, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(curPlayer);
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);

                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnMidRight, curPlayer, 1, 2);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                }
                clearBoard();
            }

        }

        private void btnLowLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnLowLeft, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(curPlayer);
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);

                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnLowLeft, curPlayer, 2, 0);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                }
                clearBoard();

            }
        }

        private void btnLowMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(btnLowMid, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(curPlayer);
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);


                }
                else if (player2.type == "real")
                {
                        game.placePiece(btnLowMid, curPlayer, 2, 1);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                    

                }
                clearBoard();

            }
        }

        private void bntLowRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (player2.type == "fake")
                {
                    game.placePiece(bntLowRight, curPlayer, 2, 2);
                    clearBoard();
                        game.switchPlayer(curPlayer);
                    comPiece(game.comMove());
                    clearBoard();
                    game.switchPlayer(curPlayer);


                }
                else if (player2.type == "real")
                {
                        game.placePiece(bntLowRight, curPlayer, 2, 2);
                    clearBoard();
                    game.switchPlayer(curPlayer);
                    
                        
                }
                

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
                player2 = new TicTacToeGame(2, "o", "real");
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
                player2 = new TicTacToeGame(2, "o", "fake");
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

        //place com piece
        private void comPiece(int num)
        {
            switch (num)
            {
                               case 1:
                    game.placePiece(bntLowRight, curPlayer, 0, 0);
                    break;
                case 2:
                    game.placePiece(btnUpMid, curPlayer, 0, 1);
                    break;
                case 3:
                    game.placePiece(btnUpRight, curPlayer, 0, 2);
                    break;
                case 4:
                    game.placePiece(btnMidLeft, curPlayer, 1, 0);
                    break;
                case 5:
                    game.placePiece(btnMid, curPlayer, 1, 1);
                    break;
                case 6:
                    game.placePiece(btnMidRight, curPlayer, 1, 2);
                    break;
                case 7:
                    game.placePiece(btnLowLeft, curPlayer, 2, 0);
                    break;
                case 8:
                    game.placePiece(btnLowMid, curPlayer, 2, 1);
                    break;
                case 9:
                    game.placePiece(bntLowRight, curPlayer, 2, 2);
                    break;
            }
        }

        private void clearBoard()
        {
            if (game.gameOver==true)
            {
                if (game.draw == true)
                {
                    MessageBox.Show("It's a draw!");
                }
                else
                {
                    MessageBox.Show($"WInner is {curPlayer.Sym}");
                }

                game.gameOver = false;

                for (int i = 0; i < game.board.GetLength(0); i++)
                {
                    for (int j = 0; j < game.board.GetLength(1); j++)
                    {
                        Console.WriteLine(game.board[i, j] = "");
                    }
                }

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
}

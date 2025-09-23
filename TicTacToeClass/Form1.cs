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
                if (btnUpLeft.Text=="")
                {
                    //if (game.curPlayer.type == "fake")
                    //{
                    //    game.placePiece(btnUpLeft, game.curPlayer, 0, 0);
                    //    game.switchPlayer(game.curPlayer);
                    //    comPiece();
                    //}
                    //else
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnUpLeft, game.curPlayer, 0, 0);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                
                    //clearBoard();

                }
                clearBoard();
                // game.switchPlayer(game.curPlayer);

            }

            // game.checkWinner(game.board);


        }

        private void btnUpMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (btnUpMid.Text=="")
                {
                    //if (game.curPlayer.type == "fake")
                    //{
                    //    game.placePiece(btnUpMid, game.curPlayer, 0, 1);
                    //    game.switchPlayer(game.curPlayer);
                    //    comPiece();

                    //}
                    //else
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnUpMid, game.curPlayer, 0, 1);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                    clearBoard();
                }
                
                // game.switchPlayer(game.curPlayer);
            }
        }

        private void btnUpRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (btnUpRight.Text=="") {
                    //if (game.curPlayer.type == "fake")
                    //{
                    //    game.placePiece(btnUpRight, game.curPlayer, 0, 2);
                    //    game.switchPlayer(game.curPlayer);
                    //    comPiece();

                    //}
                    //else
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnUpRight, game.curPlayer, 0, 2);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                        //   game.switchPlayer(game.curPlayer);
                    }
                    clearBoard();
                }
                
                // game.switchPlayer(game.curPlayer);
            }
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (btnMidLeft.Text =="")
                {
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnMidLeft, game.curPlayer, 1, 0);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                }
                clearBoard();
            }
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (btnMid.Text == "")
                {
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnMid, game.curPlayer, 1, 1);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                    clearBoard();
                }
            }
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (btnMidRight.Text == "")
                {
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnMidRight, game.curPlayer, 1, 2);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                    clearBoard();
                }
            }

        }

        private void btnLowLeft_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (btnLowLeft.Text == "")
                {
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnLowLeft, game.curPlayer, 2, 0);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                    clearBoard();
                }
            }
        }

        private void btnLowMid_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (btnLowMid.Text == "")
                {
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(btnLowMid, game.curPlayer, 2, 1);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                    clearBoard();
                }
                

            }
        }

        private void bntLowRight_Click(object sender, EventArgs e)
        {
            if (radBtnSing.Checked == true || radBtnMulti.Checked == true)
            {
                if (bntLowRight.Text == "")
                {
                    if (game.curPlayer.type == "real")
                    {
                        game.placePiece(bntLowRight, game.curPlayer, 2, 2);
                        if (player2.type == "fake")
                        {
                            game.switchPlayer(game.curPlayer);
                            comPiece();
                        }
                    }
                    clearBoard();
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
                game.curPlayer = player1;
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
                game.curPlayer = player1;
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
        private void comPiece()
        {
            Random rand = new Random();
            int num = 0;
            Button square = btnUpLeft;
            //        break;
            int num2 = 99;
            int num3 = 99;
            //Button square;

            while (true)
            {

                num = rand.Next(1, 10);
                switch (num)
                {


                    case 1:
                        num2 = 0;
                        num3 = 0;
                        square = btnUpLeft;
                        //btnUpLeft.Text = "O";
                        break;
                    case 2:
                        num2 = 0;
                        num3 = 1;
                        square = btnUpMid;
                        //btnUpMid.Text = "O";
                        break;
                    case 3:
                        num2 = 0;
                        num3 = 2;
                        square = btnUpRight;
                        //btnUpRight.Text = "O";
                        break;
                    case 4:
                        num2 = 1;
                        num3 = 0;
                        square = btnMidLeft;
                        //btnMidLeft.Text = "O";
                        break;
                    case 5:
                        num2 = 1;
                        num3 = 1;
                        square = btnMid;
                        //btnMid.Text = "O";
                        break;
                    case 6:
                        num2 = 1;
                        num3 = 2;
                        square = btnMidRight;
                        //btnMidRight.Text = "O";
                        break;
                    case 7:
                        num2 = 2;
                        num3 = 0;
                        square = btnLowLeft;
                        //btnLowLeft.Text = "O";
                        break;
                    case 8:
                        num2 = 2;
                        num3 = 1;
                        square = btnLowMid;
                        //btnLowMid.Text = "O";
                        break;
                    case 9:
                        num2 = 2;
                        num3 = 2;
                        square = bntLowRight;
                        //bntLowRight.Text = "O";
                        break;
                }
                if (game.board[num2, num3] == "")
                {
                    //game.board[num2, num3] = "O";
                    game.placePiece(square, game.curPlayer, num2, num3);
                    break;
                }
            }
        }



        private void clearBoard()
        {
            Console.WriteLine(game.board);
            if (game.gameOver == true)
            {
                if (player2.type == "fake")
                {
                    game.switchPlayer(game.curPlayer);
                }

                MessageBox.Show($"WInner is {game.curPlayer.Sym}");
                game.gameOver = false;
                game.draw = false;

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
            else if (game.draw == true)
            {
                MessageBox.Show("It's a draw!");
                game.gameOver = false;
                game.draw = false;

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

                
            
            game.switchPlayer(game.curPlayer);

        }
    }
}

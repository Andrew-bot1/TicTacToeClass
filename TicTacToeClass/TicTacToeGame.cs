using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TicTacToeClass
{
    internal class TicTacToeGame
    {
        private string[,] board =  { { "", "", ""}, { "", "", ""}, { "", "", "" } };
        public bool gameOver = false;


        private int player;
        private string sym;
        private string type;

        public TicTacToeGame()
        {
        }


        public TicTacToeGame(int myPlayer,string mySym, string myType)
        {
            player = myPlayer;
            sym = mySym;
            type = myType;
        }

        public int Player
        {
            get { return player; }
            set { player = value; }
        }

        public string Sym
        {
            get { return sym; }
            set { sym = value; }
        }

        public bool placePiece(Button Square, TicTacToeGame curPlayer, int num1, int num2)
        {
            bool winner = false;
            if (Square.Text == "")
            {
                if (curPlayer.type == "real")
                {
                    if (curPlayer.Player == 1)
                    {
                        board[num1, num2] = "x";
                        Square.Text = "X";
                        //curPlayer.Player = 2;
                    }
                    else
                    {
                        board[num1, num2] = "o";
                        Square.Text = "O";
                        //curPlayer.Player = 1;
                    }
                }
                else
                {
                    comMove();
                }
                
            }
            checkWinner(board);
            //if (checkWinner(board))
            //{
            //    MessageBox.Show("We have a winner!");
            //    board = new string[,] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
            //    winner = true;
            //}
            return winner;
        }



        public int comMove()
        {
            Random rand = new Random();
            int num = rand.Next(1, 9);

            if (board[1,1] == "")
            {
                
            }
            else if

                return num;

            //switch (num)
            //{
            //    case 1:

            //        placePiece(btnUpLeft);
            //        break;
            //}
        }

        //switch player
        public void switchPlayer(TicTacToeGame curPlayer)
        {
            if (curPlayer.Player == 1)
            {
                curPlayer.Player = 2;
            }
            else
            {
                curPlayer.Player = 1;
            }
        }

        public bool checkWinner(string[,] board)//, TicTacToeGame curPlayer)
        {
            bool winner = false;
            //check horizontal row
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "")
                {
                    //winner
                    gameOver = true;
                }
            }

            //check vertical row
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "")
                {
                    //winner
                    gameOver = true;
                }
            }
            //check diagonal row
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "")
            {
                //winner
                gameOver = true;
            }

            return winner;

        }

        //check for two in a row for computer
        public bool checkTwo(string[,] board)//, TicTacToeGame curPlayer)
        {
            bool winner = false;
            //check horizontal row
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "")
                {
                    //winner
                    gameOver = true;
                }
            }

            //check vertical row
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "")
                {
                    //winner
                    gameOver = true;
                }
            }
            //check diagonal row
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "")
            {
                //winner
                gameOver = true;
            }

            return winner;

        }
    }
}

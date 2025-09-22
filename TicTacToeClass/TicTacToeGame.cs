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
        public string[,] board =  { { "", "", ""}, { "", "", ""}, { "", "", "" } };
        public bool gameOver = false;
        public bool draw = false;


        private int player;
        private string sym;
        public string type;

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
            int num = 99;

            while (true)
            {
                num = rand.Next(1, 9);
                int num2 = 99;
                int num3 = 99;

                switch (num)
                {
                    case 1:
                        num2 = 0;
                        num3= 0;
                        break;
                    case 2:
                        num2 = 0;
                        num3 = 1;
                        break;
                    case 3:
                        num2 = 0;
                        num3 = 2;
                        break;
                    case 4:
                        num2 = 1;
                        num3 = 0;
                        break;
                    case 5:
                        num2 = 1;
                        num3 = 1;
                        break;
                    case 6:
                        num2 = 1;
                        num3 = 2;
                        break;
                    case 7:
                        num2 = 2;
                        num3 = 0;
                        break;
                    case 8:
                        num2 = 2;
                        num3 = 1;
                        break;
                    case 9:
                        num2 = 2;
                        num3 = 2;
                        break;
                } 

                if (board[num2, num3] == "")
                {
                    break;
                }
            }
            

            //if (board[1,1] == "")
            //{
                
            //}
            //else if

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

        public void checkWinner(string[,] board)//, TicTacToeGame curPlayer)
        {
           // bool winner = false;
            //check horizontal row
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "")
                {
                    //winner
                    gameOver = true;
                    break;
                }
            }

            //check vertical row
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "")
                {
                    //winner
                    gameOver = true;
                    break;
                }
            }
            //check diagonal row
            if (board[1, 1] != "")
            {
                if (board[1, 1] == board[0, 0] && board[2, 2] == board[1, 1])
                {
                    //winner
                    gameOver = true;
                }
                else if (board[1, 1] == board[0, 2] && board[1, 1] == board[2, 0])
                {
                    gameOver = true;
                }
            }
                
            //check for draw
            if (board[0, 0] != "" && board[0, 1] != "" && board[0, 2] != "" && board[1, 0] != "" && board[1, 1] != "" && board[1, 2] != "" && board[2, 0] != "" && board[2, 1] != "" && board[2, 2] != "")
            {
                draw = true;
                gameOver = true;
            }

            //return winner;

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
                    break;
                }
            }

            //check vertical row
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "")
                {
                    //winner
                    gameOver = true;
                    break;
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

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


        private int player;
        private string sym;
        private string type;

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

        public void placePiece(Button Square, TicTacToeGame curPlayer, int num1, int num2)
        {
            if (Square.Text == "")
            {
                if (curPlayer.type == "real")
                {
                    if (curPlayer.Player == 1)
                    {
                        board[num1, num2] = "x";
                        Square.Text = "X";
                        curPlayer.Player = 2;
                    }
                    else
                    {
                        board[num1, num2] = "o";
                        Square.Text = "O";
                        curPlayer.Player = 1;
                    }
                }
                else
                {

                }
                
            }
        }

        public static int comMove()
        {
            Random rand = new Random();
            int num = rand.Next(1, 9);

            return num;

            //switch (num)
            //{
            //    case 1:

            //        placePiece(btnUpLeft);
            //        break;
            //}
        }

        public static void checkWinner()
        {
            //check horizontal row

        }
    }
}

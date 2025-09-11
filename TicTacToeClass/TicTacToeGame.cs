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
        public TicTacToeGame playerOne = new TicTacToeGame(1, "X");
        TicTacToeGame playerTwo = new TicTacToeGame(2, "o");
        public int curPlayer = 1;
        int[,] board = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        private int player;
        private string sym;

        public TicTacToeGame(int player,string sym)
        {
            player = player;
            sym = sym;
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

        //string curPlayer=

        public string switchCur()
        {
            return curPlayer;
        }

        public int switchPlayer(int curPlayer)
        {
            if (curPlayer == 1)
            {
                curPlayer = 2;
                return 1;
            }
            else
            {
                curPlayer = 1;
                return 2;
            }
        }
    }
}

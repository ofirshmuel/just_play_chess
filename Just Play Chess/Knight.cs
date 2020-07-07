using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Play_Chess
{
    class Knight : General_Piece
    {
        public Knight(int which_player, PictureBox PicBox_location, int x_location, int y_location, Piece_Type type)
            : base(which_player,PicBox_location,x_location,y_location,type)
        { }

        public override bool CanMove(General_Piece[,] gameBoard, int x, int y)
        {
            bool flag = false;
            if (this._X == x && this._Y == y)
                return false;
            if (x == this._X + 2)
            {
                if (y == this._Y - 1)
                {
                    flag = true;
                }
                else if (y == this._Y + 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            else if (x == this._X - 2)
            {
                if (y == this._Y - 1)
                {
                    flag = true;
                }
                else if (y == this._Y + 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            else if (y == this._Y - 2)
            {
                if (x == this._X + 1)
                {
                    flag = true;
                }
                else if (x == this._X - 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            else if (y == this._Y + 2)
            {
                if (x == this._X + 1)
                {
                    flag = true;
                }
                else if (x == this._X - 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag)
            {
                if (gameBoard[x,y].GetPlayer() == this._Player)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}

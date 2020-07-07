using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Play_Chess
{
    class King : General_Piece
    {
        public King(int which_player, PictureBox PicBox_location, int x_location, int y_location, Piece_Type type)
            : base(which_player,PicBox_location,x_location,y_location,type)
        { }

        public override bool CanMove(General_Piece[,] gameBoard, int x, int y)
        {
            if ((x <= 7 && x >= 0) && (y >= 0 && y <= 7))// chack if the cordets is in the bonders of the game board
            {
                //if the user want to move to the pawn's place, this cant be move
                if (this._X == x && this._Y == y)
                    return false;
                //check if there is own player in the destination .
                if (gameBoard[x,y].GetPlayer() == this._Player)
                    return false;
                if ((Math.Abs(this._X - x) == 1 || Math.Abs(this._X - x) == 0) && (Math.Abs(this._Y - y) == 1 || Math.Abs(this._Y - y) == 0))	// king can pass only one square
                    return true;
            }
            return false;
        }
    }
}

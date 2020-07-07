using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Just_Play_Chess
{
    public class Pawn : General_Piece
    {
        public Pawn(int which_player, PictureBox PicBox_location, int x_location, int y_location, Piece_Type type)
            : base(which_player,PicBox_location,x_location,y_location,type)
        { }


        public override bool CanMove(General_Piece[,] gameBoard, int x, int y)
        {
            if ((y <= 7 && y >= 0) && (x >= 0 && x <= 7))// chack if the cordets is in the bonders of the game board
            {
                //if the user want to move to the pawn's place, this cant be move
                if (this._X == x && this._Y == y)
                    return false;
                //check if there is own player in the destination .
                if (gameBoard[x,y].GetPlayer() == this._Player)
                   return false;
                if (this._Y == 1 && this._Player == 1)	// if it's player 1 and first move
                {
                    if ((y - this._Y) <= 2 && (y - this._Y) > 0 && this._X == x)	//The first move of any soldier can be 2 or 1 square up
                    {
                        // ok,check if there is a another pawn on the road
                        if (gameBoard[x, y].GetPlayer() == 0 && gameBoard[x, y - 1].GetPlayer() == 0)
                            return true;
                    }
                }
                else if (this._Y == 6 && this._Player == 2)	// if it's player 2 and first move
                {
                    if ((this._Y - y) <= 2 && (this._Y - y) > 0 && this._X == x)	//The first move of any soldier can be 2 or 1 square up
                    {
                        // ok,check if there is a another pawn on the road
                        if (gameBoard[x, y].GetPlayer() == 0 && gameBoard[x, y + 1].GetPlayer() == 0)
                            return true;
                    }
                }

                //regular move
                if ((y - this._Y) == 1  && this._Player == 1)	// player 1
                {
                    if (this._X == x && gameBoard[x, y].GetPlayer() == 0)
                        return true;
                    if(Math.Abs(this._X - x) == 1 && gameBoard[x, y].GetPlayer() != 0 && gameBoard[x, y].GetPlayer() != this.GetPlayer())
                        return true;
                }
                else if ((this._Y - y) == 1  && this._Player == 2)	// player 2
                {
                    if (this._X == x && gameBoard[x, y].GetPlayer() == 0)
                        return true;
                     if(Math.Abs(this._X - x) == 1 && gameBoard[x, y].GetPlayer() != 0 && gameBoard[x, y].GetPlayer() != this.GetPlayer())
                        return true;
                }
            }
            return false;
        }
    }
}

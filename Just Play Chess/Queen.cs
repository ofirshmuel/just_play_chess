using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Play_Chess
{
    class Queen : General_Piece
    {
        public Queen(int which_player, PictureBox PicBox_location, int x_location, int y_location, Piece_Type type)
            : base(which_player,PicBox_location,x_location,y_location,type)
        { }

        public override bool CanMove(General_Piece[,] gameBoard, int x, int y)
        {
            return (this.Straight_Move(gameBoard, x, y) || this.Cross_Move(gameBoard,x,y));
        }
    }
}

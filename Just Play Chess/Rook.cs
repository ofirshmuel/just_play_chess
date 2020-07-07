using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Just_Play_Chess
{
    class Rook : General_Piece
    {
        public Rook(int which_player, PictureBox PicBox_location, int x_location, int y_location, Piece_Type type)
            : base(which_player,PicBox_location,x_location,y_location,type)
        { }

        public override bool CanMove(General_Piece[,] gameBoard, int x, int y)
        {
            return this.Straight_Move(gameBoard, x, y);
        }
    }
}

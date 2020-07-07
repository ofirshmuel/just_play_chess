using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Just_Play_Chess
{
    public class General_Piece
    {
        protected int _Player;              // which player this piece 1 or 2 OR 0 , IS empty piece
        protected PictureBox _picBox;        // picBox contain the picture Box on the board
        protected int _X;                   // location of this piece -- line X
        protected int _Y;                   // location of this piece -- col Y
        protected Piece_Type _Type;         // the type of the piece

        public General_Piece(int which_player, PictureBox PicBox_location, int x_location, int y_location, Piece_Type type)
        {
            this._Player = which_player;
            this._picBox = PicBox_location;
            this._X = x_location;
            this._Y = y_location;
            this._Type = type;
        }

        public General_Piece( General_Piece temp)
        {
            this._Player = temp._Player;
            this._picBox = null;
            this._X = temp._X;
            this._Y = temp._Y;
            this._Type = temp._Type;
        }

        // Setters
        public void SetType(Piece_Type type) { this._Type = type; }
        public void SetX(int x) { this._X = x; }
        public void SetY(int y) { this._Y = y; }
        public void Set_picBox_background(Image pic) { this._picBox.BackgroundImage = pic; }
        public void set_PicBox(PictureBox temp) { this._picBox = temp; }
        public void Set_Player(int p_num) { this._Player = p_num; }
        public void Set_Backcolor() { this._picBox.BackColor = System.Drawing.Color.LightPink; }            // this function change the backcolor to red
        public void Delete_Backcolor() { this._picBox.BackColor = Color.Transparent; }                      // this function rest the backcolor to Transparent

        // Getters
        public Piece_Type getType() { return this._Type; }
        public int GetPlayer() { return this._Player; }
        public int GetX() { return this._X; }
        int GetY() { return this._Y; }
        public Image Get_picBox_Background() { return this._picBox.BackgroundImage; }
        public PictureBox Get_PicBox() { return this._picBox; }

        public General_Piece Swap_Pieces(General_Piece temp)
        {
            General_Piece this_piece = new General_Piece(this._Player, this._picBox, this._X, this._Y, this._Type);
            this._Player = temp._Player;
            this._picBox = temp._picBox;
            //this._X = temp._X;
            //this._Y = temp._Y;
            this._Type = temp._Type;

            return this_piece;
        }

        public virtual bool CanMove(General_Piece[,] gameBoard, int x, int y) { return false; }

        protected bool Straight_Move(General_Piece[,] gameBoard, int x, int y)
        {
            int i;
            bool flag1 = false, flag = false;
            if (x <= 7 && x >= 0 && y >= 0 && y <= 7)// chack if the cordets is in the bonders of the game board
            {
                //if the user want to move to the pawn's place, this cant be move
                if (this._X == x && this._Y == y)
                {
                    return false;
                }
                else if (this._X == x || this._Y == y)	// check if is cross move
                {
                    // crooss to x is that only y is change
                    if (this._Y == y)
                    {
                        //right move, from the current location to 'goal' location
                        if (this._X - x < 0)			//the diffrence is positive
                        {
                            i = this._X;
                            flag1 = true;
                        }
                        else
                        {
                            //left move, from 'goal' location location to the current
                            i = x;
                        }

                        // check if there is a another pawn on the road
                        for (int j = 0; j < Math.Abs(this._X - x); j++)
                        {
                            if (flag1)
                            {
                                flag = (i != this._X);
                            }
                            else
                            {
                                flag = (i != x);
                            }
                            if (gameBoard[i, y].getType() != Piece_Type.EMPTY && flag)
                                return false;
                            i++;
                        }
                        if (gameBoard[x, y].GetPlayer() == this._Player)
                        {
                            return false;
                        }
                        return true;	// if it's is not return
                    }
                    else
                    {
                        // crooss to y is that only x is change
                        //up move, from the current location to 'goal' location
                        if (this._Y - y < 0)
                        {//the diffrence is positive
                            i = this._Y;
                            flag1 = true;
                        }
                        else
                        {
                            //down move, from 'goal' location location to the current
                            i = y;
                            flag1 = false;
                        }
                        for (int j = 0; j < Math.Abs(this._Y - y); j++)
                        {
                            if (flag1)
                                flag = (i != this._Y);
                            else
                                flag = (i != y);
                            if (gameBoard[x, i].getType() != Piece_Type.EMPTY && flag)
                                return false;
                            i++;
                        }
                        if (gameBoard[x, y].GetPlayer() == this._Player)
                        {
                            return false;
                        }
                        return true;
                        //return (!(gameBoard[x, y].GetPlayer() == this._Player));        // if it's is not same player return true
                    }
                }
                return false;
            }
            return false;
        }

        protected bool Cross_Move(General_Piece[,] gameBoard, int x, int y)
        {
            bool right_Move = false, up_Move = false;
            if (this._X == x && this._Y == y)
                return false;
            if ((x <= 7 && x >= 0) && (y >= 0 && y <= 7))// chack if the cordets is in the bonders of the game board
            {
                if (Math.Abs(x - this._X) == Math.Abs(y - this._Y))
                {
                    //right move, from the current location to 'goal' location
                    if (this._X - x < 0)
                        right_Move = true;
                    //up move, from the current location to 'goal' location
                    if (this._Y - y < 0)
                        up_Move = true;
                    if (right_Move && up_Move)      // right-up move
                        return Right_Up_Check(gameBoard, x, y);
                    if (right_Move && !up_Move)      // right-down move
                        return Right_Down_Check(gameBoard, x, y);
                    if (!right_Move && up_Move)      // left-up move
                        return Left_Up_Check(gameBoard, x, y);
                    if (!right_Move && !up_Move)      // left-up move
                        return Left_Down_Check(gameBoard, x, y);
                }
            }
            return false;
        }
        protected bool Right_Up_Check(General_Piece[,] gameBoard, int x, int y)
        {

            int yIndex = this._Y + 1;
            bool is_first_oppent = true;
            for (int xIndex = this._X + 1; xIndex <= x; xIndex++)
            {
                if (!is_first_oppent)
                    return false;
                if (gameBoard[xIndex, yIndex].getType() != Piece_Type.EMPTY)
                {
                    if (gameBoard[xIndex, yIndex].GetPlayer() == this._Player)
                        return false;
                    is_first_oppent = false;        // if he's not own player is the oppenet so he cant pass him.
                }
                yIndex++;
            }
            return true;
        }
        protected bool Right_Down_Check(General_Piece[,] gameBoard, int x, int y)
        {

            int yIndex = this._Y - 1;
            bool is_first_oppent = true;
            for (int xIndex = this._X + 1; xIndex <= x; xIndex++)
            {
                if (!is_first_oppent)
                    return false;
                if (gameBoard[xIndex, yIndex].getType() != Piece_Type.EMPTY)
                {
                    if (gameBoard[xIndex, yIndex].GetPlayer() == this._Player)
                        return false;
                    is_first_oppent = false;        // if he's not own player is the oppenet so he cant pass him.
                }
                yIndex--;
            }
            return true;
        }
        protected bool Left_Up_Check(General_Piece[,] gameBoard, int x, int y)
        {

            int yIndex = this._Y + 1;
            bool is_first_oppent = true;
            for (int xIndex = this._X - 1; xIndex >= x; xIndex--)
            {
                if (!is_first_oppent)
                    return false;
                if (gameBoard[xIndex, yIndex].getType() != Piece_Type.EMPTY)
                {
                    if (gameBoard[xIndex, yIndex].GetPlayer() == this._Player)
                        return false;
                    is_first_oppent = false;        // if he's not own player is the oppenet so he cant pass him.
                }
                yIndex++;
            }
            return true;
        }
        protected bool Left_Down_Check(General_Piece[,] gameBoard, int x, int y)
        {

            int yIndex = this._Y - 1;
            bool is_first_oppent = true;
            for (int xIndex = this._X - 1; xIndex >= x; xIndex--)
            {
                if (!is_first_oppent)
                    return false;
                if (gameBoard[xIndex, yIndex].getType() != Piece_Type.EMPTY)
                {
                    if (gameBoard[xIndex, yIndex].GetPlayer() == this._Player)
                        return false;
                    is_first_oppent = false;        // if he's not own player is the oppenet so he cant pass him.
                }
                yIndex--;
            }
            return true;
        }

    }
}

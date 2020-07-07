using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Play_Chess
{
    public class Manager
    {

        private General_Piece[,] _board = new General_Piece[8, 8];      // create the board into matrix of pictureboxes, size 8 * 8. protected because manager can edit this
        private string player1_name;            // player 1's name
        private Color_Type player1_color;           // player 1's color
        private string player2_name;            // player 2's name
        private Color_Type player2_color;           // player 2's color
        private int moves_number;
        private bool is_Player1_turn;
        private bool is_Game_Over;
        public event EventHandler update_data;      // this event update field

        public Manager(General_Piece[,] board_from_form, string player1_name, string player2_name, Color_Type player1_color, Color_Type player2_color) 
        {
            this._board = board_from_form;
            this.player1_name = player1_name;
            this.player1_color = player1_color;
            this.player2_name = player2_name;
            this.player2_color = player2_color;
            this.moves_number = 0;
            this.is_Player1_turn = true;
            this.is_Game_Over = false;

            this.Game_Run();
            
        }

        // This function run all the game and call to all functions
        public void Game_Run()
        {
            this.Show_Begining_Order();
        }

        public bool Move(string move_massage, EventArgs e)
        {
            string own_player, oppenent_player;
            int x1,y1,x2,y2;
            y1 = move_massage[0] - 97;
            x1 = Convert.ToInt32( move_massage[1])-49;
            y2 = move_massage[3] - 97;
            x2 = Convert.ToInt32(move_massage[4]) - 49;

            if (is_Player1_turn)
            {
                own_player = this.player1_name;
                oppenent_player = this.player2_name;
            }
            else
            {
                own_player = this.player2_name;
                oppenent_player = this.player1_name;
            }
            // check if it's his turn
            if (this.is_Player1_turn)
            {
                if (this._board[x1, y1].GetPlayer() != 1)       // if it's player 1 player turn and player 2 play
                {
                    MessageBox.Show("NOW " + this.player1_name + " turn");      //suitable message
                    return false;
                }
            }
            else
            {
                if (this._board[x1, y1].GetPlayer() != 2)       // if it's player 1 player turn and player 2 play
                {
                    MessageBox.Show("NOW " + this.player2_name + " turn");      //suitable message
                    return false;
                }
            }
            if (this._board[x1, y1].CanMove(this._board, x2, y2))
            {                
                if (this.is_Future_Chess(this.Own_Player_Number(), x1, y1, x2, y2))
                {
                    MessageBox.Show("Pay Attetion ::  You are on chess ", "Pay Attetion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }

                this.Move_on_Board(x1, y1, x2, y2, true);                 
                
                this.moves_number++;
                update_data(this, null);            // call to update data function
                if (this.is_Chess(this.Opponent_Player_Number(), this._board))
                {
                    if (this.is_Mate())
                        this.Game_Over_Function();
                    else
                        MessageBox.Show("CHESS ON " + oppenent_player, "Pay Attetion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.is_Player1_turn = !this.is_Player1_turn;       // the next player is play now , after success move
                return true;
            }
            return false;
        }

        /// <summary>
        ///  This Function show in Game_Form form all the pieces.
        ///  according to any player and his color
        /// </summary>
        public void Show_Begining_Order()
        {
            // present all  pawns with function
            Show_pawns(1, this.player1_color);          // show player 1 pawns
            Show_pawns(2, this.player2_color);          // show player 2 pawns
            Show_Others_Piece(1, this.player1_color);
            Show_Others_Piece(2, this.player2_color);
        }


        // This function show all pawns -- soldiers in the board.
        private void Show_pawns(int player, Color_Type color)
        {
            int player_pawn_position = 1;           // this variable present when to put all pawn, player 1 -> line 1 , player 2-> line 6
            if (player == 2)
                player_pawn_position = 6;           // player 1 is stay 1 and if 2 so to line 6
            switch (color)
            {
                case Color_Type.BLACK:       // color black
                    for (int i = 0; i < 8; i++)
                    {
                        this._board[i, player_pawn_position].Set_picBox_background(All_pieces.pawn_black);
                        this._board[i, player_pawn_position].SetType(Piece_Type.PAWN);          // set the type, pawn
                    }
                    break;
                case Color_Type.WHITE:       // color white
                    for (int i = 0; i < 8; i++)
                    {
                        this._board[i, player_pawn_position].Set_picBox_background(All_pieces.pawn_white);
                        this._board[i, player_pawn_position].SetType(Piece_Type.PAWN);          // set the type, pawn
                    }
                    break;
                case Color_Type.BLUE:        // color blue
                    for (int i = 0; i < 8; i++)
                    {
                        this._board[i, player_pawn_position].Set_picBox_background(All_pieces.pawn_blue);
                        this._board[i, player_pawn_position].SetType(Piece_Type.PAWN);          // set the type, pawn
                    }
                    break;
                case Color_Type.RED:        // color red
                    for (int i = 0; i < 8; i++)
                    {
                        this._board[i, player_pawn_position].Set_picBox_background(All_pieces.pawn_red);
                        this._board[i, player_pawn_position].SetType(Piece_Type.PAWN);          // set the type, pawn
                    }
                    break;
            }
            
        }

        public int Get_Moves_Number() { return this.moves_number; }
        public bool Get_Is_Player1_Turn() { return this.is_Player1_turn; }

        // this function check all posible move from one piece.
        // The return value is like that : [4,5],[2,7] this return to game_form and present this
        // x and y is the piece from this we check
        public List<Point> Possible_Move(int x, int y)
        {
            List<Point> retValue = new List<Point>();     // this variable contain all 'names' (by string) of possible move
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (this._board[x, y].CanMove(this._board, i, k))       // check if it's the same position and after that if canMove
                        retValue.Add(new Point(i,k));
                }
            }
            return retValue;
        }

        // This function show other pieces -- rook,knight,bishop,quenn,king in the board.
        private void Show_Others_Piece(int player, Color_Type color)
        {
            int player_pawn_position = 0;           // this variable present when to put all pawn, player 1 -> line 1 , player 2-> line 6
            if (player == 2)
                player_pawn_position = 7;           // player 1 is stay 1 and if 2 so to line 6
            switch (color)
            {
                case Color_Type.BLACK:       // color black
                    // all rooks
                    this._board[0, player_pawn_position].Set_picBox_background(All_pieces.rook_black);
                    this._board[7, player_pawn_position].Set_picBox_background(All_pieces.rook_black);
                    this._board[0, player_pawn_position].SetType(Piece_Type.ROOK);
                    this._board[7, player_pawn_position].SetType(Piece_Type.ROOK);

                    // all knights
                    this._board[1, player_pawn_position].Set_picBox_background(All_pieces.knight_black);
                    this._board[6, player_pawn_position].Set_picBox_background(All_pieces.knight_black);
                    this._board[1, player_pawn_position].SetType(Piece_Type.KNIGHT);
                    this._board[6, player_pawn_position].SetType(Piece_Type.KNIGHT);

                    // all bishops
                    this._board[2, player_pawn_position].Set_picBox_background(All_pieces.bishop_black);
                    this._board[5, player_pawn_position].Set_picBox_background(All_pieces.bishop_black);
                    this._board[2, player_pawn_position].SetType(Piece_Type.BISHOP);
                    this._board[5, player_pawn_position].SetType(Piece_Type.BISHOP);

                    this._board[3, player_pawn_position].Set_picBox_background(All_pieces.queen_black);
                    this._board[3, player_pawn_position].SetType(Piece_Type.QUEEN);
                    
                    this._board[4, player_pawn_position].Set_picBox_background(All_pieces.king_black);
                    this._board[4, player_pawn_position].SetType(Piece_Type.KING);
                    
                    break;
                case Color_Type.WHITE:       // color white
                    // all rooks
                    this._board[0, player_pawn_position].Set_picBox_background(All_pieces.rook_white);
                    this._board[7, player_pawn_position].Set_picBox_background(All_pieces.rook_white);
                    this._board[0, player_pawn_position].SetType(Piece_Type.ROOK);
                    this._board[7, player_pawn_position].SetType(Piece_Type.ROOK);

                    // all knights
                    this._board[1, player_pawn_position].Set_picBox_background(All_pieces.knight_white);
                    this._board[6, player_pawn_position].Set_picBox_background(All_pieces.knight_white);
                    this._board[1, player_pawn_position].SetType(Piece_Type.KNIGHT);
                    this._board[6, player_pawn_position].SetType(Piece_Type.KNIGHT);

                    // all bishops
                    this._board[2, player_pawn_position].Set_picBox_background(All_pieces.bishop_white);
                    this._board[5, player_pawn_position].Set_picBox_background(All_pieces.bishop_white);
                    this._board[2, player_pawn_position].SetType(Piece_Type.BISHOP);
                    this._board[5, player_pawn_position].SetType(Piece_Type.BISHOP);

                    this._board[3, player_pawn_position].Set_picBox_background(All_pieces.queen_white);
                    this._board[3, player_pawn_position].SetType(Piece_Type.QUEEN);

                    this._board[4, player_pawn_position].Set_picBox_background(All_pieces.king_white);
                    this._board[4, player_pawn_position].SetType(Piece_Type.KING);
                    break;
                case Color_Type.BLUE:        // color blue
                    // all rooks
                    this._board[0, player_pawn_position].Set_picBox_background(All_pieces.rook_blue);
                    this._board[7, player_pawn_position].Set_picBox_background(All_pieces.rook_blue);
                    this._board[0, player_pawn_position].SetType(Piece_Type.ROOK);
                    this._board[7, player_pawn_position].SetType(Piece_Type.ROOK);

                    // all knights
                    this._board[1, player_pawn_position].Set_picBox_background(All_pieces.knight_blue);
                    this._board[6, player_pawn_position].Set_picBox_background(All_pieces.knight_blue);
                    this._board[1, player_pawn_position].SetType(Piece_Type.KNIGHT);
                    this._board[6, player_pawn_position].SetType(Piece_Type.KNIGHT);

                    // all bishops
                    this._board[2, player_pawn_position].Set_picBox_background(All_pieces.bishop_blue);
                    this._board[5, player_pawn_position].Set_picBox_background(All_pieces.bishop_blue);
                    this._board[2, player_pawn_position].SetType(Piece_Type.BISHOP);
                    this._board[5, player_pawn_position].SetType(Piece_Type.BISHOP);

                    this._board[3, player_pawn_position].Set_picBox_background(All_pieces.queen_blue);
                    this._board[3, player_pawn_position].SetType(Piece_Type.QUEEN);

                    this._board[4, player_pawn_position].Set_picBox_background(All_pieces.king_blue);
                    this._board[4, player_pawn_position].SetType(Piece_Type.KING);
                    break;
                case Color_Type.RED:        // color red
                    // all rooks
                    this._board[0, player_pawn_position].Set_picBox_background(All_pieces.rook_red);
                    this._board[7, player_pawn_position].Set_picBox_background(All_pieces.rook_red);
                    this._board[0, player_pawn_position].SetType(Piece_Type.ROOK);
                    this._board[7, player_pawn_position].SetType(Piece_Type.ROOK);

                    // all knights
                    this._board[1, player_pawn_position].Set_picBox_background(All_pieces.knight_red);
                    this._board[6, player_pawn_position].Set_picBox_background(All_pieces.knight_red);
                    this._board[1, player_pawn_position].SetType(Piece_Type.KNIGHT);
                    this._board[6, player_pawn_position].SetType(Piece_Type.KNIGHT);

                    // all bishops
                    this._board[2, player_pawn_position].Set_picBox_background(All_pieces.bishop_red);
                    this._board[5, player_pawn_position].Set_picBox_background(All_pieces.bishop_red);
                    this._board[2, player_pawn_position].SetType(Piece_Type.BISHOP);
                    this._board[5, player_pawn_position].SetType(Piece_Type.BISHOP);

                    this._board[3, player_pawn_position].Set_picBox_background(All_pieces.queen_red);
                    this._board[3, player_pawn_position].SetType(Piece_Type.QUEEN);

                    this._board[4, player_pawn_position].Set_picBox_background(All_pieces.king_red);
                    this._board[4, player_pawn_position].SetType(Piece_Type.KING);
                    break;
            }

        }

        // this function receive x,y position and check if it's own turn. piece player 1 player when player 1 turn.
        public bool is_own_turn(int x, int y)
        {
            return ((this._board[x, y].GetPlayer() == 1 && this.is_Player1_turn) || (this._board[x, y].GetPlayer() == 2 && !this.is_Player1_turn));
        }

        /// <summary>
        /// This function check if he in chess on the king's player (in parameter)
        /// </summary>
        /// <returns></returns>
        public bool is_Chess(int player,General_Piece[,] temp_Board)
        {
            int kingX = 0, kingY = 0;
            int second_Player = 1;
            if(player == 1)
                second_Player = 2;
            for (int i = 0; i < temp_Board.GetLength(0); i++)
            {
                for (int j = 0; j < temp_Board.GetLength(1); j++)
                {
                    if (temp_Board[i, j].getType() == Piece_Type.KING && temp_Board[i, j].GetPlayer() == player)
                    {
                        kingX = i;
                        kingY = j;
                    }
                }
            }
            for (int i = 0; i < temp_Board.GetLength(0); i++)
            {
                for (int j = 0; j < temp_Board.GetLength(1); j++)
                {
                    if (temp_Board[i, j].GetPlayer() == second_Player && temp_Board[i, j].CanMove(temp_Board, kingX, kingY))
                        return true;
                }
            }
            return false;
        }

        // this function return the number of that his turn now player turn
        public int Own_Player_Number()
        {
            if (is_Player1_turn)        // if it's player 1 turn return 1
                return 1;
            return 2;                   // else return 2
        }

        // this function return the number of opponent player turn
        public int Opponent_Player_Number()
        {
            if (is_Player1_turn)        // if it's player 1 turn return 2
                return 2;
            return 1;                   // else return 1
        }

        public bool is_Future_Chess(int player,int x1, int y1, int x2, int y2)
        {
            this.Move_on_Board(x1, y1, x2, y2, false);
            if (this.is_Chess(player, this._board))
            {
                this.Move_on_Board(x2, y2, x1, y1,false);
                return true;
            }
            this.Move_on_Board(x2, y2, x1, y1, false);
            return false;
        }
        private void Move_on_Board(int x1, int y1, int x2, int y2, bool change_Image)
        {
            // this switch 
            switch (this._board[x1, y1].getType())
            {
                case Piece_Type.PAWN:
                    this._board[x2, y2] = new Pawn(this._board[x1, y1].GetPlayer(), this._board[x2, y2].Get_PicBox(), x2, y2, Piece_Type.PAWN);
                    break;
                case Piece_Type.BISHOP:
                    this._board[x2, y2] = new Bishop(this._board[x1, y1].GetPlayer(), this._board[x2, y2].Get_PicBox(), x2, y2, Piece_Type.BISHOP);
                    break;
                case Piece_Type.KING:
                    this._board[x2, y2] = new King(this._board[x1, y1].GetPlayer(), this._board[x2, y2].Get_PicBox(), x2, y2, Piece_Type.KING);
                    break;
                case Piece_Type.KNIGHT:
                    this._board[x2, y2] = new Knight(this._board[x1, y1].GetPlayer(), this._board[x2, y2].Get_PicBox(), x2, y2, Piece_Type.KNIGHT);
                    break;
                case Piece_Type.QUEEN:
                    this._board[x2, y2] = new Queen(this._board[x1, y1].GetPlayer(), this._board[x2, y2].Get_PicBox(), x2, y2, Piece_Type.QUEEN);
                    break;
                case Piece_Type.ROOK:
                    this._board[x2, y2] = new Rook(this._board[x1, y1].GetPlayer(), this._board[x2, y2].Get_PicBox(), x2, y2, Piece_Type.ROOK);
                    break;
            }

            if (change_Image)
            {
                this._board[x2, y2].Set_picBox_background(this._board[x1, y1].Get_picBox_Background());
                this._board[x1, y1] = new General_Piece(0, this._board[x1, y1].Get_PicBox(), x1, y1, Piece_Type.EMPTY);
                this._board[x1, y1].Set_picBox_background(null);
            }
            else
            {
                this._board[x1, y1] = new General_Piece(0, this._board[x1, y1].Get_PicBox(), x1, y1, Piece_Type.EMPTY);
            }
        }

        private bool is_Mate()
        {
            

            for (int i = 0; i < this._board.GetLength(0); i++)
            {
                for (int j = 0; j < this._board.GetLength(1); j++)
                {
                    if (this._board[i, j].GetPlayer() == this.Opponent_Player_Number())         // check if it's opponent player
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            for (int n = 0; n < 8; n++)
                            {
                                if(this._board[i,j].CanMove(this._board,k,n))
                                {
                                    //this.Move_on_Board( i, j, k, n, false);
                                    if (!this.is_Future_Chess(this.Opponent_Player_Number(), i, j, k, n))
                                    {
                                        //this.Move_on_Board(k, n, i, j, false);
                                        return false;
                                    }
                                    //this.Move_on_Board(k, n, i, j, false);
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool is_game_over() { return this.is_Game_Over; }

        private void Game_Over_Function()
        {
            this.is_Game_Over = true;
            string winner_Name;
            if (this.Own_Player_Number() == 1)
                winner_Name = player1_name;
            else
                winner_Name = player2_name;
            /*if(this.Own_Player_Number() == 1)
                MessageBox.Show("The Winner is " + this.player1_name + "\n\nCheck your score in Score board", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("The Winner is " + this.player2_name+ "\n\nCheck your score in Score board", "Game Over", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);*/
            update_data(this, null);
        }
    }
}

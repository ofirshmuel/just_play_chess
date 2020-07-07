using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Play_Chess
{
    public partial class Game_Form : Form
    {
        // all variable to show the game time
        private int sec = 0;     // this variable contain seconds
        private int min = 0;     // this variable contain minutes
        private int hour = 0;     // this variable contain hours
                
        private Manager game_Manager;

        private string player1_name;            // player 1's name
        private Color_Type player1_color;           // player 1's color
        private string player2_name;            // player 2's name
        private Color_Type player2_color;           // player 2's color

        private General_Piece[,] _board = new General_Piece[8,8];      // create the board into matrix of pictureboxes, size 8 * 8. protected because manager can edit this

        private bool is_Last = false;              // This variable check if this pawn is the source_pawn or dest_pawn this built a massage like this -> source-dest

        private string move_Massage;                // this variable contain the msg that move to the manager the message look like this "source-dest" example : "A1-B9"

        private List<Point> possible_Move_List;

        public Game_Form(string player1_name, string player2_name, Color_Type player1_color, Color_Type player2_color)
        {
            InitializeComponent();

            gameTime_timer.Start();     // start timer for Time of game


            this.player1_name = player1_name;
            this.player1_color = player1_color;
            this.player2_name = player2_name;
            this.player2_color = player2_color;

            this.Show_Names_on_Form();      // This function show the name of all players on the form
            
            this.Create_Matrix_board();

            this.game_Manager = new Manager(this._board, player1_name, player2_name, player1_color, player2_color);
            this.game_Manager.update_data += game_Manager_update_data;
        }

        void game_Manager_update_data(object sender, EventArgs e)
        {
            Manager m = (Manager)sender;
            if (!m.is_game_over())
            {
                this.moves_label.Text = m.Get_Moves_Number().ToString();
                if (!m.Get_Is_Player1_Turn())   // if it
                {
                    player_1_label.BackColor = Color.DarkGoldenrod;
                    player_2_label.BackColor = Color.Transparent;
                }
                else
                {
                    player_2_label.BackColor = Color.DarkGoldenrod;
                    player_1_label.BackColor = Color.Transparent;
                }
            }
            else
            {
                string winner_Name;
                if (m.Own_Player_Number() == 1)
                    winner_Name = player1_name;
                else
                    winner_Name = player2_name;
                MessageBox.Show("The Winner is " + winner_Name + "\n\nCheck your score in Score board", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                High_Score_Form high_score_start = new High_Score_Form(winner_Name);
                high_score_start.Show();
            }
        }


        // This function show the users name on the fitting label
        public void Show_Names_on_Form()
        {
            this.player_1_label.Text = this.player1_name;
            this.player_2_label.Text = this.player2_name;
        }

        // This function create an empty board and after that 
        public void Create_Matrix_board()
        {
            this._board[0, 0] = new Rook(1, this.a1, 0, 0, Piece_Type.EMPTY);
            this._board[1, 0] = new Knight(1, this.a2, 1, 0, Piece_Type.EMPTY);
            this._board[2, 0] = new Bishop(1, this.a3, 2, 0, Piece_Type.EMPTY);
            this._board[3, 0] = new Queen(1, this.a4, 3, 0, Piece_Type.EMPTY);
            this._board[4, 0] = new King(1, this.a5, 4, 0, Piece_Type.EMPTY);
            this._board[5, 0] = new Bishop(1, this.a6, 5, 0, Piece_Type.EMPTY);
            this._board[6, 0] = new Knight(1, this.a7, 6, 0, Piece_Type.EMPTY);
            this._board[7, 0] = new Rook(1, this.a8, 7, 0, Piece_Type.EMPTY);
            
            this._board[0, 1] = new Pawn(1, this.b1, 0, 1, Piece_Type.PAWN);
            this._board[1, 1] = new Pawn(1, this.b2, 1, 1, Piece_Type.PAWN);
            this._board[2, 1] = new Pawn(1, this.b3, 2, 1, Piece_Type.PAWN);
            this._board[3, 1] = new Pawn(1, this.b4, 3, 1, Piece_Type.PAWN);
            this._board[4, 1] = new Pawn(1, this.b5, 4, 1, Piece_Type.PAWN);
            this._board[5, 1] = new Pawn(1, this.b6, 5, 1, Piece_Type.PAWN);
            this._board[6, 1] = new Pawn(1, this.b7, 6, 1, Piece_Type.PAWN);
            this._board[7, 1] = new Pawn(1, this.b8, 7, 1, Piece_Type.PAWN);

            this._board[0, 2] = new General_Piece(0, this.c1, 0, 2, Piece_Type.EMPTY);
            this._board[1, 2] = new General_Piece(0, this.c2, 1, 2, Piece_Type.EMPTY);
            this._board[2, 2] = new General_Piece(0, this.c3, 2, 2, Piece_Type.EMPTY);
            this._board[3, 2] = new General_Piece(0, this.c4, 3, 2, Piece_Type.EMPTY);
            this._board[4, 2] = new General_Piece(0, this.c5, 4, 2, Piece_Type.EMPTY);
            this._board[5, 2] = new General_Piece(0, this.c6, 5, 2, Piece_Type.EMPTY);
            this._board[6, 2] = new General_Piece(0, this.c7, 6, 2, Piece_Type.EMPTY);
            this._board[7, 2] = new General_Piece(0, this.c8, 7, 2, Piece_Type.EMPTY);

            this._board[0, 3] = new General_Piece(0, this.d1, 0, 3, Piece_Type.EMPTY);
            this._board[1, 3] = new General_Piece(0, this.d2, 1, 3, Piece_Type.EMPTY);
            this._board[2, 3] = new General_Piece(0, this.d3, 2, 3, Piece_Type.EMPTY);
            this._board[3, 3] = new General_Piece(0, this.d4, 3, 3, Piece_Type.EMPTY);
            this._board[4, 3] = new General_Piece(0, this.d5, 4, 3, Piece_Type.EMPTY);
            this._board[5, 3] = new General_Piece(0, this.d6, 5, 3, Piece_Type.EMPTY);
            this._board[6, 3] = new General_Piece(0, this.d7, 6, 3, Piece_Type.EMPTY);
            this._board[7, 3] = new General_Piece(0, this.d8, 7, 3, Piece_Type.EMPTY);

            this._board[0, 4] = new General_Piece(0, this.e1, 0, 4, Piece_Type.EMPTY);
            this._board[1, 4] = new General_Piece(0, this.e2, 1, 4, Piece_Type.EMPTY);
            this._board[2, 4] = new General_Piece(0, this.e3, 2, 4, Piece_Type.EMPTY);
            this._board[3, 4] = new General_Piece(0, this.e4, 3, 4, Piece_Type.EMPTY);
            this._board[4, 4] = new General_Piece(0, this.e5, 4, 4, Piece_Type.EMPTY);
            this._board[5, 4] = new General_Piece(0, this.e6, 5, 4, Piece_Type.EMPTY);
            this._board[6, 4] = new General_Piece(0, this.e7, 6, 4, Piece_Type.EMPTY);
            this._board[7, 4] = new General_Piece(0, this.e8, 7, 4, Piece_Type.EMPTY);

            this._board[0, 5] = new General_Piece(0, this.f1, 0, 5, Piece_Type.EMPTY);
            this._board[1, 5] = new General_Piece(0, this.f2, 1, 5, Piece_Type.EMPTY);
            this._board[2, 5] = new General_Piece(0, this.f3, 2, 5, Piece_Type.EMPTY);
            this._board[3, 5] = new General_Piece(0, this.f4, 3, 5, Piece_Type.EMPTY);
            this._board[4, 5] = new General_Piece(0, this.f5, 4, 5, Piece_Type.EMPTY);
            this._board[5, 5] = new General_Piece(0, this.f6, 5, 5, Piece_Type.EMPTY);
            this._board[6, 5] = new General_Piece(0, this.f7, 6, 5, Piece_Type.EMPTY);
            this._board[7, 5] = new General_Piece(0, this.f8, 7, 5, Piece_Type.EMPTY);

            this._board[0, 6] = new Pawn(2, this.g1, 0, 6, Piece_Type.PAWN);
            this._board[1, 6] = new Pawn(2, this.g2, 1, 6, Piece_Type.PAWN);
            this._board[2, 6] = new Pawn(2, this.g3, 2, 6, Piece_Type.PAWN);
            this._board[3, 6] = new Pawn(2, this.g4, 3, 6, Piece_Type.PAWN);
            this._board[4, 6] = new Pawn(2, this.g5, 4, 6, Piece_Type.PAWN);
            this._board[5, 6] = new Pawn(2, this.g6, 5, 6, Piece_Type.PAWN);
            this._board[6, 6] = new Pawn(2, this.g7, 6, 6, Piece_Type.PAWN);
            this._board[7, 6] = new Pawn(2, this.g8, 7, 6, Piece_Type.PAWN);

            this._board[0, 7] = new Rook(2, this.h1, 0, 7, Piece_Type.EMPTY);
            this._board[1, 7] = new Knight(2, this.h2, 1, 7, Piece_Type.EMPTY);
            this._board[2, 7] = new Bishop(2, this.h3, 2, 7, Piece_Type.EMPTY);
            this._board[3, 7] = new Queen(2, this.h4, 3, 7, Piece_Type.EMPTY);
            this._board[4, 7] = new King(2, this.h5, 4, 7, Piece_Type.EMPTY);
            this._board[5, 7] = new Bishop(2, this.h6, 5, 7, Piece_Type.EMPTY);
            this._board[6, 7] = new Knight(2, this.h7, 6, 7, Piece_Type.EMPTY);
            this._board[7, 7] = new Rook(2, this.h8, 7, 7, Piece_Type.EMPTY);
        }

        private void Game_Form_Load(object sender, EventArgs e)
        {
        }


        private void exit_game_MouseHover(object sender, EventArgs e)
        {
            // change fore color of the text, exit to red. resize the font
            this.exit_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 32);
            this.exit_game.ForeColor = System.Drawing.Color.Red;
        }

        private void exit_game_MouseLeave(object sender, EventArgs e)
        {
            // change fore color of the text, exit to black
            this.exit_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 28);
            this.exit_game.ForeColor = System.Drawing.Color.Black;
        }

        private void exit_game_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gameTime_timer_Tick(object sender, EventArgs e)
        {
            game_Time.Text = hour.ToString()+" : "+min.ToString()+" : "+sec.ToString(); // show the time like -> HOUR:MIN:SEC
            sec++;
            if (sec > 59)       // if the second is over than 60 second...
            {
                min++;  // add 1 to minutes
                sec = 0;    // rest the second
            }
            if (min > 59)       // if the minutes is over than 60 minutes...
            {
                hour++; // add 1 to hours
                min = 0;    // rest the minutes.
            }

        }

        private void a1_Click(object sender, EventArgs e)
        {
            PictureBox picBox_Name = (PictureBox)sender;                     // this variable contain the picutrebox when I press on it in the board.
            if (this.is_Last)
            {
                // remove the backcolor from the past press (first picBox before the change)
                for (int i = 0; i < 8; i++)
                    for (int k = 0; k < 8; k++)
                        this._board[i, k].Delete_Backcolor();
                this.move_Massage += '-' + picBox_Name.Name;
                this.game_Manager.Move(this.move_Massage, e);
                this.is_Last = false;
            }
            else
            {
                if (this.game_Manager.is_own_turn((int)(picBox_Name.Name[1] - 49), (int)(picBox_Name.Name[0] - 97)))      // Check if it's own turn if it's no he show suitable message
                {
                    this.move_Massage = picBox_Name.Name;
                    // This change the backcolor picture box when i press it.
                    if (((int)picBox_Name.Name[0] % 2 == 1 && (int)picBox_Name.Name[1] % 2 == 0) || ((int)picBox_Name.Name[0] % 2 == 0 && (int)picBox_Name.Name[1] % 2 == 1))
                        picBox_Name.BackColor = System.Drawing.Color.LightGoldenrodYellow;            // all white (!) rectangle is odd in y (a,c,d,e,f) and even in x (2,4,6,8) or even in y and odd in x
                    else
                        picBox_Name.BackColor = System.Drawing.Color.SandyBrown;                        // all black (!) rectangle
                    this.possible_Move_List = this.game_Manager.Possible_Move((int)(picBox_Name.Name[1] - 49), (int)(picBox_Name.Name[0] - 97));
                    foreach (Point p in possible_Move_List)
                        this._board[p.X, p.Y].Set_Backcolor();
                    this.is_Last = true;
                }
                else
                    MessageBox.Show("NOW it's not your turn");      //suitable message
            }
        }



    }
    public enum Piece_Type { ROOK, KNIGHT, BISHOP, QUEEN, KING, PAWN, EMPTY };         // This enum make diffrent between all color, instead string
}

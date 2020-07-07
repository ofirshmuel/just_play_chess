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
    public partial class Before_Game_Form : Form
    {


        private Color_Type player1_color;
        private Color_Type player2_color;

        private bool color_player1_is_empty;            // This variable check if the player choose color
        private bool color_player2_is_empty;            // This variable check if the player choose color

        public Before_Game_Form()
        {
            InitializeComponent();
            this.color_player1_is_empty = false;       // because the player doesn't choose any color yet
            this.color_player2_is_empty = false;       // because the player doesn't choose any color yet

        }

        //  ---- Player 1 choose ----
        private void white_player1_Click(object sender, EventArgs e)
        {
            this.color_player1_is_empty = true;         // the player choos any color.
            this.player1_color = Color_Type.WHITE;
            this.white_player1.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.black_player1.FlatAppearance.BorderSize = 0;
            this.blue_player1.FlatAppearance.BorderSize = 0;
            this.red_player1.FlatAppearance.BorderSize = 0;

        }

        private void black_player1_Click(object sender, EventArgs e)
        {
            this.color_player1_is_empty = true;         // the player choos any color.
            this.player1_color = Color_Type.BLACK;
            this.black_player1.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.white_player1.FlatAppearance.BorderSize = 0;
            this.blue_player1.FlatAppearance.BorderSize = 0;
            this.red_player1.FlatAppearance.BorderSize = 0;
        }

        private void blue_player1_Click(object sender, EventArgs e)
        {
            this.color_player1_is_empty = true;         // the player choos any color.
            this.player1_color = Color_Type.BLUE;
            this.blue_player1.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.white_player1.FlatAppearance.BorderSize = 0;
            this.black_player1.FlatAppearance.BorderSize = 0;
            this.red_player1.FlatAppearance.BorderSize = 0;
        }

        private void red_player1_Click(object sender, EventArgs e)
        {
            this.color_player1_is_empty = true;         // the player choos any color.
            this.player1_color = Color_Type.RED;
            this.red_player1.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.black_player1.FlatAppearance.BorderSize = 0;
            this.blue_player1.FlatAppearance.BorderSize = 0;
            this.white_player1.FlatAppearance.BorderSize = 0;
        }

        // ---- player 2 ----
        private void white_player2_Click(object sender, EventArgs e)
        {
            this.color_player2_is_empty = true;         // the player choos any color.
            this.player2_color = Color_Type.WHITE;
            this.white_player2.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.black_player2.FlatAppearance.BorderSize = 0;
            this.blue_player2.FlatAppearance.BorderSize = 0;
            this.red_player2.FlatAppearance.BorderSize = 0;

        }

        private void black_player2_Click(object sender, EventArgs e)
        {
            this.color_player2_is_empty = true;         // the player choos any color.
            this.player2_color = Color_Type.BLACK;
            this.black_player2.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.white_player2.FlatAppearance.BorderSize = 0;
            this.blue_player2.FlatAppearance.BorderSize = 0;
            this.red_player2.FlatAppearance.BorderSize = 0;
        }

        private void blue_player2_Click(object sender, EventArgs e)
        {
            this.color_player2_is_empty = true;         // the player choos any color.
            this.player2_color = Color_Type.BLUE;
            this.blue_player2.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.white_player2.FlatAppearance.BorderSize = 0;
            this.black_player2.FlatAppearance.BorderSize = 0;
            this.red_player2.FlatAppearance.BorderSize = 0;
        }

        private void red_player2_Click(object sender, EventArgs e)
        {
            this.color_player2_is_empty = true;         // the player choos any color.
            this.player2_color = Color_Type.RED;
            this.red_player2.FlatAppearance.BorderSize = 4;       // bold this button

            // cancel the board if it is
            this.black_player2.FlatAppearance.BorderSize = 0;
            this.blue_player2.FlatAppearance.BorderSize = 0;
            this.white_player2.FlatAppearance.BorderSize = 0;
        }

        private void move_to_game_btn_Click(object sender, EventArgs e)
        {
            if (this.player2_name.Text == "" || this.player2_name.Text[0] == ' ' ||
                this.player1_name.Text == "" || this.player1_name.Text[0] == ' ' ||
                !color_player1_is_empty || !color_player2_is_empty ||
                (this.player2_color == this.player1_color))
            {
                MessageBox.Show("Please follow the rules:\n-\tYou must write your name, without space in the begining\n-\tYou must choose your color\n-\tThe color must be diffrent");
            }
            else
            {
                Game_Form game_form_start = new Game_Form(this.player1_name.Text, this.player2_name.Text, this.player1_color, this.player2_color);
                game_form_start.Show();
                this.Hide();
            }

        }

    }
    public enum Color_Type { BLACK, WHITE, BLUE, RED };         // This enum make diffrent between all color, instead string
}

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
    public partial class Main_Menu : System.Windows.Forms.UserControl
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void exit_botton_Click(object sender, EventArgs e)
        {
            Application.Exit();     // exit from the program
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void exit_botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.exit_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit_botton_neg));
        }

        private void exit_botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.exit_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit_botton));
        }

        private void options_botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.options_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_botton_neg));
        }

        private void options_botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.options_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_botton));
        }

        private void high_score_botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.high_score_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.high_score_botton_neg));
        }

        private void high_score_botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.high_score_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.high_score_botton));
        }

        private void play_botton_Click(object sender, EventArgs e)
        {
        }

        private void options_botton_Click(object sender, EventArgs e)
        {
            Options_menu options_menu_form = new Options_menu();        // create the options_menu class
            options_menu_form.Show();       // show the form.
        }

        private void play_botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.play_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play_botton_reg));

        }

        private void play_botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.play_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play_botton));
        }

        private void play_botton_Click_1(object sender, EventArgs e)
        {
            Before_Game_Form before_game_start = new Before_Game_Form();
            before_game_start.Show();
        }

        private void high_score_botton_Click(object sender, EventArgs e)
        {
            High_Score_Form high_score_start = new High_Score_Form();
            high_score_start.Show();
        }
    }
}

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
    public partial class Options_menu : Form
    {
        public Options_menu()
        {
            InitializeComponent();
        }

        private void home_botton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void home_botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.home_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_home_negative));
        }

        private void home_botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.home_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_home));
        }

        private void about_Botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.about_Botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_about_negative));
        }

        private void about_Botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.about_Botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_about));
        }

        private void settings_Botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.settings_Botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_settings_negative));
        }

        private void settings_Botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.settings_Botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_settings));
        }

        private void contact_botton_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.contact_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_contact_negative));
        }

        private void contact_botton_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.contact_botton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_menu_contact));
        }

        private void contact_botton_Click(object sender, EventArgs e)
        {
            Contact_Menu contact_menu_form = new Contact_Menu();
            contact_menu_form.Show();
        }

        private void about_Botton_Click(object sender, EventArgs e)
        {
            About_Menu about_menu_form = new About_Menu();
            about_menu_form.Show();
        }

        
    }
}

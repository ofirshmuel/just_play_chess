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
    public partial class Contact_Menu : Form
    {
        public Contact_Menu()
        {
            InitializeComponent();
        }

        private void return_to_option_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void return_to_option_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.return_to_option.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.contact_menu_return_neg));
        }

        private void return_to_option_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.return_to_option.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.contact_menu_return));
        }
    }
}

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
    public partial class About_Menu : Form
    {
        public About_Menu()
        {
            InitializeComponent();
        }

        private void return_home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void return_home_MouseHover(object sender, EventArgs e)
        {
            // change the color (the background image) when the mouse on the botton.
            this.return_home.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_menu_return_neg));
        }

        private void return_home_MouseLeave(object sender, EventArgs e)
        {
            // return the color (the background image) when the mouse leave the botton.
            this.return_home.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_menu_return));
        }
    }
}

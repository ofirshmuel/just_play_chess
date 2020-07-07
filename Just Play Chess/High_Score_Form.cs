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
    public partial class High_Score_Form : Form
    {
        public High_Score_Form()
        {
            InitializeComponent();
        }

        public High_Score_Form(string winner_Name)
        {
            InitializeComponent();
        }

        private void return_Home_btn_MouseHover(object sender, EventArgs e)
        {

            this.return_Home_btn.BackgroundImage = Properties.Resources.Return_home_btn_neg;
        }

        private void return_Home_btn_MouseLeave(object sender, EventArgs e)
        {

            this.return_Home_btn.BackgroundImage = Properties.Resources.Return_home_btn;
        }

        private void return_Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

    }
}

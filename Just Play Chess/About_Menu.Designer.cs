namespace Just_Play_Chess
{
    partial class About_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Menu));
            this.return_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_home
            // 
            this.return_home.BackColor = System.Drawing.Color.Transparent;
            this.return_home.BackgroundImage = global::Just_Play_Chess.Properties.Resources.about_menu_return;
            this.return_home.FlatAppearance.BorderSize = 0;
            this.return_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.return_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.return_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_home.Location = new System.Drawing.Point(874, 624);
            this.return_home.Name = "return_home";
            this.return_home.Size = new System.Drawing.Size(134, 124);
            this.return_home.TabIndex = 0;
            this.return_home.UseVisualStyleBackColor = false;
            this.return_home.Click += new System.EventHandler(this.return_home_Click);
            this.return_home.MouseLeave += new System.EventHandler(this.return_home_MouseLeave);
            this.return_home.MouseHover += new System.EventHandler(this.return_home_MouseHover);
            // 
            // About_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Just_Play_Chess.Properties.Resources.about_menu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1022, 764);
            this.Controls.Add(this.return_home);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "About_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Play Chess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_home;
    }
}
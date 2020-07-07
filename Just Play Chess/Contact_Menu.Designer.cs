namespace Just_Play_Chess
{
    partial class Contact_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Menu));
            this.return_to_option = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_to_option
            // 
            this.return_to_option.BackColor = System.Drawing.Color.Transparent;
            this.return_to_option.BackgroundImage = global::Just_Play_Chess.Properties.Resources.contact_menu_return;
            this.return_to_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.return_to_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_to_option.FlatAppearance.BorderSize = 0;
            this.return_to_option.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.return_to_option.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.return_to_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_to_option.Location = new System.Drawing.Point(797, -2);
            this.return_to_option.Name = "return_to_option";
            this.return_to_option.Size = new System.Drawing.Size(235, 200);
            this.return_to_option.TabIndex = 0;
            this.return_to_option.UseVisualStyleBackColor = false;
            this.return_to_option.Click += new System.EventHandler(this.return_to_option_Click);
            this.return_to_option.MouseLeave += new System.EventHandler(this.return_to_option_MouseLeave);
            this.return_to_option.MouseHover += new System.EventHandler(this.return_to_option_MouseHover);
            // 
            // Contact_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Just_Play_Chess.Properties.Resources.contact_menu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 762);
            this.Controls.Add(this.return_to_option);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Contact_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Play Chess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_to_option;
    }
}
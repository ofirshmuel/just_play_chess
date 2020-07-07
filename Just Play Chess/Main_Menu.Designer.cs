namespace Just_Play_Chess
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.exit_botton = new System.Windows.Forms.Button();
            this.options_botton = new System.Windows.Forms.Button();
            this.high_score_botton = new System.Windows.Forms.Button();
            this.play_botton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_botton
            // 
            this.exit_botton.BackgroundImage = global::Just_Play_Chess.Properties.Resources.exit_botton;
            this.exit_botton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_botton.Location = new System.Drawing.Point(337, 569);
            this.exit_botton.Name = "exit_botton";
            this.exit_botton.Size = new System.Drawing.Size(353, 58);
            this.exit_botton.TabIndex = 0;
            this.exit_botton.UseVisualStyleBackColor = true;
            this.exit_botton.Click += new System.EventHandler(this.exit_botton_Click);
            this.exit_botton.MouseLeave += new System.EventHandler(this.exit_botton_MouseLeave);
            this.exit_botton.MouseHover += new System.EventHandler(this.exit_botton_MouseHover);
            // 
            // options_botton
            // 
            this.options_botton.BackgroundImage = global::Just_Play_Chess.Properties.Resources.options_botton;
            this.options_botton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.options_botton.Location = new System.Drawing.Point(337, 491);
            this.options_botton.Name = "options_botton";
            this.options_botton.Size = new System.Drawing.Size(353, 57);
            this.options_botton.TabIndex = 1;
            this.options_botton.UseVisualStyleBackColor = true;
            this.options_botton.Click += new System.EventHandler(this.options_botton_Click);
            this.options_botton.MouseLeave += new System.EventHandler(this.options_botton_MouseLeave);
            this.options_botton.MouseHover += new System.EventHandler(this.options_botton_MouseHover);
            // 
            // high_score_botton
            // 
            this.high_score_botton.BackgroundImage = global::Just_Play_Chess.Properties.Resources.high_score_botton;
            this.high_score_botton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.high_score_botton.Location = new System.Drawing.Point(337, 412);
            this.high_score_botton.Name = "high_score_botton";
            this.high_score_botton.Size = new System.Drawing.Size(352, 55);
            this.high_score_botton.TabIndex = 2;
            this.high_score_botton.UseVisualStyleBackColor = true;
            this.high_score_botton.Click += new System.EventHandler(this.high_score_botton_Click);
            this.high_score_botton.MouseLeave += new System.EventHandler(this.high_score_botton_MouseLeave);
            this.high_score_botton.MouseHover += new System.EventHandler(this.high_score_botton_MouseHover);
            // 
            // play_botton
            // 
            this.play_botton.BackColor = System.Drawing.Color.Transparent;
            this.play_botton.BackgroundImage = global::Just_Play_Chess.Properties.Resources.play_botton;
            this.play_botton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play_botton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_botton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.play_botton.FlatAppearance.BorderSize = 0;
            this.play_botton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play_botton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play_botton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_botton.Location = new System.Drawing.Point(105, 205);
            this.play_botton.Name = "play_botton";
            this.play_botton.Size = new System.Drawing.Size(227, 216);
            this.play_botton.TabIndex = 3;
            this.play_botton.UseVisualStyleBackColor = false;
            this.play_botton.Click += new System.EventHandler(this.play_botton_Click_1);
            this.play_botton.MouseLeave += new System.EventHandler(this.play_botton_MouseLeave);
            this.play_botton.MouseHover += new System.EventHandler(this.play_botton_MouseHover);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Just_Play_Chess.Properties.Resources.Main_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 676);
            this.Controls.Add(this.play_botton);
            this.Controls.Add(this.high_score_botton);
            this.Controls.Add(this.options_botton);
            this.Controls.Add(this.exit_botton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Play Chess";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_botton;
        private System.Windows.Forms.Button options_botton;
        private System.Windows.Forms.Button high_score_botton;
        private System.Windows.Forms.Button play_botton;
    }
}


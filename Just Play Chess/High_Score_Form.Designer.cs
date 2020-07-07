namespace Just_Play_Chess
{
    partial class High_Score_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(High_Score_Form));
            this.return_Home_btn = new System.Windows.Forms.Button();
            this.name_1 = new System.Windows.Forms.Label();
            this.name_2 = new System.Windows.Forms.Label();
            this.name_3 = new System.Windows.Forms.Label();
            this.score_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // return_Home_btn
            // 
            this.return_Home_btn.BackColor = System.Drawing.Color.Transparent;
            this.return_Home_btn.BackgroundImage = global::Just_Play_Chess.Properties.Resources.Return_home_btn;
            this.return_Home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.return_Home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_Home_btn.FlatAppearance.BorderSize = 0;
            this.return_Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_Home_btn.ForeColor = System.Drawing.Color.Transparent;
            this.return_Home_btn.Location = new System.Drawing.Point(852, -2);
            this.return_Home_btn.Name = "return_Home_btn";
            this.return_Home_btn.Size = new System.Drawing.Size(171, 146);
            this.return_Home_btn.TabIndex = 0;
            this.return_Home_btn.UseVisualStyleBackColor = false;
            this.return_Home_btn.Click += new System.EventHandler(this.return_Home_btn_Click);
            this.return_Home_btn.MouseLeave += new System.EventHandler(this.return_Home_btn_MouseLeave);
            this.return_Home_btn.MouseHover += new System.EventHandler(this.return_Home_btn_MouseHover);
            // 
            // name_1
            // 
            this.name_1.AutoSize = true;
            this.name_1.BackColor = System.Drawing.Color.Transparent;
            this.name_1.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_1.Location = new System.Drawing.Point(330, 323);
            this.name_1.Name = "name_1";
            this.name_1.Size = new System.Drawing.Size(172, 48);
            this.name_1.TabIndex = 1;
            this.name_1.Text = "Name 1";
            // 
            // name_2
            // 
            this.name_2.AutoSize = true;
            this.name_2.BackColor = System.Drawing.Color.Transparent;
            this.name_2.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_2.Location = new System.Drawing.Point(330, 442);
            this.name_2.Name = "name_2";
            this.name_2.Size = new System.Drawing.Size(182, 48);
            this.name_2.TabIndex = 2;
            this.name_2.Text = "Name 2";
            // 
            // name_3
            // 
            this.name_3.AutoSize = true;
            this.name_3.BackColor = System.Drawing.Color.Transparent;
            this.name_3.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_3.Location = new System.Drawing.Point(330, 557);
            this.name_3.Name = "name_3";
            this.name_3.Size = new System.Drawing.Size(184, 48);
            this.name_3.TabIndex = 3;
            this.name_3.Text = "Name 3";
            // 
            // score_1
            // 
            this.score_1.AutoSize = true;
            this.score_1.BackColor = System.Drawing.Color.Transparent;
            this.score_1.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_1.ForeColor = System.Drawing.Color.Red;
            this.score_1.Location = new System.Drawing.Point(799, 323);
            this.score_1.Name = "score_1";
            this.score_1.Size = new System.Drawing.Size(52, 48);
            this.score_1.TabIndex = 4;
            this.score_1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(799, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(799, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // High_Score_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Just_Play_Chess.Properties.Resources.High_Score_Form_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1022, 765);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score_1);
            this.Controls.Add(this.name_3);
            this.Controls.Add(this.name_2);
            this.Controls.Add(this.name_1);
            this.Controls.Add(this.return_Home_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "High_Score_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_Home_btn;
        private System.Windows.Forms.Label name_1;
        private System.Windows.Forms.Label name_2;
        private System.Windows.Forms.Label name_3;
        private System.Windows.Forms.Label score_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace final_proj
{
    partial class Main
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_learn = new System.Windows.Forms.Button();
            this.btn_trivia = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_shape_play = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(295, 52);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(107, 31);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "welcom";
            // 
            // btn_learn
            // 
            this.btn_learn.BackColor = System.Drawing.SystemColors.Info;
            this.btn_learn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_learn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_learn.Location = new System.Drawing.Point(150, 106);
            this.btn_learn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_learn.Name = "btn_learn";
            this.btn_learn.Size = new System.Drawing.Size(143, 101);
            this.btn_learn.TabIndex = 1;
            this.btn_learn.Text = "learn";
            this.btn_learn.UseVisualStyleBackColor = false;
            this.btn_learn.Click += new System.EventHandler(this.btn_learn_Click);
            // 
            // btn_trivia
            // 
            this.btn_trivia.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trivia.Location = new System.Drawing.Point(415, 106);
            this.btn_trivia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_trivia.Name = "btn_trivia";
            this.btn_trivia.Size = new System.Drawing.Size(143, 101);
            this.btn_trivia.TabIndex = 2;
            this.btn_trivia.Text = "trivia";
            this.btn_trivia.UseVisualStyleBackColor = true;
            this.btn_trivia.Click += new System.EventHandler(this.btn_trivia_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(150, 253);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(143, 101);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_shape_play
            // 
            this.btn_shape_play.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shape_play.Location = new System.Drawing.Point(415, 253);
            this.btn_shape_play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_shape_play.Name = "btn_shape_play";
            this.btn_shape_play.Size = new System.Drawing.Size(143, 101);
            this.btn_shape_play.TabIndex = 4;
            this.btn_shape_play.Text = "shape game";
            this.btn_shape_play.UseVisualStyleBackColor = true;
            this.btn_shape_play.Click += new System.EventHandler(this.btn_shape_play_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_logout.Location = new System.Drawing.Point(51, 48);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(96, 35);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "log out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final_proj.Properties.Resources.background__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 440);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_shape_play);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_trivia);
            this.Controls.Add(this.btn_learn);
            this.Controls.Add(this.lbl_welcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_learn;
        private System.Windows.Forms.Button btn_trivia;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_shape_play;
        private System.Windows.Forms.Button btn_logout;
    }
}
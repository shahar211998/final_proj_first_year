namespace final_proj
{
    partial class learn_frm
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
            this.lbl_learn_frm = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.pcb_shape_pic = new System.Windows.Forms.PictureBox();
            this.lbl_content = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_shape_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_learn_frm
            // 
            this.lbl_learn_frm.AutoSize = true;
            this.lbl_learn_frm.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_learn_frm.Location = new System.Drawing.Point(382, 9);
            this.lbl_learn_frm.Name = "lbl_learn_frm";
            this.lbl_learn_frm.Size = new System.Drawing.Size(204, 44);
            this.lbl_learn_frm.TabIndex = 0;
            this.lbl_learn_frm.Text = "learn is fun";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(790, 448);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(143, 50);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(78, 448);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(143, 50);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "previous ";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // pcb_shape_pic
            // 
            this.pcb_shape_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcb_shape_pic.Location = new System.Drawing.Point(343, 81);
            this.pcb_shape_pic.Name = "pcb_shape_pic";
            this.pcb_shape_pic.Size = new System.Drawing.Size(375, 307);
            this.pcb_shape_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_shape_pic.TabIndex = 3;
            this.pcb_shape_pic.TabStop = false;
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_content.Location = new System.Drawing.Point(285, 412);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(0, 24);
            this.lbl_content.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // learn_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 573);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_content);
            this.Controls.Add(this.pcb_shape_pic);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_learn_frm);
            this.Name = "learn_frm";
            this.Text = "learn_frm";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_shape_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_learn_frm;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.PictureBox pcb_shape_pic;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Button btn_back;
    }
}
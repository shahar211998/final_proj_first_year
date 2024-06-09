namespace final_proj
{
    partial class trivia_frm
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pcb_question = new System.Windows.Forms.PictureBox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_false = new System.Windows.Forms.Button();
            this.btn_true = new System.Windows.Forms.Button();
            this.btn_submmit = new System.Windows.Forms.Button();
            this.rdbtn3 = new System.Windows.Forms.RadioButton();
            this.rdbtn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_feedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_question)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(52, 39);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 53);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_previous.Location = new System.Drawing.Point(52, 462);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(4);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(180, 69);
            this.btn_previous.TabIndex = 3;
            this.btn_previous.Text = "PREVIOUS";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Visible = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click_1);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_next.Location = new System.Drawing.Point(758, 462);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(180, 69);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click_1);
            // 
            // pcb_question
            // 
            this.pcb_question.Location = new System.Drawing.Point(272, 53);
            this.pcb_question.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_question.Name = "pcb_question";
            this.pcb_question.Size = new System.Drawing.Size(369, 249);
            this.pcb_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_question.TabIndex = 5;
            this.pcb_question.TabStop = false;
            this.pcb_question.Visible = false;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_question.Location = new System.Drawing.Point(127, 304);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(0, 39);
            this.lbl_question.TabIndex = 6;
            // 
            // btn_false
            // 
            this.btn_false.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_false.Location = new System.Drawing.Point(468, 462);
            this.btn_false.Margin = new System.Windows.Forms.Padding(4);
            this.btn_false.Name = "btn_false";
            this.btn_false.Size = new System.Drawing.Size(121, 49);
            this.btn_false.TabIndex = 9;
            this.btn_false.Text = "FALSE";
            this.btn_false.UseVisualStyleBackColor = true;
            this.btn_false.Visible = false;
            this.btn_false.Click += new System.EventHandler(this.btn_false_Click_1);
            // 
            // btn_true
            // 
            this.btn_true.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_true.Location = new System.Drawing.Point(339, 462);
            this.btn_true.Margin = new System.Windows.Forms.Padding(4);
            this.btn_true.Name = "btn_true";
            this.btn_true.Size = new System.Drawing.Size(121, 49);
            this.btn_true.TabIndex = 10;
            this.btn_true.Text = "TRUE";
            this.btn_true.UseVisualStyleBackColor = true;
            this.btn_true.Visible = false;
            this.btn_true.Click += new System.EventHandler(this.btn_true_Click_1);
            // 
            // btn_submmit
            // 
            this.btn_submmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_submmit.Location = new System.Drawing.Point(375, 451);
            this.btn_submmit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submmit.Name = "btn_submmit";
            this.btn_submmit.Size = new System.Drawing.Size(160, 70);
            this.btn_submmit.TabIndex = 14;
            this.btn_submmit.Text = "SUBMMIIT";
            this.btn_submmit.UseVisualStyleBackColor = true;
            this.btn_submmit.Visible = false;
            this.btn_submmit.Click += new System.EventHandler(this.btn_submmit_Click_1);
            // 
            // rdbtn3
            // 
            this.rdbtn3.AutoSize = true;
            this.rdbtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbtn3.Location = new System.Drawing.Point(402, 403);
            this.rdbtn3.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn3.Name = "rdbtn3";
            this.rdbtn3.Size = new System.Drawing.Size(143, 29);
            this.rdbtn3.TabIndex = 17;
            this.rdbtn3.TabStop = true;
            this.rdbtn3.Text = "radioButton3";
            this.rdbtn3.UseVisualStyleBackColor = true;
            this.rdbtn3.Visible = false;
            // 
            // rdbtn2
            // 
            this.rdbtn2.AutoSize = true;
            this.rdbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbtn2.Location = new System.Drawing.Point(402, 377);
            this.rdbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn2.Name = "rdbtn2";
            this.rdbtn2.Size = new System.Drawing.Size(143, 29);
            this.rdbtn2.TabIndex = 16;
            this.rdbtn2.TabStop = true;
            this.rdbtn2.Text = "radioButton2";
            this.rdbtn2.UseVisualStyleBackColor = true;
            this.rdbtn2.Visible = false;
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbtn1.Location = new System.Drawing.Point(402, 350);
            this.rdbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(143, 29);
            this.rdbtn1.TabIndex = 15;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "radioButton1";
            this.rdbtn1.UseVisualStyleBackColor = true;
            this.rdbtn1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "let\'s play !!";
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoEllipsis = true;
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.BackColor = System.Drawing.Color.Chartreuse;
            this.lbl_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_feedback.Location = new System.Drawing.Point(779, 211);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(128, 44);
            this.lbl_feedback.TabIndex = 19;
            this.lbl_feedback.Text = "label2";
            // 
            // trivia_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 581);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtn3);
            this.Controls.Add(this.rdbtn2);
            this.Controls.Add(this.rdbtn1);
            this.Controls.Add(this.btn_submmit);
            this.Controls.Add(this.btn_true);
            this.Controls.Add(this.btn_false);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.pcb_question);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_back);
            this.Name = "trivia_frm";
            this.Text = "trivia_frm";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pcb_question;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button btn_false;
        private System.Windows.Forms.Button btn_true;
        private System.Windows.Forms.Button btn_submmit;
        private System.Windows.Forms.RadioButton rdbtn3;
        private System.Windows.Forms.RadioButton rdbtn2;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_feedback;
    }
}
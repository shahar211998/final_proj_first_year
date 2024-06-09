using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace final_proj
{
    public partial class trivia_frm : Form
    {
        ArrayList trivia_list = new ArrayList();
        string[] tmp_arr;
        user user_tmp;
        int[] qArr = new int[8];

        //events
        public trivia_frm(user player)
        {
            InitializeComponent();
            user_tmp = player;
            StreamReader sr2 = new StreamReader("gameData.txt");
            while (!sr2.EndOfStream)
            {
                tmp_arr = sr2.ReadLine().Split(';');
                switch (int.Parse(tmp_arr[1])) //Convert.ToBoolean מצאנו באינטרנט את ההמרה
                {
                    case 0:
                        {
                            true_or_false tmp_q = new true_or_false(int.Parse(tmp_arr[0]), (game_type)int.Parse(tmp_arr[1]), tmp_arr[2], Convert.ToBoolean(int.Parse(tmp_arr[3])));
                            trivia_list.Add(tmp_q);
                        }
                        break;
                    case 1:
                        {
                            multi_choice tmp_m = new multi_choice(int.Parse(tmp_arr[0]), (game_type)int.Parse(tmp_arr[1]), tmp_arr[2], tmp_arr[3], tmp_arr[4], tmp_arr[5]);
                            trivia_list.Add(tmp_m);
                        }
                        break;
                    case 2:
                        {
                            true_or_false_with_pic tmp_qp = new true_or_false_with_pic(int.Parse(tmp_arr[0]), (game_type)int.Parse(tmp_arr[1]), tmp_arr[2], Convert.ToBoolean(int.Parse(tmp_arr[3])), tmp_arr[5]);
                            trivia_list.Add(tmp_qp);
                        }
                        break;
                    case 3:
                        {
                            multi_choice_with_pic tmp_mp = new multi_choice_with_pic(int.Parse(tmp_arr[0]), (game_type)int.Parse(tmp_arr[1]), tmp_arr[2], tmp_arr[3], tmp_arr[4], tmp_arr[5], tmp_arr[6]);
                            trivia_list.Add(tmp_mp);
                        }
                        break;
                    default:
                        break;
                }// end switch
            }// end while
            sr2.Close();

            Random rnd = new Random();
            int rand_num;
            for (int i = 0; i < 8; i++)//check if the index is already exist
            {
                rand_num = rnd.Next(0, trivia_list.Count);
                if (Array.IndexOf(qArr, rand_num) == -1) { qArr[i] = rand_num; }
                else { i--; }
            }
        }

        int i = 0;

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            // מעבר לשאלה הבאה 
            cleaner();
            lbl_feedback.Text = "";
            lbl_feedback.Visible = false;
            if (i == 7)
            {
                pcb_question.Visible = false;
                lbl_question.Visible = false;
                btn_next.Visible = false;
                lbl_feedback.Visible = true;
                lbl_feedback.Text = "finish";
            }
            if (i == qArr.Length - 1) { return; }
            ++i;
            pcb_question.Visible = false;
            lbl_question.Text = ((question)trivia_list[qArr[i]]).get_only_question();
            if (trivia_list[qArr[i]] is true_or_false_with_pic)
            {
                tf_question();
                pcb_question.Visible = true;
                pcb_question.ImageLocation = @"QIMAGES\" + ((true_or_false_with_pic)trivia_list[qArr[i]]).get_image_location() + ".PNG";
            }
            else if (trivia_list[qArr[i]] is true_or_false)
            {
                tf_question();
            }
            else if (trivia_list[qArr[i]] is multi_choice_with_pic)
            {
                mc_questions();
                pcb_question.Visible = true;
                pcb_question.ImageLocation = @"QIMAGES\" + ((multi_choice_with_pic)trivia_list[qArr[i]]).get_image_location() + ".PNG";
            }
            else { mc_questions(); }
        }

        private void btn_previous_Click_1(object sender, EventArgs e)
        {
            // פונקציה שמחזירה לשאלה הקודמת נועדה בשביל בדיקות ולא בשביל המשתמש
            if (i == 0) { return; }
            pcb_question.Visible = false;
            i--;
            if (trivia_list[qArr[i]] is true_or_false_with_pic)
            {
                pcb_question.Visible = true;
                pcb_question.ImageLocation = @"QIMAGES\" + ((true_or_false_with_pic)trivia_list[qArr[i]]).get_image_location() + ".PNG";
            }
            else if (trivia_list[qArr[i]] is multi_choice_with_pic)
            {
                pcb_question.Visible = true;
                pcb_question.ImageLocation = @"QIMAGES\" + ((multi_choice_with_pic)trivia_list[qArr[i]]).get_image_location() + ".PNG";
            }
            lbl_question.Text = trivia_list[qArr[i]].ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // חזרה לטפריט
            Main m_frm = new Main(user_tmp);
            this.Hide();
            m_frm.Show();
        }

        private void btn_true_Click_1(object sender, EventArgs e)
        {
            // אמת- שאלת אמת או שקר
            if (((true_or_false)trivia_list[qArr[i]]).get_answer() == true)
            {
                lbl_feedback.Text = "correct !!";
                cleaner();
                return;
            }
            else
            {
                lbl_feedback.Text = "incorrect !";
                cleaner();
                return;
            }
        }
        private void btn_false_Click_1(object sender, EventArgs e)
        {
            // שקר- שאלות אמת או שקר
            if (((true_or_false)trivia_list[qArr[i]]).get_answer() == false)
            {
                lbl_feedback.Text = "correct !!";
                cleaner();
                return;
            }
            else
            {
                lbl_feedback.Text = "incorrect !";
                cleaner();
                return;
            }
        }
        private void btn_submmit_Click_1(object sender, EventArgs e)
        {
            // פונקציה שבודקת האם התשובה שסומנה בשאלת ריבוי תשובות נכונה
            if (rdbtn1.Checked && rdbtn1.Text == ((multi_choice)trivia_list[qArr[i]]).get_correct_ans())
            {
                sbmmit_ans();
                return;
            }
            if (rdbtn2.Checked && rdbtn2.Text == ((multi_choice)trivia_list[qArr[i]]).get_correct_ans())
            {
                sbmmit_ans();
                return;
            }
            if (rdbtn3.Checked && rdbtn3.Text == ((multi_choice)trivia_list[qArr[i]]).get_correct_ans())
            {
                sbmmit_ans();
                return;
            }
            else
            {
                lbl_feedback.Visible = true;
                lbl_feedback.Text = "incorrect !";
                cleaner();
                return;
            }
        }
        
        //functions
        void tf_question()
        {
            // הפעלת הפקדים לשאלות נכון או לא נכון
            btn_next.Visible = false;
            lbl_feedback.Visible = true;
            btn_true.Visible = true;
            btn_false.Visible = true;
        }

        void mc_questions()
        {
            // הפעלת הפקדים לשאלות ריבוי בחירה
            btn_next.Visible = false;
            btn_submmit.Visible = true;
            rdbtn1.Visible = true;
            rdbtn2.Visible = true;
            rdbtn3.Visible = true;

            string[] ans = ((multi_choice)trivia_list[qArr[i]]).blendanswers();
            rdbtn1.Text = ans[0];
            rdbtn2.Text = ans[1];
            rdbtn3.Text = ans[2];
        }

        void cleaner()
        {
            // מחזיר את דף השאלה למצב הטבעי
            btn_next.Visible = true;
            btn_true.Visible = false;
            btn_false.Visible = false;
            btn_submmit.Visible = false;
            rdbtn1.Visible = false;
            rdbtn2.Visible = false;
            rdbtn3.Visible = false;
        }

        void sbmmit_ans()
        {
            // פונקציית עזר ל"סבמיט" כדי לחסוך בשכפול קוד
            lbl_feedback.Visible = true;
            lbl_feedback.Text = "correct !!";
            cleaner();
            return;
        }        
    }
}



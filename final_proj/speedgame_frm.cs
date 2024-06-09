using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace final_proj
{
    public partial class speedgame_frm : Form
    {
        int tick = 20, res;
        ArrayList shape_list = new ArrayList();     
        string[] tmp_arr;
        int[] qArr = new int[8];
        user tmp_user;
        
        // events
        public speedgame_frm(user player)
        {
            InitializeComponent();
            tmp_user = player;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            shuffle();
            timer1.Start();
            btn_start.Visible = false;
            gameshow();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick--;
            lbl_sec.Text = tick.ToString();
            if (tick == -1)
            {
                timer1.Stop();
                tick = 20;
                lbl_sec.Text = "20";
                lbl_question.Text = "time is up!";
                gameconseal();
                lbl_question.Visible = true;

            }
        }

        //functions
        void shuffle()
        {
            StreamReader sr2 = new StreamReader("speedgame.txt");
            while (!sr2.EndOfStream)
            {
                tmp_arr = sr2.ReadLine().Split(';');
                speedshape tmp_spds = new speedshape(int.Parse(tmp_arr[0]), int.Parse(tmp_arr[1]), tmp_arr[2]);
                shape_list.Add(tmp_spds);
            }
            Random rnd = new Random();
            int rand_num;
            for (int i = 0; i < 8; i++)//check if the index is already exist
            {
                rand_num = rnd.Next(0, shape_list.Count);
                if (Array.IndexOf(qArr, rand_num) == -1) { qArr[i] = rand_num; }
                else { i--; }
            }
            picspread();

            int count = 0;
            rand_num = rnd.Next(3, 7);
            for (int i = 0; i < 8; i++)
            {
                if (rand_num == ((speedshape)shape_list[qArr[i]]).getshape()) { count++; }
            }
            lbl_question.Text = " ?כמה " + numtoshape(rand_num) + " מופיעים ";
            res = count;
        }

        void picspread()
        {
            // מפזר את התמונות באקראי על המסך
            pictureBox1.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[0]]).getimagelocation() + ".PNG";
            pictureBox2.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[1]]).getimagelocation() + ".PNG";
            pictureBox3.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[2]]).getimagelocation() + ".PNG";
            pictureBox4.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[3]]).getimagelocation() + ".PNG";
            pictureBox5.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[4]]).getimagelocation() + ".PNG";
            pictureBox6.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[5]]).getimagelocation() + ".PNG";
            pictureBox7.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[6]]).getimagelocation() + ".PNG";
            pictureBox8.ImageLocation = @"QIMAGES\" + ((speedshape)shape_list[qArr[7]]).getimagelocation() + ".PNG";            
        }

        private void btn_submmit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tick = 20;
            btn_start.Visible = true;
            txt_res.Visible = false;
            btn_submmit.Visible = false;
            if (res == int.Parse(txt_res.Text)) { lbl_question.Text = "correct !!"; }
            else { lbl_question.Text = "incorrect"; }
        }
        
        void gameshow()
        {
            // מגלה את המשחק
            btn_start.Visible = false;
            txt_res.Visible = true;
            btn_submmit.Visible = true;
            lbl_question.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
        }

        void gameconseal()
        {
            // מסתיר את המשחק
            btn_start.Visible = true;
            txt_res.Visible = false;
            btn_submmit.Visible = false;
            lbl_question.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shape_game_frm sp_frm = new shape_game_frm(tmp_user);
            this.Hide();
            sp_frm.Show();
        }

        string numtoshape(int num)
        {
            switch (num)
            {
                case 3:
                    return "משולשים";                    
                case 4:
                    return "מרובעים";                   
                case 5:
                    return "מחומשים";                                        
                case 6:
                    return "משושים";                                
                default:
                    return "";
            }
        }
        
    }
}

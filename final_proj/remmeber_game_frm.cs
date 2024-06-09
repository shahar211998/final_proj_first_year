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
    public partial class remmeber_game_frm : Form
    {
        user user_tmp;
        ArrayList shapes_with_pic = new ArrayList();
        const int sec = 200, try1 = 5, score = 0;
        int tick = sec, gueses = try1;
        public remmeber_game_frm(user player)
        {
            user_tmp = player;
            InitializeComponent();
            shapes_with_pic = read_text("remmember_game.txt");//מחזיר מערך של צורות בלות תמונות של צורות
            initial_game();
            timer_remmember.Start();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            shape_game_frm sp_frm = new shape_game_frm(user_tmp);
            this.Hide();
            sp_frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick--;
            if (tick > 0)
            {
                lbl_time_left.Text = "time has left: " + tick.ToString();
            }
            else
            {
                // youLose();
            }
            if (tick % 2 == 0)
            {
               // this.BackColor = System.Drawing.Color.Blue;
            }
            else
            {
                //this.BackColor = System.Drawing.Color.Pink;
            }
        }

        private void pb_cover1_Click(object sender, EventArgs e)
        {
            pb_cover1.Visible = false;
        }

        private void pb_cover2_Click(object sender, EventArgs e)
        {
            pb_cover2.Visible = false;
        }

        private void pb_cover3_Click(object sender, EventArgs e)
        {
            pb_cover3.Visible = false;
        }

        private void pb_cover4_Click(object sender, EventArgs e)
        {
            pb_cover4.Visible = false;
        }

        private void pb_cover5_Click(object sender, EventArgs e)
        {
            pb_cover5.Visible = false;
        }

        private void pb_cover6_Click(object sender, EventArgs e)
        {
            pb_cover6.Visible = false;
        }

        private void initial_game()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 10);
            label1.Text = shapes_with_pic[0].ToString();
            pb_quesion1.ImageLocation = @"DIMAGES\" + ((info_data_with_pic)shapes_with_pic[number]).get_image_location() + ".png";
            number = rnd.Next(0, 10);
            pb_quesion2.ImageLocation = @"DIMAGES\" + ((info_data_with_pic)shapes_with_pic[number]).get_image_location() + ".png";        
            number = rnd.Next(0, 10);
            pb_quesion3.ImageLocation = @"DIMAGES\" + ((info_data_with_pic)shapes_with_pic[number]).get_image_location() + ".png";
            pb_quesion4.ImageLocation = @"DIMAGES\" + ((info_data_with_pic)shapes_with_pic[number]).get_image_location_of_two_pic() + "png";
            cover_all();
            
        }
        private void cover_all()//לכסות את כל הכרטיסיות
        {
            pb_cover1.Visible = true;
            pb_cover2.Visible = true;
            pb_cover3.Visible = true;
            pb_cover4.Visible = true;
            pb_cover5.Visible = true;
            pb_cover6.Visible = true;
        }
        static ArrayList read_text(string address)//מקבל כתובת של מידע על צורות ומחזיר את הצורות שלהן יש תמונות(מחזיר רק את כתובת התמונה ואת השם)
        {
            ArrayList shapes_with_pic = new ArrayList();
            string[] tmp_arr;
            StreamReader sr2 = new StreamReader(address);
            while (!sr2.EndOfStream)//ליצור מערך בעל צורות בעלי תמונות
            {
                tmp_arr = sr2.ReadLine().Split(';');

                info_data_with_pic tmp_info_data_with_pic = new info_data_with_pic(tmp_arr[0], tmp_arr[1]);//רק תמונה ושם
                shapes_with_pic.Add(tmp_info_data_with_pic);
            }
            return shapes_with_pic;
        }
    }
}


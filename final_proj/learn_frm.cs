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
    
    public partial class learn_frm : Form
    {
        ArrayList content_list = new ArrayList();
        int i = 0;
        user tmp_user;     
        string[] tmp_arr;
        public learn_frm(user player)
        {
            tmp_user = player;
            InitializeComponent();
            StreamReader sr2 = new StreamReader("infoData.txt");
            while (!sr2.EndOfStream)
            {
                tmp_arr = sr2.ReadLine().Split(';');
                if(tmp_arr.Length==4)
                {
                    info_data_with_pic tmp_info_data_with_pic = new info_data_with_pic(int.Parse(tmp_arr[0]), tmp_arr[1], tmp_arr[2],tmp_arr[3]);
                    content_list.Add(tmp_info_data_with_pic);
                    
                    
                }
                else
                {
                    info_data tmp_info_data = new info_data(int.Parse(tmp_arr[0]), tmp_arr[1], tmp_arr[2]);
                    content_list.Add(tmp_info_data);
                }
            }
            sr2.Close();        
        }
       
        private void btn_next_Click(object sender, EventArgs e)
        {
            pcb_shape_pic.Visible = false;
            if (i == content_list.Count -1)
            {
                return;
            }
            ++i;
            lbl_content.Text = content_list[i].ToString();
            
            if (content_list[i] is info_data_with_pic)
            {
                pcb_shape_pic.ImageLocation = @"DIMAGES\" + ((info_data_with_pic)content_list[i]).get_image_location() + ".png";
                pcb_shape_pic.Visible = true;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            pcb_shape_pic.Visible = false;
            if (i == 0)
            {
                return;
            }
            i--;
            if (content_list[i] is info_data_with_pic)
            {
                pcb_shape_pic.ImageLocation = @"DIMAGES\" + ((info_data_with_pic)content_list[i]).get_image_location() + ".png";
                pcb_shape_pic.Visible = true;
            }
            lbl_content.Text = content_list[i].ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main m_frm = new Main(tmp_user);
            this.Hide();
            m_frm.Show();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_proj
{
    
    public partial class Main : Form
    {
        user tmp_user;
        public Main(user player)
        {
            InitializeComponent();
            lbl_welcome.Text = lbl_welcome.Text + " " + player.Name;
            tmp_user = player;
            btn_logout.Text += " " + player.Name;
        }

        private void btn_learn_Click(object sender, EventArgs e)
        {
            learn_frm l_frm = new learn_frm(tmp_user);
            this.Hide();
            l_frm.Show();
        }

        private void btn_trivia_Click(object sender, EventArgs e)
        {
            trivia_frm t_frm = new trivia_frm(tmp_user);
            this.Hide();
            t_frm.Show();
        }

        private void btn_shape_play_Click(object sender, EventArgs e)
        {
            shape_game_frm sg_frm = new shape_game_frm(tmp_user);
            this.Hide();
            sg_frm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}

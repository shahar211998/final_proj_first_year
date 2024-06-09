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
    public partial class shape_game_frm : Form
    {
        user user_tmp;
        public shape_game_frm(user player)
        {
            InitializeComponent();
            user_tmp = player;
            lbl_headline.Text = player.Name+" "+ lbl_headline.Text;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main m_frm = new Main(user_tmp);
            this.Hide();
            m_frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            remmeber_game_frm rb_frm = new remmeber_game_frm(user_tmp);
            this.Hide();
            rb_frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            speedgame_frm spdg_frm = new speedgame_frm(user_tmp);
            this.Hide();
            spdg_frm.Show();
        }
    }
}

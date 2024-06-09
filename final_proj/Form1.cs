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

    public partial class Form1 : Form
    {
        List<user> users_list = new List<user>();// רשימה של משתמשים קיימים
        user new_user = new user();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)// לאחר לחיצת סיום, אננו מאמתים את הפרטים , בודקים אם משתמש קיים או לא ומוסיפים במידת הצורך
        {
            
            //if (txt_email.Text=="" ||txt_username.Text=="")
            //{
            //    MessageBox.Show("need to fill up all the info");
            //    return;
            //}
            //if(email_Check(txt_email.Text)==false)
            //{
            //    MessageBox.Show("wrong email structure, try again!");
            //    return;
            //}
            for (int i = 0; i < users_list.Count; i++)
            {
                if (users_list[i].Name == txt_username.Text && users_list[i].Email == txt_email.Text)//בדיקה אם משתמש כבר קיים 
                {
                    MessageBox.Show("welcome back " + txt_username.Text + " " + txt_email.Text);
                    Main main_exist_user = new Main(users_list[i]);
                    this.Hide();
                    main_exist_user.Show();
                    return;
                }
            }
            StreamWriter sw = new StreamWriter("registers.txt", true);//כתיבה ושמירת פרטי המשתמש בקובץ של רשומים
            sw.WriteLine(txt_username.Text+"-"+txt_email.Text);
            sw.Close();
            new_user.Name = txt_username.Text;
            new_user.Email = txt_email.Text;
            users_list.Add(new_user);// הוספת משתמש חדש לרשימת המשתמשים הקיימים 
            Main main_new_user = new Main(new_user);// שליחת המשתמש לאחר דף הכניסה אל הדף הראשי לשאר האופיצות
            this.Hide();
            main_new_user.Show();
            
        }
        static bool email_Check(string email)// בדקית תקינות המייל
        {
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    for (int j = i; j < email.Length; j++)
                    {
                        if (email[j] == '.')
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}

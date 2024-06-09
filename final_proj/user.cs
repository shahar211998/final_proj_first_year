using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_proj
{
    public class user
    {
        private string name;
        private string email;

        public user()
        {
            this.name = "null";
            this.email = "null";
        }
        public user(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
    }

    public class speedshape
    {
        // מחלקה למשחק המהירות
        int uniqe_num;
        int shape_type;
        string pic;

        public speedshape(int uniqe_num, int shape_type, string pic)
        {
            this.uniqe_num = uniqe_num;
            this.shape_type = shape_type;
            this.pic = pic;
        }

        public string getimagelocation() { return pic; }    
        public int getshape() { return shape_type; }
    }
}

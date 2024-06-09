using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_proj
{
    class true_or_false_with_pic : true_or_false
    {

        protected string pic_address;

        public true_or_false_with_pic(int q_number, game_type kind_of_game, string riddle, bool correct_answer, string pic_address) : base(q_number, kind_of_game, riddle, correct_answer)
        {
            Pic_address = pic_address;
        }
        protected string Pic_address { get => pic_address; set => pic_address = value; }

        public override string ToString()
        {
            return base.ToString();
        }
        public string get_image_location()
        {
            return pic_address;
        }

        public override bool get_answer()
        {
            return Correct_answer;
        }

    }
}

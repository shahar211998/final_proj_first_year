using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_proj
{
    class multi_choice_with_pic : multi_choice
    {
        private string pic_address;
        public multi_choice_with_pic(int q_number, game_type kind_of_game, string riddle, string correct_answer, string incorrect_answer_1, string incorrect_answer_2, string pic_address) : base(q_number, kind_of_game, riddle, correct_answer, incorrect_answer_1, incorrect_answer_2)
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


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_proj
{
    class true_or_false : question
    {
        private bool correct_answer;

        public true_or_false(int q_number, game_type kind_of_game, string riddle, bool correct_anser) : base(q_number, kind_of_game, riddle)
        {
            Correct_answer = correct_anser;
        }
        public bool Correct_answer { get => correct_answer; set => correct_answer = value; }

        public override string ToString()
        {
            return base.ToString() + "the right anser is: '" + correct_answer + "'";
        }

        public virtual bool get_answer()
        {
            return Convert.ToBoolean(Correct_answer);
        }
    }
}

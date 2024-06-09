using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_proj
{
    class multi_choice : question
    {
        private string correct_answer;
        private string incorrect_answer_1;
        private string incorrect_answer_2;

        public multi_choice(int q_number, game_type kind_of_game, string riddle, string correct_answer, string incorrect_answer_1, string incorrect_answer_2) : base(q_number, kind_of_game, riddle)
        {
            Correct_answer = correct_answer;
            Incorrect_answer_1 = incorrect_answer_1;
            Incorrect_answer_2 = incorrect_answer_2;
        }
        protected string Correct_answer { get => correct_answer; set => correct_answer = value; }
        protected string Incorrect_answer_1 { get => incorrect_answer_1; set => incorrect_answer_1 = value; }
        protected string Incorrect_answer_2 { get => incorrect_answer_2; set => incorrect_answer_2 = value; }
        public override string ToString()
        {
            return base.ToString() + "the right anser is: '" + Correct_answer + "'";
        }

        public string get_correct_ans()
        {
            return Correct_answer;
        }

        public string[] blendanswers()
        {
            string[] ans = new string[3];
            ans[0] = Correct_answer;
            ans[1] = Incorrect_answer_1;
            ans[2] = Incorrect_answer_2;
            return Shuffle(ans);
        }

        protected string[] Shuffle(string[] wordArray)
        {
            Random random = new Random();
            for (int i = wordArray.Length - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                string temp = wordArray[i];
                wordArray[i] = wordArray[swapIndex];
                wordArray[swapIndex] = temp;
            }
            return wordArray;
        }

    }
}

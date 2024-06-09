using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_proj
{
    public enum game_type { true_or_false = 0, multi_choice, true_or_false_pic, multi_choice_pic };
    class question
    {
        protected int q_number;
        protected game_type kind_of_game;
        protected string riddle;

        public question(int q_number, game_type kind_of_game, string riddle)
        {
            Q_number = q_number;
            Kind_of_game = kind_of_game;
            Riddle = riddle;
        }
        public question()
        {
            Q_number = 0;
            Kind_of_game = 0;
            Riddle = "null";
        }
        protected int Q_number { get => q_number; set => q_number = value; }
        protected game_type Kind_of_game { get => kind_of_game; set => kind_of_game = value; }
        protected string Riddle { get => riddle; set => riddle = value; }

        public override string ToString()
        {
            return "#" + Q_number + " kind of game " + Kind_of_game + " the question is: " + Riddle;
        }

        public string get_only_question()
        {
            return riddle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame.Data.Models.Seed
{
    public class QuestionModel
    {
        public string Category { get; set; }

        public string Type { get; set; }

        public string Difficulty { get; set; }

        public string Question { get; set; }

        public string Correct_answer { get; set; }

        public string[] Incorrect_answers { get; set; }
    }
}

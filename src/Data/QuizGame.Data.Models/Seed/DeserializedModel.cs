using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame.Data.Models.Seed
{
    public class DeserializedModel
    {
        public int Response_code { get; set; }

        public ICollection<QuestionModel> Results { get; set; }
    }
}

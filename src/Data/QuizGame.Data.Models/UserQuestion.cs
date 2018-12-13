using GuizGame.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame.Data.Models
{
    public class UserQuestion : BaseModel<string>
    {
        public string UserId { get; set; }
        public virtual QuizGameUser User { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}

using GuizGame.Data.Common;
using QuizGame.Data.Models.Enums;
using System.Collections.Generic;

namespace QuizGame.Data.Models
{
    public class Question : BaseModel<int>
    {
        public string Content { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public EQuestionDifficulty Difficulty { get; set; }

        public virtual ICollection<Answer> Answers => new HashSet<Answer>();

        public bool IsAnswered => false;

        public virtual ICollection<UserQuestion> LikedBy => new HashSet<UserQuestion>();
    }
}

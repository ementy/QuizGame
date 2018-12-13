using GuizGame.Data.Common;
using System.Collections.Generic;
using System.Linq;

namespace QuizGame.Data.Models
{
    public class Level : BaseModel<string>
    {
        public string Name { get; set; }

        public virtual ICollection<Question> Questions => new HashSet<Question>();

        public int QuestionsCount => Questions.Count;

        public int CorrectAnsweredQuestions => Questions.Where(x => x.IsAnswered == true).Count();

        public bool IsUnlocked => false;

        public bool IsCompleted => false;

        public virtual Category Category { get; set; }
    }
}

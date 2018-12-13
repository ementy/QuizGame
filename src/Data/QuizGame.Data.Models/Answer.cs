using GuizGame.Data.Common;

namespace QuizGame.Data.Models
{
    public class Answer : BaseModel<int>
    {
        public string Content { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}

namespace QuizGame.Services.Models.Answers
{
    public class CreateAnswerIn
    {
        public string Content { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
    }
}

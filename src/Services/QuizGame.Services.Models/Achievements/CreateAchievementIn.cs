namespace QuizGame.Services.Models.Achievements
{
    public class CreateAchievementIn
    {
        public string Name { get; set; }

        public int CorrectAnswers { get; set; }

        public int RewardAmount { get; set; }
    }
}

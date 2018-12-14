namespace QuizGame.Services.Models.Achievements
{
    public class EditAchievementIn
    {
        public string Name { get; set; }

        public int CorrectAnswers { get; set; }

        public int RewardAmount { get; set; }
    }
}

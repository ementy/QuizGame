namespace QuizGame.Services.Models.Achievements
{
    public class AchievementViewModelOut
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int CorrectAnswers { get; set; }
        public int RewardAmount { get; set; }
    }
}

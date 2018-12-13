using GuizGame.Data.Common;

namespace QuizGame.Data.Models
{
    public class Achievement : BaseModel<string>
    {
        public string Name { get; set; }

        public int CorrectAnswers { get; set; }

        public int RewardAmount { get; set; }

        public bool IsUnlocked => false;
    }
}

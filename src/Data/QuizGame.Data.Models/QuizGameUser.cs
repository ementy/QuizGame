using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace QuizGame.Data.Models
{
    // Add profile data for application users by adding properties to the QuizAppUser class
    public class QuizGameUser : IdentityUser
    {
        public ICollection<UserQuestion> LikedQuestions => new HashSet<UserQuestion>();

        public ICollection<Achievement> CompletedAchievements => new HashSet<Achievement>();

        public int Points { get; set; }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizGame.Data.Models;

namespace QuizGame.Data
{
    public class QuizGameContext : IdentityDbContext<QuizGameUser>
    {
        public QuizGameContext(DbContextOptions<QuizGameContext> options)
            : base(options)
        {
        }

        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<UserQuestion> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<UserQuestion>().HasKey(x => new { x.UserId, x.QuestionId });
        }
    }
}

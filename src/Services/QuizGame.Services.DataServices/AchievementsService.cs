using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuizGame.Data.Common;
using QuizGame.Data.Models;
using QuizGame.Services.DataServices.Contracts;
using QuizGame.Services.Models.Achievements;

namespace QuizGame.Services.DataServices
{
    public class AchievementsService : IAchievementsService
    {
        private readonly IRepository<Achievement> achievementsRepository;

        public AchievementsService(IRepository<Achievement> achievementsRepository)
        {
            this.achievementsRepository = achievementsRepository;
        }
        public IQueryable<AchievementViewModelOut> GetAll()
        {
            var achievements = this.achievementsRepository.All()
                .Select(x => new AchievementViewModelOut
                {
                    Id = x.Id,
                    Name = x.Name,
                    CorrectAnswers = x.CorrectAnswers,
                    RewardAmount = x.RewardAmount
                });

            return achievements;
        }


        public async Task AddAsync(CreateAchievementIn model)
        {
            var achievement = new Achievement
            {
                Name = model.Name,
                CorrectAnswers = model.CorrectAnswers,
                RewardAmount = model.RewardAmount
            };
            await this.achievementsRepository.AddAsync(achievement);
            await this.achievementsRepository.SaveChangesAsync();
        }

        public Task<Achievement> FindByIdAsync(string id)
        {
            return this.achievementsRepository.FindByIdAsync(id);
        }

        public void Delete(Achievement achievement)
        {
            this.achievementsRepository.Delete(achievement);
            this.achievementsRepository.SaveChangesAsync();
        }
    }
}

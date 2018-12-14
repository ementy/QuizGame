using QuizGame.Data.Models;
using QuizGame.Services.Models.Achievements;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Services.DataServices.Contracts
{
    public interface IAchievementsService
    {
        IQueryable<AchievementViewModelOut> GetAll();

        Task<Achievement> FindByIdAsync(string id);

        Task AddAsync(CreateAchievementIn achievement);

        void Delete(Achievement achievement);
    }
}

using QuizGame.Services.Models.Answers;
using System.Threading.Tasks;

namespace QuizGame.Services.DataServices.Contracts
{
    public interface IAnswersService
    {
        int GetCount();

        Task AddAsync(CreateAnswerIn answer);
    }
}

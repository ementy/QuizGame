using GuizGame.Data.Common;
using QuizGame.Data.Models;
using QuizGame.Services.DataServices.Contracts;
using QuizGame.Services.Models.Answers;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGame.Services.DataServices
{
    public class AnswersService : IAnswersService
    {
        private readonly IRepository<Answer> answersRepository;

        public AnswersService(IRepository<Answer> answersRepository)
        {
            this.answersRepository = answersRepository;
        }

        public Task AddAsync(CreateAnswerIn model)
        {
            var answer = new Answer
            {
                Content = model.Content,
                IsCorrect = model.IsCorrect,
                QuestionId = model.QuestionId
            };

            return this.answersRepository.AddAsync(answer);
        }

        public int GetCount()
        {
            return this.answersRepository.All().Count();
        }
    }
}

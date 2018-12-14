using QuizGame.Services.Models.Home;
using System.Collections.Generic;

namespace QuizGame.Services.DataServices.Contracts
{
    public interface IQuestionsService
    {
        IEnumerable<IndexQuestionViewModel> GetRandomQuestion(int count);

        int GetCount();
    }
}

using GuizGame.Data.Common;
using QuizGame.Data.Models;
using QuizGame.Services.DataServices.Contracts;
using QuizGame.Services.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizGame.Services.DataServices
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IRepository<Question> questionsRepository;

        public QuestionsService(IRepository<Question> questionsRepository)
        {
            this.questionsRepository = questionsRepository;
        }

        public IEnumerable<IndexQuestionViewModel> GetRandomQuestion(int count)
        {
            var questions = this.questionsRepository.All()
                .OrderBy(x => Guid.NewGuid())
                .Select(
                    x => new IndexQuestionViewModel
                    {
                        Content = x.Content,
                        CategoryName = x.Category.Name,
                    })
                    .Take(count)
                    .ToList();

            return questions;
        }

        public int GetCount()
        {
            return this.questionsRepository.All().Count();
        }
    }
}

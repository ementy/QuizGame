using System.Collections.Generic;

namespace QuizGame.Services.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<IndexQuestionViewModel> Questions { get; set; }
    }
}

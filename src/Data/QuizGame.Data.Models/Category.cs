using GuizGame.Data.Common;

namespace QuizGame.Data.Models
{
    public class Category : BaseModel<int>
    {
        public string Name { get; set; }
    }
}

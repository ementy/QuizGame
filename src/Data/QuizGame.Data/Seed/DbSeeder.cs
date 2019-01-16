using Newtonsoft.Json;
using QuizGame.Data.Models;
using QuizGame.Data.Models.Seed;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace QuizGame.Data.Seed
{
    public class DbSeeder
    {
        public void SeedQuestions()
        {

            for (int i = 0; i < 5; i++)
            {
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("https://opentdb.com/api.php?amount=50&type=multiple").Result;
                var resultSet = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<DeserializedModel>(resultSet);

                foreach (var questionModel in result.Results)
                {
                    var currentCategory = questionModel.Category;
                    var category = 
                }
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using QuizApp.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuizGame.Data
{
    public class QuizGameContextFactory : IDesignTimeDbContextFactory<QuizGameContext>
    {
        public QuizGameContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var builder = new DbContextOptionsBuilder<QuizGameContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            builder.ConfigureWarnings(w => w.Throw(RelationalEventId.QueryClientEvaluationWarning));


            return new QuizGameContext(builder.Options);
        }
    }
}

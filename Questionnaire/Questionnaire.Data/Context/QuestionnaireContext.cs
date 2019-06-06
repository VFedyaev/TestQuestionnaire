using Microsoft.EntityFrameworkCore;
using Questionnaire.Data.Entities;

namespace Questionnaire.Data
{
    public class QuestionnaireContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }

        public QuestionnaireContext(DbContextOptions<QuestionnaireContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Answer>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Answer>().Property(x => x.Age).IsRequired();
            modelBuilder.Entity<Answer>().Property(x => x.Gender).IsRequired();
            modelBuilder.Entity<Answer>().Property(x => x.DateBorn).IsRequired();
            modelBuilder.Entity<Answer>().Property(x => x.MaritalStatus).IsRequired();
            modelBuilder.Entity<Answer>().Property(x => x.Programming).IsRequired();          
        }
    }
}
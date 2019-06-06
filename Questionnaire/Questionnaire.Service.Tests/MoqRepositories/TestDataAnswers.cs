using Questionnaire.Data.Entities;
using Questionnaire.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Service.Tests
{
    public class TestDataAnswers
    {
        public static List<Answer> Answers = new List<Answer>
        {
            new Answer
            {
                Id = Guid.NewGuid(),
                Name = "Petrov",
                Age = 22,
                Gender = Gender.Male,
                DateBorn = Convert.ToDateTime("1980.12.12"),
                MaritalStatus = MaritalStatus.NotMarried,
                Programming = true

            }
        };
    }
}

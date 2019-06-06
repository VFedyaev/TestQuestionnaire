using System;
using Questionnaire.Data.Entities.Base;
using Questionnaire.Data.Enums;

namespace Questionnaire.Data.Entities
{
    public class Answer : EntityBase<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateBorn { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public bool Programming { get; set; }
        public Guid? UserId { get; set; }
    }
}

using System;
using Questionnaire.Data.Enums;
using Questionnaire.Service.Models.Base;

namespace Questionnaire.Service
{
    public class AnswerModel : BaseModel
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

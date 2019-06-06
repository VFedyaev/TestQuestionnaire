using AutoMapper;
using Questionnaire.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questionnaire.Service.Tests.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Answer, AnswerModel>(MemberList.None).ReverseMap();
        }
    }
}

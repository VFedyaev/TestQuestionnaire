using AutoMapper;
using Moq;
using Questionnaire.Data.Entities;
using Questionnaire.Data.Interfaces;
using Questionnaire.Service.Services;
using Questionnaire.Service.Tests.MappingProfiles;
using Questionnaire.Service.Tests.MoqRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questionnaire.Service.Tests.Services.Tests
{
    public class BaseInit
    {
        ///* Moq Repositories */
        //public MoqBaseRepository<Answer> moqAnswerRepository;

        ///*Moq UnitOfWork*/
        //public Mock<IUnitOfWork> moqUnitOfWork;

        //public Mock<IMapper> moqMapper;

        ///*Services*/
        //public AnswerService AnswerService;

        //public void AnswerInitialize()
        //{
        //    SetupMapper();
        //    SetupAnswerMoqRepositories();
        //    SetupAnswerMoqUnitOfWork();
        //    SetupAnswerServices();
        //}

        //public void SetupMapper()
        //{
        //    Mapper.Reset();
        //    Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
        //}

        //public void SetupAnswerMoqRepositories()
        //{
        //    moqAnswerRepository = new MoqBaseRepository<Answer>(TestDataAnswers.Answers);
        //}

        //public void SetupAnswerMoqUnitOfWork()
        //{
        //    moqUnitOfWork = new Mock<IUnitOfWork>();
        //    /* component */
        //    moqUnitOfWork
        //        .Setup(u => u.)
        //        .Returns(moqAnswerRepository.repository.Object);
        //}
        //public void SetupAnswerServices()
        //{
        //    AnswerService = new AnswerService(moqUnitOfWork.Object, moqMapper.Object);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Data.Enums;
using Questionnaire.Service;
using Questionnaire.Service.Enums;
using Questionnaire.Service.Interfaces;
using Questionnaire.Service.Query;
using Questionnaire.WEB.Models;

namespace Questionnaire.WEB.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;
        protected readonly IAnswerService _answerService;
        protected readonly UserManager<User> _userManager;
        protected readonly SignInManager<User> _signInManager;

        // Constructor for home controller
        public BaseController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Constructor for Answer controller
        public BaseController(IMapper mapper, IAnswerService answerService, UserManager<User> userManager)
        { 
            _mapper = mapper;
            _answerService = answerService;
            _userManager = userManager;
        }

        protected async Task<QueryResponse<AnswerModel>> GetData(int pageSize, int pageNumber, int sort, string query = null)
        {
            return await _answerService.GetAsync(new QueryRequest<SortType>
            {
                Start = (pageSize * (pageNumber - 1)),
                Length = pageSize,
                OrderQueries = new[]
                {
                    new QueryOrder<SortType>
                    {
                        Direction = SortDirectionType.Desc,
                        OrderType = SortType.Name
                    }
                },
                Search = new QuerySearch
                {
                    Value = query
                }
            });
        }
    }
}
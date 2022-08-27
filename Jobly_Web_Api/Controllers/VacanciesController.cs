using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jobly_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacanciesController : ControllerBase
    {
        private IVacancyService _vacancyService;

        public VacanciesController(IVacancyService vacancyService)
        {
            _vacancyService = vacancyService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _vacancyService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messsage);
            
        }

        [HttpGet("getlistbycategory")]
        public IActionResult GetListByCategory(int categoryId )
        {
            var result = _vacancyService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messsage);

        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _vacancyService.Get(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messsage);

        }

        [HttpPost("add")]
        public IActionResult Add(Vacancy vacancy)
        {
            var result = _vacancyService.Add(vacancy);
            if (result.Success)
            {
                return Ok(result.Messsage);
            }
            return BadRequest(result.Messsage);
        }

        [HttpPost("update")]
        public IActionResult Update(Vacancy vacancy)
        {
            var result = _vacancyService.Update(vacancy);
            if (result.Success)
            {
                return Ok(result.Messsage);
            }
            return BadRequest(result.Messsage);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Vacancy vacancy)
        {
            var result = _vacancyService.Delele(vacancy);
            if (result.Success)
            {
                return Ok(result.Messsage);
            }
            return BadRequest(result.Messsage);
        }


    }
}


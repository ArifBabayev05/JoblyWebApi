using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jobly_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _companyService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Messsage);

        }

        [HttpPost("add")]
        public IActionResult Add(Company company)
        {
            var result = _companyService.Add(company);
            if (result.Success)
            {
                return Ok(result.Messsage);
            }
            return BadRequest(result.Messsage);
        }

        [HttpPost("update")]
        public IActionResult Update(Company company)
        {
            var result = _companyService.Update(company);
            if (result.Success)
            {
                return Ok(result.Messsage);
            }
            return BadRequest(result.Messsage);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Company company)
        {
            var result = _companyService.Delele(company);
            if (result.Success)
            {
                return Ok(result.Messsage);
            }
            return BadRequest(result.Messsage);
        }
    }
}


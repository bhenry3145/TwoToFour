using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoToFour.Services;

namespace TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoNumbersSentencesController : ControllerBase
    {
        private readonly TwoNumbersSentencesServices _twoNumbersSentencesServices;

        public TwoNumbersSentencesController(TwoNumbersSentencesServices twoNumbersSentencesServices)
        {
            _twoNumbersSentencesServices = twoNumbersSentencesServices;
        }

        [HttpPost]
        [Route("2Numbers/{num1}/{num2}")]

        public string ComparedNumbers(int num1, int num2)
        {
            return _twoNumbersSentencesServices.ComparedNumbers(num1, num2);
        }
    }
}
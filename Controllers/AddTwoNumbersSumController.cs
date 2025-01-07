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
    public class AddTwoNumbersSumController : ControllerBase
    {
        private readonly AddTwoNumbersSumServices _addTwoNumbersSumServices;
    

    public AddTwoNumbersSumController(AddTwoNumbersSumServices addTwoNumbersSumServices)
    {
        _addTwoNumbersSumServices = addTwoNumbersSumServices;
    }

    [HttpPost]
    [Route("Add2Numbers/{num1}/{num2}")]

    public string AddNumbers(int num1, int num2)
    {
        return _addTwoNumbersSumServices.AddNumbers(num1, num2);
    }

}
}
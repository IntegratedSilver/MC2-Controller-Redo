using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MC2_Controller_Redo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MC2Controllers : ControllerBase
    {
       [HttpGet("/Add")] // specifying the endpoint directly here
       public ActionResult<string> Add(int num1, int num2)
       {
           int sum = num1 + num2;
           return $"The sum of {num1} and {num2} is {sum}.";
       }  

       [HttpGet("/NameTime")] 
       public string nameTime(string name, string time){
        return $"So {name}, you woke up at {time}?";

       }  
         
         [HttpGet("/EvenOdd")]
        public ActionResult<string> evenOdd(int num1, int num2){
            string comparison1, comparison2;

    if (num1 > num2)
        comparison1 = "greater than";
    else if (num1 < num2)
        comparison1 = "less than";
    else
        comparison1 = "equal to";

    if (num2 > num1)
        comparison2 = "greater than";
    else if (num2 < num1)
        comparison2 = "less than";
    else
        comparison2 = "equal to";

    return $"{num1} is {comparison1} the {num2}.\n" +
           $"{num2} is {comparison2} the {num1}.";
    }

    }
    
}



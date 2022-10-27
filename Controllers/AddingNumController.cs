//Lerissa Lazar
//10-25-22
//AddingNumbers
//This is a webapi that gets inputs (numbers) and returns the sum
//peer review by Carlos Felipe: This program works well it adds two integers. It even works for negative numbers. Code is formtated correctly. 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChAddingNumEndPoint.Controllers
{
    [Route("[controller]")]
    public class AddingNumController : Controller
    {
        [HttpGet]
        [Route("AddingNum/{num1}/{num2}")]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
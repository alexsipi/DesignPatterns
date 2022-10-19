using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TestAPI.Logic;

namespace TestAPI.Controllers
{
    public class TestController : ControllerBase
    {
        private IDateAndTime mydate;

        public TestController(IDateAndTime myDateAndTime) {
            mydate = myDateAndTime;
        }

        [HttpGet]
        public DateTime GetDateAndTime() {
            return mydate.GetTime();
        }
    }
}

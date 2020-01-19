using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hanfile_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test(int ci)
        {
            if (ci == 1)
                BackgroundJob.Enqueue(() => ThrowTest());
            

            for (int i=0;i<ci;i++)
                BackgroundJob.Enqueue(() => CallTest());

            return Ok("안녕");

        }


        [HttpGet("deque")]
        public async Task<IActionResult> Deque()
        {
            //RecurringJob.AddOrUpdate("")
            await Task.Delay(1000);
            return Ok("안녕1");

        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task CallTest()
        {
            await Task.Delay(5000);
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now.ToString("mm:ss")}"); 
            Console.WriteLine("1");
                
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task ThrowTest()
        {
            await Task.Delay(3000);
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now.ToString("mm:ss")}");
            Console.WriteLine("1");
            throw new Exception("치명적인 매력");
        }
    }
}
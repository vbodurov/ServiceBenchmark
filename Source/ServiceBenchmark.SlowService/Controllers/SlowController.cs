﻿using System;
using System.Threading;
using System.Web.Http;

namespace ServiceBenchmark.SlowService.Controllers
{
    public class SlowController : ApiController
    {
        [Route("api/slow")]
        public string Get()
        {
            Thread.Sleep(100);
            return "Some String";
        }
    }
}
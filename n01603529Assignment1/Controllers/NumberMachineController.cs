﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603529Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            return id * id - 10;
        }
    }
}

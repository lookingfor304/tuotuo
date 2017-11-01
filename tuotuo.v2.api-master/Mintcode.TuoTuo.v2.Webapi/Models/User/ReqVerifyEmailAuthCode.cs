﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mintcode.TuoTuo.v2.Infrastructure;

namespace Mintcode.TuoTuo.v2.Webapi
{
    public class ReqVerifyEmailAuthCode:RequestBaseModel
    {
        public int codeType { set; get; }

        public string mail { get; set; }

        public string code { get; set; }
    }
}

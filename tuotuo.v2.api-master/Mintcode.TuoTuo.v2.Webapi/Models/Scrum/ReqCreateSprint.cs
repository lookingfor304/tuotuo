﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mintcode.TuoTuo.v2.Webapi.Models
{
    public class ReqCreateSprint : RequestBaseModel
    {
        public int releaseID { set; get; }

        public long startTime { set; get; }

        public long endTime { set; get; }
    }
}

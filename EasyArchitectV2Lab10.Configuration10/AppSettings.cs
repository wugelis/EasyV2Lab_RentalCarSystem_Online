﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyArchitectV2Lab10.Configuration10
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int? TimeoutMinutes { get; set; }
    }
}

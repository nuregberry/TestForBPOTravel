﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class ExchangeRateResponse
    {
        public List<Result> result { get; set; }
        public int total { get; set; }
        public Time time { get; set; }
    }
}

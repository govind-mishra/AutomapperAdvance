﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public InnerSource Inner { get; set; }

    }
    public class InnerSource
    {
        public int OtherValue { get; set; }
        public int onemorevalue { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    public class EmployeeDTO
    {
        public string FullName { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public InnerDest Inner { get; set; }
    }
    public class InnerDest
    {
        public int OtherValue { get; set; }
    }
}

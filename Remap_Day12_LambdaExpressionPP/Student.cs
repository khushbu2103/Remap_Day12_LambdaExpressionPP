using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day12_LambdaExpressionPP
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int TotalMarks { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, MobileNumber: {MobileNumber}, Address: {Address}, Age{ Age}. Total marks: {TotalMarks}";
        }
    }
   
}

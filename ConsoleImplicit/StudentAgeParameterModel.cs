using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImplicit
{
    public class StudentAgeParameterModel
    {
        public int StudentAge { get; set; }

        public static implicit operator StudentAgeParameterModel(StudentParameterModel studentModel)
        {
            var result = new StudentAgeParameterModel
            {
                StudentAge = studentModel.Age,
            };
            return result;
        }
    }
}

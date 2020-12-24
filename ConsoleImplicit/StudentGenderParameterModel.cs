using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImplicit
{
    public class StudentGenderParameterModel
    {
        public string StudentGender { get; set; }

        public static implicit operator StudentGenderParameterModel(StudentParameterModel studentModel)
        {
            var result = new StudentGenderParameterModel
            {
                StudentGender = studentModel.Gender,
            };
            return result;
        }
    }
}

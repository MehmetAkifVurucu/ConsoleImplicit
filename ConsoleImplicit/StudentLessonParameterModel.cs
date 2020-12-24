using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImplicit
{
    public class StudentLessonParameterModel
    {
        public string StudentLesson { get; set; }

        public static implicit operator StudentLessonParameterModel(StudentParameterModel studentModel)
        {
            var result = new StudentLessonParameterModel
            {
                StudentLesson = studentModel.Lesson,
            };
            return result;
        }
    }
}

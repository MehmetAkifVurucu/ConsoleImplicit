using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentParameterModel = new StudentParameterModel { Age = 41, Gender = "Erkek", Lesson = "Matematik" };

            var listByAge = GetStudentByAge(studentParameterModel);
            Console.WriteLine("Yaşa Göre Liste");
            foreach (var item in listByAge)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
            Console.WriteLine("----------");

            var listByGender = GetStudentByGender(studentParameterModel);
            Console.WriteLine("Cinsiyete Göre Liste");
            foreach (var item in listByGender)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
            Console.WriteLine("----------");

            var listByLesson = GetStudentByLesson(studentParameterModel);
            Console.WriteLine("Derse Göre Liste");
            foreach (var item in listByLesson)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
            Console.ReadLine();
        }


        private static List<StudentInformationModel> GetStudentLessonList()
        {
            List<StudentInformationModel> list = new List<StudentInformationModel>();

            list.Add(new StudentInformationModel { Id = 1, Name = "Mehmet Akif", Surname = "Vurucu", Age = 40, Gender = "Erkek", Email = "mehmetakif@gmail.com", PhoneNumber = "5553332211", Lesson = "Kimya" });
            list.Add(new StudentInformationModel { Id = 2, Name = "Hasan", Surname = "Mutlu", Age = 41, Gender = "Erkek", Email = "hasan@gmail.com", PhoneNumber = "5332223366", Lesson = "Fizik" });
            list.Add(new StudentInformationModel { Id = 3, Name = "Cansu", Surname = "Doğan", Age = 40, Gender = "Kadın", Email = "cansu@gmail.com", PhoneNumber = "5442221100", Lesson = "Matematik" });
            list.Add(new StudentInformationModel { Id = 4, Name = "Ziya", Surname = "Kaya", Age = 40, Gender = "Erkek", Email = "ziya@gmail.com", PhoneNumber = "5351111111", Lesson = "Biyoloji" });
            list.Add(new StudentInformationModel { Id = 5, Name = "Müge", Surname = "Güneş", Age = 41, Gender = "Kadın", Email = "muge@gmail.com", PhoneNumber = "5432223311", Lesson = "Türkçe" });
            list.Add(new StudentInformationModel { Id = 6, Name = "İpek", Surname = "Topçu", Age = 41, Gender = "Kadın", Email = "ipek@gmail.com", PhoneNumber = "5553338877", Lesson = "Fizik" });
            list.Add(new StudentInformationModel { Id = 7, Name = "İnci", Surname = "Kumbaracığolu", Age = 40, Gender = "Kadın", Email = "inci@gmail.com", PhoneNumber = "5555556622", Lesson = "Fizik" });
            list.Add(new StudentInformationModel { Id = 8, Name = "Kerem", Surname = "Tunçeri", Age = 40, Gender = "Erkek", Email = "kerem@gmail.com", PhoneNumber = "5555557788", Lesson = "Kimya" });
            list.Add(new StudentInformationModel { Id = 9, Name = "Ahmet", Surname = "Bardakçı", Age = 40, Gender = "Erkek", Email = "ahmet@gmail.com", PhoneNumber = "5555554444", Lesson = "Türkçe" });
            list.Add(new StudentInformationModel { Id = 10, Name = "Ozan", Surname = "Şişeci", Age = 41, Gender = "Erkek", Email = "ozan@gmail.com", PhoneNumber = "5553332211", Lesson = "Biyoloji" });
            list.Add(new StudentInformationModel { Id = 11, Name = "Ali", Surname = "Gönül", Age = 41, Gender = "Erkek", Email = "ali@gmail.com", PhoneNumber = "5558889977", Lesson = "Türkçe" });
            list.Add(new StudentInformationModel { Id = 12, Name = "Aynur", Surname = "Gülenyüz", Age = 41, Gender = "Kadın", Email = "aynur@gmail.com", PhoneNumber = "5554442233", Lesson = "Matematik" });
            list.Add(new StudentInformationModel { Id = 13, Name = "Ayşe", Surname = "Kolonyacı", Age = 40, Gender = "Kadın", Email = "ayse@gmail.com", PhoneNumber = "5556668899", Lesson = "Matematik" });
            list.Add(new StudentInformationModel { Id = 14, Name = "Cenk", Surname = "Elvan", Age = 40, Gender = "Erkek", Email = "cenk@gmail.com", PhoneNumber = "5552223388", Lesson = "Kimya" });
            list.Add(new StudentInformationModel { Id = 15, Name = "Gökhan", Surname = "Erkin", Age = 41, Gender = "Erkek", Email = "gokhan@gmail.com", PhoneNumber = "5552223399", Lesson = "Türkçe" });
            list.Add(new StudentInformationModel { Id = 16, Name = "Meral", Surname = "Ekici", Age = 40, Gender = "Kadın", Email = "meral@gmail.com", PhoneNumber = "5552224466", Lesson = "Fizik" });
            list.Add(new StudentInformationModel { Id = 17, Name = "Ender", Surname = "Aziz", Age = 41, Gender = "Erkek", Email = "ender@gmail.com", PhoneNumber = "5552225566", Lesson = "Fizik" });
            list.Add(new StudentInformationModel { Id = 18, Name = "Birsel", Surname = "Demirel", Age = 40, Gender = "Kadın", Email = "birsel@gmail.com", PhoneNumber = "5552226666", Lesson = "Biyoloji" });
            list.Add(new StudentInformationModel { Id = 19, Name = "Burcu", Surname = "Günok", Age = 41, Gender = "Kadın", Email = "burcu@gmail.com", PhoneNumber = "5552223333", Lesson = "Türkçe" });
            list.Add(new StudentInformationModel { Id = 20, Name = "Demet", Surname = "Tosun", Age = 40, Gender = "Kadın", Email = "demet@gmail.com", PhoneNumber = "5552227777", Lesson = "Matematik" });

            return list;
        }
        private static List<StudentInformationModel> GetStudentByAge(StudentAgeParameterModel parameterModel)
        {
            var list = GetStudentLessonList();
            return list.Where(x => x.Age == parameterModel.StudentAge).ToList();
        }

        private static List<StudentInformationModel> GetStudentByGender(StudentGenderParameterModel parameterModel)
        {
            var list = GetStudentLessonList();
            return list.Where(x => x.Gender == parameterModel.StudentGender).ToList();
        }

        private static List<StudentInformationModel> GetStudentByLesson(StudentLessonParameterModel parameterModel)
        {
            var list = GetStudentLessonList();
            return list.Where(x => x.Lesson == parameterModel.StudentLesson).ToList();
        }
    }
}

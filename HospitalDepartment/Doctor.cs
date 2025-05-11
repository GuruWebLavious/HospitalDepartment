using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDepartment
{
    public class Doctor : Person
    {
        public override string Surname { get; set; }
        public override string Name { get; set; }
        public override string Patronymic { get; set; }
        public override string Gender { get; set; }
        public override int Age { get; set; }

        public Doctor(string surname, string name, string patronymic, string gender, int age)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Gender = gender;
            Age = age;
        }
    }
}

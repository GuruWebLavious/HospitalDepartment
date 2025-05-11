using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDepartment
{
    public class Patient : Person
    {
        public override string Surname { get; set; }
        public override string Name { get; set; }
        public override string Patronymic { get; set; }
        public override string Gender { get; set; }
        public override int Age { get; set; }
        public string Diagnosis { get; set; }
        public string Status { get; set; }
        public int doctor_patient { get; set; }

        public Patient(string surname, string name, string patronymic, string gender, int age, string diagnosis, string status, int doctor_id)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Gender = gender;
            Age = age;
            Diagnosis = diagnosis;
            Status = status;
            doctor_patient = doctor_id;
        }
    }
}

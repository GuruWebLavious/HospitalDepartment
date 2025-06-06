﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDepartment
{
    public class Patient : Person
    {
        public override int Id { get; set; } 
        public override string Surname { get; set; }
        public override string Name { get; set; }
        public override string Patronymic { get; set; }
        public override string Gender { get; set; }
        public override int Age { get; set; }
        public string Diagnosis { get; set; }
        public string Status { get; set; }
        public int doctor_patient { get; set; }

        public Patient(int id, string surname, string name, string patronymic, string gender, int age, string diagnosis = "", string status = "", int id_doctor = 0)
        {

            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Gender = gender;
            Age = age;
            Diagnosis = diagnosis;
            Status = status;
            doctor_patient = id_doctor;
        }
        public Patient(string surname, string name, string patronymic, string gender, int age, string diagnosis = "", string status = "", int id_doctor = 0)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Gender = gender;
            Age = age;
            Diagnosis = diagnosis;
            Status = status;
            doctor_patient = id_doctor;
        }
    }
}

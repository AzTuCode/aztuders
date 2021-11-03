using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Talaba:Human
    {
        public  Talaba[] Talabas;
        public Talaba()
        {
            Talabas = new Talaba[0];
        }
        public int No { get; set; }
        public string Speciality { get; set; }
        public int Experience { get; set; }

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nNo: {No}\nSpeciality: {Speciality}\nExperience: {Experience}";
        }

        public void DoctorAdd(Talaba doctor)
        {
            Array.Resize(ref Talabas, Talabas.Length + 1);
            Talabas[Talabas.Length - 1] = doctor;
        }

        internal void TalabaAdd(Talaba talaba) => throw new NotImplementedException();
    }
}
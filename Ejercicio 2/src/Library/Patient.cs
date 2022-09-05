using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        public string celular {get; set;}
        public string name;       
        public Patient (string name, string celular)
        {
            this.name = name;
            this.celular = celular; 
        }
        public static string PatientName (string name)
        {
            return name;
        }
        public static string CelularGet (string celular)
        {
            return celular;
        }
    }
}
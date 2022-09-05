using System;
using System.Text;

namespace Library
{   

    // Esta clase se cumple con el fin de cumplir con SRP y Expert, guardando asi la informacion que unicamente le intersa a esta clase respecto a los pacientes
    // al igual que esta clase solo tiene una razon de ser
    public class Patient
    {
        public string celular {get; set;}
        public string name;
        public int edad {get; set;}       
        public Patient (string name, string celular, int edad)
        {
            this.name = name;
            this.celular = celular; 
            this.edad = edad;
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
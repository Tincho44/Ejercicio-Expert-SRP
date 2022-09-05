using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string name {get;}      
        private string ReservaConsulta {get; set;}
        public string especialidad {get;}
        public Doctor (string name, string especialidad)
        {
            this.name = name;
            this.especialidad = especialidad; 
        }
        public static string NombreDoctor (string name)
        {
            return name;
        }
        public static string ObtenerReserva (string ReservaConsulta)
        {
            return ReservaConsulta;
        }

        public static string ObtenerEspecialidad (string especialidad)
        {
            return especialidad;
        }
    }
}
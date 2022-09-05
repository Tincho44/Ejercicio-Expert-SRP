using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

        public Patient name {get; set;}
        private string id {get; set;}
        private Patient celular {get; set;} 
        public Doctor GetDoctor {get; set;}
        public Doctor ObtenerReserva {get; set;}
        public static string CreateAppointment(string name, string id, string celular, DateTime date, string ObtenerReserva, string GetDoctor)
        //cambie muchos parametros por que primero hice la clase doctor y clase patient, y cuando me di cuenta que tenian que coincidir con esta clase
        // me resultaba mas rapido cambiar los parametros aca que en la otra clase. 
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            StringBuilder UniqueCode  = new StringBuilder("New code...\n");
            // este es el codigo unico que pide la letra

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(celular))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(ObtenerReserva))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(GetDoctor))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment scheduled");
            }

            return stringBuilder.ToString();

            // Esta clase no cumple con SRP por que tiene mas de una razon de cambio, por eso por ejemplo se crea la clase patient
        }

    }
}

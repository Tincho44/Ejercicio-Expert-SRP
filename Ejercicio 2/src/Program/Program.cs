using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);

            /*

            Al codigo en general le faltaban varios datos, comoe es el ejeplo de crear la clase
            "Doctor" y la clase "Patient" en mi caso. Tambien agregarles datos como puede ser datos personales
            al paciente o la especialidad al Doctor. Faltaban atritubtos en la clase de Appointment.


            */
        }
    }
}

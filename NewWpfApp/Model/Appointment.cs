using System;

namespace NewWpfApp.Model
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public string Notatka { get; set; }
    }
}

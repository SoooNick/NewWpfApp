using NewWpfApp.Model;
using System.Collections.Generic;

namespace NewWpfApp.DefaultData
{
    public static class DefaultData
    {
        private static IList<Doctor> _doctors;
        public static IList<Doctor> Doctors
        {
            get
            {
                if(_doctors == null)
                {
                    _doctors = new List<Doctor>();

                    _doctors.Add(new Doctor("Jan", "Kowalski", Enums.DoctorDegree.Doctor, Enums.Specialization.Dentist, Enums.Sex.Male));
                    _doctors.Add(new Doctor("Adam", "Nowak", Enums.DoctorDegree.Professor, Enums.Specialization.GP, Enums.Sex.Male));
                }
                return _doctors;
            }
        }

        private static IList<Appointment> _appointments;

        public static IList<Appointment> Appointments
        {
            get
            {
                if(_appointments == null)
                {
                    _appointments = new List<Appointment>();

                    _appointments.Add(new Appointment() { Doctor = Doctors[0], Date = new System.DateTime(2019, 01, 01) });
                    _appointments.Add(new Appointment() { Doctor = Doctors[1], Date = new System.DateTime(2019, 02, 01) });
                }
                return _appointments;
            }
        }
    }
}

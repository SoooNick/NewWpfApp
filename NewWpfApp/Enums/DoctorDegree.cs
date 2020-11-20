using NewWpfApp.Attribiutes;

namespace NewWpfApp.Enums
{
    public enum DoctorDegree
    {
        [Name("Doktor")]
        [Symbol("Dr")]
        Doctor = 1,
        [Name("Profesor")]
        [Symbol("Prof.")]
        Professor = 2
    }
}

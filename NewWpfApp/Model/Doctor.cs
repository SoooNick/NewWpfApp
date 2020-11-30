using NewWpfApp.Attribiutes;
using NewWpfApp.Enums;
using NewWpfApp.Helpers;

namespace NewWpfApp.Model
{
    public class Doctor : Person
    {

        public Doctor(string firstName, string secondName, DoctorDegree doctorDegree, Specialization specialization, Sex sex)
            : base(firstName, secondName, sex)
        {
            DoctorDegree = doctorDegree;
            Specialization = specialization;
        }

        public DoctorDegree DoctorDegree { get; set; }
        public Specialization Specialization { get; set; }

        public override string ToString()
        {
            var symbol = DoctorDegree.GetAttributeOfType<SymbolAttribute>();
            return $"{symbol.Symbol} {FirstName} {SecondName}";
        }
    }
}

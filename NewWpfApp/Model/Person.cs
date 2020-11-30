using NewWpfApp.Enums;

namespace NewWpfApp.Model
{
    public abstract class Person
    {
        public Person(string firstName, string secondName, Sex sex)
        {
            FirstName = firstName;
            SecondName = secondName;
            Sex = sex;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Sex Sex { get; set; }
    }
}

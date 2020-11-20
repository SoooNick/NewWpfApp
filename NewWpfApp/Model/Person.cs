namespace NewWpfApp.Model
{
    public abstract class Person
    {
        public Person(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}

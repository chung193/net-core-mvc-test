namespace testMVC.Models
{
    public class Respository
    {
        private static List<Person> persons = new List<Person>();
        public static IEnumerable<Person> AllPersons { get { return persons; } }
        public static void Create(Person person)
        {
            persons.Add(person);
        }
    }
}

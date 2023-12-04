namespace OopExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(
                "Doe", 
                "Jhon", 
                new DateTime(1990, 12, 4),
                new Address("Romania", "Bihor", "Oradea", "Nufarului", "58"));
            p.Print();
        }
    }
}
namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson spanish = new SpanishPerson();
            spanish.Speak();
            IPerson french = new FrenchPerson();
            french.Speak();
            IPerson russian = new RussianPerson();
            russian.Speak();
        }
    }
}
namespace Enum
{
    internal class Program
    {
        public enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine(Month.January);
                    break; 
                case 2:
                    Console.WriteLine(Month.February);
                    break;
                case 3:
                    Console.WriteLine(Month.March);
                    break;
                case 4:
                    Console.WriteLine(Month.April);
                    break;
                case 5:
                    Console.WriteLine(Month.May);
                    break;
                case 6:
                    Console.WriteLine(Month.June);
                    break;
                case 7:
                    Console.WriteLine(Month.July);
                    break;
                case 8:
                    Console.WriteLine(Month.August);
                    break;
                case 9:
                    Console.WriteLine(Month.September);
                    break;
                case 10:
                    Console.WriteLine(Month.October);
                    break;
                case 11:
                    Console.WriteLine(Month.November);
                    break;
                case 12:
                    Console.WriteLine(Month.December);
                    break;
                default:
                    Console.WriteLine("Input is incorrect");
                    break;
            }
        }
    }
}
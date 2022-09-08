namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to check wheter alphabet is vowel or not");
            Console.WriteLine("Enter 2 to check whether a numbe ris +ve or -ve");
            Console.WriteLine("Enter 3 to find the largest among three variables");
            Console.WriteLine("Enter 4 to find the largest among 3 numbers");
            Console.WriteLine("Enter 5 to print the alphabets between a t z");
            var ans = Convert.ToInt32(Console.ReadLine());
            switch(ans)
            {
                case 1: Vowel CheckVowel = new Vowel(); break;
                case 2: PositiveOrNegative numberType = new PositiveOrNegative(); break;
                case 3: LargestNumber largest = new LargestNumber();  break;
                case 4: Largest max = new Largest(); break;
                case 5: AtoZ print = new AtoZ(); break;
                default: break;
            }
        }
    }
}
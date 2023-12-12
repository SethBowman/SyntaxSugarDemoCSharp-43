namespace SyntaxSugarDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicit typing
            int number = 10;
            string name = "test";
            int num;

            //Inferred typing
            var thing = true;
            var otherNum = 12.0m;

            //Inline if/ Ternary

            var age = 10;

            Console.WriteLine(age >= 18 ? "You're an adult" : age < 5 ? "You're a baby" : "You're a minor");

            //String interpolation vs Concatenation

            var middleName = 'S';

            Console.WriteLine($"Brandon {middleName} Bowman");
            Console.WriteLine("Brandon" + " " + middleName + " " + "Bowman");


        }
    }
}

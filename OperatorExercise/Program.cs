namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // 1. Create 2 integer variables
            int a = 17;
            int b = 4;

            // 2. write equations using addition, subtraction, multiplication, divison, and modulous
            var sum = a + b;
            var difference = a - b;
            var product = a * b;
            var quotient = (double) a / b;
            var remainder = (double) a % b;

           
            // 3. create 2 interger variables for division
            int quotient2 = a / b;
            int remainder2 = a % b;

            // 4. output results with formated string
            Console.WriteLine($"The sum of {a} + {b} is {sum}\n");
            Console.WriteLine($"The difference of {a} - {b} is {difference}\n");
            Console.WriteLine($"The product of {a} * {b} is {product}\n");
            Console.WriteLine($"The quotient of {a} / {b} is {quotient}\n");
            Console.WriteLine($"The remainder of {a} / {b} is {remainder}\n");
            Console.WriteLine($"{a}/{b} is {quotient2} remainder {remainder2}");
        }
    }
}

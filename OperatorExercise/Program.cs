namespace OperatorExercise
{
    public class Program
    {
        // Ex2a. get radius from user
        public static double GetRadius()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            return radius;
        }


        // Ex2b. define AreaOfCircle method
        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * radius * radius);
        }


        static void Main(string[] args)
        {

            // Ex1a. create 2 integer variables
            int a = 17;
            int b = 4;

            // Ex1b. write equations using addition, subtraction, multiplication, divison, and modulous
            var sum = a + b;
            var difference = a - b;
            var product = a * b;
            var quotient = (double) a / b;
            var remainder = (double) a % b;

            // Ex1c. create 2 interger variables for division
            int quotient2 = a / b;
            int remainder2 = a % b;

            // Ex1d. output results with formated string
            Console.WriteLine($"\t- Exercise 1 -\n");
            Console.WriteLine($"The sum of {a} + {b} is {sum}");
            Console.WriteLine($"The difference of {a} - {b} is {difference}");
            Console.WriteLine($"The product of {a} * {b} is {product}");
            Console.WriteLine($"The quotient of {a} / {b} is {quotient}");
            Console.WriteLine($"The remainder of {a} / {b} is {remainder}");
            Console.WriteLine($"{a}/{b} is {quotient2} remainder {remainder2}\n");

            // Ex2c
            Console.WriteLine("\t- Exercise 2 -\n");
            double radius = GetRadius();
            Console.WriteLine($"\nThe area of a circle with the radius of {radius} is {AreaOfCircle(radius)}");
            
        }
    }
}

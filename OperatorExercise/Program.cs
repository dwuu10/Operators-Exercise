namespace OperatorExercise
{
    public class Program
    {
        public static double CircleArea(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("second number");
            int b = int.Parse(Console.ReadLine());
            int add = a + b;
            int sub = a - b;
            int multi = a * b;
            int div = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} = {add}");
            Console.WriteLine($"{a} - {b} = {sub}");
            Console.WriteLine($"{a} * {b} = {multi}");
            Console.WriteLine($"{a} / {b} = {div}, with a remainder of {remainder}");

            Console.WriteLine("what is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var cArea = CircleArea(radius);
            Console.WriteLine($"the area of a circle with a radius of {radius} is {cArea}");
        }
    }
}

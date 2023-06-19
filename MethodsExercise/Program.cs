namespace MethodsExercise
{
    public class Program
    { //-------------------exercise 1

        static void Main(string[] args)

        {

            Console.WriteLine("Hello - What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is an amaizing color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Awesome ! Now, What is your favorite band?");
            var band = Console.ReadLine();


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            //---------------Exercise 2

            Console.WriteLine("value: " + Add(10, 8, 3));

            Console.WriteLine("value: " + Subtract(10, 8));

            Console.WriteLine("value: " + Multiply(8, 3));

            Console.WriteLine("value: " + Divide(10, 3));


        }  


        public static int Add(int num1, int num2, int num3)
        {

            return num1 + num2 + num3;

        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;

        }
        public static int Multiply(int num2, int num3)
        { 
          return num2 * num3;


        }
        public static int Divide(int num1, int num3) 
        {
            return num1 / num3;
        
        }
    }
}

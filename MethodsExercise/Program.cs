namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello - What is your name?");
            var UserName = Console.ReadLine();

            Console.WriteLine($"Hi, {UserName}. What is your favorite color?");
            var color = Console.ReadLine(); 

            Console.WriteLine($" {color} is an amaizing color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Awesome ! Now, What is your favorite band?");
            var band = Console.ReadLine();


        }
    }
}

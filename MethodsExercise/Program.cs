namespace MethodsExercise
{
    public class Program
    {
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


        }
    }
}

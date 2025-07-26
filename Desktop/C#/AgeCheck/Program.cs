using System;
class GovernmentAgeCheck
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter your name: ");
        string Name = Console.ReadLine();
        Console.WriteLine("Your name is: {0}", Name);
        Console.WriteLine("Enter your age: ");
        string input = Console.ReadLine();

        int? Age = null;

        if (int.TryParse(input, out int tempAge))
        {
            Age = tempAge;
        }

        if (Age.HasValue)
        {
            if (Age < 18)
            {
                Console.WriteLine("STILL A MINOR — get away from here, {0}!", Name);
                Console.WriteLine("You are {0} years away from turning 100 years old.", 100 - Age);
            }
            else if (Age < 65)
            {
                Console.WriteLine("Congratulations {0}, you are an adult. Are you having fun yet?", Name);
                Console.WriteLine("You are {0} years away from turning 100 years old.", 100 - Age);
            }
            else
            {
                Console.WriteLine("You are a senior citizen, {0}. Enjoy your retirement!", Name);
                Console.WriteLine("You are {0} years away from turning 100 years old.", 100 - Age);
            }
        }
        else
        {
            Console.WriteLine("Invalid age entered. Keeping Age as null. Time traveler?");
        }
    }
}

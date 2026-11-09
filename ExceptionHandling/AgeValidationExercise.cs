namespace AtmConsoleApp.ExceptionHandling
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    public class AgeValidationExercise
    {
        public int ParseAge(string text)
        {
            if (!int.TryParse(text, out int age))
            {
                throw new InvalidAgeException("Age must be a number");
            }

            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Age must be between 0 and 120");
            }

            return age;
        }

        public void Run()
        {

                try
                {
                    Console.WriteLine("Enter your age:");
                    string text = Console.ReadLine();
                    ParseAge(text);
                    Console.WriteLine($"{text} is valid");
                }
                catch (InvalidAgeException exception)
                {
                    Console.WriteLine($"Invalid: {exception.Message}");
                }
            }
        }
    }


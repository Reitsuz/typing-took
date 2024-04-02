using System;

namespace TypingTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Typing Tool!");
            Console.WriteLine("Type the following sentence:");

            string targetSentence = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(targetSentence);

            Console.Write("Your input: ");
            string userInput = Console.ReadLine();

            // Calculate typing speed and accuracy
            int targetLength = targetSentence.Length;
            int userLength = userInput.Length;
            double accuracy = CalculateAccuracy(targetSentence, userInput);
            double typingSpeed = CalculateTypingSpeed(userLength);

            Console.WriteLine($"Typing speed: {typingSpeed} characters per minute");
            Console.WriteLine($"Accuracy: {accuracy:P}");

            Console.WriteLine("Thank you for using the Typing Tool!");
        }

        static double CalculateAccuracy(string target, string user)
        {
            int correctCount = 0;
            for (int i = 0; i < Math.Min(target.Length, user.Length); i++)
            {
                if (target[i] == user[i])
                    correctCount++;
            }

            return (double)correctCount / target.Length;
        }

        static double CalculateTypingSpeed(int userLength)
        {
            // Assuming an average typing speed of 200 characters per minute
            const int averageTypingSpeed = 200;
            return userLength * 60.0 / averageTypingSpeed;
        }
    }
}

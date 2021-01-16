using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Calculator Exercise
            Console.WriteLine("Do you want to add, multiply, square or average?");
            var calculatorInput = Console.ReadLine();
            Console.WriteLine("Please input 3 numbers like this: 1,2,3");
            var numberInput = Console.ReadLine();
            var numberSplit = numberInput.Split(",");

            var a = 0;
            var b = 0;
            var c = 0;
            var calcCounter = 0;
            foreach (var number in numberSplit)
            {
                int stringToNumber = Int32.Parse(number);

                if (calcCounter == 0)
                {
                    a += stringToNumber;
                    calcCounter++;
                }
                else if (calcCounter == 1)
                {
                    b += stringToNumber;
                    calcCounter++;
                }
                else if (calcCounter == 2)
                {
                    c += stringToNumber;
                    calcCounter++;
                }

            }

            if (calculatorInput == "multiply")
            {
                var multiply = $"Your numbers multiplied together are {a * b * c}";
                Console.WriteLine(multiply);
            }
            else if (calculatorInput == "square")
            {
                var square = $"Your numbers squared are {a * a}, {b * b}, & {c * c}";
                Console.WriteLine(square);
            }
            else if (calculatorInput == "add")
            {
                var add = $"Your numbers added together total  {a + b + c}";
                Console.WriteLine(add);
            }
            else if (calculatorInput == "average")
            {
                Console.WriteLine($"Your average of the 3 numbers is {(a + b + c) / 3}");
            }
            else if (calculatorInput == "divide")
            {
                Console.WriteLine($"Your answer is {a / b / c}");
            }


            //MASK SENSITIVE INFORMATION
            Console.WriteLine("Please enter a secret:");
            var secretInput = Console.ReadLine();
            var joinedInput = string.Join("", secretInput.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            string maskedAnswer = String.Empty;

            //Making a string of *
            foreach (var charachter in joinedInput)
            {
                maskedAnswer += '*';
            }

            //Making it 4 less
  
            var lastFour = secretInput.Substring(secretInput.Length - 4);
            int indexOfMask = maskedAnswer.Length - 5;
            var choppedString = maskedAnswer.Remove(indexOfMask, 4);

            //Concating the last 4 with the stars
            var finalSecretOutput = choppedString + lastFour;

            Console.WriteLine($"{finalSecretOutput}");




            //VALIDATOR

            Console.WriteLine("Enter a Pin code between 4-8 numbers");
            var pinCode = Console.ReadLine();
            bool switcher = true;

            try
            {
                int result = Int32.Parse(pinCode);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Your pin must be all numbers '{pinCode}' is invalid");
                switcher = false;
            }

            if (pinCode.Length < 4)
            {
                Console.WriteLine("Your Pin is too short");
            }
            else if (pinCode.Length > 8)
            {
                Console.WriteLine("Your pin is too long");
            }
            else if(switcher)
            {
                Console.WriteLine("Success!");
            }





            Console.WriteLine("Whats your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, Let's Party!!");


            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("Whats your favorite color?");
            var favoriteColor = Console.ReadLine();

            // Create a Random object  
            Random rand = new Random();
            // Generate a random index less than the size of the array.  
            int index = rand.Next(animals.Length);
            // Display the result.  
            Console.WriteLine($"Would you like a {favoriteColor} {animals[index]}?");


            Console.WriteLine("Enter some charachters");
            var charachters = Console.ReadLine();
            string newOutput = string.Empty;
            var counter = 1;
            foreach (char charachter in charachters)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (i == 0)
                    {
                        var letter = Char.ToUpper(charachter);
                        newOutput += letter;
                    }
                    else
                    {
                        var lowerLetter = Char.ToLower(charachter);
                        newOutput += lowerLetter;
                    }

                }
                newOutput += "-";
                counter++;

            }
            string finalOutput = newOutput.TrimEnd('-');
            Console.WriteLine($"Here is the new output {finalOutput}");




            Console.WriteLine("Choose what greeting you would like! Southern, Midwestern, or British");
            var input = Console.ReadLine();

            if (input == "Southern")
            {
                Console.WriteLine("Howdy Yall!");
            }
            if (input == "Midwestern")
            {
                Console.WriteLine("Ope, how ya doing bud?");
            }
            if (input == "British")
            {
                Console.WriteLine("Tea and Crumpets!");
            }


            var x = Console.Read();
            Console.WriteLine($"The decimal conversion of that key is {x}");

            ConsoleKeyInfo enteredKey;

            //This is gonna read the key you type while its NOT the escape key

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            } while (enteredKey.Key != ConsoleKey.Escape);

            string sentence;

            do
            {
                Console.WriteLine("Type in a sentence. Press enter when done.");
                sentence = Console.ReadLine();
                Console.WriteLine($"You entered the sentence: {sentence}");

            } while (sentence != "quit");

        }
    }
}

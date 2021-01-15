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
            calcCounter = 0;
            var average = a + b + c / 3;
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
            foreach (char cha in charachters)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (i == 0)
                    {
                        var letter = Char.ToUpper(cha);
                        newOutput += letter;
                    }
                    else
                    {
                        var lowerLetter = Char.ToLower(cha);
                        newOutput += lowerLetter;
                    }

                }
                newOutput += "-";
                counter++;

            }
            Console.WriteLine($"Here is the new output {newOutput}");




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

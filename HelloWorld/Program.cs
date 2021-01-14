using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey();

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("Choose what greeting you would like! Southern, Midwestern, or British");
            var input = Console.ReadLine();

            if(input == "Southern")
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
            

            var x =  Console.Read();
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

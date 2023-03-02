using System;

namespace AllLoops
{
    public class Loops
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the methods to run:\n" +
                "1. Loop For.\n" +
                "2. Loop Foreach.\n" +
                "3. Loop Whil.\n" +
                "4. Loop Dowhile.\n");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    UsingLoops.ForLoop();
                    break;

                case "2":
                    UsingLoops.ForeachLoop();
                    break;

                case "3":
                    UsingLoops.WhileLoop();
                    break;

                case "4":
                    UsingLoops.DowhileLoop();
                    break;

                default:
                    Console.WriteLine("A valid option was not entered.\n" +
                        "Please choose a valid option.");
                    break;
            }
        }
    }

    public class UsingLoops
    {
        public static void ForLoop()
        {
            Console.WriteLine("With the For loop you can perform different tasks, this loop\n" +
                "executes one or more statements repeatedly as long as they meet with\n" +
                "the conditions(initializer; Conditión; iterator).\n" +
                "\nIn this simple example we will only make it show int type data,\n" +
                "here we will enter only one number and if this number is less than 50,\n" +
                "5 will be added and 3 will be subtracted.\n" +
                "\nPlease enter an integer:\n");

            string? number = Console.ReadLine();
            int i = int.Parse(number);

            for (i = 0; i < 50; i+=5, i-=3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nAnd if the number was less than 50 it will show us a series of numbers,\n" +
                "and once it no longer meets the assigned condition it will stop.\n" +
                "The For loop can be used to modify arrays, lists, variables, show data, etc.\n");
        }

        public static void ForeachLoop()
        {
            Console.WriteLine("The Foreach loop helps us to execute a statement repetitively \n" +
                "but unlike the for loop in the Foreach loop excecutes a statement or block of statements\n" +
                "for each element in an instance.\n");

            string[] arraystring = { "Pepe", "Pedro", "Agustin", "Pablo", "Pancracio"};

            foreach (string name in arraystring )
            {
                Console.WriteLine(name + ", ");
            }

            Console.WriteLine("\nIn this case we only show the elements of an array of type string\n" +
                "but usually this loop is used when you don't know how many elements an instance has.\n");
        }

        public static void WhileLoop()
        {
            Console.WriteLine("The While Loop executes a statement or a block of statements\n" +
                "while a specified Boolean expression evaluates to true or false and if from the beginning it is not fulfilled\n" +
                "with this then it will not be executed.\n" +
                "\nTry to guess between 1 and 10 the correct number to activate the loop\n" +
                "Type the number:\n" +
                "\n~2~\n");

            string? numero = Console.ReadLine();
            int number = int.Parse(numero);
            while (number == 2)
            {
                Console.WriteLine("You managed to guess the number!");
                break;
            }

            Console.WriteLine("\nAnd as in the rest of loops, with the While loop we can\n" +
                "excecute statements, modify variables, etc.\n");
        }

        public static void DowhileLoop()
        {
            Console.WriteLine("The Do-while loop is different from the While loop because while in the While loop\n" +
                "a Boolean expression is executed that will determine whether a statement or block of statements will be executed,\n" +
                "in the While loop the statements or block of statements it contains are executed at least once\n" +
                "and then a boolean expression determines whether it will be excute again.\n");

            string? answer = "y";
            do
            {
                Console.WriteLine("This is a Do-while loop.\n" +
                    "Do you want to repeat the loop? y/n");
                answer = Console.ReadLine();
            } while (answer == "y");

            Console.WriteLine("\nThe Do-while loop can be used in the same way as the While loop\n" +
                "with the difference that will be executed at least once.\n");
        }
    }
}
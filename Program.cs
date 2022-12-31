using System;

namespace mis221_lab5_lacyrich
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu(); 

        }

        static void Menu()
        {
            Random r = new Random ();
            int rows = r.Next(3, 9);
            int columns = r.Next(3, 9);

            DisplayMenu();

            Console.WriteLine("Please enter your integer choice:");

            string userInput = Console.ReadLine();

            while(userInput != "3")
            {
                if(userInput != "1" && userInput != "2")
                {
                    Console.WriteLine("Invalid Choice");
                    userInput = Console.ReadLine();
                }
                else if(userInput == "1")
                {
                    GetChips(ref rows, ref columns);
                }
                else if(userInput == "2")
                {
                    StackedChips(ref rows, ref columns);
                }

                DisplayMenu();

                userInput = Console.ReadLine();
            } 
        }
        static void DisplayMenu()
        {
            System.Console.WriteLine("Enter 1 to display the number of chips Preston starts with");
            System.Console.WriteLine("Enter 2 to display the chips Preston hasn't played");
            System.Console.WriteLine("Enter 3 to exit");
        }

        static void GetChips(ref int rows, ref int columns)
        {
           

            for(int i = 0; i < rows; i++){
                for(int j = 0; j< columns; j++){
                Console.Write("O");
                }
            
            Console.WriteLine();
            }
            
        }

        static void StackedChips(ref int rows, ref int columns)
        {
            for(int i = 0; i < rows; i++){
                for(int j = 0; j< columns; j++){
                    Random r = new Random();
                    int blank = r.Next(2);
                    if(blank == 1){
                        Console.Write(" ");
                    }
                    else{
                        Console.Write("O");
                    }
                }
            
            Console.WriteLine();
            }
            //int number = r.Next();
        }
    }
}


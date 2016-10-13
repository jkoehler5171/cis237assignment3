using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        public void MainMenu()
        {
            Boolean exitBool = false;
            int choiceInt = 0;

            while (exitBool != true)
            {
                Console.WriteLine("Greetings User");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1) Add a new Droid");
                Console.WriteLine("2) List all current Droids");
                Console.WriteLine("3) Exit Program");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    switch (choiceInt)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:
                            exitBool = true;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid option.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine();
                }
            }
        }

        private void AddDroidType()
        {
            bool exitBool = false;
            int choiceInt = 0;


            while (exitBool != true)
            {
                Console.WriteLine();
                Console.WriteLine("What type of droid would you like to add?");
                Console.WriteLine();
                Console.WriteLine("1) Protocol Droid");
                Console.WriteLine("2) AstroMech Droid");
                Console.WriteLine("3) Janitor Droid");
                Console.WriteLine("4) Cancel");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    switch (choiceInt)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:
                            exitBool = true;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid option.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine();
                }


            }
        }



    }
}









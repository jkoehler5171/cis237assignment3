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
                            InvalidSelectionMessage();
                            break;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                }
            }
        }

        private void AddDroidType()
        {
           
            int choiceInt = 0;          
            
                Console.WriteLine();
                Console.WriteLine("What type of droid would you like to add?");
                Console.WriteLine();
                Console.WriteLine("1) Protocol Droid");
                Console.WriteLine("2) AstroMech Droid");
                Console.WriteLine("3) Janitor Droid");
                

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
                        default:
                            InvalidSelectionMessage();
                            break;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                }


            
        }

        private void ProtocolSelected()
        {
            
        }

        private void JanitorSelected()
        {

        }

        private void AstromechSelected()
        {

        }

        private string MaterialQuestion()
        {
            int choiceInt = 0;

            Console.WriteLine();
            Console.WriteLine("Please select a Droid casing material");
            Console.WriteLine();
            Console.WriteLine("1)Plastoid");
            Console.WriteLine("2)Durasteel");
            Console.WriteLine("3)Bronzium");

            try
            {
                choiceInt = Convert.ToInt32(Console.ReadLine());

                switch (choiceInt)
                {
                    case 1:
                        return "Plastoid";

                    case 2:
                        return "Durasteel";

                    case 3:
                        return "Bronzium";

                    default:
                        InvalidSelectionMessage();
                        return "Error";
                }
            }
            catch
            {
                InvalidSelectionMessage();
                return "Error";
            }

        }
            
        private string ColorQuestion()
        {
            int choiceInt = 0;
            
            Console.WriteLine();
            Console.WriteLine("Please select color for your Droid");
            Console.WriteLine();
            Console.WriteLine("1)Gold");
            Console.WriteLine("2)Blue");
            Console.WriteLine("3)Black");

            try
            {
                choiceInt = Convert.ToInt32(Console.ReadLine());

                switch (choiceInt)
                {
                    case 1:
                        return "Gold";
                    case 2:
                        return "Blue";
                    case 3:
                        return "Black";
                    default:
                        InvalidSelectionMessage();
                        return "Error";
                }
            }
            catch
            {
                InvalidSelectionMessage();
                return "Error";
            }

        }


        private int LangaugesQuestion()
        {
            int numberOfLanguagesInt;

            Console.WriteLine();
            Console.WriteLine("Please enter the number of languages you would like installed(minimum 1):");
            try
            {
                numberOfLanguagesInt = Convert.ToInt32(Console.ReadLine());
                if(numberOfLanguagesInt < 1)
                {
                    InvalidSelectionMessage();                    
                    return 0;
                }
                else
                {
                    return numberOfLanguagesInt;
                }
            }
            catch
            {
                InvalidSelectionMessage();
                return 0;               
            }
        }

        private int ShipsQuestion()
        {
            int numberOfShipsInt;

            Console.WriteLine();
            Console.WriteLine("Please enter the number of ship compatability modules you would like installed(minimum 1):");
            try
            {
                numberOfShipsInt = Convert.ToInt32(Console.ReadLine());
                if (numberOfShipsInt < 1)
                {
                    InvalidSelectionMessage();
                    return 0;
                }
                else
                {
                    return numberOfShipsInt;
                }
            }
            catch
            {
                InvalidSelectionMessage();
                return 0;
            }
        }

        private bool ToolboxQuestion()
        {
            int choiceInt;
            bool exitBool = false;
            bool questionBool = false;

            while (exitBool != true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to have an integrated toolbox installed?");
                Console.WriteLine();
                Console.WriteLine("1)Yes");
                Console.WriteLine("2)No");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    if(choiceInt == 1)
                    {
                        questionBool = true;
                        exitBool = true;
                    }
                    if(choiceInt == 2)
                    {
                        questionBool = false;
                        exitBool = true;
                    }                    
                }
                catch
                {
                    InvalidSelectionMessage();
                }
            }
            return questionBool;

            
        }

        private bool ComputerQuestion()
        {
            int choiceInt;
            bool exitBool = false;
            bool questionBool = false;

            while (exitBool != true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to have a computer interface installed?");
                Console.WriteLine();
                Console.WriteLine("1)Yes");
                Console.WriteLine("2)No");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    if (choiceInt == 1)
                    {
                        questionBool = true;
                        exitBool = true;
                    }
                    if (choiceInt == 2)
                    {
                        questionBool = false;
                        exitBool = true;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                }
            }
            return questionBool;


        }

        private bool ArmQuestion()
        {
            int choiceInt;
            bool exitBool = false;
            bool questionBool = false;

            while (exitBool != true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to have a multi-purpose arm installed?");
                Console.WriteLine();
                Console.WriteLine("1)Yes");
                Console.WriteLine("2)No");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    if (choiceInt == 1)
                    {
                        questionBool = true;
                        exitBool = true;
                    }
                    if (choiceInt == 2)
                    {
                        questionBool = false;
                        exitBool = true;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                }
            }
            return questionBool;


        }


        private bool TrashQuestion()
        {
            int choiceInt;
            bool exitBool = false;
            bool questionBool = false;

            while (exitBool != true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to have a trash compactor installed?");
                Console.WriteLine();
                Console.WriteLine("1)Yes");
                Console.WriteLine("2)No");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    if (choiceInt == 1)
                    {
                        questionBool = true;
                        exitBool = true;
                    }
                    if (choiceInt == 2)
                    {
                        questionBool = false;
                        exitBool = true;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                }
            }
            return questionBool;


        }

        private bool VacuumQuestion()
        {
            int choiceInt;
            bool exitBool = false;
            bool questionBool = false;

            while (exitBool != true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to have a vaccum tool installed?");
                Console.WriteLine();
                Console.WriteLine("1)Yes");
                Console.WriteLine("2)No");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    if (choiceInt == 1)
                    {
                        questionBool = true;
                        exitBool = true;
                    }
                    if (choiceInt == 2)
                    {
                        questionBool = false;
                        exitBool = true;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                }
            }
            return questionBool;


        }

        private bool ExtingisherQuestion()
        {
            int choiceInt;
            bool exitBool = false;
            bool questionBool = false;

            while (exitBool != true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to have a fire extingusher installed?");
                Console.WriteLine();
                Console.WriteLine("1)Yes");
                Console.WriteLine("2)No");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    if (choiceInt == 1)
                    {
                        questionBool = true;
                        exitBool = true;
                    }
                    if (choiceInt == 2)
                    {
                        questionBool = false;
                        exitBool = true;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                }
            }
            return questionBool;


        }
        
        private void InvalidSelectionMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a valid option.");
            Console.WriteLine();
        }

    }
}









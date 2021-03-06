﻿//Jordan Koehler
//TR 3:30 to 5:45
//Oct 17th 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        public UserInterface(DroidCollection droids)
        {

        }


        public void MainMenu(DroidCollection droids) // The Main menu of the user inteface. Uses a Swtich/Case Structure
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
                            AddDroidType(droids);
                            break;
                        case 2:
                            droids.PrintDroidList();
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

        private void AddDroidType(DroidCollection droids) //User Menu for Adding Droids. Swtich/Case
        {
           
            int choiceInt = 0;
            bool exitBool = false;
                       
                Console.WriteLine();
                Console.WriteLine("What type of droid would you like to add?");
                Console.WriteLine();
                Console.WriteLine("1) Protocol Droid");                
                Console.WriteLine("2) AstroMech Droid");
                Console.WriteLine("3) Janitor Droid");
                Console.WriteLine("4) Utility Droid");

            while (exitBool != true)
            {
                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    switch (choiceInt)
                    {
                        case 1:
                            ProtocolSelected(droids);
                            exitBool = true;
                            break;
                        case 2:
                            AstromechSelected(droids);
                            exitBool = true;
                            break;
                        case 3:
                            JanitorSelected(droids);
                            exitBool = true;
                            break;
                        case 4:
                            UtilitySelected(droids);
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

        private void ProtocolSelected(DroidCollection droids) //Method for Adding a Protocol Droid. Pulls up a method containing each question.
        {
            string droidModel = "Protocol";
            Console.WriteLine();
            Console.WriteLine("Protocol Droid Selected");
            Console.WriteLine();

            string droidMaterial = MaterialQuestion();
            string droidColor = ColorQuestion();
            int droidLanguages = LangaugesQuestion();

            droids.addDroid(droidModel, droidMaterial, droidColor, droidLanguages);

            Console.WriteLine();
            Console.WriteLine("Exellent! You have added a new droid to the order list");
            Console.WriteLine(droids.PrintCurrentDroid());
            Console.WriteLine();
        }

        private void JanitorSelected(DroidCollection droids)//Method for adding a Janitor Droid
        {
            string droidModel = "Janitor";
            Console.WriteLine();
            Console.WriteLine("Janitor Droid Selected");
            Console.WriteLine();

            string droidMaterial = MaterialQuestion();
            string droidColor = ColorQuestion();
            bool droidToolbox = ToolboxQuestion();
            bool droidComputer = ComputerQuestion();
            bool droidArm = ArmQuestion();
            bool droidCompactor = TrashQuestion();
            bool droidVacuum = VacuumQuestion();

            droids.addDroid(droidModel, droidMaterial, droidColor, droidToolbox, droidComputer, droidArm, droidCompactor, droidVacuum);

            Console.WriteLine();
            Console.WriteLine("Exellent! You have added a new droid to the order list");

            Console.WriteLine(droids.PrintCurrentDroid());
            Console.WriteLine();
        }

        private void AstromechSelected(DroidCollection droids) //Method for adding an Astromech Droid
        {
            string droidModel = "Astromech";
            Console.WriteLine();
            Console.WriteLine("AstroMech Droid Selected");
            Console.WriteLine();
                        
            string droidMaterial = MaterialQuestion();
            string droidColor = ColorQuestion();
            bool droidToolbox = ToolboxQuestion();
            bool droidComputer = ComputerQuestion();
            bool droidArm = ArmQuestion();
            bool droidExtinguisher = ExtingisherQuestion();
            int droidShips = ShipsQuestion();

            droids.addDroid(droidModel, droidMaterial, droidColor, droidToolbox, droidComputer, droidArm, droidExtinguisher, droidShips);

            Console.WriteLine();
            Console.WriteLine("Exellent! You have added a new droid to the order list");
            Console.WriteLine(droids.PrintCurrentDroid());
            Console.WriteLine();
        }

        private void UtilitySelected(DroidCollection droids) //Method for adding a Utility Droid
        {
            string droidModel = "Utility";
            Console.WriteLine();
            Console.WriteLine("Utility Droid Selected");
            Console.WriteLine();

            string droidMaterial = MaterialQuestion();
            string droidColor = ColorQuestion();
            bool droidToolbox = ToolboxQuestion();
            bool droidComputer = ComputerQuestion();
            bool droidArm = ArmQuestion();          

            droids.addDroid(droidModel, droidMaterial, droidColor, droidToolbox, droidComputer, droidArm);

            Console.WriteLine();
            Console.WriteLine("Exellent! You have added a new droid to the order list");
            Console.WriteLine(droids.PrintCurrentDroid());
            Console.WriteLine();
        }

        private string MaterialQuestion()//User question for determining material
        {
            int choiceInt = 0;
            bool exitBool = false;
            string answerString = "Error";

            Console.WriteLine();
            Console.WriteLine("Please select a Droid casing material");
            Console.WriteLine();
            Console.WriteLine("1)Plastoid");
            Console.WriteLine("2)Durasteel");
            Console.WriteLine("3)Bronzium");

            while (exitBool != true)
            {
                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    switch (choiceInt)
                    {
                        case 1:
                            answerString= "Plastoid";
                            exitBool = true;
                            break;
                        case 2:
                            answerString= "Durasteel";
                            exitBool = true;
                            break;
                        case 3:
                            answerString= "Bronzium";
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
            return answerString;

        }
            
        private string ColorQuestion()//User question for determining droid color
        {
            int choiceInt = 0;
            bool exitBool = false;
            string answerString = "Error";

            Console.WriteLine();
            Console.WriteLine("Please select color for your Droid");
            Console.WriteLine();
            Console.WriteLine("1)Gold");
            Console.WriteLine("2)Blue");
            Console.WriteLine("3)Black");

            while (exitBool != true)
            {
                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    switch (choiceInt)
                    {
                        case 1:
                            answerString = "Gold";
                            exitBool = true;
                            break;
                        case 2:
                            answerString = "Blue";
                            exitBool = true;
                            break;
                        case 3:
                            answerString = "Black";
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
            return answerString;
        }


        private int LangaugesQuestion()//User question for determining number of languages spoken by a protocol droid
        {
            int numberOfLanguagesInt = 1;
            bool exitBool = false;

            Console.WriteLine();
            Console.WriteLine("Please enter the number of languages you would like installed(minimum 1):");

            while (exitBool != true)
            {
                try
                {
                    numberOfLanguagesInt = Convert.ToInt32(Console.ReadLine());
                    if (numberOfLanguagesInt < 1)
                    {
                        InvalidSelectionMessage();

                    }
                    else
                    {
                        exitBool = true;
                    }
                }
                catch
                {
                    InvalidSelectionMessage();

                }
            }
            return numberOfLanguagesInt;
        }

        private int ShipsQuestion()//User question for determining number of compatible ships for Astromech droids
        {
            int numberOfShipsInt = 1;
            bool exitBool = false;

            Console.WriteLine();
            Console.WriteLine("Please enter the number of ship compatability modules you would like installed(minimum 1):");

            while (exitBool != true)
            {
                try
                {
                    numberOfShipsInt = Convert.ToInt32(Console.ReadLine());
                    if (numberOfShipsInt < 1)
                    {
                        InvalidSelectionMessage();
                        
                    }
                    else
                    {
                        exitBool = true; 
                    }
                }
                catch
                {
                    InvalidSelectionMessage();
                    
                }
            }
            return numberOfShipsInt;
        }

        private bool ToolboxQuestion()//User question for determining if the droid is equipped with a toolbox
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

        private bool ComputerQuestion()//User question for determining if the droid is equipped with a computer interface
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

        private bool ArmQuestion()//User question for determining if the droid is equipped with a multi-use utility arm
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


        private bool TrashQuestion()//User question for determining if the droid is equipped with a trash compactor
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

        private bool VacuumQuestion()//User question for determining if the droid is equipped with a vacuum
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

        private bool ExtingisherQuestion()//User question for determining if the droid is equipped with a fire extinguisher
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
        
        private void InvalidSelectionMessage()//Message to be displayed upon an invalid entry.
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a valid option.");
            Console.WriteLine();
        }

    }
}









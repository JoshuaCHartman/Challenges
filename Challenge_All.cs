using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Week1Challenge_All
{
    [TestClass]
    public class Challenge_All
    {
        [TestMethod]
        public void Pt1NamesPart4Operators()
        {
            //Part 1

            string firstName = "Josh";
            string lastName = "Hartman";
            int age = 41;

            //Operators
            /*
            int add = 41 + 7;
            int sub = 41 - 7;
            int product = 41 * 7;
            int quotient = 41 / 7;
            int remainder = 4 % 7;
            */
            Console.WriteLine("My age is " + age);
            Console.WriteLine("My age + 7 is " + (7 + age));
            Console.WriteLine("My age - 7 is " + (age - 7));
            Console.WriteLine("My age x 7 is " + (age * 7));
            Console.WriteLine("The whole number of my age / 7 is " + (age / 7));
            Console.WriteLine("The remainder of my age / 7 is " + (age % 7));
        }

        [TestMethod]
        public void Pt2Arrays()
        {
            //Part 2

            string[] favs = { "Book1", "Book2", "Book3", "Book4" };

        }

        [TestMethod]
        public void Pt3Lists()
        {

            // Pt 3

            

            var dt = DateTime.Now;
            var simpleDateConverted = dt.ToString("d");
            string simpleDateString = "11/12/2020";
     

            List<string> dAT = new List<string>();
            //add date & times d(ate) A(nd) T(ime) //
            {
                dAT.Add(dt.ToString("d"));
                dAT.Add(simpleDateConverted);
                dAT.Add(simpleDateString);
               
            }

            foreach (string i in dAT)
            { Console.WriteLine(i); }
            

            List<DateTime> dateList = new List<DateTime>();

            DateTime today = DateTime.Today;
            dateList.Add(today);
            dateList.Add(new DateTime(2020, 12, 25));
            dateList.Add(new DateTime(2020, 10, 31));
            dateList.Add(new DateTime(2020, 01, 01));

        }

        [TestMethod]
        public void Conditionals()

            //Pt 5 Conditionals
        {
            int sleepHours = 5;

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep");
            }
            else if (sleepHours > 8 && sleepHours < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (sleepHours > 4 && sleepHours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man get some sleep");
            }
            
            Console.ReadLine();
        }

        [TestMethod]
        public void SwitchCase()
        {
            //Pt 6 Switch Case

            Console.WriteLine("On a scale of 1-5, how was your day?");

            string userInput;
            userInput = Console.ReadLine();

            int convertInput;
            convertInput = Convert.ToInt32(userInput);

            switch (convertInput)
            {
                case 1:
                    Console.WriteLine(":(");
                    break;
                case 2:
                    Console.WriteLine("Bad");
                    break;
                case 3:
                    Console.WriteLine("Okay");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Great");
                    break;

                // add default
                default:
                    Console.WriteLine("Enter a number from 1 to 5");
                    break;
            }
           
        }

        [TestMethod]
        public void StringConversion()
        {
            // Pt 7 String Conversion

            string name = "SUPERCALIFRAGILISTICEXPEALIDOCIOUS";

            //--print each letter--//

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }


            //--change I / L / not I --//

            foreach (char letter in name)
            {
                if (letter == 'I')

                {
                    Console.WriteLine("I");
                }

                else if (letter == 'L')

                {
                    Console.WriteLine("L");
                }

                else

                {
                    Console.WriteLine("Not I");
                }
            }



            //make integer = numberOfLetters and set that starting to 0//
            int numberOfLetters = 0;
            foreach (char letter in name)
            {
                //add 1 to 0 for each letter in name//
                numberOfLetters++;
            }
            Console.WriteLine("There are " + numberOfLetters + " letters in Supercalifragilisticexpealidocious");
        }
    }
}

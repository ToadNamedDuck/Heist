using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a way to store multiple team members
            List<TeamMember> Team = new List<TeamMember>();

            //Randomized luck value.
            Random rnd = new Random();


            //Let's initialize a bank with 100 difficulty.
            Bank theBank = new Bank(100);

            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("________________");
            Console.WriteLine("We're going to need at least one team member to plan this heist.");
            Console.WriteLine("________________________________________________________________");
            //Initialize a team member.
            //This section will also be looped, to add more team members if the user would like.
            //We want the loop to break when an empty name is entered for the team member, according to the spec sheet.
            while (true)//inf loop til break condition is met.
            {
                Console.WriteLine("What is your team member's name?");
                string memberName = Console.ReadLine();
                //check if the name is empty
                if (memberName == "")
                {
                    break;
                }
                Console.WriteLine("Enter a whole number for this team member's Skill Level.");
                int memberSkill = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a decimal between 0.0 and 2.0 for this member's Courage Level.");
                double memberCourage = double.Parse(Console.ReadLine());
                //Take the three variables the user has input and construct our member.
                TeamMember newMember = new TeamMember(memberName, memberSkill, memberCourage);
                Team.Add(newMember);
                Console.WriteLine("Add another member? (Y/N)");
                if (!(Console.ReadLine().ToLower() == "y"))//Also ask them if they want to continue, so they know they can type something not "y"
                //to end this loop.
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            //Once that loop is finished, display a number of the members of the team, and then output each member's information.
            Console.WriteLine($"You have added {Team.Count} members to your heist team. Let's review each of them, now.");
            Console.WriteLine("_______________________________________________________________________________________");
            //save a total of everyone's skill level;
            int totalSkill = 0;
            foreach (TeamMember member in Team)
            {
                Console.WriteLine(member.ToString());
                totalSkill += member.SkillLevel;
            }

            Console.WriteLine($"Your team's total skill level is {totalSkill}.");
            Console.WriteLine($"The bank's difficulty level is {theBank.DifficultyLevel}.");

            Console.WriteLine("How many times should we run the calculations?");

            int numberOfRuns = int.Parse(Console.ReadLine());

            //loop over the simulation
            for (int i = 0; i < numberOfRuns; i++)
            {
                //generate the luck value of the bank.
                int luck = rnd.Next(-10, 10);
                theBank.DifficultyLevel += luck;
                if (theBank.DifficultyLevel < totalSkill)
                {
                    Console.WriteLine("You robbed this bank successfully!");
                }
                else
                {
                    Console.WriteLine("You failed to rob the bank.");
                }
            }
        }
    }
}

using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("________________");
            //Initialize a team member.
            Console.WriteLine("What is your team member's name?");
            string memberName = Console.ReadLine();
            Console.WriteLine("Enter a whole number for this team member's Skill Level.");
            int memberSkill = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a decimal between 0.0 and 2.0 for this member's Courage Level.");
            double memberCourage = double.Parse(Console.ReadLine());
            //Take the three variables the user has input and construct our member.
            TeamMember firstMember = new TeamMember(memberName, memberSkill, memberCourage);
            Console.WriteLine(firstMember.ToString());
        }
    }
}

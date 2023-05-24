using System;

namespace Heist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double Courage { get; set; }

        public TeamMember(string name, int skillLevel, double courage)
        {

            Name = name;
            SkillLevel = skillLevel;
            Courage = courage;

        }

        override public string ToString()
        {
            return $"{Name} - Skill Level of: {SkillLevel} - Courage Level of: {Courage}";
        }
    }
}
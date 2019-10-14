using System;
using System.Collections.Generic;

namespace planheist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist");

            List<TeamMember> team = new  List<TeamMember>();

            Console.WriteLine("Bank Difficulty: ");
            int bankDifficulty = int.Parse(Console.ReadLine());

            // int bankDifficulty = 100;
            // Random generator = new Random();
            // int luckValue  =  generator.Next(-10, 11);

            // bankDifficulty += luckValue;

            Console.Write("Name: ");
            string name = Console.ReadLine();

            while (name !=  "")  {

            Console.Write("Skill:  ");
            string skill  = Console.ReadLine();

            Console.Write("Courage: ");
            string courage =  Console.ReadLine();

            Console.WriteLine($"{name} has skill of {skill} and courage level of {courage}");

            // Dictionary<string,  string> member  =  new  Dictionary<string, string>() {
            //     {"Name",  name},
            //     {"Skill", skill},
            //     {"Courage", courage}
            // };

            TeamMember member = new TeamMember();
            member.Name = name;
            member.Skill = int.Parse(skill);
            member.Courage = double.Parse(courage);

            team.Add(member);

            //next person
            Console.Write("Name: ");
            name = Console.ReadLine();
            
            }

            int teamSkill = 0;
            foreach(TeamMember member in team){
                // Console.WriteLine("-------------------");
                // Console.WriteLine($"Name: {member["Name"]}");
                // Console.WriteLine($"Skill: {member["Skill"]}");
                // Console.WriteLine($"Courage: {member["Courage"]}");

                
            };

            Console.WriteLine("-------------------");
            Console.Write("Number of Runs: ");
            int trialRunCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");


            Console.WriteLine($"Team Size: {team.Count}");

            foreach(TeamMember member in team) {
                // string skillLevel =  member["Skill"];
                // teamSkill = teamSkill +  int.Parse(skillLevel);

                teamSkill += member.Skill;
            }
            
            HeistReport report = new HeistReport();

            // Dictionary<string ,int> report = new Dictionary<string, int>(){
            //     {"Successes", 0},
            //     {"Failures", 0}
            // };

            for(int i=0; i<trialRunCount; i++)
            {
            
            Random generator = new Random();
            int luckValue  =  generator.Next(-10, 11);

            int trialRunBankDifficulty = bankDifficulty + luckValue;

            Console.WriteLine($"Skill Level: {teamSkill}");
            Console.WriteLine($"Bank Difficulty: {trialRunBankDifficulty}");

            if (trialRunBankDifficulty > teamSkill) {
                Console.WriteLine("Team will FAIL");

                report.FailureCount++;

            }  else  {
                Console.WriteLine("Team will SUCCEED!");
                
                report.SuccessCount++;
            }
            }
            report.Print();
        }
    }
}

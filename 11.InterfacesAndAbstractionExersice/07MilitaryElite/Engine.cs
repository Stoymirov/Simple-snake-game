using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using MilitaryElite.IO.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite
{
    internal class Engine : IEngine

    {

        private IReader reader;
        private IWriter writer;


        private Dictionary<int, ISoldier> soldiers;
        public Engine(IWriter writer,IReader reader)
        {
            soldiers = new Dictionary<int, ISoldier>();
            this.writer = writer;
            this.reader = reader;
        }
        public void Run()
        {
            string input = String.Empty;
            while ((input = reader.ReadLine()) != "End")
            {
                try
                {


                    string[] tokens = input.Split();

                    writer.WriteLine(ProcessInput(tokens));
                }
                catch (Exception e)
                {
                }

                
            }
        }

        private string ProcessInput(string[] tokens)
        {
            string type = tokens[0];
            int id = int.Parse(tokens[1]);
            string firstName = tokens[2];
            string lastName = tokens[3];

            ISoldier soldier = default;

            switch (type)
            {
                case "Private":
                    soldier = GetPrivate(id, firstName, lastName, decimal.Parse(tokens[4]));
                    break;
                case "LieutenantGeneral":
                    soldier = GetLieutenantGeneral(id, firstName, lastName, tokens);
                    break;
                case "Engineer":
                    soldier = GetEngineer(id,firstName,lastName,tokens);
                    break;
                case "Commando":
                    soldier = GetCommando(id,firstName,lastName,tokens);
                    break;
                case "Spy":
                    soldier = GetSpy(id, firstName, lastName, int.Parse(tokens[4]));
                    break;
            }

            soldiers.Add(id, soldier);

            return soldier.ToString();
        }

        private ISoldier GetSpy(int id, string firstName, string lastName, int codeNumber)
        {
           return new Spy(id, firstName, lastName, codeNumber);
        }

        private ISoldier GetCommando(int id, string firstName, string lastName, string[] tokens)
        {
            bool isValid = Enum.TryParse<Corps>(tokens[5], out Corps corps);
            if (!isValid)
            {
                throw new Exception();
            }

            List<IMission> missions = new List<IMission>();
            for (int i = 6; i < tokens.Length; i+=2)
            {
                string CodeName = tokens[i];
                string missionsState = tokens[i + 1];

                bool isValidMissionState = Enum.TryParse<State>(missionsState, out State state);

                if (isValidMissionState == false)
                {
                    continue;
                }

                IMission mission = new Mission(CodeName, state);
                missions.Add(mission);
            }

            return new Commando(id, firstName, lastName, decimal.Parse(tokens[4]), corps, missions);
        }

        private ISoldier GetEngineer(int id, string firstName, string lastName, string[] tokens)
        {

            bool isValidCorps = Enum.TryParse<Corps>(tokens[5], out Corps corps);
            if (!isValidCorps)
            {
                throw new Exception();
            }

            List<IRepair> repairs = new List<IRepair>();

            for (int i = 6; i < tokens.Length; i += 2)
            {
                string partName = tokens[i];
                int hoursWorked = int.Parse(tokens[i + 1]);

                IRepair repair = new Repair(partName, hoursWorked);

                repairs.Add(repair);
            }
            return new Engineer(id, firstName, lastName, decimal.Parse(tokens[4]), corps, repairs);
        }

        private ISoldier GetLieutenantGeneral(int id, string firstName, string lastName, string[] tokens)
        {
            List<IPrivate> privates = new();

            for (int i = 5; i < tokens.Length; i++)
            {
                int soldierId = int.Parse(tokens[i]);
                IPrivate soldier = (IPrivate)soldiers[soldierId];
                privates.Add(soldier);
            }

            LieutenantGeneral solder = new(id, firstName, lastName, decimal.Parse(tokens[4]), privates);
            return solder;
        }

        private ISoldier GetPrivate(int id, string firstName, string lastName, decimal salary)
        {
            Private solder = new(id, firstName, lastName, salary);
            return solder;
        }
    }
}

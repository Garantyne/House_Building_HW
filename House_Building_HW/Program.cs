using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using House_Building_HW.house;
using House_Building_HW.team;

namespace House_Building_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Worker workerBasement = new Worker(SkillWorker.BasementSkill);
            Worker workerWalls = new Worker(SkillWorker.WindowSkill);
            workerBasement.WorkerMake(ref house, new Basement());
            workerWalls.WorkerMake(ref house, new Walls());
            workerWalls.WorkerMake(ref house, new Walls());
            workerWalls.WorkerMake(ref house, new Walls());
            workerWalls.WorkerMake(ref house, new Walls());
            TeamLeader teamLeader = new TeamLeader();
            teamLeader.WorkerMake(ref house, null);
        }
    }
}

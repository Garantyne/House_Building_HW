using House_Building_HW.house;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Building_HW.team
{
    public enum SkillWorker { BasementSkill,WallSkill,DoorSkill,WindowSkill,RoofSkill}
    internal class Worker : IWorker
    {
        private SkillWorker skillWorker;

        public Worker(SkillWorker skillWorker)
        {
            this.skillWorker = skillWorker;
        }

        public void WorkerMake(ref House house, IPart ipart)
        {
            if (ipart is Basement && skillWorker == SkillWorker.BasementSkill)
            {
                if(house.Basement == null)
                {
                    house.Basement = (Basement)ipart;
                }
                return;
            }
            else
            {
                Console.WriteLine("Специализация работника не соответсвует этой работе, найдите работника который умеет заливать фундамент");
                return;
            }
            if(ipart is Walls && skillWorker == SkillWorker.WindowSkill)
            {
                for(int i = 0; i< house.Walls.Length; i++)
                {
                    if (house.Walls[i]==null)
                    {
                        house.Walls[i] = (Walls)ipart;
                        break;
                    }
                    
                }
                return;
            }
            else
            {
                Console.WriteLine("Специализация работника не соответсвует этой работе, найдите работника который умеет возводить стены");
                return;
            }
            if (ipart is Door && skillWorker == SkillWorker.DoorSkill)
            {
                if(house.Door == null)
                {
                    house.Door = (Door)ipart;
                }
                else
                {
                    Console.WriteLine("Дверь установлена перейти к следующему этапу");
                }
                return;
            }
            else
            {
                Console.WriteLine("Специализация работника не соответсвует этой работе, найдите работника который умеет устанавливать двери");
                return;
            }
            if (ipart is Window && skillWorker == SkillWorker.WindowSkill)
            {
                for (int i = 0; i < house.Windows.Length; i++)
                {
                    if (house.Windows[i] == null)
                    {
                        house.Windows[i] = (Window)ipart;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Все окна уже установлены, переходите к установки крыши");
                    }
                }
                return;
            }
            else
            {
                Console.WriteLine("Специализация работника не соответсвует этой работе, найдите работника который умеет ставить окна");
                return;
            }
            if (ipart is Roof && skillWorker == SkillWorker.RoofSkill)
            {
                if(house.Roof == null)
                {
                    house.Roof = (Roof)ipart;
                }
                else
                {
                    Console.WriteLine("Строительство завершено");
                }
                return;
            }
            else
            {
                Console.WriteLine("Специализация работника не соответсвует этой работе, найдите работника который умеет крышевать");
                return;
            }

        }
    }
}

using House_Building_HW.house;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Building_HW.team
{
    internal class TeamLeader : IWorker
    {
        public void WorkerMake(ref House house, IPart ipart)
        {
            if(house.Basement != null)
            {
                Console.WriteLine("Фундамент залит");
                if(house.Walls != null)
                {
                    for(int i = 0; i< house.Walls.Length; i++) {
                        if (house.Walls[i] == null)
                        {
                            Console.WriteLine($"Поставьте {i + 1} стену");
                        }
                        else
                        {
                            Console.WriteLine("Стены поставлены");
                            if (house.Door == null)
                            {
                                Console.WriteLine("Утсановите дверь");
                            }
                            else
                            {
                                Console.WriteLine("Дверь установлена, можно продолжать дальше.");
                                if (house.Windows != null)
                                {
                                    for (int j = 0; j < house.Windows.Length; j++)
                                    {
                                        if (house.Windows[j] == null)
                                        {
                                            Console.WriteLine($"Поставьте {j + 1} окно");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Окна установлены");
                                    if(house.Roof == null)
                                    {
                                        Console.WriteLine("Утсановите крышу");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Крыша построена");
                                        Console.WriteLine("Дом построен");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Фундамент не залит залит");
                return;
            }
        }
    }
}

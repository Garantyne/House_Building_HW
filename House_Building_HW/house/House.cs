using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Building_HW.house
{
    internal class House:IPart
    {
        public Basement Basement { get; set; }
        public Walls[] Walls {  get; set; }
        public Door Door {  get; set; }
        public Window[] Windows {  get; set; }
        public Roof Roof { get; set; }

        public House()
        {
            Basement = null;
            Walls = new Walls[4];
            Door = null;
            Windows = new Window[4];
            Roof = null;
        }

        

        public void BuildingPart()
        {
            if(Basement == null)
            {
                Console.WriteLine("фундамент ещё не залит, залейте фундамент");
            }
            else
            {
                Console.WriteLine("Фундамент залит, идем дальше");
                if(Walls.Count() < 4) {
                    Console.WriteLine("вы возвели не все стены, возведите все стены");
                }
                else
                {
                    Console.WriteLine("Все стены возведены идем дальше.");
                    if(Door == null)
                    {
                        Console.WriteLine("Дверь отсутствует, поставьте дверь");
                    }else
                    {
                        Console.WriteLine("Дверь в наличии идем дальше");
                        if (Windows.Count() < 4)
                        {
                            Console.WriteLine("Не все окна установлены, установите все окна");
                        }
                        else
                        {
                            Console.WriteLine("Все окна присутствуют, идем дальше");
                            if(Roof == null)
                            {
                                Console.WriteLine("Крыши нет, поставьте крышу");
                            }
                            else
                            {
                                Console.WriteLine("Крыша установлена дом полностью завершон");
                            }
                        }
                    }
                }
            }
        }
    }
}

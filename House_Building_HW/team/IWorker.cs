using House_Building_HW.house;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Building_HW.team
{
    internal interface IWorker
    {
        void WorkerMake(ref House h, IPart ipart);
    }
}

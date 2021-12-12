using Game.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface ISalesService
    {
        void Sales(Customer customer, Campaign campaign);
    }
}

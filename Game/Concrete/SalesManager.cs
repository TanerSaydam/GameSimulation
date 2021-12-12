using Game.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sales(Customer customer, Campaign campaign)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " oyuncusuna " + " " + campaign.CampaignName + " satış yapıldı.");
        }
    }
}

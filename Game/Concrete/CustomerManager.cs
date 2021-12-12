using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " oyuncu kayıtı başarıyla gerçekleşti.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " oyuncu kayıtı başarıyla silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " oyuncu kayıtı başarıyla güncellendi.");
        }
    }
}

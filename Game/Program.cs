using Game.Concrete;
using Game.Entites;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------
            //1.     Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Ad = "Taner";
            customer1.Soyad = "Saydam";
            customer1.TcNo = "12345678910";
            customer1.DateOfBirthYear = 1989;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Ad = "Tugay";
            customer2.Soyad = "Saydam";
            customer2.TcNo = "12345678910";
            customer2.DateOfBirthYear = 1994;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Ad = "Seval";
            customer3.Soyad = "Saydam";
            customer3.TcNo = "12345678910";
            customer3.DateOfBirthYear = 1986;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer2);
            customerManager.Delete(customer3);
            //--------------------------------------------
            Console.WriteLine("----------------------------------------");
            //--------------------------------------------
            //2.     Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

            SalesManager salesManager = new SalesManager();
            //salesManager.Sales(customer1);
            //--------------------------------------------
            Console.WriteLine("----------------------------------------");
            //--------------------------------------------
            //3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yaz Kampanyası";

            Campaign campaign2 = new Campaign();
            campaign2.Id = 1;
            campaign2.CampaignName = "Güz Kampanyası";

            Campaign campaign3 = new Campaign();
            campaign3.Id = 1;
            campaign3.CampaignName = "Kış Kampanyası";


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign3);
            //--------------------------------------------
            Console.WriteLine("----------------------------------------");
            //--------------------------------------------
            //4.     Satışlarda kampanya entegrasyonunu simule ediniz.
            salesManager.Sales(customer1, campaign3);
            //--------------------------------------------
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
    }
}

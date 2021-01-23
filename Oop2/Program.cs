using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReelCustomer reelCustomer = new ReelCustomer();
            reelCustomer.Name ="Yusuf";
            reelCustomer.SurName ="Kızılırmak";
            reelCustomer.Id =1;
            reelCustomer.IdentityNo ="231232";
            reelCustomer.CustomerNo ="12345";


            LegalCustomer legalCustomer1 = new LegalCustomer();
            legalCustomer1.Id = 2;
            legalCustomer1.CustomerNo = "987654";
            legalCustomer1.FirmName = "Kodlama";
            legalCustomer1.TaxNo = "987";

            //base class implemete ettiği classın ref nosunu tutabilir
            //aynı sonucu verir.
            Customer customer3 = new ReelCustomer();// farklarına bak
            Customer customer4 = new LegalCustomer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(reelCustomer);
        }
    }
}

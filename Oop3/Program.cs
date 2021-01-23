using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //WishManager wishManager = new WishManager();
            //wishManager.Calculate();
            ////interface onu implemente eden classın referansını tutabilir.
            ////Aynı sonucu verir
            //ICrediManager wishManager1 = new WishManager();
            //wishManager1.Calculate();

            //CarManager carManager = new CarManager();
            //carManager.Calculate();

            //MortgageManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();



            ICrediManager wishManager2 = new WishManager();
            ICrediManager carManager2 = new CarManager();
            ICrediManager mortgageManager2 = new MortgageManager();


            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService filebaseLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            BasvuruManager basvuruManager1 = new BasvuruManager();
            basvuruManager.BasvuruYap(carManager2,new DataBaseLoggerService());
            basvuruManager1.BasvuruYapp(carManager2,                                                //polimorphism
                new List<ILoggerService> {new DataBaseLoggerService(),new FileLoggerService()});    //new lemeleri 30 31 inci satırdakiler gibi de yapabiliriz.




            //interface ile list cok iyi kullanılıyor.
            List<ICrediManager> crediManagers = new List<ICrediManager> 
            {wishManager2,carManager2,mortgageManager2};
            basvuruManager.CreditPreInfo(crediManagers);
        }
    }
}

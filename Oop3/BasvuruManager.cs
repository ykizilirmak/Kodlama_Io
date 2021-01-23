using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {//Dependency injection, method injection  arastır  soyut halleri parametre alıp somutu enjekte ediyoruz.
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService) 
        {
            //MortgageManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();  wrong

            crediManager.Calculate();
            loggerService.Log();
        }
                                                             //polimorphism                               
        public void BasvuruYapp(ICrediManager crediManager, List<ILoggerService> loggerServices)
        {
            //MortgageManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();  wrong

            crediManager.Calculate();
            foreach (var item in loggerServices)
            {
                item.Log();
            } 
        }


        public void CreditPreInfo(List<ICrediManager> crediManagers)
        {
            foreach (var item in crediManagers)
            {
                item.Calculate();
            }
        }
    }
}

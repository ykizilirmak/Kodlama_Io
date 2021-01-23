using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class MortgageManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("house credit calculated");

        }

        public void Doit()
        {
            throw new NotImplementedException();
        }
    }
}

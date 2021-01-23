using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class WishManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("wish credit calculated");
        }

        public void Doit()
        {
            throw new NotImplementedException();
        }
    }
}

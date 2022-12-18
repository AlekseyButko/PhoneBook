using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class PController<T> where T : Hero 
    {
        public T Data;
        public PController(T data) 
        {
            Data= data;
        }
        public void Print() { Console.WriteLine(Data); }
        public void ForceToAttack()
        {
            Data.Attack();
        }
    }
}

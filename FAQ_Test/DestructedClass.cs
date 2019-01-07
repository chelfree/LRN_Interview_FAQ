using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAQ_Test
{
    public class DestructedClass
    {
        int k;

        public DestructedClass(int i)
        {
            k = i;
        }

        // Деструктор
        ~DestructedClass()
        {
            //вызывается через неопределенное время минут через 10-20
            Console.WriteLine("Object {0} destroyed", k);
        }

        // Метод создающий и тут же уничтожающий объект
        public void objectGenerator(int i)
        {
            DestructedClass ob = new DestructedClass(i);
        }
    }
}

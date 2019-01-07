using System;

namespace FAQ_Test
{
    public class PointClass
    {
        public int no1, no2;

        public PointClass(int n1, int n2)
        {
            this.no1 = n1;
            this.no2 = n2;
        }

        public void ShowValues()
        {
            Console.WriteLine("{0}, {1}", this.no1, this.no2);
        }
    }

    // Создадим структуру
    public struct PointStruct
    {
        public int no1, no2;

        public PointStruct(int n1, int n2)
        {
            this.no1 = n1;
            this.no2 = n2;
        }

        public void ShowValues()
        {
            Console.WriteLine("{0}, {1}", this.no1, this.no2);
        }
    }
}

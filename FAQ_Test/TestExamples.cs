using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAQ_Test
{
    public static class TestExamples
    {
        public static void Increment_Decreent()
        {
            var i_inc = 1;
            var j_inc = 1;
            Console.WriteLine("j_inc = {0}", j_inc--);
            Console.WriteLine("i_inc = {0}", --i_inc);

            var i_dec = 10;
            var j_dec = 10;
            Console.WriteLine("j_dec = {0}", j_dec--);
            Console.WriteLine("i_dec = {0}", --i_dec);

            for (int i_loop = 0; i_loop < 1; ++i_loop)
            {
                Console.WriteLine("i_loop = {0}", i_loop);
            }

            
        }

        public static void StructVsClass()
        {
            PointClass pc = new PointClass(10, 20);
            Console.WriteLine("After Object for Class created: ");
            pc.ShowValues();
            ModifyClassValues(pc); //Класс передается по ссылке
            Console.WriteLine("After ModifyClassValues Method Invoke: ");
            pc.ShowValues();

            Console.WriteLine("\n--------------");
            PointStruct ps = new PointStruct(10, 20);
            Console.WriteLine("After Object for Structure created: ");
            ps.ShowValues();
            ModifyStructValues(ps); //Структура передается по значению
            //ModifyStructValues(ref ps); //Но структуру можно тоже передовать по ссылке используя модификаторы out и ref
            Console.WriteLine("After ModifyStructValues Method Invoke: ");
            ps.ShowValues();
        }

        private static void ModifyStructValues(PointStruct ps)
        {
            ps.no1 += 100;
            ps.no2 += 100;

            Console.WriteLine("Within ModifyStructValues: {0}, {1}", ps.no1, ps.no2);
        }

        private static void ModifyStructValues(ref PointStruct ps)
        {
            ps.no1 += 100;
            ps.no2 += 100;

            Console.WriteLine("Within ModifyStructValues: {0}, {1}", ps.no1, ps.no2);
        }

        private static void ModifyClassValues(PointClass pc)
        {
            pc.no1 += 100;
            pc.no2 += 100;

            Console.WriteLine("Within ModifyClassValues: {0}, {1}", pc.no1, pc.no2);
        }

        public static void DestructorExample()
        {
            int i = 1;
            DestructedClass obj = new DestructedClass(0);

            for (; i < 120000; i++)
            {
                obj.objectGenerator(i);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThe end");
        }

        public static void ArrayZeroAndOnes()
        {
            int[] curArray = new int[] { 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1 };

            int commonSumm = 0;
            int countOnes = 0;

            //в один проход с конца
            for (int i = curArray.Length - 1; i >= 0; i--)
            {
                if (curArray[i] == 0)
                {
                    commonSumm += countOnes;
                }
                else
                {
                    countOnes++;
                }
            }

            //в один проход с начала
            //for (var i = 0; i < curArray.Length; i++)
            //{
            //    if (curArray[i] == 0)
            //    {
            //        countOnes++;
            //    }
            //    else
            //    {
            //        commonSumm += countOnes;
            //    }
            //}

            //for (int i = 0; i < curArray.Length; i++)
            //{
            //    if (curArray[i] == 0)
            //    {
            //        int countOnes = 0;

            //        for (int j = i + 1; j < curArray.Length; j++)
            //        {
            //            if (curArray[j] == 1)
            //            {
            //                countOnes++;
            //            }
            //        }

            //        commonSumm += countOnes;
            //    }
            //}

            Console.WriteLine("Common summ = {0}", commonSumm);
        }
    }
}

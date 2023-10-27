using System;

namespace Lib1 //имя пространстваЪ
{
    public class Class1
    {
        /// <summary>
        /// GetRaz имя метода
        /// </summary>
        /// <param name="K"></param> число k
        /// <param name="sum"></param> сумма
        /// <param name="kol"></param> колличество
        /// <param name="value"></param> переменная
        /// <param name="raz"></param> результат

        public static void GetRaz(int K, ref int sum, ref int kol, out int value, ref int raz)
        {
            value = 0;
            Random rnd = new Random();


            value = rnd.Next(2, 10); 
            sum += value; 
            raz -= value; 
            kol++; 

        }
    }
}

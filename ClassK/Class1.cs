using System;

namespace Lib1 //��� �������������
{
    public class Class1
    {
        /// <summary>
        /// GetRaz ��� ������
        /// </summary>
        /// <param name="K"></param> ����� k
        /// <param name="sum"></param> �����
        /// <param name="kol"></param> �����������
        /// <param name="value"></param> ����������
        /// <param name="raz"></param> ���������

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

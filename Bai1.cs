using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Bai1
    {
        int n;
        public void nhapn()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        public int Tinhtong()
        {
            int i, S = 0;
           
            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    S += i - (i + 1);
            }
            return S;
        }
      
        public double Tinhtong_PhanSo()
        {
            int j;
            double A = 0.0;
           
            for (j = 1; j <= n; j++)
            {
                 A = A + 1 / (double)j;
            }
            return A;
        }
        public int Tinhtong_Giamdan()
        {
            int k, Sum = 0;          
            for(k = n; k > 0; k--)
            {
                Sum += k;
            }
            return Sum;
        }
        public int Tinhtong_uoc()
        {
            int b, Tong = 0;
            for (b = 1; b < n; b++)
            {
                if (n % b == 0)
                    Tong += b;
            }
            return Tong;
        }
       
        public void In()
        {
            Console.WriteLine("Ket qua cua phep tinh 1 - 2 + 3 - 4 + 5 - ... + n la: {0} \n" +
                "Ket qua cua phep tinh 1 + 1/2 + 1/3 +....+ 1/n la: {1} \n" +
                "Ket qua cua phep tinh n + (n - 1) + (n - 2) + ... + 1 la: {2} \n" +
                "Ket qua cua cac uoc cua n la: {3}", 
                this.Tinhtong(), this.Tinhtong_PhanSo(), this.Tinhtong_Giamdan(), this.Tinhtong_uoc());
        }
    }
}

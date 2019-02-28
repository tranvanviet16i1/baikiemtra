using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class HK
    {
        string maTau;
        int Soluong;

        public void Nhap()
        {
            Console.WriteLine("Nhap ma tau: ");
            this.maTau = Console.ReadLine();
            Console.WriteLine("Nhap so luong Hk: ");
            this.Soluong = Int32.Parse(Console.ReadLine());
        }
        public int tinhtongtien()
        {
            int S = 0;
            if (this.Soluong < 100)
                S = this.Soluong * 100000;
            else S = this.Soluong * 80000;
            return S;
        }
        public void In()
        {
            Console.WriteLine("Tau {0} co tong tien la {1}", this.maTau, this.tinhtongtien());
        }
    }
}

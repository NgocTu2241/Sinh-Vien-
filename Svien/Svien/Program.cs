using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svien
{
    internal class Program
    {
        struct sinhVien156
        {
            public string msv156;
            public string ten156;
            public String lop156;
            public double diem156;
        }
        enum xepLoai
        {
            yeu156 = 4,
            trungBinh156 = 5,
            kha156 = 7,
            gioi156 = 9
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            sinhVien156[] sv156 = new sinhVien156[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap ma sinh vien {0}: ", i + 1);
                sv156[i].msv156 = Console.ReadLine();
                Console.WriteLine("\nNhap ho ten sinh vien {0}: ", i + 1);
                sv156[i].ten156 = Console.ReadLine();
                Console.WriteLine("Nhap lop sinh vien {0}: ", i + 1);
                sv156[i].lop156 = Console.ReadLine();
                Console.WriteLine("Nhap diem sinh vien {0}: ", i + 1);
                sv156[i].diem156 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDanh sach SV:");
            foreach (sinhVien156 sv in sv156)
            {
                Console.Write(sv.msv156 + "\t");
                Console.Write(sv.ten156 + "\t");
                Console.Write(sv.lop156 + "\t");
                Console.Write(sv.diem156 + "\n");
            }

            Console.WriteLine("Nhap ten SV can tim");
            String name = Console.ReadLine();
            int find = 0;
            foreach (sinhVien156 sv in sv156)
            {
                if (String.Compare(name, sv.ten156) == 0)
                {
                    Console.Write(sv.msv156 + "\t");
                    Console.Write(sv.ten156 + "\t");
                    Console.Write(sv.lop156 + "\t");
                    String loai = "";
                    if (sv.diem156 >= (double)xepLoai.gioi156)
                        loai = "gioi";
                    else if (sv.diem156 >= (double)xepLoai.kha156)
                        loai = "kha";
                    else if (sv.diem156 >= (double)xepLoai.trungBinh156)
                        loai = "trung binh";
                    else if (sv.diem156 >= (double)xepLoai.yeu156)
                        loai = "yeu";
                    Console.Write("{0} xep loai: {1} \n", sv.diem156, loai);

                }
                else find++;
            }
            if (find == sv156.Length)
            {
                Console.WriteLine("Khong co SV nao co ten {0} !!", name);
            }
            Console.ReadKey();
        }
    }
}
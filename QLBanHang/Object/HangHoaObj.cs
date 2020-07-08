using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class HangHoaObj
    {
        string ma, ten;
        int dongia, soluong;

        public int Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string MaHangHoa { get => ma; set => ma = value; }
        public string TenHangHoa { get => ten; set => ten = value; }

        public HangHoaObj() { }
        public HangHoaObj(string ma, string ten, int dongia, int soluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.dongia = dongia;
            this.soluong = soluong;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class HoaDonObj
    {
        string ma, ngaylap, nguoilap, khachhang;

        public string Ma { get => ma; set => ma = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Nguoilap { get => nguoilap; set => nguoilap = value; }
        public string Khachhang { get => khachhang; set => khachhang = value; }

        public HoaDonObj() { }

        public HoaDonObj(string ma, string ngaylap, string nguoilap, string khachhang)
        {
            this.ma = ma;
            this.ngaylap = ngaylap;
            this.nguoilap = nguoilap;
            this.khachhang = khachhang;
        }
    }
}


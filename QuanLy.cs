using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Quản lý (Mã quản lý, Tên quản lý, SĐT)
    public class QuanLy
    {
        public string maQuanLy { get; set; }
        public string tenQuanLy { get; set; }
        public Toa maToa { get; set;}
        public string soDienThoai { get; set; }

        public QuanLy(string maQuanLy, string tenQuanLy,Toa maToa, string soDienThoai)
        {
            this.maQuanLy = maQuanLy;
            this.tenQuanLy = tenQuanLy;
            this.maToa = maToa;
            this.soDienThoai = soDienThoai;
        }
        public QuanLy(QuanLy ql)
        {
            maQuanLy = ql.maQuanLy;
            tenQuanLy = ql.tenQuanLy;
            maToa = ql.maToa;
            soDienThoai = ql.soDienThoai;
        }
    }
}

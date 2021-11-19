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
        public Toa toa { get; set;}
        public string soDienThoai { get; set; }

        public QuanLy(string maQuanLy, string tenQuanLy,Toa toa, string soDienThoai)
        {
            this.maQuanLy = maQuanLy;
            this.tenQuanLy = tenQuanLy;
            this.toa = toa;
            this.soDienThoai = soDienThoai;
        }
        public QuanLy(QuanLy ql)
        {
            maQuanLy = ql.maQuanLy;
            tenQuanLy = ql.tenQuanLy;
            toa = ql.toa;
            soDienThoai = ql.soDienThoai;
        }
    }
}

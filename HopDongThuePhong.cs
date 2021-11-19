using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Hợp đồng thuê phòng (Mã HĐ, Mã SV, Ngày ký)
    public class HopDongThuePhong
    {
        public string maHopDong { get; set; }
        public SinhVien maSV { get; set; }
        public string ngayKy { get; set; }

        public HopDongThuePhong(string maHopDong, SinhVien maSV, string ngayKy)
        {
            this.maHopDong = maHopDong;
            this.maSV = maSV;
            this.ngayKy = ngayKy;
        }
        public HopDongThuePhong(HopDongThuePhong hd)
        {
            maHopDong = hd.maHopDong;
            maSV = hd.maSV;
            ngayKy = hd.ngayKy;
        }
    }
}

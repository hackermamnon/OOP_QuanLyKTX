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
        public SinhVien sinhVien { get; set; }
        public string tenHopDong { get; set; }

        public HopDongThuePhong(string maHopDong, SinhVien sinhVien, string tenHopDong)
        {
            this.maHopDong = maHopDong;
            this.sinhVien = sinhVien;
            this.tenHopDong = tenHopDong;
        }
        public HopDongThuePhong(HopDongThuePhong hd)
        {
            maHopDong = hd.maHopDong;
            sinhVien = hd.sinhVien;
            tenHopDong = hd.tenHopDong;
        }
    }
}

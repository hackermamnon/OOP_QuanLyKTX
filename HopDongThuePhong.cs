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
        public string maSinhVien { get; set; }
        public string tenHopDong { get; set; }

        //related = singular
        public SinhVien sinhVien { get; set; }

        //Constructor
        public HopDongThuePhong() { }

        public HopDongThuePhong(string maHopDong, string maSinhVien, string tenHopDong, SinhVien sinhVien)
        {
            this.maHopDong = maHopDong;
            this.maSinhVien = maSinhVien;
            this.tenHopDong = tenHopDong;
            this.sinhVien = sinhVien;
        }
        public HopDongThuePhong(HopDongThuePhong hd)
        {
            this.maHopDong = hd.maHopDong;
            this.maSinhVien = hd.maSinhVien;
            this.tenHopDong = hd.tenHopDong;
            this.sinhVien = hd.sinhVien;
        }
    }
}

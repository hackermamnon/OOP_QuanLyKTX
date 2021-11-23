using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Sinh Viên (MaSV, Tên SV, Giới tính, SĐT, Mã phòng)
    public class SinhVien
    {
        public string maSV { get; set; }
        public string tenSV { get; set; }
        public bool gioiTinh { get; set; }
        public string soDienThoai { get; set; }

        public SinhVien(string maSV, string tenSV, bool gioiTinh, string soDienThoai)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
        }
        public SinhVien(SinhVien sv)
        {
            maSV = sv.maSV;
            tenSV = sv.tenSV;
            gioiTinh = sv.gioiTinh;
            soDienThoai = sv.soDienThoai;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Nhân viên (Mã nhân viên, Mã loại NV, Mã tòa, Tên nhân viên, SDT, Lương)
    public class NhanVien
    {
        public string maNV { get; set; }
        public LoaiNhanVien maLoaiNV { get; set; }
        public Toa maToa { get; set; }
        public string tenNhanVien { get; set; }
        public string soDienThoai { get; set; }
        public double luong { get; set; }

        public NhanVien(string maNV, LoaiNhanVien maLoaiNV, Toa maToa, string tenNhanVien, string soDienThoai, double luong)
        {
            this.maNV = maNV;
            this.maLoaiNV = maLoaiNV;
            this.maToa = maToa;
            this.tenNhanVien = tenNhanVien;
            this.soDienThoai = soDienThoai;
            this.luong = luong;
        }
        public NhanVien(NhanVien nv)
        {
            maNV = nv.maNV;
            maLoaiNV = nv.maLoaiNV;
            maToa = nv.maToa;
            tenNhanVien = nv.tenNhanVien;
            soDienThoai = nv.soDienThoai;
            luong = nv.luong;
        }
    }
}

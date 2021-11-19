using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Loại nhân viên (Mã loại NV, Chức vụ, Công việc)
    public class LoaiNhanVien
    {
        public string maLoaiNV { get; set; }
        public string chucVu { get; set; }
        public string congViec { get; set; }

        public LoaiNhanVien(string maLoaiNV, string chucVu, string congViec)
        {
            this.maLoaiNV = maLoaiNV;
            this.chucVu = chucVu;
            this.congViec = congViec;
        }
        public LoaiNhanVien(LoaiNhanVien lnv)
        {
            maLoaiNV = lnv.maLoaiNV;
            chucVu = lnv.chucVu;
            congViec = lnv.congViec;
        }
    }
}

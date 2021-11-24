using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    public class ChiTietHoaDonDichVu
    {
        public string maHoaDon { get; set; }
        public string maPhong { get; set; }
        public double tongTien { get; set; }
        public DateTime ngayThanhToan { get; set; }
        
        //related = singular
        public ChiTietHopDong chitiethopdong { get; set; }
        
        //related = plural
        public ICollection<DichVu> dsdichvu { get; set; }

        //Constructor
        public ChiTietHoaDonDichVu() { }
        public ChiTietHoaDonDichVu(string maHoaDon, string maPhong, double tongTien, DateTime ngayThanhToan,
            ChiTietHopDong chitiethopdong, ICollection<DichVu> dsdichvu)
        {
            this.maHoaDon = maHoaDon;
            this.maPhong = maPhong;
            this.tongTien = tongTien;
            this.ngayThanhToan = ngayThanhToan;
            this.chitiethopdong = chitiethopdong;
            this.dsdichvu = dsdichvu;
        }
        public ChiTietHoaDonDichVu(ChiTietHoaDonDichVu cthd)
        {
            this.maHoaDon = cthd.maHoaDon;
            this.maPhong = cthd.maPhong;
            this.tongTien = cthd.tongTien;
            this.ngayThanhToan = cthd.ngayThanhToan;
            this.chitiethopdong = cthd.chitiethopdong;
            this.dsdichvu = cthd.dsdichvu;
        }
    }
}

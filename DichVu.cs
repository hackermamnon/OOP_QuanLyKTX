using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Hóa đơn dịch vụ (Mã hóa đơn, Mã phòng, Tổng tiền, Ngày thanh toán) (1 hóa đơn/phòng nhưng thanh toán cho nhiều dịch vụ)
    public class DichVu
    {
        public string maHoaDon { get; set; }
        public Phong phong { get; set; }
        public double tongTien { get; set; }
        public DateTime ngayThanhToan { get; set; }

        public DichVu(string maHoaDon, Phong phong, double tongTien, DateTime ngayThanhToan)
        {
            this.maHoaDon = maHoaDon;
            this.phong = phong;
            this.tongTien = tongTien;
            this.ngayThanhToan = ngayThanhToan;
        }
        public DichVu(DichVu HoaDonDV)
        {
            maHoaDon = HoaDonDV.maHoaDon;
            phong = HoaDonDV.phong;
            tongTien = HoaDonDV.tongTien;
            ngayThanhToan = HoaDonDV.ngayThanhToan;
        }
    }
}
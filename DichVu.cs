using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //DichVu(Mã dịch vụ, tên dịch vụ)
    public class DichVu
    {
        public string maDichVu { get; set; }
        public string tenDichVu { get; set; }
        //related plural
        public ICollection<ChiTietHoaDonDichVu> hoadon { get; set; }

        //Constructor
        public DichVu() { }
        public DichVu(string maDichVu, string tenDichVu, ICollection<ChiTietHoaDonDichVu> hoadon)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.hoadon = hoadon;
        }
        public DichVu(DichVu HoaDonDV)
        {
            this.maDichVu = HoaDonDV.maDichVu;
            this.tenDichVu = HoaDonDV.tenDichVu;
            this.hoadon = HoaDonDV.hoadon;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Chi tiết hợp đồng (Mã HĐ, Mã phòng, Mã tòa, Ngày bắt đầu, Ngày kết thúc)
    public class ChiTiet_HD
    {
        public HopDongThuePhong maHopDong { get; set; }
        public Phong maPhong { get; set; }
        public Toa maToa { get; set; }
        public string ngayBatDau { get; set; }
        public string ngayKetThuc { get; set; }

        public ChiTiet_HD(HopDongThuePhong maHopDong, Phong maPhong, Toa maToa, string ngayBatDau, string ngayKetThuc)
        {
            this.maHopDong = maHopDong;
            this.maPhong = maPhong;
            this.maToa = maToa;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }
        public ChiTiet_HD(ChiTiet_HD ct)
        {
            maHopDong = ct.maHopDong;
            maPhong = ct.maPhong;
            maToa = ct.maToa;
            ngayBatDau = ct.ngayBatDau;
            ngayKetThuc = ct.ngayKetThuc;
        }
    }
}

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
        public HopDongThuePhong hopDong { get; set; }
        public Phong phong { get; set; }
        public Toa toa { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }

        public ChiTiet_HD(HopDongThuePhong hopDong, Phong phong, Toa toa, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.hopDong = hopDong;
            this.phong = phong;
            this.toa = toa;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }
        public ChiTiet_HD(ChiTiet_HD ct)
        {
            hopDong = ct.hopDong;
            phong = ct.phong;
            toa = ct.toa;
            ngayBatDau = ct.ngayBatDau;
            ngayKetThuc = ct.ngayKetThuc;
        }
    }
}

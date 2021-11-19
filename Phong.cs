using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Phòng (Mã phòng, Mã tòa, Mã loại phòng, Trạng thái)
    public class Phong
    {
        public string maPhong { get; set; }
        public Toa toa { get; set; }
        public LoaiPhong loaiPhong { get; set; }
        public bool trangThai { get; set; }

        public Phong(string maPhong, Toa toa, LoaiPhong loaiPhong, bool trangThai)
        {
            this.maPhong = maPhong;
            this.toa = toa;
            this.loaiPhong = loaiPhong;
            this.trangThai = trangThai;
        }
        public Phong(Phong p)
        {
            maPhong = p.maPhong;
            toa = p.toa;
            loaiPhong = p.loaiPhong;
            trangThai = p.trangThai;
        }
    }
}

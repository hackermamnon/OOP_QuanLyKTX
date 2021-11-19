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
        public Toa maToa { get; set; }
        public LoaiPhong maLoaiPhong { get; set; }
        public bool trangThai { get; set; }

        public Phong(string maPhong, Toa maToa, LoaiPhong maLoaiPhong, bool trangThai)
        {
            this.maPhong = maPhong;
            this.maToa = maToa;
            this.maLoaiPhong = maLoaiPhong;
            this.trangThai = trangThai;
        }
        public Phong(Phong p)
        {
            maPhong = p.maPhong;
            maToa = p.maToa;
            maLoaiPhong = p.maLoaiPhong;
            trangThai = p.trangThai;
        }
    }
}

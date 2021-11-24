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
        public string maToa { get; set; }
        public string maLoaiPhong { get; set; }
        public bool trangThai { get; set; }

        //related = singular
        public Toa toa { get; set; }
        public LoaiPhong loaiPhong { get; set; }

        //related = plural
        public ICollection<SinhVien> dssv_phong { get; set; }

        //Constructor
        public Phong() { }
        public Phong(string maPhong, string maToa, string maLoaiPhong,  Toa toa, LoaiPhong loaiPhong,
            bool trangThai, ICollection<SinhVien> dssv_phong)
        {
            this.maPhong = maPhong;
            this.maLoaiPhong = maLoaiPhong;
            this.maToa = maToa;
            this.toa = toa;
            this.loaiPhong = loaiPhong;
            this.trangThai = trangThai;
            this.dssv_phong = dssv_phong;
        }
        public Phong(Phong p)
        {
            this.maPhong = p.maPhong;
            this.maLoaiPhong = p.maLoaiPhong;
            this.maToa = p.maToa;
            this.toa = p.toa;
            this.loaiPhong = p.loaiPhong;
            this.trangThai = p.trangThai;
            this.dssv_phong = p.dssv_phong;
        }
    }
}

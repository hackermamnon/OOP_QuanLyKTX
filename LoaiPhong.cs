using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Loại phòng (Mã loại phòng, Tên loại phòng, Giá phòng)
    public class LoaiPhong
    {
        public string maLoaiPhong { get; set; }
        public string tenLoaiPhong { get; set; }
        public double giaPhong { get; set; }

        // related = plural
        public ICollection<Tho> dsphong_loai { get; set; }

        public LoaiPhong(string maLoaiPhong, string tenLoaiPhong, double giaPhong)
        {
            this.maLoaiPhong = maLoaiPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.giaPhong = giaPhong;
        }
        public LoaiPhong(LoaiPhong lp)
        {
            maLoaiPhong = lp.maLoaiPhong;
            tenLoaiPhong = lp.tenLoaiPhong;
            giaPhong = lp.giaPhong;
        }
    }
}

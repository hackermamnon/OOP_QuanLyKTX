using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    public class TrangBi
    {
        public string maLoaiPhong { get; set; }

        //related = singular
        public LoaiPhong loaiPhong { get; set; }

        //related = plural
        public ICollection<ThietBi> dsthietbi_loaiphong { get; set; }

        public TrangBi() { }
        public TrangBi(string maLoaiPhong, LoaiPhong loaiPhong, ICollection<ThietBi> dsthietbi_loaiphong)
        {
            this.maLoaiPhong = maLoaiPhong;
            this.loaiPhong = loaiPhong;
            this.dsthietbi_loaiphong = dsthietbi_loaiphong;
        }
        public TrangBi(TrangBi trb)
        {
            this.maLoaiPhong = trb.maLoaiPhong;
            this.loaiPhong = trb.loaiPhong;
            this.dsthietbi_loaiphong = trb.dsthietbi_loaiphong;
        }
    }
}

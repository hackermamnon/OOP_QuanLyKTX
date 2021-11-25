using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    public class TrangBi
    {
        public string maPhong { get; set; }
        public string maThietBi { get; set; }

        //related = singular
        public LoaiPhong loaiPhong { get; set; }

        //related = plural
        public ICollection<ThietBi> dsthietbi_loaiphong { get; set; }

        public TrangBi() { }
        public TrangBi(string maPhong, string maThietBi, LoaiPhong loaiPhong, ICollection<ThietBi> dsthietbi_loaiphong)
        {
            this.maPhong = maPhong;
            this.maThietBi = maThietBi;
            this.loaiPhong = loaiPhong;
            this.dsthietbi_loaiphong = dsthietbi_loaiphong;
        }
        public TrangBi(TrangBi trb)
        {
            this.maPhong = trb.maPhong;
            this.maThietBi = trb.maThietBi;
            this.loaiPhong = trb.loaiPhong;
            this.dsthietbi_loaiphong = trb.dsthietbi_loaiphong;
        }
    }
}

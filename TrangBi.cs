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
        public Phong phong { get; set; }
        //related = plural
        public ICollection<ThietBi> thietBi { get; set; }
        public TrangBi() { }

        public TrangBi(string maPhong, string maThietBi, Phong phong, ICollection<ThietBi> thietBi)
        {
            this.maPhong = maPhong;
            this.maThietBi = maThietBi;
            this.phong = phong;
            this.thietBi = thietBi;
        }
        public TrangBi(TrangBi trb)
        {
            this.maPhong = trb.maPhong;
            this.maThietBi = trb.maThietBi;
            this.phong = trb.phong;
            this.thietBi = trb.thietBi;
        }
    }
}

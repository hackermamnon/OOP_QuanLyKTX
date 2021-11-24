using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    public class ThietBi
    {
        public string maThietBi { get; set; }
        public string tenThietBi { get; set; }
        public bool trangThai { get; set; }
        //related = singular
        public TrangBi trangBi { get; set; }

        //Constructor
        public ThietBi() { }
        public ThietBi(string maThietBi, string tenThietBi, bool trangThai, TrangBi trangBi)
        {
            this.maThietBi = maThietBi;
            this.tenThietBi = tenThietBi;
            this.trangThai = trangThai;
            this.trangBi = trangBi;
        }
        public ThietBi(ThietBi tb)
        {
            this.maThietBi = tb.maThietBi;
            this.tenThietBi = tb.tenThietBi;
            this.trangThai = tb.trangThai;
            this.trangBi = tb.trangBi;
        }
    }
}

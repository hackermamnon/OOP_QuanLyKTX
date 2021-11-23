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

        public ThietBi(string maThietBi, string tenThietBi, bool trangThai)
        {
            this.maThietBi = maThietBi;
            this.tenThietBi = tenThietBi;
            this.trangThai = trangThai;
        }
        public ThietBi(ThietBi tb)
        {
            maThietBi = tb.maThietBi;
            tenThietBi = tb.tenThietBi;
            trangThai = tb.trangThai;
        }
    }
}

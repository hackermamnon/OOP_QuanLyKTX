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
       
        //Constructor
        public ThietBi() { }
        public ThietBi(string maThietBi, string tenThietBi)
        {
            this.maThietBi = maThietBi;
            this.tenThietBi = tenThietBi;
        }
        public ThietBi(ThietBi tb)
        {
            this.maThietBi = tb.maThietBi;
            this.tenThietBi = tb.tenThietBi;
        }
    }
}

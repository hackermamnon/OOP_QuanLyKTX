using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    public class TrangBi
    {
        public Phong phong { get; set; }
        public ThietBi thietBi { get; set; }

        public TrangBi(Phong phong, ThietBi thietBi)
        {
            this.phong = phong;
            this.thietBi = thietBi;
        }
        public TrangBi(TrangBi trb)
        {
            phong = trb.phong;
            thietBi = trb.thietBi;
        }
    }
}

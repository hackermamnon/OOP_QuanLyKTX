using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Tòa (Mã tòa, Mã quản lý, Sức chứa, Số lượng phòng)
    public class Toa
    {
        public char maToa { get; set; }
        public int sucChua { get; set; }
        public int soPhong { get; set; }

        public Toa(char maToa, int sucChua, int soPhong)
        {
            this.maToa = maToa;
            this.sucChua = sucChua;
            this.soPhong = soPhong;
        }
        public Toa(Toa t)
        {
            maToa = t.maToa;
            sucChua = t.sucChua;
            soPhong = t.soPhong;
        }
    }
}

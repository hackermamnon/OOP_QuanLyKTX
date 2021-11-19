using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Dịch vụ (Mã dịch vụ, Tên dịch vụ, Chỉ số tháng, Tiền dịch vụ)
    public class DichVu
    {
        public string maDichVu { get; set; }
        public string tenDichVu { get; set; }
        public int chiSoThang { get; set; }
        public double tienDichVu { get; set; }

        public DichVu(string maDichVu, string tenDichVu, int chiSoThang, double tienDichVu)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.chiSoThang = chiSoThang;
            this.tienDichVu = tienDichVu;
        }
        public DichVu(DichVu dv)
        {
            maDichVu = dv.maDichVu;
            tenDichVu = dv.tenDichVu;
            chiSoThang = dv.chiSoThang;
            tienDichVu = dv.tienDichVu;
        }
    }
}

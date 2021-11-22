using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Báo cáo hỏng hóc thiết bị(Mã báo cáo, Mã phòng, Thời gian, Mô tả)
    public class BaoCaoThietBi
    {
        public string maBaoCao { get; set; }
        public Phong phong { get; set; }
        public DateTime thoiGian { get; set; }
        public string moTaBaoCao { get; set; }

        public BaoCaoThietBi(string maBaoCao, Phong phong, DateTime thoiGian, string moTaBaoCao)
        {
            this.maBaoCao = maBaoCao;
            this.phong = phong;
            this.thoiGian = thoiGian;
            this.moTaBaoCao = moTaBaoCao;
        }
        public BaoCaoThietBi(BaoCaoThietBi baoCao)
        {
            maBaoCao = baoCao.maBaoCao;
            phong = baoCao.phong;
            thoiGian = baoCao.thoiGian;
            moTaBaoCao = baoCao.moTaBaoCao;
        }
    }
}
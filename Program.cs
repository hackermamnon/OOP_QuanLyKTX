using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    class Program
    {
        public static List<Phong> dsPhong = new List<Phong>();
        public static List<LoaiPhong> dsLoaiPhong = new List<LoaiPhong>();
        public static List<Toa> dsToa = new List<Toa>();
        public static List<SinhVien> dsSinhVien = new List<SinhVien>();
        public static List<DichVu> dsDichVu = new List<DichVu>();
        public static List<ChiTietHoaDonDichVu> dsHoaDon = new List<ChiTietHoaDonDichVu>();
        public static List<LoaiNhanVien> dsLoaiNhanVien = new List<LoaiNhanVien>();
        public static List<NhanVien> dsNhanVien = new List<NhanVien>();
        public static List<ThietBi> dsThietBi = new List<ThietBi>();
        public static List<TrangBi> dsTrangBi = new List<TrangBi>();
        public static List<HopDongThuePhong> dsHopDong = new List<HopDongThuePhong>();
        public static List<ChiTietHopDong> dsChiTietHopDong = new List<ChiTietHopDong>();

        public static void TaoDanhSachThietBi()
        {
            dsDichVu.Add(new DichVu("DV01", "Binh nuoc uong 20L", new List<ChiTietHoaDonDichVu>()));
            dsDichVu.Add(new DichVu("DV02", "Giat do", new List<ChiTietHoaDonDichVu>()));
            dsDichVu.Add(new DichVu("DV03", "Photocopy", new List<ChiTietHoaDonDichVu>()));
            dsDichVu.Add(new DichVu("DV04", "Internet", new List<ChiTietHoaDonDichVu>()));
            dsDichVu.Add(new DichVu("DV05", "Giu xe", new List<ChiTietHoaDonDichVu>()));
        }

        public static void TaoDanhSachTrangBi()
        {
            dsTrangBi.Add(new TrangBi(dsPhong[1].maPhong, dsThietBi[1].maThietBi, dsPhong[1], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[1].maPhong, dsThietBi[1].maThietBi, dsPhong[1], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[1].maPhong, dsThietBi[1].maThietBi, dsPhong[0], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[2].maPhong, dsThietBi[2].maThietBi, dsPhong[0], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[3].maPhong, dsThietBi[3].maThietBi, dsPhong[0], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[4].maPhong, dsThietBi[4].maThietBi, dsPhong[0], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[5].maPhong, dsThietBi[5].maThietBi, dsPhong[0], new List<ThietBi>()));

            dsThietBi.Add(new ThietBi("QT", "Quạt treo"));
            dsThietBi.Add(new ThietBi("ML", "Máy lạnh"));
            dsThietBi.Add(new ThietBi("QD", "Quat dung"));

            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[0]);
            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[2]);

            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[1]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[2]);

        }
        public static void TaoDanhSachThietBi()
        {
            dsThietBi.Add(new ThietBi("QT", "Quạt treo"));
            dsThietBi.Add(new ThietBi("ML", "Máy lạnh"));
            dsThietBi.Add(new ThietBi("QĐ", "Quạt đứng"));
            dsThietBi.Add(new ThietBi("BH", "Bàn học"));
            dsThietBi.Add(new ThietBi("ĐH", "Đèn học"));
            dsThietBi.Add(new ThietBi("QTr", "Quạt trần"));
            dsThietBi.Add(new ThietBi("TĐ", "Tủ đồ cá nhân"));
            dsThietBi.Add(new ThietBi("Ghe", "Ghế ngồi"));
            dsThietBi.Add(new ThietBi("MTD", "Móc treo đồ"));
            dsThietBi.Add(new ThietBi("OCD", "Ổ cắm điện"));

            dsTrangBi[0].thietBi.Add(dsThietBi[0]);
            dsTrangBi[1].thietBi.Add(dsThietBi[1]);
            dsTrangBi[2].thietBi.Add(dsThietBi[2]);
            dsTrangBi[3].thietBi.Add(dsThietBi[3]);
            dsTrangBi[4].thietBi.Add(dsThietBi[4]);
            dsTrangBi[5].thietBi.Add(dsThietBi[5]);
            dsTrangBi[6].thietBi.Add(dsThietBi[6]);
            dsTrangBi[7].thietBi.Add(dsThietBi[7]);
            dsTrangBi[8].thietBi.Add(dsThietBi[8]);
            dsTrangBi[9].thietBi.Add(dsThietBi[9]);
        }
        public static void TaoDanhSachChiTietHoaDonDichVu()
        {
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV01", dsPhong[0].maPhong, 4000000, new DateTime(2020, 2, 1), dsChiTietHopDong[0], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV02", dsPhong[0].maPhong, 35000000, new DateTime(2020, 2, 3), dsChiTietHopDong[1], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV03", dsPhong[2].maPhong, 34500000, new DateTime(2020, 2, 3), dsChiTietHopDong[2], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV04", dsPhong[3].maPhong, 41250000, new DateTime(2020, 2, 4), dsChiTietHopDong[3], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV05", dsPhong[4].maPhong, 4870000, new DateTime(2020, 2, 4), dsChiTietHopDong[4], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV06", dsPhong[5].maPhong, 47500000, new DateTime(2020, 2, 4), dsChiTietHopDong[5], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV07", dsPhong[6].maPhong, 52100000, new DateTime(2020, 2, 6), dsChiTietHopDong[6], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV08", dsPhong[6].maPhong, 38900000, new DateTime(2020, 2, 6), dsChiTietHopDong[7], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV09", dsPhong[6].maPhong, 37400000, new DateTime(2020, 2, 7), dsChiTietHopDong[8], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV10", dsPhong[6].maPhong, 39900000, new DateTime(2020, 2, 8), dsChiTietHopDong[9], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV11", dsPhong[8].maPhong, 42500000, new DateTime(2020, 2, 8), dsChiTietHopDong[10], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV12", dsPhong[8].maPhong, 3700000, new DateTime(2020, 2, 10), dsChiTietHopDong[11], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV13", dsPhong[8].maPhong, 51200000, new DateTime(2020, 2, 10), dsChiTietHopDong[12], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV14", dsPhong[8].maPhong, 41000000, new DateTime(2020, 2, 10), dsChiTietHopDong[13], new List<DichVu>()));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV15", dsPhong[1].maPhong, 5300000, new DateTime(2020, 2, 10), dsChiTietHopDong[14], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV16", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[15], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV17", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[16], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV18", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[17], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV19", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[18], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV20", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[19], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV21", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[20], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV22", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[21], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV23", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[22], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV24", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[23], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV25", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[24], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV26", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[25], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV27", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[26], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV28", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[27], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV29", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[28], new List<DichVu>()));
            //dsHoaDon.Add(new ChiTietHoaDonDichVu("DV30", dsPhong[0].maPhong, 12000000, new DateTime(2020, 2, 1), dsChiTietHopDong[29], new List<DichVu>()));

            dsChiTietHopDong[0].dshoadon_phong.Add(dsHoaDon[0]);

        }
        public static void TaoDanhSachChiTietHopDong()
        {
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[0].maHopDong, dsPhong[0].maPhong, new DateTime(2020, 1, 8), new DateTime(2021, 1, 8), dsHopDong[0], dsPhong[0], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[1].maHopDong, dsPhong[0].maPhong, new DateTime(2020, 1, 9), new DateTime(2021, 1, 9), dsHopDong[1], dsPhong[0], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[2].maHopDong, dsPhong[2].maPhong, new DateTime(2020, 2, 23), new DateTime(2021, 2, 23), dsHopDong[2], dsPhong[2], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[3].maHopDong, dsPhong[3].maPhong, new DateTime(2020, 2, 18), new DateTime(2021, 2, 18), dsHopDong[3], dsPhong[3], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[4].maHopDong, dsPhong[4].maPhong, new DateTime(2020, 3, 2), new DateTime(2021, 3, 2), dsHopDong[4], dsPhong[4], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[5].maHopDong, dsPhong[5].maPhong, new DateTime(2020, 3, 7), new DateTime(2021, 1, 7), dsHopDong[5], dsPhong[5], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[6].maHopDong, dsPhong[6].maPhong, new DateTime(2020, 3, 12), new DateTime(2021, 6, 12), dsHopDong[6], dsPhong[6], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[7].maHopDong, dsPhong[6].maPhong, new DateTime(2020, 3, 17), new DateTime(2021, 6, 17), dsHopDong[7], dsPhong[6], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[8].maHopDong, dsPhong[6].maPhong, new DateTime(2020, 3, 24), new DateTime(2021, 1, 24), dsHopDong[8], dsPhong[6], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[9].maHopDong, dsPhong[6].maPhong, new DateTime(2020, 4, 21), new DateTime(2022, 4, 21), dsHopDong[9], dsPhong[6], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[10].maHopDong, dsPhong[8].maPhong, new DateTime(2020, 4, 24), new DateTime(2021, 4, 24), dsHopDong[10], dsPhong[8], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[11].maHopDong, dsPhong[8].maPhong, new DateTime(2020, 5, 7), new DateTime(2021, 5, 7), dsHopDong[11], dsPhong[8], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[12].maHopDong, dsPhong[8].maPhong, new DateTime(2020, 5, 8), new DateTime(2021, 5, 8), dsHopDong[12], dsPhong[8], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[13].maHopDong, dsPhong[8].maPhong, new DateTime(2020, 5, 18), new DateTime(2021, 5, 18), dsHopDong[13], dsPhong[8], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[14].maHopDong, dsPhong[1].maPhong, new DateTime(2020, 5, 28), new DateTime(2021, 1, 28), dsHopDong[14], dsPhong[1], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[15].maHopDong, dsPhong[1].maPhong, new DateTime(2020, 6, 6), new DateTime(2021, 2, 6), dsHopDong[15], dsPhong[1], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[16].maHopDong, dsPhong[2].maPhong, new DateTime(2020, 6, 9), new DateTime(2021, 2, 9), dsHopDong[16], dsPhong[2], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[17].maHopDong, dsPhong[2].maPhong, new DateTime(2020, 6, 17), new DateTime(2021, 2, 17), dsHopDong[17], dsPhong[2], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[18].maHopDong, dsPhong[2].maPhong, new DateTime(2020, 6, 24), new DateTime(2021, 2, 24), dsHopDong[18], dsPhong[2], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[19].maHopDong, dsPhong[10].maPhong, new DateTime(2020, 7, 21), new DateTime(2022, 7, 21), dsHopDong[19], dsPhong[10], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[20].maHopDong, dsPhong[10].maPhong, new DateTime(2020, 7, 28), new DateTime(2022, 7, 28), dsHopDong[20], dsPhong[10], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[21].maHopDong, dsPhong[10].maPhong, new DateTime(2020, 8, 5), new DateTime(2022, 8, 5), dsHopDong[21], dsPhong[10], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[22].maHopDong, dsPhong[10].maPhong, new DateTime(2020, 8, 12), new DateTime(2022, 8, 12), dsHopDong[22], dsPhong[10], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[23].maHopDong, dsPhong[11].maPhong, new DateTime(2020, 8, 28), new DateTime(2021, 8, 28), dsHopDong[23], dsPhong[11], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[24].maHopDong, dsPhong[11].maPhong, new DateTime(2020, 9, 17), new DateTime(2021, 9, 17), dsHopDong[24], dsPhong[11], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[25].maHopDong, dsPhong[11].maPhong, new DateTime(2020, 10, 12), new DateTime(2021, 9, 12), dsHopDong[25], dsPhong[11], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[26].maHopDong, dsPhong[11].maPhong, new DateTime(2020, 10, 22), new DateTime(2021, 10, 22), dsHopDong[26], dsPhong[11], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[27].maHopDong, dsPhong[12].maPhong, new DateTime(2020, 10, 26), new DateTime(2021, 2, 26), dsHopDong[27], dsPhong[12], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[28].maHopDong, dsPhong[12].maPhong, new DateTime(2020, 10, 30), new DateTime(2021, 3, 3), dsHopDong[28], dsPhong[12], new List<ChiTietHoaDonDichVu>()));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[29].maHopDong, dsPhong[12].maPhong, new DateTime(2020, 10, 31), new DateTime(2021, 3, 3), dsHopDong[29], dsPhong[12], new List<ChiTietHoaDonDichVu>()));

        }
        public static void TaoDanhSachHopDong()
        {
            dsHopDong.Add(new HopDongThuePhong("HD01", dsSinhVien[0].maSV, "Hop dong thue phong SV01", dsSinhVien[0]));
            dsHopDong.Add(new HopDongThuePhong("HD02", dsSinhVien[1].maSV, "Hop dong thue phong SV02", dsSinhVien[1]));
            dsHopDong.Add(new HopDongThuePhong("HD03", dsSinhVien[2].maSV, "Hop dong thue phong SV03", dsSinhVien[2]));
            dsHopDong.Add(new HopDongThuePhong("HD04", dsSinhVien[3].maSV, "Hop dong thue phong SV04", dsSinhVien[3]));
            dsHopDong.Add(new HopDongThuePhong("HD05", dsSinhVien[4].maSV, "Hop dong thue phong SV05", dsSinhVien[4]));
            dsHopDong.Add(new HopDongThuePhong("HD06", dsSinhVien[5].maSV, "Hop dong thue phong SV06", dsSinhVien[5]));
            dsHopDong.Add(new HopDongThuePhong("HD07", dsSinhVien[6].maSV, "Hop dong thue phong SV07", dsSinhVien[6]));
            dsHopDong.Add(new HopDongThuePhong("HD08", dsSinhVien[7].maSV, "Hop dong thue phong SV08", dsSinhVien[7]));
            dsHopDong.Add(new HopDongThuePhong("HD09", dsSinhVien[8].maSV, "Hop dong thue phong SV09", dsSinhVien[8]));
            dsHopDong.Add(new HopDongThuePhong("HD10", dsSinhVien[9].maSV, "Hop dong thue phong SV10", dsSinhVien[9]));
            dsHopDong.Add(new HopDongThuePhong("HD11", dsSinhVien[10].maSV, "Hop dong thue phong SV11", dsSinhVien[10]));
            dsHopDong.Add(new HopDongThuePhong("HD12", dsSinhVien[11].maSV, "Hop dong thue phong SV12", dsSinhVien[11]));
            dsHopDong.Add(new HopDongThuePhong("HD13", dsSinhVien[12].maSV, "Hop dong thue phong SV13", dsSinhVien[12]));
            dsHopDong.Add(new HopDongThuePhong("HD14", dsSinhVien[13].maSV, "Hop dong thue phong SV14", dsSinhVien[13]));
            dsHopDong.Add(new HopDongThuePhong("HD15", dsSinhVien[14].maSV, "Hop dong thue phong SV15", dsSinhVien[14]));
            dsHopDong.Add(new HopDongThuePhong("HD16", dsSinhVien[15].maSV, "Hop dong thue phong SV16", dsSinhVien[15]));
            dsHopDong.Add(new HopDongThuePhong("HD17", dsSinhVien[16].maSV, "Hop dong thue phong SV17", dsSinhVien[16]));
            dsHopDong.Add(new HopDongThuePhong("HD18", dsSinhVien[17].maSV, "Hop dong thue phong SV18", dsSinhVien[17]));
            dsHopDong.Add(new HopDongThuePhong("HD19", dsSinhVien[18].maSV, "Hop dong thue phong SV19", dsSinhVien[18]));
            dsHopDong.Add(new HopDongThuePhong("HD20", dsSinhVien[19].maSV, "Hop dong thue phong SV20", dsSinhVien[19]));
            dsHopDong.Add(new HopDongThuePhong("HD21", dsSinhVien[20].maSV, "Hop dong thue phong SV21", dsSinhVien[20]));
            dsHopDong.Add(new HopDongThuePhong("HD22", dsSinhVien[21].maSV, "Hop dong thue phong SV22", dsSinhVien[21]));
            dsHopDong.Add(new HopDongThuePhong("HD23", dsSinhVien[22].maSV, "Hop dong thue phong SV23", dsSinhVien[22]));
            dsHopDong.Add(new HopDongThuePhong("HD24", dsSinhVien[23].maSV, "Hop dong thue phong SV24", dsSinhVien[23]));
            dsHopDong.Add(new HopDongThuePhong("HD25", dsSinhVien[24].maSV, "Hop dong thue phong SV25", dsSinhVien[24]));
            dsHopDong.Add(new HopDongThuePhong("HD26", dsSinhVien[25].maSV, "Hop dong thue phong SV26", dsSinhVien[25]));
            dsHopDong.Add(new HopDongThuePhong("HD27", dsSinhVien[26].maSV, "Hop dong thue phong SV27", dsSinhVien[26]));
            dsHopDong.Add(new HopDongThuePhong("HD28", dsSinhVien[27].maSV, "Hop dong thue phong SV28", dsSinhVien[27]));
            dsHopDong.Add(new HopDongThuePhong("HD29", dsSinhVien[28].maSV, "Hop dong thue phong SV29", dsSinhVien[28]));
            dsHopDong.Add(new HopDongThuePhong("HD30", dsSinhVien[29].maSV, "Hop dong thue phong SV30", dsSinhVien[29]));


            dsSinhVien[0].dshopdong.Add(dsHopDong[0]);
            dsSinhVien[1].dshopdong.Add(dsHopDong[1]);
            dsSinhVien[2].dshopdong.Add(dsHopDong[2]);
            dsSinhVien[3].dshopdong.Add(dsHopDong[3]);
            dsSinhVien[4].dshopdong.Add(dsHopDong[4]);
            dsSinhVien[5].dshopdong.Add(dsHopDong[5]);
            dsSinhVien[6].dshopdong.Add(dsHopDong[6]);
            dsSinhVien[7].dshopdong.Add(dsHopDong[7]);
            dsSinhVien[8].dshopdong.Add(dsHopDong[8]);
            dsSinhVien[9].dshopdong.Add(dsHopDong[9]);
            dsSinhVien[10].dshopdong.Add(dsHopDong[10]);
            dsSinhVien[11].dshopdong.Add(dsHopDong[11]);
            dsSinhVien[12].dshopdong.Add(dsHopDong[12]);
            dsSinhVien[13].dshopdong.Add(dsHopDong[13]);
            dsSinhVien[14].dshopdong.Add(dsHopDong[14]);
            dsSinhVien[15].dshopdong.Add(dsHopDong[15]);
            dsSinhVien[16].dshopdong.Add(dsHopDong[16]);
            dsSinhVien[17].dshopdong.Add(dsHopDong[17]);
            dsSinhVien[18].dshopdong.Add(dsHopDong[18]);
            dsSinhVien[19].dshopdong.Add(dsHopDong[19]);
            dsSinhVien[20].dshopdong.Add(dsHopDong[20]);
            dsSinhVien[21].dshopdong.Add(dsHopDong[21]);
            dsSinhVien[22].dshopdong.Add(dsHopDong[22]);
            dsSinhVien[23].dshopdong.Add(dsHopDong[23]);
            dsSinhVien[24].dshopdong.Add(dsHopDong[24]);
            dsSinhVien[25].dshopdong.Add(dsHopDong[25]);
            dsSinhVien[26].dshopdong.Add(dsHopDong[26]);
            dsSinhVien[27].dshopdong.Add(dsHopDong[27]);
            dsSinhVien[28].dshopdong.Add(dsHopDong[28]);
            dsSinhVien[29].dshopdong.Add(dsHopDong[29]);
        }
        public static void TaoDanhSachLoaiNhanVien()
        {
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV01", "Lao công", "Quét sân", new List<NhanVien>()));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV02", "Phụ bếp", "Dọn dẹp nhà bếp", new List<NhanVien>()));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV03", "Đầu bếp", "Nấu ăn", new List<NhanVien>()));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV04", "Bảo vệ", "Canh cổng ra vào", new List<NhanVien>()));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV05", "Sửa điện", "Xử lý vấn đề về điện", new List<NhanVien>()));
        }
        public static void TaoDanhSachNhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV01", dsLoaiNhanVien[0].maLoaiNV, dsToa[1].maToa, "Phan Quang Đạt", "0321550699", 12000000, dsLoaiNhanVien[0], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV02", dsLoaiNhanVien[0].maLoaiNV, dsToa[1].maToa, "Nguyễn Hoàng Hải", "0935538764", 10500000, dsLoaiNhanVien[0], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV03", dsLoaiNhanVien[1].maLoaiNV, dsToa[2].maToa, "Phan Ninh Thuật", "0375512722", 12500000, dsLoaiNhanVien[1], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV04", dsLoaiNhanVien[4].maLoaiNV, dsToa[2].maToa, "Văn Viết Hồng", "0933592539", 15500000, dsLoaiNhanVien[4], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV05", dsLoaiNhanVien[2].maLoaiNV, dsToa[3].maToa, "Vũ Hoàng Lâm", "0873562883", 11300000, dsLoaiNhanVien[2], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV06", dsLoaiNhanVien[2].maLoaiNV, dsToa[3].maToa, "Trần Văn Tài", "0376588314", 14800000, dsLoaiNhanVien[2], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV07", dsLoaiNhanVien[3].maLoaiNV, dsToa[3].maToa, "Nguyễn Thị Bích Châu", "0935543050", 18200000, dsLoaiNhanVien[3], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV08", dsLoaiNhanVien[3].maLoaiNV, dsToa[0].maToa, "Trần Hạnh Vy", "0835559895", 11500000, dsLoaiNhanVien[3], dsToa[0]));
            dsNhanVien.Add(new NhanVien("NV09", dsLoaiNhanVien[2].maLoaiNV, dsToa[1].maToa, "Trần Phương Thanh", "0855586047", 12000000, dsLoaiNhanVien[2], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV10", dsLoaiNhanVien[1].maLoaiNV, dsToa[2].maToa, "Ngô Ngọc Huế", "0935517709", 13500000, dsLoaiNhanVien[1], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV11", dsLoaiNhanVien[3].maLoaiNV, dsToa[1].maToa, "Khưu Hoài Bắc", "0952114939", 13000000, dsLoaiNhanVien[3], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV12", dsLoaiNhanVien[3].maLoaiNV, dsToa[1].maToa, "Tôn Yên Bình", "0933213448", 11500000, dsLoaiNhanVien[3], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV13", dsLoaiNhanVien[3].maLoaiNV, dsToa[2].maToa, "Nguyễn Nguyên Khôi", "0941527983", 13500000, dsLoaiNhanVien[3], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV14", dsLoaiNhanVien[3].maLoaiNV, dsToa[2].maToa, "Hoàng Hiệp Hà", "0992525872", 16500000, dsLoaiNhanVien[3], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV15", dsLoaiNhanVien[0].maLoaiNV, dsToa[3].maToa, "Lâm Phi Hùng", "0991204916", 12300000, dsLoaiNhanVien[0], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV16", dsLoaiNhanVien[4].maLoaiNV, dsToa[3].maToa, "Trần Tấn Nam", "0967537105", 15800000, dsLoaiNhanVien[4], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV17", dsLoaiNhanVien[4].maLoaiNV, dsToa[3].maToa, "Trần Minh Tiến", "0938910107", 19200000, dsLoaiNhanVien[4], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV18", dsLoaiNhanVien[4].maLoaiNV, dsToa[0].maToa, "Phạm Minh Thiện", "0921507874", 12500000, dsLoaiNhanVien[4], dsToa[0]));
            dsNhanVien.Add(new NhanVien("NV19", dsLoaiNhanVien[2].maLoaiNV, dsToa[1].maToa, "Hoàng Công Bằng", "0973125823", 13000000, dsLoaiNhanVien[2], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV20", dsLoaiNhanVien[2].maLoaiNV, dsToa[2].maToa, "Nguyễn Thành Công", "0931213547", 13500000, dsLoaiNhanVien[2], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV21", dsLoaiNhanVien[0].maLoaiNV, dsToa[1].maToa, "Bùi Trọng Kim", "0935181991", 12000000, dsLoaiNhanVien[0], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV22", dsLoaiNhanVien[0].maLoaiNV, dsToa[1].maToa, "Đào Phi Hải", "0912529277", 10500000, dsLoaiNhanVien[0], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV23", dsLoaiNhanVien[0].maLoaiNV, dsToa[2].maToa, "Trịnh Thiện Luân", "0987558119", 12500000, dsLoaiNhanVien[0], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV24", dsLoaiNhanVien[1].maLoaiNV, dsToa[2].maToa, "Nguyễn Quang Ninh", "0935502239", 15500000, dsLoaiNhanVien[1], dsToa[2]));
            dsNhanVien.Add(new NhanVien("NV25", dsLoaiNhanVien[1].maLoaiNV, dsToa[3].maToa, "Trần Minh Thạc", "0936457259", 10300000, dsLoaiNhanVien[1], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV26", dsLoaiNhanVien[1].maLoaiNV, dsToa[3].maToa, "Nguyễn Minh Thạc", "0935599247", 14800000, dsLoaiNhanVien[1], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV27", dsLoaiNhanVien[0].maLoaiNV, dsToa[3].maToa, "Trần Công Ân", "0912590004", 17200000, dsLoaiNhanVien[0], dsToa[3]));
            dsNhanVien.Add(new NhanVien("NV28", dsLoaiNhanVien[0].maLoaiNV, dsToa[0].maToa, "Mạnh Gia Bình", "0958974792", 9500000, dsLoaiNhanVien[0], dsToa[0]));
            dsNhanVien.Add(new NhanVien("NV29", dsLoaiNhanVien[0].maLoaiNV, dsToa[1].maToa, "Thịnh Bảo Lâm", "0915501907", 11000000, dsLoaiNhanVien[0], dsToa[1]));
            dsNhanVien.Add(new NhanVien("NV30", dsLoaiNhanVien[0].maLoaiNV, dsToa[2].maToa, "Nguyễn Cao Tiến", "0958585889", 12500000, dsLoaiNhanVien[0], dsToa[2]));

            //		dsLoaiPhong[5].dsphong_loai.Add(dsPhong[11));

            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[0]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[1]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[14]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[20]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[21]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[22]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[26]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[27]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[28]);
            dsLoaiNhanVien[0].dsnhanvien_loai.Add(dsNhanVien[29]);


            dsLoaiNhanVien[1].dsnhanvien_loai.Add(dsNhanVien[2]);
            dsLoaiNhanVien[1].dsnhanvien_loai.Add(dsNhanVien[9]);
            dsLoaiNhanVien[1].dsnhanvien_loai.Add(dsNhanVien[23]);
            dsLoaiNhanVien[1].dsnhanvien_loai.Add(dsNhanVien[24]);
            dsLoaiNhanVien[1].dsnhanvien_loai.Add(dsNhanVien[25]);


            dsLoaiNhanVien[2].dsnhanvien_loai.Add(dsNhanVien[4]);
            dsLoaiNhanVien[2].dsnhanvien_loai.Add(dsNhanVien[5]);
            dsLoaiNhanVien[2].dsnhanvien_loai.Add(dsNhanVien[8]);
            dsLoaiNhanVien[2].dsnhanvien_loai.Add(dsNhanVien[18]);
            dsLoaiNhanVien[2].dsnhanvien_loai.Add(dsNhanVien[19]);

            dsLoaiNhanVien[3].dsnhanvien_loai.Add(dsNhanVien[6]);
            dsLoaiNhanVien[3].dsnhanvien_loai.Add(dsNhanVien[7]);
            dsLoaiNhanVien[3].dsnhanvien_loai.Add(dsNhanVien[10]);
            dsLoaiNhanVien[3].dsnhanvien_loai.Add(dsNhanVien[11]);
            dsLoaiNhanVien[3].dsnhanvien_loai.Add(dsNhanVien[12]);
            dsLoaiNhanVien[3].dsnhanvien_loai.Add(dsNhanVien[13]);

            dsLoaiNhanVien[4].dsnhanvien_loai.Add(dsNhanVien[3]);
            dsLoaiNhanVien[4].dsnhanvien_loai.Add(dsNhanVien[15]);
            dsLoaiNhanVien[4].dsnhanvien_loai.Add(dsNhanVien[16]);
            dsLoaiNhanVien[4].dsnhanvien_loai.Add(dsNhanVien[17]);
        }
        public static void TaoDanhSachLoaiPhong()
        {
            dsLoaiPhong.Add(new LoaiPhong("PML04", "Phòng máy lạnh 4 người", 4000000, new List<Phong>()));
            dsLoaiPhong.Add(new LoaiPhong("PML06", "Phòng máy lạnh 6 người", 5500000, new List<Phong>()));
            dsLoaiPhong.Add(new LoaiPhong("PML08", "Phòng máy lạnh 8 người", 7500000, new List<Phong>()));
            dsLoaiPhong.Add(new LoaiPhong("PQ04", "Phòng quạt 4 người", 2500000, new List<Phong>()));
            dsLoaiPhong.Add(new LoaiPhong("PQ06", "Phòng quạt 6 người", 3500000, new List<Phong>()));
            dsLoaiPhong.Add(new LoaiPhong("PQ08", "Phòng quạt 8 người", 4500000, new List<Phong>()));
        }
        public static void TaoDanhSachPhong()
        {
            dsPhong.Add(new Phong("P01", dsToa[0].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[0], dsLoaiPhong[1]));
            dsPhong.Add(new Phong("P02", dsToa[0].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[0], dsLoaiPhong[1]));
            dsPhong.Add(new Phong("P03", dsToa[1].maToa, dsLoaiPhong[3].maLoaiPhong, true, dsToa[1], dsLoaiPhong[3]));
            dsPhong.Add(new Phong("P04", dsToa[1].maToa, dsLoaiPhong[3].maLoaiPhong, true, dsToa[1], dsLoaiPhong[3]));
            dsPhong.Add(new Phong("P05", dsToa[2].maToa, dsLoaiPhong[2].maLoaiPhong, true, dsToa[2], dsLoaiPhong[2]));
            dsPhong.Add(new Phong("P06", dsToa[2].maToa, dsLoaiPhong[2].maLoaiPhong, true, dsToa[2], dsLoaiPhong[2]));
            dsPhong.Add(new Phong("P07", dsToa[3].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[3], dsLoaiPhong[1]));
            dsPhong.Add(new Phong("P08", dsToa[3].maToa, dsLoaiPhong[3].maLoaiPhong, false, dsToa[3], dsLoaiPhong[3]));
            dsPhong.Add(new Phong("P09", dsToa[1].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[1], dsLoaiPhong[0]));
            dsPhong.Add(new Phong("P10", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[3], dsLoaiPhong[0]));
            dsPhong.Add(new Phong("P11", dsToa[0].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[0], dsLoaiPhong[4]));
            dsPhong.Add(new Phong("P12", dsToa[0].maToa, dsLoaiPhong[5].maLoaiPhong, true, dsToa[0], dsLoaiPhong[5]));
            dsPhong.Add(new Phong("P13", dsToa[1].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[1], dsLoaiPhong[4]));
            dsPhong.Add(new Phong("P14", dsToa[1].maToa, dsLoaiPhong[5].maLoaiPhong, false, dsToa[1], dsLoaiPhong[5]));
            dsPhong.Add(new Phong("P15", dsToa[2].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[2], dsLoaiPhong[4]));
            dsPhong.Add(new Phong("P16", dsToa[2].maToa, dsLoaiPhong[5].maLoaiPhong, true, dsToa[2], dsLoaiPhong[5]));
            dsPhong.Add(new Phong("P17", dsToa[3].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[3], dsLoaiPhong[1]));
            dsPhong.Add(new Phong("P18", dsToa[3].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[3], dsLoaiPhong[1]));
            dsPhong.Add(new Phong("P19", dsToa[1].maToa, dsLoaiPhong[2].maLoaiPhong, true, dsToa[1], dsLoaiPhong[2]));
            dsPhong.Add(new Phong("P20", dsToa[3].maToa, dsLoaiPhong[2].maLoaiPhong, false, dsToa[3], dsLoaiPhong[2]));
            dsPhong.Add(new Phong("P21", dsToa[0].maToa, dsLoaiPhong[3].maLoaiPhong, true, dsToa[0], dsLoaiPhong[3]));
            dsPhong.Add(new Phong("P22", dsToa[0].maToa, dsLoaiPhong[3].maLoaiPhong, false, dsToa[0], dsLoaiPhong[3]));
            dsPhong.Add(new Phong("P23", dsToa[1].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[1], dsLoaiPhong[4]));
            dsPhong.Add(new Phong("P24", dsToa[1].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[1], dsLoaiPhong[4]));
            dsPhong.Add(new Phong("P25", dsToa[2].maToa, dsLoaiPhong[5].maLoaiPhong, true, dsToa[2], dsLoaiPhong[5]));
            dsPhong.Add(new Phong("P26", dsToa[2].maToa, dsLoaiPhong[5].maLoaiPhong, true, dsToa[2], dsLoaiPhong[5]));
            dsPhong.Add(new Phong("P27", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[3], dsLoaiPhong[0]));
            dsPhong.Add(new Phong("P28", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, true, dsToa[3], dsLoaiPhong[0]));
            dsPhong.Add(new Phong("P29", dsToa[1].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[1], dsLoaiPhong[0]));
            dsPhong.Add(new Phong("P30", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[3], dsLoaiPhong[0]));


            dsLoaiPhong[0].dsphong_loai.Add(dsPhong[8]);
            dsLoaiPhong[0].dsphong_loai.Add(dsPhong[9]);
            dsLoaiPhong[0].dsphong_loai.Add(dsPhong[26]);
            dsLoaiPhong[0].dsphong_loai.Add(dsPhong[27]);
            dsLoaiPhong[0].dsphong_loai.Add(dsPhong[28]);
            dsLoaiPhong[0].dsphong_loai.Add(dsPhong[29]);

            dsLoaiPhong[1].dsphong_loai.Add(dsPhong[0]);
            dsLoaiPhong[1].dsphong_loai.Add(dsPhong[1]);
            dsLoaiPhong[1].dsphong_loai.Add(dsPhong[6]);
            dsLoaiPhong[1].dsphong_loai.Add(dsPhong[16]);
            dsLoaiPhong[1].dsphong_loai.Add(dsPhong[17]);

            dsLoaiPhong[2].dsphong_loai.Add(dsPhong[4]);
            dsLoaiPhong[2].dsphong_loai.Add(dsPhong[5]);
            dsLoaiPhong[2].dsphong_loai.Add(dsPhong[18]);
            dsLoaiPhong[2].dsphong_loai.Add(dsPhong[19]);
            dsLoaiPhong[2].dsphong_loai.Add(dsPhong[17]);

            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[2]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[3]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[7]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[20]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[11]);

            dsLoaiPhong[4].dsphong_loai.Add(dsPhong[10]);
            dsLoaiPhong[4].dsphong_loai.Add(dsPhong[12]);
            dsLoaiPhong[4].dsphong_loai.Add(dsPhong[22]);
            dsLoaiPhong[4].dsphong_loai.Add(dsPhong[23]);
            dsLoaiPhong[4].dsphong_loai.Add(dsPhong[14]);

            dsLoaiPhong[5].dsphong_loai.Add(dsPhong[11]);
            dsLoaiPhong[5].dsphong_loai.Add(dsPhong[13]);
            dsLoaiPhong[5].dsphong_loai.Add(dsPhong[15]);
            dsLoaiPhong[5].dsphong_loai.Add(dsPhong[24]);
            dsLoaiPhong[5].dsphong_loai.Add(dsPhong[25]);

            dsToa[0].dsphong_toa.Add(dsPhong[0]);
            dsToa[0].dsphong_toa.Add(dsPhong[1]);
            dsToa[0].dsphong_toa.Add(dsPhong[10]);
            dsToa[0].dsphong_toa.Add(dsPhong[11]);
            dsToa[0].dsphong_toa.Add(dsPhong[20]);
            dsToa[0].dsphong_toa.Add(dsPhong[21]);

            dsToa[1].dsphong_toa.Add(dsPhong[2]);
            dsToa[1].dsphong_toa.Add(dsPhong[3]);
            dsToa[1].dsphong_toa.Add(dsPhong[8]);
            dsToa[1].dsphong_toa.Add(dsPhong[12]);
            dsToa[1].dsphong_toa.Add(dsPhong[13]);
            dsToa[1].dsphong_toa.Add(dsPhong[18]);
            dsToa[1].dsphong_toa.Add(dsPhong[22]);
            dsToa[1].dsphong_toa.Add(dsPhong[23]);
            dsToa[1].dsphong_toa.Add(dsPhong[28]);

            dsToa[2].dsphong_toa.Add(dsPhong[4]);
            dsToa[2].dsphong_toa.Add(dsPhong[5]);
            dsToa[2].dsphong_toa.Add(dsPhong[14]);
            dsToa[2].dsphong_toa.Add(dsPhong[15]);
            dsToa[2].dsphong_toa.Add(dsPhong[24]);
            dsToa[2].dsphong_toa.Add(dsPhong[25]);


            dsToa[3].dsphong_toa.Add(dsPhong[6]);
            dsToa[3].dsphong_toa.Add(dsPhong[7]);
            dsToa[3].dsphong_toa.Add(dsPhong[9]);
            dsToa[3].dsphong_toa.Add(dsPhong[16]);
            dsToa[3].dsphong_toa.Add(dsPhong[17]);
            dsToa[3].dsphong_toa.Add(dsPhong[19]);
            dsToa[3].dsphong_toa.Add(dsPhong[26]);
            dsToa[3].dsphong_toa.Add(dsPhong[27]);
            dsToa[3].dsphong_toa.Add(dsPhong[29]);
        }
        public static void TaoDachSachToa()
        {
            dsToa.Add(new Toa('A', 300, 45, new List<Phong>(), new List<NhanVien>()));
            dsToa.Add(new Toa('B', 330, 50, new List<Phong>(), new List<NhanVien>()));
            dsToa.Add(new Toa('C', 300, 45, new List<Phong>(), new List<NhanVien>()));
            dsToa.Add(new Toa('D', 330, 50, new List<Phong>(), new List<NhanVien>()));
        }
        public static void TaoDanhSachSinhVien()
        {
            dsSinhVien.Add(new SinhVien("SV01", "Văn Minh Anh", true, "0335573464", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV02", "Kha Sỹ Phú", true, "0955546106", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV03", "Phan Phúc Lâm", true, "0875516075", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV04", "Trần Trung Thế", true, "0335555459", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV05", "Cao Đăng Ngọc Quý", true, "0995578740", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV06", "Phạm Vĩnh Long", true, "0335558622", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV07", "Tạ Bạch Cúc", false, "0935505935", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV08", "Mai Kiều Hoa", false, "0855533475", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV09", "Mai Phương Thúy", false, "0955515045", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV10", "Hoàng Phương Thảo", false, "0895501461", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV11", "Trần Quang Bửu", true, "09732588394", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV12", "Nguyễn Quang Dũng", true, "03312598591", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV13", "Nguyễn Thiện Giang", true, "09331529049", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV14", "Nguyễn Trọng Khánh", true, "09556752852", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV15", "Phan Bảo Long", true, "03758710360", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV16", "Cao Khắc Minh", true, "03512548013", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV17", "Đoàn Kiên Trung", true, "09655516844", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV18", "Huỳnh Huy Cường", true, "03578507626", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV19", "Danh Hoàng Giang", true, "098559527928", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV20", "Đỗ Mỹ Loan", false, "03515538943", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV21", "Nguyễn Phương Lan", false, "09959743180", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV22", "Trịnh Thúy Anh", false, "03565533549", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV23", "Lương Bạch Loan", false, "09351210183", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV24", "Nghiêm Diệu Hà", false, "03364557138", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV25", "Nguyễn Hải Châu", false, "0333129573", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV26", "Vũ Bạch Yến", false, "0335979171", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV27", "Nguyễn Bích Thủy", false, "09915542642", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV28", "Việt Mỹ Kiều", false, "09532563250", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV29", "Nguyễn Linh Sương Sương", false, "09857975293", new List<HopDongThuePhong>()));
            dsSinhVien.Add(new SinhVien("SV30", "Vũ Bích Vân", false, "03368595027", new List<HopDongThuePhong>()));
        }

        //1. Cho biết những phòng còn trống ở tòa A và C
        public static void Linq1()
        {
            var result = from p in dsPhong
                         where (p.trangThai == false) && (p.maToa == 'A' || p.maToa == 'C')
                         select p;
            Console.WriteLine("Danh sach cac phong con trong cua 'A' va 'C' la: ");
            foreach (var p in result)
                Console.WriteLine("Phong: {0}", p.maPhong);
        }

        //2. Cho biết nhân viên "Tran Phuong Thanh" đang làm việc ở tòa nhà nào
        public static void Linq2()
        {
            var result = from nv in dsNhanVien
                         where nv.tenNhanVien == "Tran Phuong Thanh"
                         select new { nv.tenNhanVien, nv.toa.maToa };
            foreach (var nv in result)
                Console.WriteLine("Nhan vien {0} dang lam viec o toa {1}", nv.tenNhanVien, nv.maToa);
        }

        //3. Cho biết các nhân viên đang làm ở vị trí "đầu bếp"
        public static void Linq3()
        {
            var result = from nv in dsNhanVien
                         where nv.loaiNhanVien.chucVu == "Đầu bếp"
                         select nv;
            Console.WriteLine("Danh sach nhan vien lam o vi tri dau bep la:");
            foreach (var nv in result)
                Console.WriteLine("{0}", nv.tenNhanVien);
        }

        //4. Danh sách những nhân viên đang giữ chức vụ Bảo vệ
        public static void Linq4()
        {
            var result = from nv in dsNhanVien
                         where nv.loaiNhanVien.chucVu == "Bảo vệ"
                         select nv;
            Console.WriteLine("Danh sach nhung nhan vien giu chuc vu Bao ve la: ");
            foreach (var nv in result)
                Console.WriteLine("{0} - {1}", nv.maNV, nv.tenNhanVien);
        }

        ////5. Cho biết tiền dịch vụ của phòng ...
        //public static void Linq5()
        //{

        //}
        //6. Cho biết số lượng phòng chưa được thuê của tòa D
        public static void Linq6()
        {
            var result = from p in dsPhong
                         where p.maToa == 'D' && p.trangThai == false
                         select p;
            Console.WriteLine("So luong phong chua duoc thue cua toa D la: {0}", result.Count());
            foreach (var p in result)
                Console.WriteLine("{0} - {1}", p.maPhong, p.loaiPhong.tenLoaiPhong);
        }

        //7. Cho biết những hợp đồng hết hạn trước ngày 21/04/2021
        public static void Linq7()
        {
            var result = from hd in dsChiTietHopDong
                         where hd.ngayKetThuc <= new DateTime(2021, 04, 21)
                         select hd;
            Console.WriteLine("Cac hop dong het han truoc ngay 21/04/2021 la: ");
            foreach (var hd in result)
                Console.WriteLine("Hop dong " +
                    "{0} cua sinh vien {1} - {2} dang o phong {3}", 
                    hd.hopDong.maHopDong, hd.hopDong.maSinhVien, hd.hopDong.sinhVien.tenSV, hd.maPhong);
        }

        //8. Cho biết số lượng phòng máy lạnh đang được thuê ở tòa A
        public static void Linq8()
        {
            var result = from p in dsPhong
                         where p.loaiPhong.tenLoaiPhong.StartsWith("Phòng máy lạnh") && p.maToa == 'A'
                         select p;
            Console.WriteLine("So luong phong may lanh duoc thue o toa A la: {0}", result.Count());
            foreach (var p in result)
                Console.WriteLine("Phong: {0}", p.maPhong);
        }

        ////9. Liệt kê sinh viên đang ở phòng P06
        //public static void Linq9()
        //{
        //    var sinhVienP06 = from sv in dsSinhVien
        //                      //join p in phong on sv.phong.maPhong equals p.maPhong
        //                      where sv.dshopdong. == "P06"
        //                      select new { sv.tenSV };
        //}
        //10. Cho biết các phòng chưa thanh toán tiền dịch vụ
        public static void Linq10()
        {
            var tongSoPhong = from p in dsPhong
                              select p.maPhong;
            var phongDaDongTien = from dv in dsDichVu
                                  select dv.hoadon.;
            var result = from p in tongSoPhong.Except(phongDaDongTien)
                         select p;
            Console.WriteLine("Cac phong chua thanh toan tien dich vu la: ");
            foreach (var r in result)
                Console.WriteLine(r);
        }

        ////11. Cho biết thời hạn hợp đồng của phòng
        //public static void Linq11()
        //{

        //}

        ////12. Danh sách các báo cáo từ ngày 1/6/2020 đến nay
        //public static void Linq12()
        //{
        //    var result = from bc in baoCaoThietBi
        //                     //where bc.thoiGian <= new DateTime(2020, 6, 1)
        //                 select bc;
        //    Console.WriteLine("Ma bao cao\tPhong\t\tMo ta");
        //    foreach (var r in result)
        //        Console.WriteLine("{0}\t\t{1}\t\t{2}\n", r.maBaoCao, r.phong.maPhong, r.moTaBaoCao);
        //}

        ////13. Cho biết tòa đã được thuê hết phòng """
        //public static void Linq13()
        //{

        //}

        ////14. Liệt kê các phòng đang được thuê theo thứ tự tăng dần giá phòng.
        public static void Linq14()
        {
            var result = from p in dsPhong
                         where p.trangThai == true
                         orderby p.loaiPhong.giaPhong
                         select new { p.maPhong, p.loaiPhong.giaPhong };
            Console.WriteLine("Danh sach cac phong dang duoc thue theo thu tu tang dan cua gia phong: ");
            foreach (var p in result)
                Console.WriteLine("Phong: {0} - Gia phong: {1} VND", p.maPhong, p.giaPhong);
        }
        ////15. Cho biết các sinh viên đang ở loại phòng ...
        //public static void Linq15()
        //{

        //}
        ////16. Cho biết tòa có số lượng SV nhiều nhất (*)
        ////public static void Linq16()
        ////{
        ////    var result = from sv in sinhVien
        ////                 join p in phong on sv.phong.maPhong equals p.maPhong
        ////                 join t in toa on p.toa.maToa equals t.maToa
        ////                 group p.maPhong by t.maToa into groups
        ////                 select new { groups};
        ////    //select new { sv.maSV, sv.phong.maPhong, p.toa.maToa };
        ////    Console.WriteLine("Danh sach sinh vien theo ma toa: ");
        ////    foreach (var r in result)
        ////        Console.WriteLine("Sinh vien {0}", r.groups);
        ////}

        ////17. Cho biết phòng có tiền sử dụng dịch vụ cao nhất
        //public static void Linq17()
        //{

        //}
        ////18. Cho biết phòng có thời gian thuê ngắn nhất (*)
        //public static void Linq18()
        //{
        //    var danhSachThoiGianThue = from p in phong
        //                               join hd in dsChiTietHopDong on p.maPhong equals hd.phong.maPhong
        //                               select new { range = (hd.ngayKetThuc - hd.ngayBatDau), p.maPhong };
        //    var result = danhSachThoiGianThue.Min();
        //    Console.WriteLine("Phong co thoi gian thue ngan nhat la: {0} - ", result);
        //    Console.WriteLine("Danh sach thoi gian thue cua tung phong: ");
        //    foreach (var ds in danhSachThoiGianThue)
        //        Console.WriteLine("Phong {0} - Thoi gian thue {1}", ds.maPhong, ds.range);
        //}

        ////19. Cho biết những nhân viên đang làm ... có lương cao hơn trung bình ở tòa ... *
        //public static void Linq19()
        //{

        //}

        ////20. Cho biết tiền sử dụng dịch vụ trung bình của tòa B/(từng tòa)
        //public static void Linq20()
        //{
        //    var danhSachTongTien = from dv in dichVu
        //                           join p in phong on dv.phong.maPhong equals p.maPhong
        //                           join t in toa on p.toa.maToa equals t.maToa
        //                           where t.maToa == 'B'
        //                           select dv.tongTien;
        //    var result = danhSachTongTien.Average();
        //    Console.WriteLine("Tien su dung dich vu trung binh cua toa B la: {0} VND", result);
        //}


        ////Test
        //public static void Linq01()
        //{
        //    // lambda
        //    var dsnhom = dsLoaiNhanVien.Select(nt => nt);
        //    foreach (var nhom in dsnhom)
        //    {
        //        Console.WriteLine("{0} - {1} - {2} ",
        //            nhom.maLoaiNV, nhom.chucVu, nhom.congViec);
        //        foreach (var tho in nhom.dsnhanvien_loai)
        //        {
        //            Console.WriteLine("{0} - {1} - {2} - {3}",
        //                tho.maNV, tho.tenNhanVien, tho.toa.maToa, tho.luong);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        static void Main(string[] args)
        {
            TaoDanhSachLoaiPhong();
            TaoDachSachToa();
            TaoDanhSachPhong();
            TaoDanhSachTrangBi();
            TaoDanhSachThietBi();
            TaoDanhSachLoaiNhanVien();
            TaoDanhSachNhanVien();
            TaoDanhSachSinhVien();
            TaoDanhSachDichVu();
            TaoDanhSachHopDong();
            TaoDanhSachChiTietHopDong();
            TaoDanhSachChiTietHoaDonDichVu();


            Console.OutputEncoding = Encoding.UTF8;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static void TaoDanhSachTrangBi()
        {
            dsTrangBi.Add(new TrangBi(dsPhong[0].maLoaiPhong, dsLoaiPhong[0], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[1].maLoaiPhong, dsLoaiPhong[1], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[2].maLoaiPhong, dsLoaiPhong[2], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[3].maLoaiPhong, dsLoaiPhong[3], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[4].maLoaiPhong, dsLoaiPhong[4], new List<ThietBi>()));
            dsTrangBi.Add(new TrangBi(dsPhong[5].maLoaiPhong, dsLoaiPhong[5], new List<ThietBi>()));
        }
        public static void TaoDanhSachThietBi()
        {
            dsThietBi.Add(new ThietBi("QT", "Quạt treo"));//0
            dsThietBi.Add(new ThietBi("ML", "Máy lạnh"));//1
            dsThietBi.Add(new ThietBi("QĐ", "Quạt đứng"));//2
            dsThietBi.Add(new ThietBi("BH", "Bàn học"));//3
            dsThietBi.Add(new ThietBi("ĐH", "Đèn học"));//4
            dsThietBi.Add(new ThietBi("QTr", "Quạt trần"));//5
            dsThietBi.Add(new ThietBi("TĐ", "Tủ đồ cá nhân"));//6
            dsThietBi.Add(new ThietBi("Ghe", "Ghế ngồi"));//7
            dsThietBi.Add(new ThietBi("MTD", "Móc treo đồ"));//8
            dsThietBi.Add(new ThietBi("OCD", "Ổ cắm điện"));//9


            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[1]);
            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[3]);
            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[4]);
            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[5]);
            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[6]);
            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[7]);
            dsTrangBi[0].dsthietbi_loaiphong.Add(dsThietBi[8]);

            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[1]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[3]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[4]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[5]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[6]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[7]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[8]);
            dsTrangBi[1].dsthietbi_loaiphong.Add(dsThietBi[9]);

            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[1]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[2]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[3]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[4]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[5]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[6]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[7]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[8]);
            dsTrangBi[2].dsthietbi_loaiphong.Add(dsThietBi[9]);

            dsTrangBi[3].dsthietbi_loaiphong.Add(dsThietBi[0]);
            dsTrangBi[3].dsthietbi_loaiphong.Add(dsThietBi[3]);
            dsTrangBi[3].dsthietbi_loaiphong.Add(dsThietBi[5]);
            dsTrangBi[3].dsthietbi_loaiphong.Add(dsThietBi[7]);

            dsTrangBi[4].dsthietbi_loaiphong.Add(dsThietBi[0]);
            dsTrangBi[4].dsthietbi_loaiphong.Add(dsThietBi[2]);
            dsTrangBi[4].dsthietbi_loaiphong.Add(dsThietBi[3]);
            dsTrangBi[4].dsthietbi_loaiphong.Add(dsThietBi[5]);
            dsTrangBi[4].dsthietbi_loaiphong.Add(dsThietBi[6]);
            dsTrangBi[4].dsthietbi_loaiphong.Add(dsThietBi[7]);

            dsTrangBi[5].dsthietbi_loaiphong.Add(dsThietBi[0]);
            dsTrangBi[5].dsthietbi_loaiphong.Add(dsThietBi[2]);
            dsTrangBi[5].dsthietbi_loaiphong.Add(dsThietBi[3]);
            dsTrangBi[5].dsthietbi_loaiphong.Add(dsThietBi[5]);
            dsTrangBi[5].dsthietbi_loaiphong.Add(dsThietBi[6]);
            dsTrangBi[5].dsthietbi_loaiphong.Add(dsThietBi[7]);
            dsTrangBi[5].dsthietbi_loaiphong.Add(dsThietBi[9]);

        }
        public static void TaoDanhSachDichVu()
        {
            dsDichVu.Add(new DichVu("BNU", "Binh nuoc uong 20L"));//0 40K
            dsDichVu.Add(new DichVu("GD", "Giat do"));//1 60k
            dsDichVu.Add(new DichVu("PHOTO", "Photocopy"));//20k
            dsDichVu.Add(new DichVu("INT", "Internet"));//3 200k
            dsDichVu.Add(new DichVu("GX", "Giu xe"));//4 150k
        }

        public static void TaoDanhSachChiTietHoaDonDichVu()
        {
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV01 - BNU", dsPhong[0].maPhong, 160000, new DateTime(2020, 12, 3), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV01 - GD", dsPhong[0].maPhong, 180000, new DateTime(2020, 12, 3), dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV01 - PHOTO", dsPhong[0].maPhong, 80000, new DateTime(2020, 12, 3), dsDichVu[2]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV01 - INT", dsPhong[0].maPhong, 200000, new DateTime(2020, 12, 3), dsDichVu[3]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV02 - BNU", dsPhong[1].maPhong, 120000, new DateTime(2020, 12, 2), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV02 - GD", dsPhong[1].maPhong, 240000, new DateTime(2020, 12, 4), dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV02 - INT", dsPhong[1].maPhong, 400000, new DateTime(2020, 12, 5), dsDichVu[3]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV03 - BNU", dsPhong[2].maPhong, 200000, new DateTime(2020, 12, 12), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV03 - GD", dsPhong[2].maPhong, 180000, new DateTime(2020, 12, 13), dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV03 - INT ", dsPhong[2].maPhong, 200000, new DateTime(2020, 12, 13), dsDichVu[3]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV04 - BNU", dsPhong[3].maPhong, 120000, new DateTime(2020, 12, 23), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV04 - GD", dsPhong[3].maPhong, 120000, new DateTime(2020, 12, 23), dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV04 - INT", dsPhong[3].maPhong, 400000, new DateTime(2020, 12, 23), dsDichVu[3]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV04 - GX", dsPhong[3].maPhong, 150000, new DateTime(2020, 12, 23), dsDichVu[4]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV05 - BNU", dsPhong[4].maPhong, 200000, new DateTime(2020, 12, 14), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV05 - GD", dsPhong[4].maPhong, 240000, new DateTime(2020, 12, 15), dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV05 - PHOTO", dsPhong[4].maPhong, 100000, new DateTime(2020, 12, 16), dsDichVu[2]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV05 - INT", dsPhong[4].maPhong, 400000, new DateTime(2020, 12, 16), dsDichVu[3]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV06 - INT", dsPhong[5].maPhong, 200000, DateTime.MinValue, dsDichVu[3]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV06 - PHOTO", dsPhong[5].maPhong, 60000, DateTime.MinValue, dsDichVu[2]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV06 - GD", dsPhong[5].maPhong, 150000, new DateTime(2020, 12, 25), dsDichVu[4]));
            
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV07 - BNU", dsPhong[6].maPhong, 240000, new DateTime(2020, 12, 23), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV07 - PHOTO", dsPhong[6].maPhong, 60000, new DateTime(2020, 12, 20), dsDichVu[2]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV07 - GD", dsPhong[6].maPhong, 150000, new DateTime(2020, 12, 25), dsDichVu[4]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV11 - GT", dsPhong[10].maPhong, 120000, DateTime.MinValue, dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV11 - INT", dsPhong[10].maPhong, 200000, DateTime.MinValue, dsDichVu[3]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV12 - BNU", dsPhong[11].maPhong, 40000, new DateTime(2020, 12, 18), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV12 - GD", dsPhong[11].maPhong, 60000, new DateTime(2020, 12, 8), dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV12 - PHOTO", dsPhong[11].maPhong, 40000, new DateTime(2020, 12, 20), dsDichVu[2]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV12 - INT", dsPhong[11].maPhong, 200000, new DateTime(2020, 12, 3), dsDichVu[3]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV13 - GD", dsPhong[12].maPhong, 60000, DateTime.MinValue, dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV13 - INT", dsPhong[12].maPhong, 200000, DateTime.MinValue, dsDichVu[3]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV13 - GX", dsPhong[12].maPhong, 300000, DateTime.MinValue, dsDichVu[4]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV15 - BNU", dsPhong[14].maPhong, 80000, new DateTime(2020, 12, 19), dsDichVu[0]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV15 - PHOTO", dsPhong[14].maPhong, 20000, new DateTime(2020, 12, 20), dsDichVu[2]));

            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV16 - GD", dsPhong[15].maPhong, 60000, new DateTime(2020, 12, 21), dsDichVu[1]));
            dsHoaDon.Add(new ChiTietHoaDonDichVu("DV16 - PHOTO", dsPhong[15].maPhong, 80000, new DateTime(2020, 12, 21), dsDichVu[2]));
        }
        public static void TaoDanhSachChiTietHopDong()
        {
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[0].maHopDong, dsPhong[0].maPhong, new DateTime(2020, 1, 8), new DateTime(2021, 1, 8), dsHopDong[0], dsPhong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[1].maHopDong, dsPhong[0].maPhong, new DateTime(2020, 1, 9), new DateTime(2021, 1, 9), dsHopDong[1], dsPhong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[2].maHopDong, dsPhong[1].maPhong, new DateTime(2020, 1, 23), new DateTime(2021, 2, 23), dsHopDong[2], dsPhong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[3].maHopDong, dsPhong[1].maPhong, new DateTime(2020, 2, 18), new DateTime(2021, 2, 18), dsHopDong[3], dsPhong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[4].maHopDong, dsPhong[1].maPhong, new DateTime(2020, 3, 2), new DateTime(2021, 3, 2), dsHopDong[4], dsPhong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[5].maHopDong, dsPhong[5].maPhong, new DateTime(2020, 3, 7), new DateTime(2021, 1, 7), dsHopDong[5], dsPhong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[6].maHopDong, dsPhong[2].maPhong, new DateTime(2020, 3, 12), new DateTime(2021, 6, 12), dsHopDong[6], dsPhong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[7].maHopDong, dsPhong[2].maPhong, new DateTime(2020, 3, 17), new DateTime(2021, 6, 17), dsHopDong[7], dsPhong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[8].maHopDong, dsPhong[3].maPhong, new DateTime(2020, 3, 24), new DateTime(2021, 1, 24), dsHopDong[8], dsPhong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[9].maHopDong, dsPhong[3].maPhong, new DateTime(2020, 4, 21), new DateTime(2022, 4, 21), dsHopDong[9], dsPhong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[10].maHopDong, dsPhong[4].maPhong, new DateTime(2020, 4, 24), new DateTime(2021, 4, 24), dsHopDong[10], dsPhong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[11].maHopDong, dsPhong[4].maPhong, new DateTime(2020, 5, 7), new DateTime(2021, 5, 7), dsHopDong[11], dsPhong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[12].maHopDong, dsPhong[5].maPhong, new DateTime(2020, 5, 8), new DateTime(2021, 5, 8), dsHopDong[12], dsPhong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[13].maHopDong, dsPhong[5].maPhong, new DateTime(2020, 5, 18), new DateTime(2021, 5, 18), dsHopDong[13], dsPhong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[14].maHopDong, dsPhong[6].maPhong, new DateTime(2020, 5, 28), new DateTime(2021, 1, 28), dsHopDong[14], dsPhong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[15].maHopDong, dsPhong[6].maPhong, new DateTime(2020, 6, 6), new DateTime(2021, 2, 6), dsHopDong[15], dsPhong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[16].maHopDong, dsPhong[6].maPhong, new DateTime(2020, 6, 9), new DateTime(2021, 2, 9), dsHopDong[16], dsPhong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[17].maHopDong, dsPhong[10].maPhong, new DateTime(2020, 6, 17), new DateTime(2021, 2, 17), dsHopDong[17], dsPhong[10]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[18].maHopDong, dsPhong[10].maPhong, new DateTime(2020, 6, 24), new DateTime(2021, 2, 24), dsHopDong[18], dsPhong[10]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[19].maHopDong, dsPhong[11].maPhong, new DateTime(2020, 7, 21), new DateTime(2022, 7, 21), dsHopDong[19], dsPhong[11]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[20].maHopDong, dsPhong[11].maPhong, new DateTime(2020, 7, 28), new DateTime(2022, 7, 28), dsHopDong[20], dsPhong[11]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[21].maHopDong, dsPhong[11].maPhong, new DateTime(2020, 8, 5), new DateTime(2022, 8, 5), dsHopDong[21], dsPhong[11]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[22].maHopDong, dsPhong[12].maPhong, new DateTime(2020, 8, 12), new DateTime(2022, 8, 12), dsHopDong[22], dsPhong[12]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[23].maHopDong, dsPhong[12].maPhong, new DateTime(2020, 8, 28), new DateTime(2021, 8, 28), dsHopDong[23], dsPhong[12]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[24].maHopDong, dsPhong[12].maPhong, new DateTime(2020, 9, 17), new DateTime(2021, 9, 17), dsHopDong[24], dsPhong[12]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[25].maHopDong, dsPhong[14].maPhong, new DateTime(2020, 10, 12), new DateTime(2021, 9, 12), dsHopDong[25], dsPhong[14]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[26].maHopDong, dsPhong[14].maPhong, new DateTime(2020, 10, 22), new DateTime(2021, 10, 22), dsHopDong[26], dsPhong[14]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[27].maHopDong, dsPhong[15].maPhong, new DateTime(2020, 10, 26), new DateTime(2021, 10, 26), dsHopDong[27], dsPhong[15]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[28].maHopDong, dsPhong[15].maPhong, new DateTime(2020, 10, 30), new DateTime(2021, 10, 3), dsHopDong[28], dsPhong[15]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[29].maHopDong, dsPhong[15].maPhong, new DateTime(2020, 10, 31), new DateTime(2021, 10, 31), dsHopDong[29], dsPhong[15]));
        }
        public static void TaoDanhSachHopDong()
        {
            dsHopDong.Add(new HopDongThuePhong("HD01", dsSinhVien[0].maSV, new DateTime(2020, 1, 5), dsSinhVien[0]));
            dsHopDong.Add(new HopDongThuePhong("HD02", dsSinhVien[1].maSV, new DateTime(2020, 1, 6), dsSinhVien[1]));
            dsHopDong.Add(new HopDongThuePhong("HD03", dsSinhVien[2].maSV, new DateTime(2020, 1, 17), dsSinhVien[2]));
            dsHopDong.Add(new HopDongThuePhong("HD04", dsSinhVien[3].maSV, new DateTime(2020, 2, 11), dsSinhVien[3]));
            dsHopDong.Add(new HopDongThuePhong("HD05", dsSinhVien[4].maSV, new DateTime(2020, 2, 25), dsSinhVien[4]));
            dsHopDong.Add(new HopDongThuePhong("HD06", dsSinhVien[5].maSV, new DateTime(2020, 2, 28), dsSinhVien[5]));
            dsHopDong.Add(new HopDongThuePhong("HD07", dsSinhVien[6].maSV, new DateTime(2020, 3, 2), dsSinhVien[6]));
            dsHopDong.Add(new HopDongThuePhong("HD08", dsSinhVien[7].maSV, new DateTime(2020, 3, 5), dsSinhVien[7]));
            dsHopDong.Add(new HopDongThuePhong("HD09", dsSinhVien[8].maSV, new DateTime(2020, 3, 10), dsSinhVien[8]));
            dsHopDong.Add(new HopDongThuePhong("HD10", dsSinhVien[9].maSV, new DateTime(2020, 3, 17), dsSinhVien[9]));
            dsHopDong.Add(new HopDongThuePhong("HD11", dsSinhVien[10].maSV, new DateTime(2020, 4, 13), dsSinhVien[10]));
            dsHopDong.Add(new HopDongThuePhong("HD12", dsSinhVien[11].maSV, new DateTime(2020, 4, 16), dsSinhVien[11]));
            dsHopDong.Add(new HopDongThuePhong("HD13", dsSinhVien[12].maSV, new DateTime(2020, 5, 1), dsSinhVien[12]));
            dsHopDong.Add(new HopDongThuePhong("HD14", dsSinhVien[13].maSV, new DateTime(2020, 5, 2), dsSinhVien[13]));
            dsHopDong.Add(new HopDongThuePhong("HD15", dsSinhVien[14].maSV, new DateTime(2020, 5, 11), dsSinhVien[14]));
            dsHopDong.Add(new HopDongThuePhong("HD16", dsSinhVien[15].maSV, new DateTime(2020, 5, 21), dsSinhVien[15]));
            dsHopDong.Add(new HopDongThuePhong("HD17", dsSinhVien[16].maSV, new DateTime(2020, 5, 30), dsSinhVien[16]));
            dsHopDong.Add(new HopDongThuePhong("HD18", dsSinhVien[17].maSV, new DateTime(2020, 6, 2), dsSinhVien[17]));
            dsHopDong.Add(new HopDongThuePhong("HD19", dsSinhVien[18].maSV, new DateTime(2020, 6, 2), dsSinhVien[18]));
            dsHopDong.Add(new HopDongThuePhong("HD20", dsSinhVien[19].maSV, new DateTime(2020, 7, 17), dsSinhVien[19]));
            dsHopDong.Add(new HopDongThuePhong("HD21", dsSinhVien[20].maSV, new DateTime(2020, 7, 5), dsSinhVien[20]));
            dsHopDong.Add(new HopDongThuePhong("HD22", dsSinhVien[21].maSV, new DateTime(2020, 7, 25), dsSinhVien[21]));
            dsHopDong.Add(new HopDongThuePhong("HD23", dsSinhVien[22].maSV, new DateTime(2020, 7, 28), dsSinhVien[22]));
            dsHopDong.Add(new HopDongThuePhong("HD24", dsSinhVien[23].maSV, new DateTime(2020, 9, 3), dsSinhVien[23]));
            dsHopDong.Add(new HopDongThuePhong("HD25", dsSinhVien[24].maSV, new DateTime(2020, 9, 28), dsSinhVien[24]));
            dsHopDong.Add(new HopDongThuePhong("HD26", dsSinhVien[25].maSV, new DateTime(2020, 10, 3), dsSinhVien[25]));
            dsHopDong.Add(new HopDongThuePhong("HD27", dsSinhVien[26].maSV, new DateTime(2020, 10, 7), dsSinhVien[26]));
            dsHopDong.Add(new HopDongThuePhong("HD28", dsSinhVien[27].maSV, new DateTime(2020, 10, 20), dsSinhVien[27]));
            dsHopDong.Add(new HopDongThuePhong("HD29", dsSinhVien[28].maSV, new DateTime(2020, 10, 7), dsSinhVien[28]));
            dsHopDong.Add(new HopDongThuePhong("HD30", dsSinhVien[29].maSV, new DateTime(2020, 10, 10), dsSinhVien[29]));
        }
        public static void TaoDanhSachLoaiNhanVien()
        {
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV01", "Lao công", "Quét sân", new List<NhanVien>(), null));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV02", "Phụ bếp", "Dọn dẹp nhà bếp", new List<NhanVien>(), null));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV03", "Đầu bếp", "Nấu ăn", new List<NhanVien>(), null));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV04", "Bảo vệ", "Canh cổng ra vào", new List<NhanVien>(), null));
            dsLoaiNhanVien.Add(new LoaiNhanVien("LNV05", "Sửa điện", "Xử lý vấn đề về điện", new List<NhanVien>(), null));
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

            //mã quản lý 0 - 2 - 4 - 6 - 3
            dsLoaiNhanVien[0].quanLy = new NhanVien(dsNhanVien[0]);
            dsLoaiNhanVien[0].maQuanLy = dsNhanVien[0].maNV;

            dsLoaiNhanVien[1].quanLy = new NhanVien(dsNhanVien[2]);
            dsLoaiNhanVien[1].maQuanLy = dsNhanVien[2].maNV;

            dsLoaiNhanVien[2].quanLy = new NhanVien(dsNhanVien[4]);
            dsLoaiNhanVien[2].maQuanLy = dsNhanVien[4].maNV;

            dsLoaiNhanVien[3].quanLy = new NhanVien(dsNhanVien[6]);
            dsLoaiNhanVien[3].maQuanLy = dsNhanVien[6].maNV;

            dsLoaiNhanVien[4].quanLy = new NhanVien(dsNhanVien[3]);
            dsLoaiNhanVien[4].maQuanLy = dsNhanVien[3].maNV;

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
            dsPhong.Add(new Phong("P01", dsToa[0].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[0], dsLoaiPhong[1], new List<SinhVien>()));
            dsPhong.Add(new Phong("P02", dsToa[0].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[0], dsLoaiPhong[1], new List<SinhVien>()));
            dsPhong.Add(new Phong("P03", dsToa[1].maToa, dsLoaiPhong[3].maLoaiPhong, true, dsToa[1], dsLoaiPhong[3], new List<SinhVien>()));
            dsPhong.Add(new Phong("P04", dsToa[1].maToa, dsLoaiPhong[3].maLoaiPhong, true, dsToa[1], dsLoaiPhong[3], new List<SinhVien>()));
            dsPhong.Add(new Phong("P05", dsToa[2].maToa, dsLoaiPhong[2].maLoaiPhong, true, dsToa[2], dsLoaiPhong[2], new List<SinhVien>()));
            dsPhong.Add(new Phong("P06", dsToa[2].maToa, dsLoaiPhong[2].maLoaiPhong, true, dsToa[2], dsLoaiPhong[2], new List<SinhVien>()));
            dsPhong.Add(new Phong("P07", dsToa[3].maToa, dsLoaiPhong[1].maLoaiPhong, true, dsToa[3], dsLoaiPhong[1], new List<SinhVien>()));
            dsPhong.Add(new Phong("P08", dsToa[3].maToa, dsLoaiPhong[3].maLoaiPhong, false, dsToa[3], dsLoaiPhong[3], new List<SinhVien>()));
            dsPhong.Add(new Phong("P09", dsToa[1].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[1], dsLoaiPhong[0], new List<SinhVien>()));
            dsPhong.Add(new Phong("P10", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[3], dsLoaiPhong[0], new List<SinhVien>()));
            dsPhong.Add(new Phong("P11", dsToa[0].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[0], dsLoaiPhong[4], new List<SinhVien>()));
            dsPhong.Add(new Phong("P12", dsToa[0].maToa, dsLoaiPhong[5].maLoaiPhong, true, dsToa[0], dsLoaiPhong[5], new List<SinhVien>()));
            dsPhong.Add(new Phong("P13", dsToa[1].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[1], dsLoaiPhong[4], new List<SinhVien>()));
            dsPhong.Add(new Phong("P14", dsToa[1].maToa, dsLoaiPhong[5].maLoaiPhong, false, dsToa[1], dsLoaiPhong[5], new List<SinhVien>()));
            dsPhong.Add(new Phong("P15", dsToa[2].maToa, dsLoaiPhong[4].maLoaiPhong, true, dsToa[2], dsLoaiPhong[4], new List<SinhVien>()));
            dsPhong.Add(new Phong("P16", dsToa[2].maToa, dsLoaiPhong[5].maLoaiPhong, true, dsToa[2], dsLoaiPhong[5], new List<SinhVien>()));
            dsPhong.Add(new Phong("P17", dsToa[3].maToa, dsLoaiPhong[1].maLoaiPhong, false, dsToa[3], dsLoaiPhong[1], new List<SinhVien>()));
            dsPhong.Add(new Phong("P18", dsToa[3].maToa, dsLoaiPhong[1].maLoaiPhong, false, dsToa[3], dsLoaiPhong[1], new List<SinhVien>()));
            dsPhong.Add(new Phong("P19", dsToa[1].maToa, dsLoaiPhong[2].maLoaiPhong, false, dsToa[1], dsLoaiPhong[2], new List<SinhVien>()));
            dsPhong.Add(new Phong("P20", dsToa[3].maToa, dsLoaiPhong[2].maLoaiPhong, false, dsToa[3], dsLoaiPhong[2], new List<SinhVien>()));
            dsPhong.Add(new Phong("P21", dsToa[0].maToa, dsLoaiPhong[3].maLoaiPhong, false, dsToa[0], dsLoaiPhong[3], new List<SinhVien>()));
            dsPhong.Add(new Phong("P22", dsToa[0].maToa, dsLoaiPhong[3].maLoaiPhong, false, dsToa[0], dsLoaiPhong[3], new List<SinhVien>()));
            dsPhong.Add(new Phong("P23", dsToa[1].maToa, dsLoaiPhong[4].maLoaiPhong, false, dsToa[1], dsLoaiPhong[4], new List<SinhVien>()));
            dsPhong.Add(new Phong("P24", dsToa[1].maToa, dsLoaiPhong[4].maLoaiPhong, false, dsToa[1], dsLoaiPhong[4], new List<SinhVien>()));
            dsPhong.Add(new Phong("P25", dsToa[2].maToa, dsLoaiPhong[5].maLoaiPhong, false, dsToa[2], dsLoaiPhong[5], new List<SinhVien>()));
            dsPhong.Add(new Phong("P26", dsToa[2].maToa, dsLoaiPhong[5].maLoaiPhong, false, dsToa[2], dsLoaiPhong[5], new List<SinhVien>()));
            dsPhong.Add(new Phong("P27", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[3], dsLoaiPhong[0], new List<SinhVien>()));
            dsPhong.Add(new Phong("P28", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[3], dsLoaiPhong[0], new List<SinhVien>()));
            dsPhong.Add(new Phong("P29", dsToa[1].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[1], dsLoaiPhong[0], new List<SinhVien>()));
            dsPhong.Add(new Phong("P30", dsToa[3].maToa, dsLoaiPhong[0].maLoaiPhong, false, dsToa[3], dsLoaiPhong[0], new List<SinhVien>()));


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

            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[2]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[3]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[7]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[20]);
            dsLoaiPhong[3].dsphong_loai.Add(dsPhong[21]);

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
            dsSinhVien.Add(new SinhVien("SV01", "Văn Minh Anh", true, "0335573464", dsPhong[0]));
            dsSinhVien.Add(new SinhVien("SV02", "Kha Sỹ Phú", true, "0955546106", dsPhong[0]));
            dsSinhVien.Add(new SinhVien("SV03", "Phan Phúc Lâm", true, "0875516075", dsPhong[1]));
            dsSinhVien.Add(new SinhVien("SV04", "Trần Trung Thế", true, "0335555459", dsPhong[1]));
            dsSinhVien.Add(new SinhVien("SV05", "Cao Đăng Ngọc Quý", true, "0995578740", dsPhong[1]));
            dsSinhVien.Add(new SinhVien("SV06", "Phạm Vĩnh Long", true, "0335558622", dsPhong[5]));
            dsSinhVien.Add(new SinhVien("SV07", "Tạ Bạch Cúc", false, "0935505935", dsPhong[2]));
            dsSinhVien.Add(new SinhVien("SV08", "Mai Kiều Hoa", false, "0855533475", dsPhong[2]));
            dsSinhVien.Add(new SinhVien("SV09", "Mai Phương Thúy", false, "0955515045", dsPhong[3]));
            dsSinhVien.Add(new SinhVien("SV10", "Hoàng Phương Thảo", false, "0895501461", dsPhong[3]));
            dsSinhVien.Add(new SinhVien("SV11", "Trần Quang Bửu", true, "09732588394", dsPhong[4]));
            dsSinhVien.Add(new SinhVien("SV12", "Nguyễn Quang Dũng", true, "03312598591", dsPhong[4]));
            dsSinhVien.Add(new SinhVien("SV13", "Nguyễn Thiện Giang", true, "09331529049", dsPhong[5]));
            dsSinhVien.Add(new SinhVien("SV14", "Nguyễn Trọng Khánh", true, "09556752852", dsPhong[5]));
            dsSinhVien.Add(new SinhVien("SV15", "Phan Bảo Long", true, "03758710360", dsPhong[6]));
            dsSinhVien.Add(new SinhVien("SV16", "Cao Khắc Minh", true, "03512548013", dsPhong[6]));
            dsSinhVien.Add(new SinhVien("SV17", "Đoàn Kiên Trung", true, "09655516844", dsPhong[6]));
            dsSinhVien.Add(new SinhVien("SV18", "Huỳnh Huy Cường", true, "03578507626", dsPhong[10]));
            dsSinhVien.Add(new SinhVien("SV19", "Danh Hoàng Giang", true, "098559527928", dsPhong[10]));
            dsSinhVien.Add(new SinhVien("SV20", "Đỗ Mỹ Loan", false, "03515538943", dsPhong[11]));
            dsSinhVien.Add(new SinhVien("SV21", "Nguyễn Phương Lan", false, "09959743180", dsPhong[11]));
            dsSinhVien.Add(new SinhVien("SV22", "Trịnh Thúy Anh", false, "03565533549", dsPhong[11]));
            dsSinhVien.Add(new SinhVien("SV23", "Lương Bạch Loan", false, "09351210183", dsPhong[12]));
            dsSinhVien.Add(new SinhVien("SV24", "Nghiêm Diệu Hà", false, "03364557138", dsPhong[12]));
            dsSinhVien.Add(new SinhVien("SV25", "Nguyễn Hải Châu", false, "0333129573", dsPhong[12]));
            dsSinhVien.Add(new SinhVien("SV26", "Vũ Bạch Yến", false, "0335979171", dsPhong[14]));
            dsSinhVien.Add(new SinhVien("SV27", "Nguyễn Bích Thủy", false, "09915542642", dsPhong[14]));
            dsSinhVien.Add(new SinhVien("SV28", "Việt Mỹ Kiều", false, "09532563250", dsPhong[15]));
            dsSinhVien.Add(new SinhVien("SV29", "Nguyễn Linh Sương Sương", false, "09857975293", dsPhong[15]));
            dsSinhVien.Add(new SinhVien("SV30", "Vũ Bích Vân", false, "03368595027", dsPhong[15]));

            dsPhong[0].dssv_phong.Add(dsSinhVien[0]);
            dsPhong[0].dssv_phong.Add(dsSinhVien[1]);

            dsPhong[1].dssv_phong.Add(dsSinhVien[2]);
            dsPhong[1].dssv_phong.Add(dsSinhVien[3]);
            dsPhong[1].dssv_phong.Add(dsSinhVien[4]);

            dsPhong[2].dssv_phong.Add(dsSinhVien[6]);
            dsPhong[2].dssv_phong.Add(dsSinhVien[7]);

            dsPhong[3].dssv_phong.Add(dsSinhVien[8]);
            dsPhong[3].dssv_phong.Add(dsSinhVien[9]);

            dsPhong[4].dssv_phong.Add(dsSinhVien[10]);
            dsPhong[4].dssv_phong.Add(dsSinhVien[11]);

            dsPhong[5].dssv_phong.Add(dsSinhVien[5]);
            dsPhong[5].dssv_phong.Add(dsSinhVien[12]);
            dsPhong[5].dssv_phong.Add(dsSinhVien[13]);

            dsPhong[6].dssv_phong.Add(dsSinhVien[14]);
            dsPhong[6].dssv_phong.Add(dsSinhVien[15]);
            dsPhong[6].dssv_phong.Add(dsSinhVien[16]);

            dsPhong[10].dssv_phong.Add(dsSinhVien[17]);
            dsPhong[10].dssv_phong.Add(dsSinhVien[18]);

            dsPhong[11].dssv_phong.Add(dsSinhVien[19]);
            dsPhong[11].dssv_phong.Add(dsSinhVien[20]);
            dsPhong[11].dssv_phong.Add(dsSinhVien[21]);

            dsPhong[12].dssv_phong.Add(dsSinhVien[22]);
            dsPhong[12].dssv_phong.Add(dsSinhVien[23]);
            dsPhong[12].dssv_phong.Add(dsSinhVien[24]);

            dsPhong[14].dssv_phong.Add(dsSinhVien[26]);
            dsPhong[14].dssv_phong.Add(dsSinhVien[25]);

            dsPhong[15].dssv_phong.Add(dsSinhVien[27]);
            dsPhong[15].dssv_phong.Add(dsSinhVien[28]);
            dsPhong[15].dssv_phong.Add(dsSinhVien[29]);
        }

        //1. Cho biết thông tin phòng còn trống ở mỗi tòa
        public static void Linq1()
        {
            Console.WriteLine("Linq1");
            Console.WriteLine("Danh sách những phòng còn trống theo tòa");

            var groupTheoToa = dsPhong
                .Where(p => !p.trangThai)
                .GroupBy(p => p.maToa)
                .Select(y => new { MaToa = y.Key, Phong = y });

            foreach (var t in groupTheoToa)
            {
                Console.WriteLine("Tòa {0}:", t.MaToa);
                foreach (var p in t.Phong)
                {
                    Console.WriteLine("Mã phòng: {0} - Mã loại phòng: {1}", p.maPhong, p.maLoaiPhong);
                }
            }
            Console.WriteLine();
        }
        //2. Cho biết thông tin quản lý của nhân viên 
        public static void Linq2(string ma)
        {
            Console.WriteLine("Linq2");

            NhanVien nv = dsNhanVien
                .Where(t => t.maNV == ma)
                .FirstOrDefault();
            Console.WriteLine("Mã nhân viên: {0} - Họ tên: {1} đang quản lý loại nhân viên có {2}",
                nv.loaiNhanVien.maQuanLy, nv.loaiNhanVien.quanLy.tenNhanVien, nv.loaiNhanVien.maLoaiNV);
            Console.WriteLine();
        }
        //3. Sắp xếp tăng dần số lượng sinh viên theo từng phòng
        public static void Linq3()
        {
            Console.WriteLine("Linq3");
            Console.WriteLine("Số lượng sinh viên theo từng phòng");
            var SLSVTheoPhong = dsSinhVien
               .GroupBy(p => p.phong.maPhong)
               .Select(y => new { MaPhong = y.Key, SoLuongSV = y.Count() })
               .OrderBy(e => e.SoLuongSV);
            foreach (var a in SLSVTheoPhong)
                Console.WriteLine("Phòng {0}: {1} sinh viên", a.MaPhong, a.SoLuongSV);
            Console.WriteLine();
        }

        //4. Cho biết tổng tiền sử dụng dịch vụ của mỗi phòng 
        public static void Linq4()
        {
            Console.WriteLine("Linq4");
            Console.WriteLine("Tiền dịch vụ của mỗi phòng");
            var groupTheoPhong = dsHoaDon
                .GroupBy(p => p.maPhong)
                .Select(y => new { maPhong = y.Key, tien = y.Sum(a => a.tongTien) });
            foreach (var t in groupTheoPhong)
                Console.WriteLine("Phòng {0}: {1}VNĐ", t.maPhong, t.tien);
            Console.WriteLine();
        }

        //5. Liệt kê thông tin các sinh viên đang ở phòng " "
        public static void Linq5(string maph)
        {
            Console.WriteLine("Linq5");
            Console.WriteLine("Thông tin sinh viên đang sống ở phòng {0}", maph);
            var SVTheoPhong = dsSinhVien
               .Where(t => t.phong.maPhong == maph)
               .Select(t => new { MaSV = t.maSV, Ten = t.tenSV, Gioi = t.gioiTinh, SDT = t.soDienThoai });
            foreach (var sv in SVTheoPhong)
                Console.WriteLine("Mã SV: {0} - Họ tên: {1} - Giới tính {2} - SĐT: {3}", sv.MaSV, sv.Ten, sv.Gioi ? "Nam" : "Nữ", sv.SDT);

        }
        //6. Cho biết số lượng và danh sách các phòng chưa được thuê của tòa ...
        public static void Linq6(char t)
        {
            Console.WriteLine("Linq6");
            var result = from p in dsPhong
                         where p.maToa == t && p.trangThai == false
                         select p;
            Console.WriteLine("Số lượng phòng chưa được thuê của tòa {0} là: {1}", t, result.Count());
            foreach (var p in result)
                Console.WriteLine("{0} - {1}", p.maPhong, p.loaiPhong.tenLoaiPhong);
        }

        //7. Cho biết thông tin nhân viên có mức lương cao nhất và thấp nhấp theo mỗi loại nhân viên
        public static void Linq7()
        {
            Console.WriteLine("Linq7");
            //Format tiền Việt
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            var luongThapTheoLoai = dsNhanVien
                .GroupBy(t => t.maLoaiNV)
                .Select(nv => nv.OrderBy(x => x.luong))
                .Select(x => x.First());

            var luongCaoTheoLoai = dsNhanVien
               .GroupBy(t => t.maLoaiNV)
               .Select(nv => nv.OrderByDescending(x => x.luong))
               .Select(x => x.First());
            Console.WriteLine("Danh sách nhân viên lương thấp nhất mỗi loại nhân viên");
            foreach (var i in luongThapTheoLoai)
                Console.WriteLine("Mã loại: {0} - Công việc: {1} - Họ tên: {2} - Lương {3} VNĐ", i.maLoaiNV, i.loaiNhanVien.congViec, i.tenNhanVien, double.Parse(i.luong.ToString()).ToString("#,###", cul.NumberFormat));
            Console.WriteLine();
            Console.WriteLine("Danh sách nhân viên lương cao nhất mỗi loại nhân viên");
            foreach (var i in luongCaoTheoLoai)
                Console.WriteLine("Mã loại: {0} - Công việc: {1} - Họ tên: {2} - Lương {3} VNĐ", i.maLoaiNV, i.loaiNhanVien.congViec, i.tenNhanVien, double.Parse(i.luong.ToString()).ToString("#,###", cul.NumberFormat));
        }

        //8. Cho biết số lượng phòng máy lạnh đang được thuê ở tòa ...
        public static void Linq8(char t)
        {
            Console.WriteLine("Linq8");
            var result = from p in dsPhong
                         where p.loaiPhong.tenLoaiPhong.StartsWith("Phòng máy lạnh") && p.maToa == t
                         select p;
            Console.WriteLine("Số lượng máy lạnh được thuê ở tòa {0} là: {1}", t, result.Count());
            foreach (var p in result)
                Console.WriteLine("Phong: {0}", p.maPhong);
        }

        //9. Liệt kê những thiết bị theo từng loại phòng
        public static void Linq9()
        {
            Console.WriteLine("Linq9");
            var ThietBiTheoLoaiPhong = dsTrangBi.Select(x => x);

            foreach (var i in ThietBiTheoLoaiPhong)
            {
                Console.WriteLine("Mã loại phòng: {0} - Tên loại phòng: {1}", i.loaiPhong.maLoaiPhong, i.loaiPhong.tenLoaiPhong);
                foreach (var j in i.dsthietbi_loaiphong)
                {
                    Console.WriteLine("Mã thiết bị: {0} - Tên thiết bị: {1}", j.maThietBi, j.tenThietBi);
                }
                Console.WriteLine();
            }
        }
        //10. Cho biết các phòng chưa thanh toán hóa đơn dịch vụ nào cả
        public static void Linq10()
        {
            Console.WriteLine("Linq10");
            var tongSoPhong = from p in dsPhong
                              where p.trangThai == true
                              select p.maPhong;
            var phongDaDongTien = from hd in dsHoaDon
                                  where hd.ngayThanhToan != DateTime.MinValue
                                  select hd.maPhong;
            var result = from p in tongSoPhong.Except(phongDaDongTien)
                         select p;
            Console.WriteLine("Các phòng chưa thanh toán hóa đơn dịch vụ nào là: ");
            foreach (var r in result)
                Console.WriteLine(r);
        }
        //11. Cho biết thông tin sinh viên ký hợp đồng thuê KTX từ ngày 15/04/2020 đến 15/05/2020
        public static void Linq11()
        {
            Console.WriteLine("Linq11");
            var hd = dsHopDong
                .Where(x => x.ngayKyHopDong >= new DateTime(2020, 04, 15)
                && x.ngayKyHopDong <= new DateTime(2020, 05, 15))
                .Select(y => new { sv = y });
            foreach (var i in hd)
                Console.WriteLine("Mã SV: {0} - Họ tên: {1} - SĐT: {2} - Ngày ký HĐ: {3} ", i.sv.maSinhVien, i.sv.sinhVien.tenSV, i.sv.sinhVien.soDienThoai, i.sv.ngayKyHopDong.ToShortDateString());
        }


        //12. Cho biết những hợp đồng hết hạn trước ngày 21/04/2021
        public static void Linq12()
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
       

        //14. Liệt kê các phòng đang được thuê theo thứ tự tăng dần giá phòng.
        public static void Linq14()
        {
            Console.WriteLine("Linq14");
            var result = from p in dsPhong
                         where p.trangThai == true
                         orderby p.loaiPhong.giaPhong
                         select new { p.maPhong, p.loaiPhong.giaPhong, p.loaiPhong.tenLoaiPhong };
            Console.WriteLine("Danh sách các phòng đang được thuê theo thứ tự tăng dần của giá phòng: ");
            foreach (var p in result)
                Console.WriteLine("Loại phòng: {0} - Phòng: {1} - Giá phòng: {2} VND", 
                    p.tenLoaiPhong, p.maPhong, p.giaPhong);
        }

        //13. Sắp xếp tổng tiền sử dụng dịch vụ từ cao xuống thấp
        public static void Linq13()
        {
            Console.WriteLine("Linq13");
            var tongTienDichVu = dsHoaDon
            .GroupBy(x => x.maPhong)
            .Select(y => new { MaPhong = y.Key, TienDV = y.Sum(z => z.tongTien) });

            var sapXepTien = tongTienDichVu
                .OrderByDescending(x => x.TienDV);

            foreach (var i in sapXepTien)
                Console.WriteLine("Phòng: {0} - Tiền: {1}", i.MaPhong, i.TienDV);

        }

        //15. Cho biết danh sách thông tin từng phòng theo loại phòng
        public static void Linq15()
        {
            Console.WriteLine("Linq15");
            //Format tiền Việt
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            foreach (var loai in dsLoaiPhong)
            {
                Console.WriteLine("{0} - {1} - {2} VNĐ ",
                   loai.maLoaiPhong, loai.tenLoaiPhong, double.Parse(loai.giaPhong.ToString()).ToString("#,###", cul.NumberFormat));
                foreach (var phong in loai.dsphong_loai)
                {
                    Console.WriteLine("{0} -Tòa {1} - {2}",
                        phong.maPhong, phong.maToa, phong.trangThai ? "Được thuê" : "Trống");
                }
                Console.WriteLine();
            }
        }
        
        //16. Cho biết số lượng sinh viên trong mỗi phòng đang được thuê theo từng tòa
        public static void Linq16()
        {
            Console.WriteLine("Linq16");

            var groupTheoToa = dsPhong
                .Where(p => p.trangThai)
                .GroupBy(t => t.maToa)
                .Select(y => new { MaToa = y.Key, Phong = y });

            var SLSVTheoPhong = dsSinhVien
                .GroupBy(p => p.phong.maPhong)
                .Select(y => new { MaPhong = y.Key, SoLuongSV = y.Count() });

            foreach (var i in groupTheoToa)
            {
                Console.WriteLine("Mã tòa: {0}", i.MaToa);
                foreach (var j in i.Phong)
                { 
                    Console.WriteLine("Mã phòng: {0}", j.maPhong);
                    foreach (var k in SLSVTheoPhong)
                    {
                        if (j.maPhong == k.MaPhong)
                        Console.WriteLine("Số lượng sinh viên: {0}", k.SoLuongSV);
                    }
                }
            }   
        }
        //17.Chó biết thông tin hóa đơn thấp nhất và cao nhất mỗi phòng
        public static void Linq17()
        {
            Console.WriteLine("Linq17");
            //Format tiền Việt
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            var hoaDonThapNhat = dsHoaDon
                .GroupBy(x => x.maPhong)
                .Select(nv => nv.OrderBy(x => x.tongTien))
                .Select(x => x.First());

            var hoaDonCaoNhat = dsHoaDon
                .GroupBy(x => x.maPhong)
                .Select(nv => nv.OrderByDescending(x => x.tongTien))
                .Select(x => x.First());
            Console.WriteLine("Danh sách hóa đơn thấp nhất mỗi phòng");
            foreach (var i in hoaDonThapNhat)
                Console.WriteLine("Phòng {0} - Hóa đơn: {1} - Giá trị hóa đơn: {2} VNĐ", i.maPhong, i.maHoaDon, double.Parse(i.tongTien.ToString()).ToString("#,###", cul.NumberFormat));
            Console.WriteLine();
            Console.WriteLine("Danh sách hóa đơn cao nhất mỗi phòng");
            foreach (var i in hoaDonCaoNhat)
                Console.WriteLine("Phòng {0} - Hóa đơn: {1} - Giá trị hóa đơn: {2} VNĐ", i.maPhong, i.maHoaDon, double.Parse(i.tongTien.ToString()).ToString("#,###", cul.NumberFormat));


        }
        //18. Cho biết thời gian thuê phòng của từng sinh viên
        public static void Linq18()
        {
            Console.WriteLine("Linq18");
            var DanhSachThoiGianThue = dsChiTietHopDong
                .Select(p => 
                new { range = p.ngayKetThuc - p.ngayBatDau, p.hopDong.maSinhVien, p.hopDong.sinhVien.tenSV });
            foreach (var tg in DanhSachThoiGianThue)
            {
                int years = (tg.range.Days) / 365;
                int months = (tg.range.Days - years * 365) / 30;
                int days = (tg.range.Days - years * 365 - months * 30);
                if (years == 0)
                    Console.WriteLine("Hợp đồng của {0} - {1} có thời hạn: {2} tháng {3} ngày", 
                        tg.maSinhVien, tg.tenSV, months, days);
                else
                    Console.WriteLine("Hợp đồng của {0} - {1} có thời hạn: {2} năm {3} tháng {4} ngày",
                        tg.maSinhVien, tg.tenSV, years, months, days);
            }
        }
        //19. Cho biết phòng sử dụng dịch vụ nhiều nhất và ít nhất
        public static void Linq19()
        {

        }
        //20. Cho biết tiền sử dụng dịch vụ trung bình của tòa .../(từng tòa)
        //public static void Linq20()
        //{
        //    Console.WriteLine("Linq20");
        //    var groupTheoPhong = dsHoaDon
        //        .GroupBy(p => p.maPhong)
        //        .Select(y => new { maPhong = y.Key, tien = y.Sum(a => a.tongTien) });
        //    var groupTheoToa = dsToa
        //        .GroupBy(p => p.maToa)
        //        .Select(y => new { groupTheoPhong });
        //    foreach(var avg in groupTheoPhong)
        //    {
               
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
            TaoDanhSachHopDong();
            TaoDanhSachChiTietHopDong();
            TaoDanhSachDichVu();
            TaoDanhSachChiTietHoaDonDichVu();

            Console.OutputEncoding = Encoding.UTF8;
            //Linq2();
            //Linq4();
            //Linq6();
            //Linq8();
            //Linq10();
            //Linq12();
            //Linq14();
            //Linq16();in progress
            //Linq18();in progress
            //Linq20();in progress
            //Linq3();
            //Linq5("P06");
            //Linq7();
            //Linq9();
            //Linq11();
            //Linq13();
            //Linq15();
            Linq17();
            //Linq16();
            //Linq18();
            //Linq20();
            Console.ReadKey();
        }
    }
}
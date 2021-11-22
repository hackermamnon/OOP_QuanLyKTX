using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    class Program
    {
        static List<Toa> toa = new List<Toa>();
        static List<SinhVien> sinhVien = new List<SinhVien>();
        static List<QuanLy> quanLy = new List<QuanLy>();
        static List<Phong> phong = new List<Phong>();
        static List<NhanVien> nhanVien = new List<NhanVien>();
        static List<LoaiPhong> loaiPhong = new List<LoaiPhong>();
        static List<LoaiNhanVien> loaiNhanVien = new List<LoaiNhanVien>();
        static List<HopDongThuePhong> hopDongThuePhong = new List<HopDongThuePhong>();
        static List<ChiTiet_HD> chiTiet_HD = new List<ChiTiet_HD>();
        static List<DichVu> dichVu = new List<DichVu>();
        static List<HoaDonDichVu> hoaDonDichVu = new List<HoaDonDichVu>();
        
        public static void TaoDanhSachChiTiet_HD()
        {
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[0], phong[0], toa[0], new DateTime(2020, 1, 8), new DateTime(2021, 1, 8)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[1], phong[1], toa[0], new DateTime(2020, 1, 17), new DateTime(2021, 1, 17)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[2], phong[2], toa[1], new DateTime(2020, 2, 23), new DateTime(2021, 2, 23)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[3], phong[3], toa[1], new DateTime(2020, 2, 18), new DateTime(2021, 2, 18)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[4], phong[4], toa[2], new DateTime(2020, 3, 2), new DateTime(2021, 3, 2)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[5], phong[5], toa[2], new DateTime(2020, 3, 7), new DateTime(2021, 1, 7)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[6], phong[6], toa[3], new DateTime(2020, 3, 12), new DateTime(2021, 6, 12)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[7], phong[7], toa[3], new DateTime(2020, 3, 17), new DateTime(2021, 6, 17)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[8], phong[8], toa[1], new DateTime(2020, 3, 24), new DateTime(2021, 1, 24)));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[9], phong[9], toa[3], new DateTime(2020, 4, 21), new DateTime(2022, 4, 21)));
        }
        public static void TaoDanhSachHopDong()
        {
            hopDongThuePhong.Add(new HopDongThuePhong("HD01", sinhVien[0], new DateTime(2020, 1, 1)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD02", sinhVien[1], new DateTime(2020, 10, 2)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD03", sinhVien[2], new DateTime(2020, 1, 26)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD04", sinhVien[3], new DateTime(2020, 2, 11)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD05", sinhVien[4], new DateTime(2020, 2, 23)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD06", sinhVien[5], new DateTime(2020, 2, 28)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD07", sinhVien[6], new DateTime(2020, 3, 2)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD08", sinhVien[7], new DateTime(2020, 3, 10)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD09", sinhVien[8], new DateTime(2020, 3, 17)));
            hopDongThuePhong.Add(new HopDongThuePhong("HD10", sinhVien[9], new DateTime(2020, 04, 14)));
        }
        public static void TaoDanhSachLoaiNhanVien()
        {
            loaiNhanVien.Add(new LoaiNhanVien("LNV01", "Lao công", "Quét sân"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV02", "Phụ bếp", "Dọn dẹp nhà bếp"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV03", "Đầu bếp", "Nấu ăn"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV04", "Bảo vệ", "Canh cổng ra vào"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV05", "Sửa điện", "Sửa điện"));
        }
        public static void TaoDanhSachNhanVien()
        {
            nhanVien.Add(new NhanVien("NV01", loaiNhanVien[0], toa[1], "Phan Quang Đạt", "0321550699", 12000000));
            nhanVien.Add(new NhanVien("NV02", loaiNhanVien[0], toa[1], "Nguyễn Hoàng Hải", "0935538764", 10500000));
            nhanVien.Add(new NhanVien("NV03", loaiNhanVien[1], toa[2], "Phan Ninh Thuật", "0375512722", 12500000));
            nhanVien.Add(new NhanVien("NV04", loaiNhanVien[4], toa[2], "Văn Viết Hồng", "0933592539", 15500000));
            nhanVien.Add(new NhanVien("NV05", loaiNhanVien[2], toa[3], "Vũ Hoàng Lâm", "0873562883", 11300000));
            nhanVien.Add(new NhanVien("NV06", loaiNhanVien[2], toa[3], "Trần Văn Tài", "0376588314", 14800000));
            nhanVien.Add(new NhanVien("NV07", loaiNhanVien[3], toa[3], "Nguyễn Thị Bích Châu", "0935543050", 18200000));
            nhanVien.Add(new NhanVien("NV08", loaiNhanVien[3], toa[0], "Trần Hạnh Vy", "0835559895", 11500000));
            nhanVien.Add(new NhanVien("NV09", loaiNhanVien[2], toa[1], "Trần Phương Thanh", "0855586047", 12000000));
            nhanVien.Add(new NhanVien("NV10", loaiNhanVien[1], toa[2], "Ngô Ngọc Huế", "0935517709", 13500000));
            nhanVien.Add(new NhanVien("NV11", loaiNhanVien[3], toa[1], "Khưu Hoài Bắc", "0952114939", 13000000));
            nhanVien.Add(new NhanVien("NV12", loaiNhanVien[3], toa[1], "Tôn Yên Bình", "0933213448", 11500000));
            nhanVien.Add(new NhanVien("NV13", loaiNhanVien[3], toa[2], "Nguyễn Nguyên Khôi", "0941527983", 13500000));
            nhanVien.Add(new NhanVien("NV14", loaiNhanVien[3], toa[2], "Hoàng Hiệp Hà", "0992525872", 16500000));
            nhanVien.Add(new NhanVien("NV15", loaiNhanVien[0], toa[3], "Lâm Phi Hùng", "0991204916", 12300000));
            nhanVien.Add(new NhanVien("NV16", loaiNhanVien[4], toa[3], "Trần Tấn Nam", "0967537105", 15800000));
            nhanVien.Add(new NhanVien("NV17", loaiNhanVien[4], toa[3], "Trần Minh Tiến", "0938910107", 19200000));
            nhanVien.Add(new NhanVien("NV18", loaiNhanVien[4], toa[0], "Phạm Minh Thiện", "0921507874", 12500000));
            nhanVien.Add(new NhanVien("NV19", loaiNhanVien[2], toa[1], "Hoàng Công Bằng", "0973125823", 13000000));
            nhanVien.Add(new NhanVien("NV20", loaiNhanVien[2], toa[2], "Nguyễn Thành Công", "0931213547", 13500000));
            nhanVien.Add(new NhanVien("NV21", loaiNhanVien[0], toa[1], "Bùi Trọng Kim", "0935181991", 12000000));
            nhanVien.Add(new NhanVien("NV22", loaiNhanVien[0], toa[1], "Đào Phi Hải", "0912529277", 10500000));
            nhanVien.Add(new NhanVien("NV23", loaiNhanVien[0], toa[2], "Trịnh Thiện Luân", "0987558119", 12500000));
            nhanVien.Add(new NhanVien("NV24", loaiNhanVien[1], toa[2], "Nguyễn Quang Ninh", "0935502239", 15500000));
            nhanVien.Add(new NhanVien("NV25", loaiNhanVien[1], toa[3], "Trần Minh Thạc", "0936457259", 10300000));
            nhanVien.Add(new NhanVien("NV26", loaiNhanVien[1], toa[3], "Ngyyen64 Minh Thạc", "0935599247", 14800000));
            nhanVien.Add(new NhanVien("NV27", loaiNhanVien[0], toa[3], "Trần Công Ân", "0912590004", 17200000));
            nhanVien.Add(new NhanVien("NV28", loaiNhanVien[0], toa[0], "Mạnh Gia Bình", "0958974792", 9500000));
            nhanVien.Add(new NhanVien("NV29", loaiNhanVien[0], toa[1], "Thịnh Bảo Lâm", "0915501907", 11000000));
            nhanVien.Add(new NhanVien("NV30", loaiNhanVien[0], toa[2], "Nguyễn Cao Tiến", "0958585889", 12500000));
        }
        public static void TaoDanhSachLoaiPhong()
        {
            loaiPhong.Add(new LoaiPhong("PML04", "Phòng máy lạnh 4 người", 4000000));
            loaiPhong.Add(new LoaiPhong("PML06", "Phòng máy lạnh 6 người", 5500000));
            loaiPhong.Add(new LoaiPhong("PML08", "Phòng máy lạnh 8 người", 7500000));
            loaiPhong.Add(new LoaiPhong("PQ04", "Phòng quạt 4 người", 2500000));
            loaiPhong.Add(new LoaiPhong("PQ06", "Phong quạt 6 người", 3500000));
            loaiPhong.Add(new LoaiPhong("PQ08", "Phòng quạt 8 người", 4500000));
        }
        public static void TaoDanhSachPhong()
        {
            phong.Add(new Phong("P01", toa[0], loaiPhong[1], true));
            phong.Add(new Phong("P02", toa[0], loaiPhong[1], true));
            phong.Add(new Phong("P03", toa[1], loaiPhong[3], true));
            phong.Add(new Phong("P04", toa[1], loaiPhong[3], true));
            phong.Add(new Phong("P05", toa[2], loaiPhong[2], true));
            phong.Add(new Phong("P06", toa[2], loaiPhong[2], true));
            phong.Add(new Phong("P07", toa[3], loaiPhong[1], true));
            phong.Add(new Phong("P08", toa[3], loaiPhong[3], false));
            phong.Add(new Phong("P09", toa[1], loaiPhong[0], false));
            phong.Add(new Phong("P10", toa[3], loaiPhong[0], false));
            phong.Add(new Phong("P11", toa[0], loaiPhong[4], false));
            phong.Add(new Phong("P12", toa[0], loaiPhong[5], true));
            phong.Add(new Phong("P13", toa[1], loaiPhong[4], true));
            phong.Add(new Phong("P14", toa[1], loaiPhong[5], false));
            phong.Add(new Phong("P15", toa[2], loaiPhong[4], true));
            phong.Add(new Phong("P16", toa[2], loaiPhong[5], true));
            phong.Add(new Phong("P17", toa[3], loaiPhong[1], true));
            phong.Add(new Phong("P18", toa[3], loaiPhong[1], true));
            phong.Add(new Phong("P19", toa[1], loaiPhong[2], true));
            phong.Add(new Phong("P20", toa[3], loaiPhong[2], false));
            phong.Add(new Phong("P21", toa[0], loaiPhong[3], true));
            phong.Add(new Phong("P22", toa[0], loaiPhong[3], false));
            phong.Add(new Phong("P23", toa[1], loaiPhong[4], true));
            phong.Add(new Phong("P24", toa[1], loaiPhong[4], true));
            phong.Add(new Phong("P25", toa[2], loaiPhong[5], true));
            phong.Add(new Phong("P26", toa[2], loaiPhong[5], true));
            phong.Add(new Phong("P27", toa[3], loaiPhong[0], false));
            phong.Add(new Phong("P28", toa[3], loaiPhong[0], true));
            phong.Add(new Phong("P29", toa[1], loaiPhong[0], false));
            phong.Add(new Phong("P30", toa[3], loaiPhong[0], false));
        }
        public static void TaoDachSachToa()
        {
            toa.Add(new Toa('A', 300, 45));
            toa.Add(new Toa('B', 330, 50));
            toa.Add(new Toa('C', 300, 45));
            toa.Add(new Toa('D', 330, 50));
        }
        public static void TaoDanhSachQuanLy()
        {
            quanLy.Add(new QuanLy("QL0A", "Nguyễn Bảo Định", toa[0], "0355511246"));
            quanLy.Add(new QuanLy("QL0B", "Vũ Đức Mạnh", toa[1], "0985568304"));
            quanLy.Add(new QuanLy("QL0C", "Dương Bách Quỳnh", toa[2], "0855568006"));
            quanLy.Add(new QuanLy("QL0D", "Nghiêm Phạm Thu Phương", toa[3], "0955560295"));
        }
        public static void TaoDanhSachSinhVien()
        {
            sinhVien.Add(new SinhVien("SV01", "Văn Minh Anh", true, "0335573464", phong[0]));
            sinhVien.Add(new SinhVien("SV02", "Kha Sỹ Phú", true, "0955546106", phong[1]));
            sinhVien.Add(new SinhVien("SV03", "Phan Phúc Lâm", true, "0875516075", phong[2]));
            sinhVien.Add(new SinhVien("SV04", "Trần Trung Thế", true, "0335555459", phong[3]));
            sinhVien.Add(new SinhVien("SV05", "Cao Đăng Ngọc Quý", true, "0995578740", phong[4]));
            sinhVien.Add(new SinhVien("SV06", "Phạm Vĩnh Long", true, "0335558622", phong[5]));
            sinhVien.Add(new SinhVien("SV07", "Tạ Bạch Cúc", false, "0935505935", phong[6]));
            sinhVien.Add(new SinhVien("SV08", "Mai Kiều Hoa", false, "0855533475", phong[6]));
            sinhVien.Add(new SinhVien("SV09", "Mai Phương Thúy", false, "0955515045", phong[6]));
            sinhVien.Add(new SinhVien("SV10", "Hoàng Phương Thảo", false, "0895501461", phong[6]));
            sinhVien.Add(new SinhVien("SV11", "Trần Quang Bửu", true, "09732588394", phong[8]));
            sinhVien.Add(new SinhVien("SV12", "Nguyễn Quang Dũng", true, "03312598591", phong[8]));
            sinhVien.Add(new SinhVien("SV13", "Nguyễn Thiện Giang", true, "09331529049", phong[8]));
            sinhVien.Add(new SinhVien("SV14", "Nguyễn Trọng Khánh", true, "09556752852", phong[8]));
            sinhVien.Add(new SinhVien("SV15", "Phan Bảo Long", true, "03758710360", phong[1]));
            sinhVien.Add(new SinhVien("SV16", "Cao Khắc Minh", true, "03512548013", phong[1]));
            sinhVien.Add(new SinhVien("SV17", "Đoàn Kiên Trung", true, "09655516844", phong[2]));
            sinhVien.Add(new SinhVien("SV18", "Huỳnh Huy Cường", true, "03578507626", phong[2]));
            sinhVien.Add(new SinhVien("SV19", "Danh Hoàng Giang", true, "098559527928", phong[2]));
            sinhVien.Add(new SinhVien("SV20", "Đỗ Mỹ Loan", false, "03515538943", phong[10]));
            sinhVien.Add(new SinhVien("SV21", "Nguyễn Phương Lan", false, "09959743180", phong[10]));
            sinhVien.Add(new SinhVien("SV22", "Trịnh Thúy Anh", false, "03565533549", phong[10]));
            sinhVien.Add(new SinhVien("SV23", "Lương Bạch Loan", false, "09351210183", phong[10]));
            sinhVien.Add(new SinhVien("SV24", "Nghiêm Diệu Hà", false, "03364557138", phong[11]));
            sinhVien.Add(new SinhVien("SV25", "Nguyễn Hải Châu", false, "0333129573", phong[11]));
            sinhVien.Add(new SinhVien("SV26", "Vũ Bạch Yến", false, "0335979171", phong[11]));
            sinhVien.Add(new SinhVien("SV27", "Nguyễn Bích Thủy", false, "09915542642", phong[11]));
            sinhVien.Add(new SinhVien("SV28", "Việt Mỹ Kiều", false, "09532563250", phong[12]));
            sinhVien.Add(new SinhVien("SV29", "Nguyễn Linh Sương Sương", false, "09857975293", phong[12]));
            sinhVien.Add(new SinhVien("SV30", "Vũ Bích Vân", false, "03368595027", phong[12]));
        }

        //1. Cho biết những phòng còn trống ở tòa A và C
        public static void Linq1()
        {

        }

        //2. Cho biết nhân viên "Tran Phuong Thanh" đang làm việc ở tòa nhà nào
        public static void Linq2()
        {
            var result = from nv in nhanVien
                         join t in toa on nv.toa.maToa equals t.maToa
                         where nv.tenNhanVien == "Tran Phuong Thanh"
                         select new { nv.tenNhanVien, nv.toa.maToa };
            foreach(var nv in result)
                Console.WriteLine("Nhan vien {0} dang lam viec o toa {1}", nv.tenNhanVien, nv.maToa);
        }

        //3. Cho biết các nhân viên mà Vu Duc Manh đang quản lý
        public static void Linq3()
        {
            var nhanVienLamViec = from ql in quanLy 
                           join t in toa on ql.toa.maToa equals t.maToa  
                           join nv in nhanVien on ql.toa.maToa equals nv.toa.maToa
                           where ql.tenQuanLy == "Vu Duc Manh"
                           select new {nv.tenNhanVien};
            Console.WriteLine("Danh sach nhan vien ma quan ly Vu Duc Manh dang quan ly:");
            foreach (var nv in nhanVienLamViec)
                Console.WriteLine("{0}", nv.tenNhanVien);
        }

        //4. Danh sách những nhân viên đang giữ chức vụ Bao ve
        public static void Linq4()
        {
            var result = from nv in nhanVien
                         join lnv in loaiNhanVien on nv.loaiNhanVien.maLoaiNV equals lnv.maLoaiNV
                         where lnv.chucVu == "Bao ve"
                         select new { nv.maNV, nv.tenNhanVien, lnv.chucVu ,lnv.congViec };
            Console.WriteLine("Danh sach nhung nhan vien giu chuc vu Bao ve la: ");
            foreach (var nv in result)
                Console.WriteLine("MaNV: {0}\nTen: {1}", nv.maNV, nv.tenNhanVien);
        }

        //5. Cho biết tiền dịch vụ của phòng ...
        public static void Linq5()
        {

        }
        //6. Cho biết số lượng phòng chưa được thuê của tòa C
        public static void Linq6()
        {
            var result = from p in phong
                         join t in toa on p.toa.maToa equals t.maToa
                         where t.maToa == 'D' && p.trangThai == false
                         select new { p.maPhong };
            Console.WriteLine("So luong phong chua duoc thue cua toa C la: {0}", result.Count());
        }

        //7. Cho biết những hợp đồng hết hạn trước ngày 21/04/2021
        public static void Linq7()
        {

        }

        //8. Cho biết số lượng phòng máy lạnh đang được thuê ở tòa A
        public static void Linq8()
        {
            var dsPhong = from p in phong
                         join t in toa on p.toa.maToa equals t.maToa
                         where p.loaiPhong.tenLoaiPhong.StartsWith("Phong may lanh") && t.maToa == 'A'
                         select p;
            var result = dsPhong.Count();
            Console.WriteLine("So luong phong may lanh duoc thue o toa A la: {0}", result);
        }

        //9. Liệt kê sinh viên đang ở phòng
        public static void Linq9()
        {
             var sinhVienP06 = from sv in sinhVien
                              join p in phong on sv.phong.maPhong equals p.maPhong
                              where p.maPhong == "P06"
                              select new { sv.tenSV };
        }
        //10. Cho biết các phòng chưa thanh toán tiền dịch vụ
        public static void Linq10()
        {

        }

        //11. Cho biết thời hạn hợp đồng của phòng
        public static void Linq11()
        {

        }

        //12. Cho biết sức chứa của những tòa được thuê từ 2 phòng trở lên
        public static void Linq12()
        {
            var phongDuocThueToaA = from p in phong
                                    join t in toa on p.toa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'A'
                                    select new { p.maPhong };
            var phongDuocThueToaB = from p in phong
                                    join t in toa on p.toa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'B'
                                    select new { p.maPhong };
            var phongDuocThueToaC = from p in phong
                                    join t in toa on p.toa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'C'
                                    select new { p.maPhong };
            var phongDuocThueToaD = from p in phong
                                    join t in toa on p.toa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'D'
                                    select new { p.maPhong };
            var toaDuocThueTren2 = from a in phongDuocThueToaA
                                   from b in phongDuocThueToaB
                                   from c in phongDuocThueToaC
                                   from d in phongDuocThueToaD
                                   select a;
        }

        //13. Cho biết tòa đã được thuê hết phòng """
        public static void Linq13()
        {

        }

        //14. Liệt kê các phòng đang được thuê theo thứ tự tăng dần giá phòng.
        public static void Linq14()
        {
            var result = from p in phong
                         where p.trangThai == true
                         orderby p.loaiPhong.giaPhong
                         select new { p.maPhong, p.loaiPhong.giaPhong };
            Console.WriteLine("Danh sach cac phong dang duoc thue theo thu tu tang dan cua gia phong: ");
            foreach (var p in result)
                Console.WriteLine("Phong: {0} _ Gia phong: {1} VND", p.maPhong, p.giaPhong);
        }

        //15. Cho biết các sinh viên đang ở loại phòng ...
        public static void Linq15()
        {

        }
        //16. Cho biết tòa có số lượng SV nhiều nhất
        public static void Linq16()
        {
            
        }

        //17. Cho biết phòng có tiền sử dụng dịch vụ cao nhất
        public static void Linq17()
        {

        }
        //18. Cho biết phòng có thời gian thuê ngắn nhất
        public static void Linq18()
        {

        }

        //19. Cho biết những nhân viên đang làm ... có lương cao hơn trung bình ở tòa ... *
        public static void Linq19()
        {

        }

        //20. Cho biết tiền sử dụng dịch vụ trung bình của tòa
        public static void Linq20()
        {

        }

        static void Main(string[] args)
        {
            
            TaoDanhSachLoaiPhong();
            TaoDanhSachLoaiNhanVien();
            TaoDachSachToa();
            TaoDanhSachQuanLy();
            TaoDanhSachNhanVien();
            TaoDanhSachPhong();
            TaoDanhSachSinhVien();
            TaoDanhSachHopDong();
            TaoDanhSachChiTiet_HD();
       
            Linq14();
            Console.ReadKey();
        }
    }
}

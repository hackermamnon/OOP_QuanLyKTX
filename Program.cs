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
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[0], phong[0], toa[0], new DateTime(2020, 1, 8), "08/01/2021"));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[1], phong[1], toa[0], new DateTime(2020, 1, 17), "17/01/2021"));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[2], phong[2], toa[1], new DateTime(2020, 2, 23), "23/02/2021"));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[3], phong[3], toa[1], new DateTime(2020, 2, 18), "18/02/2021"));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[4], phong[4], toa[2], new DateTime(2020, 3, 2), "02/03/2021"));
            chiTiet_HD.Add(new ChiTiet_HD(hopDongThuePhong[5], phong[5], toa[2], new DateTime(2020, 3, 7), new DateTime(2021, 1, 7));
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
            loaiNhanVien.Add(new LoaiNhanVien("LNV01", "Lao cong", "Quet san"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV02", "Phu bep", "Don dep nha bep"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV03", "Dau bep", "Nau an"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV04", "Bao ve", "Canh cong ra vao"));
            loaiNhanVien.Add(new LoaiNhanVien("LNV05", "Sua dien", "Sua dien"));
        }
        public static void TaoDanhSachNhanVien()
        {
            nhanVien.Add(new NhanVien("NV01", loaiNhanVien[0], toa[1], "Phan Quang Dat", "0321550699", 12000000));
            nhanVien.Add(new NhanVien("NV02", loaiNhanVien[0], toa[1], "Nguyen Hoang Hai", "0935538764", 10500000));
            nhanVien.Add(new NhanVien("NV03", loaiNhanVien[1], toa[2], "Pham Ninh Thuat", "0375512722", 12500000));
            nhanVien.Add(new NhanVien("NV04", loaiNhanVien[4], toa[2], "Van Viet Hong", "0933592539", 15500000));
            nhanVien.Add(new NhanVien("NV05", loaiNhanVien[2], toa[3], "Vu Hoang Lam", "0873562883", 11300000));
            nhanVien.Add(new NhanVien("NV06", loaiNhanVien[2], toa[3], "Tran Van Tai", "0376588314", 14800000));
            nhanVien.Add(new NhanVien("NV07", loaiNhanVien[3], toa[3], "Nguyen Bich Chau", "0935543050", 18200000));
            nhanVien.Add(new NhanVien("NV08", loaiNhanVien[3], toa[0], "Tran Hanh Vi", "0835559895", 11500000));
            nhanVien.Add(new NhanVien("NV09", loaiNhanVien[2], toa[1], "Tran Phuong Thanh", "0855586047", 12000000));
            nhanVien.Add(new NhanVien("NV10", loaiNhanVien[1], toa[2], "Ngo Ngoc Hue", "0935517709", 13500000));
        }
        public static void TaoDanhSachLoaiPhong()
        {
            loaiPhong.Add(new LoaiPhong("PML04", "Phong may lanh 4 nguoi", 4000000));
            loaiPhong.Add(new LoaiPhong("PML08", "Phong may lanh 8 nguoi", 7500000));
            loaiPhong.Add(new LoaiPhong("PQ04", "Phong quat 4 nguoi", 2500000));
            loaiPhong.Add(new LoaiPhong("PQ08", "Phong quat 8 nguoi", 4500000));
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
            phong.Add(new Phong("P08", toa[3], loaiPhong[3], true));
            phong.Add(new Phong("P09", toa[1], loaiPhong[0], true));
            phong.Add(new Phong("P10", toa[3], loaiPhong[0], false));
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
            quanLy.Add(new QuanLy("QL0A", "Nguyen Bao Dinh", toa[0], "0355511246"));
            quanLy.Add(new QuanLy("QL0B", "Vu Duc Manh", toa[1], "0985568304"));
            quanLy.Add(new QuanLy("QL0C", "Duong Bach Quynh", toa[2], "0855568006"));
            quanLy.Add(new QuanLy("QL0D", "Nghiem Pham Thu Phuong", toa[3], "0955560295"));
        }
        public static void TaoDanhSachSinhVien()
        {
            sinhVien.Add(new SinhVien("SV01", "Van Minh An", true, "0335573464", phong[0]));
            sinhVien.Add(new SinhVien("SV02", "Kha Sy Phu", true, "0955546106", phong[1]));
            sinhVien.Add(new SinhVien("SV03", "Phan Phuc Lam", true, "0875516075", phong[2]));
            sinhVien.Add(new SinhVien("SV04", "Tran Trung The", true, "0335555459", phong[3]));
            sinhVien.Add(new SinhVien("SV05", "Cao Dang Ngoc Quy", true, "0995578740", phong[4]));
            sinhVien.Add(new SinhVien("SV06", "Pham Vinh Long", true, "0335558622", phong[5]));
            sinhVien.Add(new SinhVien("SV07", "Ta Bach Cuc", false, "0935505935", phong[6]));
            sinhVien.Add(new SinhVien("SV08", "Mai Kieu Hoa", false, "0855533475", phong[6]));
            sinhVien.Add(new SinhVien("SV09", "Mai Phuong Thuy", false, "0955515045", phong[6]));
            sinhVien.Add(new SinhVien("SV10", "Hoang Huong Thao", false, "0895501461", phong[6]));
        }

        //1. Cho biết những phòng còn trống ở tòa A và C
        public static void Linq1()
        {

        }

        //Cho biết nhân viên "Tran Phuong Thanh" đang làm việc ở tòa nhà nào
        public static void Linq2()
        {
            var result = from nv in nhanVien
                         join t in toa on nv.maToa.maToa equals t.maToa
                         where nv.tenNhanVien == "Tran Phuong Thanh"
                         select new { nv.tenNhanVien, nv.maToa };
            foreach(var nv in result)
                Console.WriteLine("Nhan vien {0} dang lam viec o toa {1}", nv.tenNhanVien, nv.maToa.maToa);
        }

        //3. Cho biết các nhân viên mà Vu Duc Manh đang quản lý
        public static void Linq3()
        {
            var nhanVienLamViec = from ql in quanLy 
                           join t in toa on ql.maToa.maToa equals t.maToa  
                           join nv in nhanVien on ql.maToa.maToa equals nv.maToa.maToa
                           where ql.tenQuanLy == "Vu Duc Manh"
                           select new {nv.tenNhanVien};
            Console.WriteLine("Danh sach nhan vien ma quan ly Vu Duc Manh dang quan ly:");
            foreach (var nv in nhanVienLamViec)
                Console.WriteLine("{0}", nv.tenNhanVien);
        }

        //Danh sách những nhân viên đang giữ chức vụ Bao ve
        public static void Linq4()
        {
            var result = from nv in nhanVien
                         join lnv in loaiNhanVien on nv.maLoaiNV.maLoaiNV equals lnv.maLoaiNV
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
        //Cho biết số lượng phòng chưa được thuê của tòa C
        public static void Linq6()
        {
            var result = from p in phong
                         join t in toa on p.maToa.maToa equals t.maToa
                         where t.maToa == 'D' && p.trangThai == false
                         select new { p.maPhong };
            Console.WriteLine("So luong phong chua duoc thue cua toa C la: {0}", result.Count());
        }

        //7. Cho biết những hợp đồng hết hạn trước ngày 21/04/2021
        public static void Linq7()
        {

        }

        //Cho biết số lượng phòng máy lạnh đang được thuê ở tòa A
        public static void Linq8()
        {
            var dsPhong = from p in phong
                         join t in toa on p.maToa.maToa equals t.maToa
                         where p.loaiPhong.tenLoaiPhong.StartsWith("Phong may lanh") && t.maToa == 'A'
                         select p;
            var result = dsPhong.Count();
            Console.WriteLine("So luong phong may lanh duoc thue o toa A la: {0}", result);
        }

        //9. Liệt kê sinh viên đang ở phòng
        public static void Linq9()
        {
             var sinhVienP06 = from sv in sinhVien
                              join p in phong on sv.maPhong.maPhong equals p.maPhong
                              where p.maPhong == "P06"
                              select new { sv.tenSV };
        }
        //Cho biết các phòng chưa thanh toán tiền dịch vụ
        public static void Linq10()
        {

        }

        //11) Cho biết thời hạn hợp đồng của phòng
        public static void Linq11()
        {

        }

        //Cho biết sức chứa của những tòa được thuê từ 2 phòng trở lên
        public static void Linq12()
        {
            var phongDuocThueToaA = from p in phong
                                    join t in toa on p.maToa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'A'
                                    select new { p.maPhong };
            var phongDuocThueToaB = from p in phong
                                    join t in toa on p.maToa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'B'
                                    select new { p.maPhong };
            var phongDuocThueToaC = from p in phong
                                    join t in toa on p.maToa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'C'
                                    select new { p.maPhong };
            var phongDuocThueToaD = from p in phong
                                    join t in toa on p.maToa.maToa equals t.maToa
                                    where p.trangThai == true && t.maToa == 'D'
                                    select new { p.maPhong };
            var toaDuocThueTren2 = from a in phongDuocThueToaA
                                   from b in phongDuocThueToaB
                                   from c in phongDuocThueToaC
                                   from d in phongDuocThueToaD
                                   select a;
        }

        //13. Cho biết tòa đã được thuê hết phòng
        public static void Linq13()
        {

        }

        //Liệt kê các phòng đang được thuê theo thứ tự tăng dần giá phòng.
        public static void Linq14()
        {
            var result = from p in phong
                         where p.trangThai == true
                         orderby p.loaiPhong.giaPhong
                         select new { p.maPhong, p.loaiPhong.giaPhong };
            Console.WriteLine("Danh sach cac phong dang duoc thue theo thu tu tang dan cua gia phong: ");
            foreach (var p in result)
                Console.WriteLine("Phong: {0} - Gia phong: {1} VND", p.maPhong, p.giaPhong);
        }

        //15) Cho biết các sinh viên đang ở loại phòng ...
        public static void Linq15()
        {

        }
        //Cho biết tòa có số lượng SV nhiều nhất
        public static void Linq16()
        {
            
        }

        //17) Cho biết phòng có tiền sử dụng dịch vụ cao nhất
        public static void Linq17()
        {

        }
        //Cho biết phòng có thời gian thuê ngắn nhất
        public static void Linq18()
        {

        }

        //19. Cho biết những nhân viên đang làm ... có lương cao hơn trung bình ở tòa ... *
        public static void Linq19()
        {

        }

        //Cho biết tiền sử dụng dịch vụ trung bình của tòa
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
       
                              
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_SanPham
    {
        //protected SqlConnection con = new SqlConnection("Data Source =DESKTOP-11BA3SD\\SQLEXPRESS;Initial Catalog= QL_BanDienThoai; Persist Security Info= true;User ID=sa;Password=123");
        QLDTDataContext qldt = new QLDTDataContext();
        public List<SANPHAM> loadTatCaDuLieu()
        {
            //lấy sản phẩm có lượng tồn kho lớn hơn 0
            //string cauLenh = "SELECT MaSP,TenSP,GiaBan,GiaCu,MoTa,HinhAnh,MaLoai FROM SANPHAM "
            //    + "WHERE MaSP IN (SELECT MaSP FROM KHO GROUP BY MaSP HAVING SUM(SoLuongTonKho)>0)";
            //return loadDuLieu(cauLenh);

            var lstSP = qldt.SANPHAMs.ToList();
            return lstSP;
        }

        public List<SANPHAM> timSanPhamTheoTen(string tenSP)
        {
            //string cauLenh = "SELECT MaSP,TenSP,GiaBan,GiaCu,MoTa,HinhAnh,MaLoai FROM SANPHAM "
            //    + "WHERE TenSP LIKE '%' + N'" + tenSP + "' + '%' AND MaSP IN (SELECT MaSP FROM KHO GROUP BY MaSP HAVING SUM(SoLuongTonKho)>0)";
            //return loadDuLieu(cauLenh);

            var lstSP = qldt.SANPHAMs.Where(s => s.TenSP == tenSP).ToList();
            return lstSP;
        }

        //load dữ liệu sản phẩm
        //public List<SANPHAM> loadDuLieu(string cauLenh)
        //{
        //    List<SANPHAM> listSP = new List<SANPHAM>();
        //    try
        //    {
        //        if (con.State == ConnectionState.Closed)
        //            con.Open();
        //        SqlCommand cmd = new SqlCommand(cauLenh, con);
        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            SANPHAM SP = new SANPHAM();
        //            SP.MaSP = rd["MaSP"].ToString();
        //            SP.TenSP = rd["TenSP"].ToString();
        //            SP.GiaBan = int.Parse(rd["GiaBan"].ToString());
        //            SP.GiaCu = int.Parse(rd["GiaCu"].ToString());
        //            SP.MoTa = rd["MoTa"].ToString();
        //            SP.HinhAnh = rd["HinhAnh"].ToString();
        //            SP.MaLoai = rd["MaLoai"].ToString();
        //            listSP.Add(SP);
        //        }
        //        rd.Close();
        //        if (con.State == ConnectionState.Open)
        //            con.Close();

        //        return listSP;
        //    }
        //    catch
        //    {
        //        return null; //Lỗi truy vấn
        //    }
        //}
//        MaSP varchar(50) NOT NULL,
//TenSP nvarchar(100) NULL,
//	GiaBan int NULL,
//    GiaCu int NULL,
//    MoTa nvarchar(max) NULL,
//	HinhAnh varchar(100) NULL,
//	MaLoai varchar(20) NULL,
        public bool themSP(string MaSP, string tenSP, int giaBan, int giaCu,string moTa,string img, string maLoai)
        {
            SANPHAM sp = new SANPHAM();

            sp.MaSP = MaSP;
            sp.TenSP = tenSP;
            sp.GiaBan = giaBan;
            sp.GiaCu = giaCu;
            sp.MoTa = moTa;
            sp.HinhAnh = img;
            sp.MaLoai = maLoai;

            qldt.SANPHAMs.InsertOnSubmit(sp);
            qldt.SubmitChanges();
            return true;
        }
        public bool suaSP(string MaSP, string tenSP, int giaBan, int giaCu, string moTa, string img, string maLoai)
        {
            SANPHAM sp = qldt.SANPHAMs.Where(s => s.MaSP==MaSP).FirstOrDefault();
            sp.TenSP = tenSP;
            sp.GiaBan = giaBan;
            sp.GiaCu = giaCu;
            sp.MoTa = moTa;
            sp.HinhAnh = img;
            sp.MaLoai = maLoai;

            qldt.SubmitChanges();
            return true;
        }

        public bool xoaSP(string maSP)
        {
            SANPHAM sp = qldt.SANPHAMs.Where(s => s.MaSP == maSP).FirstOrDefault();


            qldt.SANPHAMs.DeleteOnSubmit(sp);
            qldt.SubmitChanges();
            return true;
        }
        public SANPHAM loadtheoMa(string masp)
        {
            SANPHAM sp = qldt.SANPHAMs.Where(s => s.MaSP == masp).FirstOrDefault();
            return sp;
        }
        public bool KTKCSanPham(string maSP)
        {
            var lst = qldt.SANPHAMs.ToList();
            foreach (var a in lst)
            {
                if (a.MaSP.Equals(maSP))
                    return false;
            }
            return true;
        }
        public bool KTKNLoaiSP(string maloai)
        {
            var lst = qldt.SANPHAMs.ToList();
            foreach (var a in lst)
            {
                if (a.MaLoai.Equals(maloai))
                    return false;
            }
            return true;
        }
    }
}

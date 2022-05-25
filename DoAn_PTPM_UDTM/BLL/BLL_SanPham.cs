using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_SanPham
    {
        DAL_SanPham dalSP = new DAL_SanPham();
        public List<SANPHAM> getLoadTatCa()
        {
            return dalSP.loadTatCaDuLieu();
        }
        public List<SANPHAM> getListTimTheoTen(string maSP)
        {
            return dalSP.timSanPhamTheoTen(maSP);
        }

        public SANPHAM getLoadTheoMaSP(string maSP)
        {
            return dalSP.loadtheoMa(maSP);
        }
        public bool getThemSP(string MaSP, string tenSP, int giaBan, int giaCu, string moTa, string img, string maLoai)
        {
            return dalSP.themSP(MaSP, tenSP, giaBan, giaCu, moTa, img, maLoai);
        }
        public bool getSuaSP(string MaSP, string tenSP, int giaBan, int giaCu, string moTa, string img, string maLoai)
        {
            return dalSP.suaSP(MaSP, tenSP, giaBan, giaCu, moTa, img, maLoai);
        }
        public bool getXoaSP(string MaSP)
        {
            return dalSP.xoaSP(MaSP);
        }
        public bool getKTKCSanPham(string masp)
        {
            return dalSP.KTKCSanPham(masp);
        }
        public bool getKTKNLoaiSP(string maloai)
        {
            return dalSP.KTKNLoaiSP(maloai);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_KhachHang
    {
        QLDTDataContext qldt = new QLDTDataContext();

        DAL_KhachHang dalKH = new DAL_KhachHang();
        public List<KHACHHANG> getloadKhachHang()
        {
            return dalKH.loadKhachHang();
        }

        public bool getThemKH(string MaKH, string tenKH, string sdt, string dc)
        {
            return dalKH.themKH(MaKH, tenKH, sdt, dc);
        }

        public bool getSuaKH(string MaKH, string tenKH, string sdt, string dc)
        {
            return dalKH.suaKH(MaKH, tenKH, sdt, dc);
        }
        public bool getXoaKH(string maKH)
        {
            return dalKH.xoaKH(maKH);
        }

        public bool getBatTTGiaoDich(string maKH)
        {
            return dalKH.batTrangThaiGiaoDich(maKH);
        }

        public bool getTatTTGiaoDich(string maKH)
        {
            return dalKH.tatTrangThaiGiaoDich(maKH);
        }

        public string getTimMaKHBatGiaoDich()
        {
            return dalKH.timID();
        }

        public int getSoLuongKHDangGiaoDich()
        {
            return dalKH.ktTrangThai();
        }

        public List<KHACHHANG> getTimKhachHangSDT(string sdt)
        {
            return dalKH.timkhachHangTheoSDT(sdt);
        }
        public bool getKTKC(string maKH)
        {
            return dalKH.KTKCKhachHang(maKH);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_HoaDon
    {
        QLDTDataContext qldt = new QLDTDataContext();
        DAL_HoaDon dalHD = new DAL_HoaDon();
        //Load Hóa đơn theo mã khách hàng và trạng thái

        public List<HOADON> getLoadHoaDon()
        {
            return dalHD.loadHD();
        }
        public List<HOADON> getLoadTheoMaKHVaTT(string MaKH,int tt)
        {
            return dalHD.loadTheoMaKHVaTT(MaKH,tt);
        }
        public List<HOADON> getLoadTheoTKVaTT(string tk,int tt)
        {
            return dalHD.loadTheoTKVaTT(tk, tt);
        }
        public bool getThemHD(string maKH, string maSP, string tk, int slBan, int gb, DateTime nb, int tt)
        {
            return dalHD.themHD(maKH, maSP, tk, slBan, gb, nb, tt);
        }
        public bool getSuaHD(string maKH, string maSP, string tk, int slBan, int gb, DateTime nb)
        {
            return dalHD.suaHD(maKH, maSP, tk, slBan, gb, nb);
        }
        public bool getXoaHoaDon(string maKH,DateTime nb)
        {
            return dalHD.xoaHoaDon(maKH, nb);
        }
        public bool getSuaSoLuongMua(string maKH, DateTime nb, int soluong)
        {
            return dalHD.suaSoLuongMua(maKH, nb, soluong);
        }
        public string getTinhTongSanPhamDaBan(string tenDN)
        {
            return dalHD.tinhTongCacSPDaBan(tenDN);
        }
        public bool getCapNhatTT(string maKH)
        {
            return dalHD.capNhatTrangThaiBan(maKH);
        }
        public bool getKTKNKhachHang(string maKH)
        {
            return dalHD.KTKNKhachHang(maKH);
        }
        public bool getKTKNSanPham(string maSP)
        {
            return dalHD.KTKNSanPham(maSP);
        }
        public bool getKTKNTaiKhoan(string tk)
        {
            return dalHD.KTKNTaiKhoan(tk);
        }
        public string getTongALL()
        {
            return dalHD.tinhTongALL();
        }
    }
}

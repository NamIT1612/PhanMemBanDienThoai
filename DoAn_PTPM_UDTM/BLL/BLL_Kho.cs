using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Kho
    {
        DAL_Kho dalKho = new DAL_Kho();
        public List<KHO> getLoadKho()
        {
            return dalKho.loadKho();
        }
        public List<KHO> getLoadKhoTheoMaSP(string maSP)
        {
            return dalKho.loadKhoTheoMa(maSP);
        }
        public string getLoadSoLuongKhoTheoMaSP(string maSP)
        {
            return dalKho.loadSoLuongKhoTheoMa(maSP);
        }
        //public bool capNhatSoLuongGioHang(string maSP, int soLuongMua)
        //{
        //    KHO k = qldt.KHOs.Where(s => s.MaSP == maSP).FirstOrDefault();
        //    k.SoLuongTonKho = k.SoLuongTonKho - soLuongMua;
        //    return true;
        //}
        public bool getCapNhatSoLuongGioHang(string maSP,int soLuongMua)
        {
            return dalKho.capNhatSoLuongGioHang(maSP, soLuongMua);
        }

        public bool getThemKho(string masp,int soLuong)
        {
            return dalKho.themKho(masp, soLuong);
        }

        public bool getSuaKho(string masp ,int sl)
        {
            return dalKho.suaKho(masp, sl);
        }
       public bool getXoaKho(string masp)
        {
            return dalKho.xoaKho(masp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Kho
    {
        QLDTDataContext qldt = new QLDTDataContext();

        public int SoLuongTonKho { get; set; }
        public List<KHO> loadKho()
        {
            return qldt.KHOs.ToList();
        }
        public List<KHO> loadKhoTheoMa(string maSP)
        {
            var lstKho = qldt.KHOs.Where(s => s.MaSP == maSP && s.SoLuongTonKho > 0).ToList();
            return lstKho;
        }
        public string loadSoLuongKhoTheoMa(string maSP)
        {
            string so = "";
            var lstKho = qldt.KHOs.Where(s => s.MaSP == maSP && s.SoLuongTonKho > 0).ToList();
            foreach (var t in lstKho)
            {
                so = t.SoLuongTonKho.ToString();
            }
            return so;
        }
        public bool capNhatSoLuongGioHang(string maSP, int soLuongMua)
        {
            KHO k = qldt.KHOs.Where(s => s.MaSP == maSP).FirstOrDefault();
            k.SoLuongTonKho = k.SoLuongTonKho - soLuongMua;
            qldt.SubmitChanges();
            return true;
        }
        public bool themKho(string maSP,int soLuong)
        {
            KHO k = new KHO();

            k.MaSP = maSP;
            k.SoLuongTonKho = soLuong;

            qldt.KHOs.InsertOnSubmit(k);
            qldt.SubmitChanges();
            return true;
        }

        public bool suaKho(string maSP,int soLuong)
        {
            KHO k = qldt.KHOs.Where(s => s.MaSP == maSP).FirstOrDefault();
            k.SoLuongTonKho = soLuong;
            qldt.SubmitChanges();
            return true;
        }
        public bool xoaKho(string maSP)
        {
            KHO k = qldt.KHOs.Where(s => s.MaSP == maSP).FirstOrDefault();
            qldt.KHOs.DeleteOnSubmit(k);
            qldt.SubmitChanges();
            return true;
        }
    }
}

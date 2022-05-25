using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_HienThiSanPham
    {
        QLDTDataContext qldt = new QLDTDataContext();
        public void load2bang(DataGridView a)
        {
            var lst=qldt.KHACHHANGs.ToList();

            a.DataSource = lst;
            
        }
    }
}

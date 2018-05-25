using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class CanBoGiaoVienBUL
    {
        CanBoGiaoVienDAL myCB = new CanBoGiaoVienDAL();
        public List<CanBoGiaoVienDTO> LayDsCanBo()
        {
            return myCB.LayBangCanBoGiaoVien();
        }
    }
}

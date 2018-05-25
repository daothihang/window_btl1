using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class CanBoGiaoVienDAL
    {
        
        public List<CanBoGiaoVienDTO> LayBangCanBoGiaoVien()
        {
            List<CanBoGiaoVienDTO> dscb = new List<CanBoGiaoVienDTO>();

            KetNoiCoSoDuLieu.MoKetNoi();
            String sql = "SELECT*FROM Lop";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CanBoGiaoVienDTO cb = new CanBoGiaoVienDTO(dr["MaCanBoGiaoVien"].ToString(), dr["HoTen"].ToString(),
                    dr["DiaChi"].ToString(),dr["SoDienThoai"].ToString(), dr["TaiKhoan"].ToString(),dr["MatKhau"].ToString(),dr["LoaiTaiKhoan"].ToString());

                dscb.Add(cb);
            }


            KetNoiCoSoDuLieu.DongKetNoi();
            return dscb;
        }
    }
}

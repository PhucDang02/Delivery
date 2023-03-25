using Delivery.Common;
using Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Delivery.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        string connString = @"Data Source=.;Initial Catalog=""Giao Hàng"";Integrated Security=True";
        SqlConnection conn = null;
        public ActionResult Login(int id = -1)
        {
            if(id==0)
            {
                ViewBag.message = "Tài khoản hoặc mật khẩu không đúng";
            }            
            return View();
        }

        public ActionResult LoginValidation()
        {
            conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter sqlDataAdapter;
            //Kiểm tra tồn tại tài khoản
            string user = Request.Form["username"];
            string pass = Request.Form["password"];

            cmd = new SqlCommand("KiemTraDangNhap", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@user", SqlDbType.Text).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.Text).Value = pass;
            sqlDataAdapter = new SqlDataAdapter(cmd);

            var returnPara = cmd.Parameters.Add("@Return", SqlDbType.Int);
            returnPara.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            //result 0="Sai tài khoản hoặc mật khẩu", 1="Đúng"
            int result = (int)returnPara.Value;

            if (result == 0)
            {
                return RedirectToAction("Login",new { id = 0 });
            }
            else
            {
            cmd = new SqlCommand("KiemTraChucNang",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maChucVu",SqlDbType.Int).Value=1;
            sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            List<ChucNang> chucNangs = new List<ChucNang>();
            foreach (DataRow item in dt.Rows)
            {
                ChucNang chucNang = new ChucNang();
                chucNang.MaChucNang= (int)item["Mã chức năng"];
                chucNang.TenChucNang= item["Tên chức năng"].ToString();
                chucNang.BieuTuong = item["Biểu tượng"].ToString();
                chucNangs.Add(chucNang);
            }

            Session.Add(CommonConstants.PHIEN_DANG_NHAP, 1);
            Session.Add(CommonConstants.CHUC_NANG,chucNangs);
            conn.Close();
            }
            
            return null;
        }
        
    }
}
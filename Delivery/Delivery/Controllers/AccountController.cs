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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            var session = (List<ChucNang>) Session[CommonConstants.CHUC_NANG];
            if (session != null) {
                Response.Redirect("~/Home");
            }
            conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("KiemTraChucNang",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maChucVu",SqlDbType.Int).Value=1;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
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

            Session.Add(CommonConstants.CHUC_NANG,chucNangs);
            conn.Close();
            return View("Index");
        }
        
    }
}
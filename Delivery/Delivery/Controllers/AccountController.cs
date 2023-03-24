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

        public void Login()
        {
            conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("KiemTraChucNang",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maChucVu",SqlDbType.Int).Value=1;
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            System.Web.HttpContext.Current.Session["ChucNang"] = "Asdfasdf";
            Response.Redirect("~/Home");
            conn.Close();
            return;
        }
        
    }
}
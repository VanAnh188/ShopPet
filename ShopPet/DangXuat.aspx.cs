using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class DangXuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["dangnhap"] = 0;
            Session.Remove("email");
            //Session.Remove("hoten");
            Session.Remove("password");
            Session.Abandon();
            Response.Redirect("TrangChu.aspx");
        }
    }
}
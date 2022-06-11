using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string user = Request.Form["email"];
                string pass = Request.Form["password"];
                List<CUser> list = (List<CUser>)Application["user"];

                foreach (CUser a in list)
                {
                    if (user == a.email && pass == a.password)
                    {
                        Session["dangnhap"] = 1;
                        Session["email"] = a.email;
                        Session["password"] = a.password;
                        Response.Redirect("TrangChu.aspx");
                    }
                }
            }
        }
    }
}
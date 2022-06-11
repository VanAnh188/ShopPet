using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<CUser> arrUser;
            arrUser = (List<CUser>)Application["user"];

            if (IsPostBack)
            {
                if (Request.Form["dk"] == "Đăng ký")
                {
                    CUser u = new CUser();
                    u.name = Request.Form["fullnameDK"];
                    u.email = Request.Form["emailDK"];
                    u.password = Request.Form["passwordDk"];
                    arrUser.Add(u);
                    Application["user"] = arrUser;

                    Session["dangnhap"] = 1;
                    Session["email"] = Request.Form["emailDK"];
                    Session["passwword"] = Request.Form["passwordDk"];

                    Response.Redirect("DangNhap.aspx");
                }
            }
        }
    }
}
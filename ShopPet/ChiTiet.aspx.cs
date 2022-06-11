using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            ArrayList arrProductt = (ArrayList)Session["giohang"];
            foreach (CProduct sp in arrProductt)
            {
                i++;
            }
            slgsp.InnerHtml = "<p style='font-size:10px; font-weight:600'>" + i + "</p>";
            if (Session["dangnhap"].ToString() == "1")
            {
                //changpass.Visible = true;
                dangky.InnerHtml =
                    "Xin chào, " + Session["email"].ToString()
                    + "<span> | </span> <a href=\"DangXuat.aspx\" style=\"color: #ffffff; font-size: 18px;\">Đăng xuất  </a>";
            }
            else
            {
                //changpass.Visible = false;
                dangky.InnerHtml = "<a href=\"DangNhap.aspx\" style=\"color: #ffffff; font-size: 18px;\">Đăng nhập</a><span> | </span>" +
                           "<a href=\"DangKy.aspx\" style=\"color: #ffffff; font-size: 18px;\">Đăng ký</a> ";
            }
            string request = Request.QueryString["pi"];
            ArrayList arrProduct = Application[Global.san_pham] as ArrayList;

            foreach ( CProduct sp in arrProduct)
            {
                if (sp.id == request)
                {
                    productimage.InnerHtml = "<img src='" + sp.image + "'id ='img-feature' alt='" + sp.id + "'>";
                    productname.InnerText = sp.name;
                    productprice.InnerText = sp.price;
                    mota.InnerHtml = sp.detail;


                }

            }
        }
      
        protected void btnthem_Click(object sender, EventArgs e)
        {
            string request = Request.QueryString["pi"];
            ArrayList arrProduct = (ArrayList)Session["giohang"];
            ArrayList dsach = Application[Global.san_pham] as ArrayList;
            if (arrProduct==null)
            {
                arrProduct = new ArrayList();
            }
            foreach (CProduct p in dsach)
            {
                if (p.id == request)
                {
                    arrProduct.Add(p);
                    break;

                }
            }
            Session["giohang"] = arrProduct;
            Response.Redirect(Request.Url.ToString(), true);
        }

    }
}

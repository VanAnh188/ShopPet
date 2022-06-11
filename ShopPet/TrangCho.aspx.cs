using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class TrangCho : System.Web.UI.Page
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
            ArrayList arr = Application[Global.san_pham] as ArrayList;
            string s = "";



            string loai = Request.QueryString["type"];
            // noibat = 1,2,3
            /* string html = "";*/


           
                foreach (CProduct sp in arr)
                {
                    if (String.Equals(sp.type, loai))
                    {
                        s += "<div class='grid'>";
                        s += "<a href='Chitiet.aspx?pi=" + sp.id + "'style='text-decoration: none;'>";
                        s += "<div class='product-img'>";
                        s += "<img src='" + sp.image + "' alt=''>";
                        s += "</div>";
                        s += "<div class='product-name'>" + sp.name + "</div>";
                        s += "</a>";
                        s += "<div class='product-price'>" + sp.price + "</div>";
                        s += "</div>";


                    }
                    loaisp.InnerHtml = s;
                }
            }



        }

    }
//}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class TrangMeo : System.Web.UI.Page
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
                    + "<span> | </span> <a href=\"DangXuat.aspx\" style=\"color: #ffffff; font-size: 18px;\">Đăng xuất  </a> ";
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


            //if (IsPostBack)
            //{
            //    if (Request.Form["filter01"] == "<100.000đ")
            //    {
            //        var a = "";
            //        foreach (CProduct sp in arr)
            //        {
            //            if (String.Equals(sp.type, loai) && (decimal.Parse(sp.price) < 100000))
            //            {
            //                a += "<div class='grid'>";
            //                a += "<a href='Chitiet.aspx?pi=" + sp.id + "'style='text-decoration: none;'>";
            //                a += "<div class='product-img'>";
            //                a += "<img src='" + sp.image + "' alt=''>";
            //                a += "</div>";
            //                a += "<div class='product-name'>" + sp.name + "</div>";
            //                a += "</a>";
            //                a += "<div class='product-price'>" + sp.price + "</div>";
            //                a += "</div>";


            //            }
            //            loaisp.InnerHtml = a;
            //        }
            //    }

            //    if (Request.Form["filter02"] == "100.000đ - 200.000đ")
            //    {
            //        var b = "";
            //        foreach (CProduct sp in arr)
            //        {
            //            if (String.Equals(sp.type, loai) && (decimal.Parse(sp.price) > 100000) && (decimal.Parse(sp.price) < 200000))
            //            {
            //                b += "<div class='grid'>";
            //                b += "<a href='Chitiet.aspx?pi=" + sp.id + "'style='text-decoration: none;'>";
            //                b += "<div class='product-img'>";
            //                b += "<img src='" + sp.image + "' alt=''>";
            //                b += "</div>";
            //                b += "<div class='product-name'>" + sp.name + "</div>";
            //                b += "</a>";
            //                b += "<div class='product-price'>" + sp.price + "</div>";
            //                b += "</div>";


            //            }
            //            loaisp.InnerHtml = b;
            //        }

            //    }

            //    if (Request.Form["filter03"] == ">200.000đ")
            //    {
            //        var c = "";
            //        foreach (CProduct sp in arr)
            //        {
            //            if (String.Equals(sp.type, loai) && (decimal.Parse(sp.price) > 200000))
            //            {
            //                c += "<div class='grid'>";
            //                c += "<a href='Chitiet.aspx?pi=" + sp.id + "'style='text-decoration: none;'>";
            //                c += "<div class='product-img'>";
            //                c += "<img src='" + sp.image + "' alt=''>";
            //                c += "</div>";
            //                c += "<div class='product-name'>" + sp.name + "</div>";
            //                c += "</a>";
            //                c += "<div class='product-price'>" + sp.price + "</div>";
            //                c += "</div>";


            //            }
            //            loaisp.InnerHtml = c;
            //        }
            //    }
            //    if (Request.Form["filter04"] == "Tất cả")
            //    {
            //        var d = "";
            //        foreach (CProduct sp in arr)
            //        {
            //            if (String.Equals(sp.type, loai))
            //            {
            //                d += "<div class='grid'>";
            //                d += "<a href='Chitiet.aspx?pi=" + sp.id + "'style='text-decoration: none;'>";
            //                d += "<div class='product-img'>";
            //                d += "<img src='" + sp.image + "' alt=''>";
            //                d += "</div>";
            //                d += "<div class='product-name'>" + sp.name + "</div>";
            //                d += "</a>";
            //                d += "<div class='product-price'>" + sp.price + "</div>";
            //                d += "</div>";


            //            }
            //            loaisp.InnerHtml = d;
            //        }
            //    }
            //}
            //else
            //{
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
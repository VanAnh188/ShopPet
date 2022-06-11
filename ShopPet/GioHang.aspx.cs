using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class GioHang : System.Web.UI.Page
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
            ArrayList arrProduct = (ArrayList)Session["giohang"];
            string chuoi = "";
            //Mở thẻ table
            chuoi += "<table>";
            //mở thẻ thead
            chuoi += "<thead>";
            //mở tr
            chuoi += "<tr class='cart-list-item'>";
            //mở các thẻ th
            chuoi += "<th>Sản phẩm</th>";
            chuoi += "<th>Tên sản phẩm</th>";
            
            chuoi += "<th>SL</th>";
            chuoi += "<th>Thành tiền</th>";
            chuoi += "<th>Xóa</th>";
            //dóng tr
            chuoi += "</tr>";
            //đóng thead
            chuoi += "</thead>";
            //int i = 1;
            decimal tongtien = 0;
            foreach(CProduct sp in arrProduct)
            {
                tongtien += decimal.Parse(sp.price);
                //mở tbody
                chuoi += "<tbody id='mcart'>";
                //mở tr
                chuoi += "<tr class='cart-list-item'>";
                //mở td
                chuoi += "<td class='asp' id='asp' runat='server'> ";
                chuoi += "<img src = '" + sp.image + "'id='img-feature' alt='" + sp.id + " 'width='40%' />";
                chuoi += "</td>";
                chuoi += "<td class='tsp' id ='tsp' runat='server' style='font-size:1.4rem; ' >" + sp.name + "</td>";
         
                chuoi += "<td  class='sl' id='sl' runat='server' style='font-size:1.4rem;'>";
                chuoi += "<input type='number' value='1' min ='1' style='width:70px;'/> ";
                chuoi += "</td>";
                chuoi += "<td class='tt' id ='tt' runat='server' style='font-size:1.4rem; ' >" + sp.price + "</td>";
                chuoi += "<td>";
                chuoi += "<a href='Xulyxoa.aspx?idxoa=" + sp.id + "'>Xóa</a>";
                chuoi += "</td>";
                chuoi += "</tr>";
                chuoi += "</tbody>";
            }
            chuoi += "<td class='thanhtoan'>";
            chuoi += "<div class='tongtien'>";
            chuoi += "<p>Tổng: </p>";
            chuoi += "<span>"+tongtien+" VNĐ</span>";
            chuoi += "</div>";
            chuoi += "</td>";

            chuoi += "</table>";
            bang.InnerHtml = chuoi;
            
        }
    }
}
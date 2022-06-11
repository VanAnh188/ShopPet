using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class TrangChu : System.Web.UI.Page
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
                /*changpass.Visible = true;*/
                dangky.InnerHtml =
                    "Xin chào, " + Session["email"].ToString()
                    + "<span> | </span> <a href=\"DangXuat.aspx\" style=\"color: #ffffff; font-size: 18px;\">Đăng xuất  </a>"; ;
            }
            else
            {
                //changpass.Visible = false;
                dangky.InnerHtml = "<a href=\"DangNhap.aspx\" style=\"color: #ffffff; font-size: 18px;\">Đăng nhập</a><span> | </span>" +
                           "<a href=\"DangKy.aspx\" style=\"color: #ffffff; font-size: 18px;\">Đăng ký</a> ";
            }
           

            
        }
        public string HienProducts(int basedIndex, int lastIndex = -1)
        {
            ArrayList arrProduct
                = Application[Global.san_pham] as ArrayList;
            StringBuilder sb = new StringBuilder();
            if (lastIndex < 0)
                lastIndex = arrProduct.Count;
            for (int i = basedIndex; i < lastIndex; i++)
            {
                CProduct item = arrProduct[i] as CProduct;
                sb.Append("<div class='grid'>");
                sb.AppendFormat("<a href='/ChiTiet.aspx?pi={2}' title='Xem {1}'><img src='{0}' alt='{1}' title='{1}' class='product-img'/>"
                    , item.image
                    , item.name
                    , item.id
                    );
                sb.AppendFormat("<div class='product-name'><a href='/ChiTiet.aspx?pi={1}' title='Xem {0}'>{0}</a></div>"
                    , item.name
                    , item.id
                    );
                sb.Append("</a>");
                sb.AppendFormat("<div class='product-price'>{0}</div>"
                    , item.price);
                sb.Append("</div>");
            }
            return sb.ToString();
        }
    }
}
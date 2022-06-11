using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopPet
{
    public partial class Xulyxoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string request = Request.QueryString["idxoa"];
            ArrayList arrProduct = (ArrayList)Session["giohang"];
            ArrayList dsach = Application[Global.san_pham] as ArrayList;
            CProduct itemXoa = null;
            foreach (CProduct p in dsach)
            {
                if (p.id == request)
                {
                    itemXoa = p;

                }
            }

            if (itemXoa != null)
            {
                arrProduct.Remove(itemXoa);
            }
            Response.Redirect("GioHang.aspx");
        }
    }
}
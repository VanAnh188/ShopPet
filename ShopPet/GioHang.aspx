<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="ShopPet.GioHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assest/css/giohang.css" rel="stylesheet" />
    <link href="assest/font/themify-icons/themify-icons.css" rel="stylesheet" />
</head>
<body>
    <div class="app">
        <!-- top bar trên cùng -->
        <div class="topbar_big">
            <div class="topbar">
                <div class="topbar_left">Cửa hàng bán đồ và phụ kiện cho thú cưng</div>
                <div class="topbar_right">
                    <div class="dangky" id="dangky" runat="server">
                        <%--<a href="DangKi.aspx" >Đăng ký</a>--%>
                    </div>
                    
                    <%--<span>|</span>
                    <a href="DangNhap.aspx" class="dangnhap">Đăng nhập</a>--%>
                    
                </div>
            </div>    
        </div>
        <!-- logo, search và giỏ hàng -->
        <div class="header_big">
            <div class="header">    
                <h1 class="logo">PET</h1>
                <div class="search">
                    <input type="text" name="search" id="search">
                    <input type="button"><i class="ti-search"></i> 
                </div>
                
                <div class="giohang">
                    <i class="ti-shopping-cart"></i>
                    <div class="text-cart">
                        <span class="top_cart">Giỏ hàng</span>
                        <div class="bot_cart" id="slgsp" runat="server">0</div>
                        <p>sản phẩm</p>
                    </div>
                </div>
                
                
            </div>
        </div>
        <!-- menu nav -->
        <div class="nav">
            <div class="menu">
                <ul class="menu_list">
                    <li><a href="TrangChu.aspx" style="color:#FA8072;">Trang chủ</a></li>
                    <li><a href="TrangCho.aspx?type=cho">Chó</a></li>
                    <li><a href="TrangMeo.aspx?type=meo">Mèo</a></li>
                    <li><a href="">Giới thiệu</a></li>
                    <li><a href="">Liên hệ</a></li>
                </ul>

            </div>
            
        </div>
        <hr>
        <%-- phần thân thanh toán --%>
         <div class="col l-12 m-12 c-12 cart">
              <div class="cart-content" style="border-radius: 15px;">
                  <%-- giohang --%>
                   <h6 class="header-giohang">GIỎ HÀNG CỦA BẠN
                       <span></span></h6>
                  <%-- bảng giỏ hàng --%>
                   <div class="cart-content-item">
                  <form id="form1" runat="server">
                       <div id="bang" runat="server">

                       </div>
                       
                            

                      
                  </form>
               </div>
                  
                  <%-- cột --%>
                   <div class="row">
                        <div class="btn">
                             <a href="GioHang.aspx" class="btn nutdongythanhtoan">Đồng Ý Thanh Toán</a>
                         </div>
                   </div>        
               </div>
          </div>
        <%-- footer --%>
         <div class="footer">
            <div class="footer_left">
                <h3>PET</h3>
                <br>
                <h4>Môn: Lập trình web cơ bản</h4>
                <h4>Đề tài: Website bán đồ và phụ kiện cho thú cưng</h4>
                <h4>Giáo viên hướng dẫn: Lê Hữu Dũng</h4>

            </div>
            <div class="footer_right">
                <h3>Thành viên:</h3>
                <br>
                <h4>Nguyễn Vân Anh-2010A01</h4>
                <h4>Hoàng Thị Phương Thảo-1910A05</h4>
                <h4>Vũ Đức Thọ-1910A05</h4>
            </div>
        </div>
        
      </div>
             
      
        
</body>
</html>

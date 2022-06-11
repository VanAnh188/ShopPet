<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangMeo.aspx.cs" Inherits="ShopPet.TrangMeo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="assest/font/themify-icons/themify-icons.css" rel="stylesheet" />
    <link href="assest/css/meo.css" rel="stylesheet" />
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
                    <%--<a href="" class="Dangky">Đăng ký</a>
                    <span>|</span>
                    <a href="" class="Dangnhap">Đăng nhập</a>--%>
                </div>
            </div>    
        </div>
        <!-- logo, search và giỏ hàng -->
        <div class="header_big">
            <div class="header">    
                <div class="logo">
                    <img src="./assest/img/logomeo.jpg" alt="" width="70px"/>
                    <span><a href="TrangChu.aspx">PET</a></span>
                    
                </div>
                <div class="search">
                    <input type="text" name="search" id="search" />
                    <input type="button" /><i class="ti-search"></i> 
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
        <!-- ảnh bìa -->
         <div class="anhbia">
            <img src="./assest/img/meo.png" alt="hình ảnh" class="img_bia">
        </div> 
        <br><br>
        <!-- danh mục  -->
        <div class="content">
            <div class="abc">
                <a href="TrangChu.aspx"><strong>TRANG CHỦ</strong></a> / <a href="TrangCho.aspx"><strong>PHỤ KIỆN CHO CHÓ</strong></a>
        
        <br><br>
        <!-- menu dọc bên trái -->
                <div class="sidebar_one">
                    <div class="row_1">
                        <strong class="danhmuc">Danh mục sản phẩm</strong>
                        <div class="show">
                            <ul class="list-menu">
                                <li><a href="TrangCho.aspx?type=cho">Phụ kiện cho chó</a></li>
                                <li><a href="TrangMeo.aspx?type=meo">Phụ kiện cho mèo</a></li>
                            </ul>
                        </div>
                         <br/>
                    </div>
                    <img src ="./assest/img/meo-03.png" alt="Ảnh bìa" style="max-width:100%; height:auto; margin-top: 30px;"/>                    
                    <img src ="./assest/img/meo-04.png" alt="Ảnh bìa" style="max-width:100%; height:auto; margin-top: 30px;"/>
                </div>
            </div>

        <!-- list sản phẩm bên phải -->
                    
                  
                
            <div class="sanpham">
                <div class="product-list" id="loaisp" runat="server">
                        <%--<div class="grid">
                                <img src="./assest/img/meouongnuoc.jpg" alt="hinhanh" class="product-img">
                                <div class="product-name">Vòi uống nước hình hoa</div>
                                <div class="product-price">500,000VNĐ</div>
                                
                        </div>--%>
                    
                        
                           
                            
                        </div>
                       
                    </div>
                
             </div>
        
    
        <!-- footer -->
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

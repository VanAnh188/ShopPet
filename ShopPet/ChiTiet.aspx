<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="ShopPet.ChiTiet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assest/css/chitiet.css" rel="stylesheet" />
    <link href="assest/font/themify-icons/themify-icons.css" rel="stylesheet" />
</head>
<body>
    <%-- header --%>
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
                <div class="logo">
                    <img src="./assest/img/logomeo.jpg" alt="" width="70px"/>
                    <span><a href="TrangChu.aspx">PET</a></span>
                    
                </div>
                <div class="search">
                    <input type="text" name="search" id="search"/>
                    <input type="button"><i class="ti-search"/></i> 
                </div>
                
                <div class="giohang">
                    <a href="GioHang.aspx">
                    <i class="ti-shopping-cart"></i></a>
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
        <br>
        <%-- chi tiết sản phẩm --%>
        <form id="form1" action="" method="post" runat ="server">
            <div class="products-detail-content">
        <!-- ảnh thong tin và giá -->
        <div class="product-details">
            <div>
                <div class="product-image" id="productimage" runat="server">
               
                    </div>
                <%-- <div style="display:flex;">
                <img class="img-product" id="1"
                        src="./assest/img/meo1.jpg" width="100px" alt="" style="height:100px;">
                <img class="img-product" width="100px" id="2" 
                    src="./assest/img/meo1.jpg"
                        alt="" style="height:100px;">
                 <img class="img-product" id="3"
                        src="./assest/img/meo1.jpg" width="100px" alt="" style="height:100px;">
            </div>--%>
            </div>
            
                <div class="anhct">
                     <div class="product" id="anh1" runat="server"></div>
                          <div class="product1" id="anh2" runat="server"></div>
                        <%--<img class="img-product" id="1"
                                src="./assest/img/meo1.jpg" width="100" alt=""/>
                        <img class="img-product" width="100" id="2" 
                            src="./assest/img/pk1.jpg"
                                alt=""/>
                         <img class="img-product" id="3"
                                src="./assest/img/meo1.jpg" width="100" alt=""/>--%>
                    </div>

            <div class="product-cost">
                <ul class="product-detail">
                    <li>
                        <span class="product-name" id="productname" runat="server"></span>
                    </li>
                    <li style="color:red; font-weight:700;">
                        <span class="current-price" id="productprice" runat="server" >500000</span>
                        <span class="currency">VNĐ</span>
                    </li>
                    
                    <li id="mota" class="mota" runat="server">
                        

                    </li>
                    
                </ul>
               
                <%-- nút mua --%>
                
                <div class="cost-button">
                    <div class="add-to-cart">
                        <%--<button id="addtocart" class="addtocart" runat="server" onserverclick="btnthem_Click">Thêm vào giỏ hàng</button>--%>
                        <button id="addtocart" class="addtocart" runat="server" onserverclick="btnthem_Click">Thêm vào giỏ hàng</button>
                        
                    </div>
                    <div class="buy-button">
                       
                    </div>
                </div>
            </div>
        </div></div></form>
        <!-- thông tin chính sách -->
        <div class="product-info">
            <div class="warranty-infos">
                <ul>
                    <li>
                        <span class="warranty-title" style ="font-weight:600;">THÔNG TIN CHÍNH SÁCH</span>
                    </li>
                    <hr/>
                    <li>
                        <span>Bảo hành 1 tháng đối với sản phảm phụ kiện</span>
                    </li>
                    <li>
                        <span>Miễn phí đổi trả trong vòng 7 ngày</span>
                    </li>
                    <li>
                        <span>Miễn phí vận chuyển đơn hàng trên 500.000 vnd</span>
                    </li>
                </ul>
            </div>
        </div>
        <br>        

        <!-- <div class="lienquan">
            <h3>SẢN PHẨM LIÊN QUAN</h3>
            <hr />
        </div>
        <br><br>
        <div class="product-list">
            <div class="grid">
                <img src="./assest/img/meouongnuoc.jpg" alt="hinhanh" class="product-img">
                <div class="product-name">Vòi uống nước hình hoa</div>
                <div class="product-price">500,000VNĐ</div>
                
            </div>
        </div> -->
        
     </div>

        
        <div class="footer">
            <div class="footer_left">
                <h3>PET</h3>
                <br/>
                <h4>Môn: Lập trình web cơ bản</h4>
                <h4>Đề tài: Website bán đồ và phụ kiện cho thú cưng</h4>
                <h4>Giáo viên hướng dẫn: Lê Hữu Dũng</h4>

            </div>
            <div class="footer_right">
                <h3>Thành viên:</h3>
                <br/>
                <h4>Nguyễn Vân Anh-2010A01</h4>
                <h4>Hoàng Thị Phương Thảo-1910A05</h4>
                <h4>Vũ Đức Thọ-1910A05</h4>
            </div>
        </div>
        
        </div>
    
</body>
</html>

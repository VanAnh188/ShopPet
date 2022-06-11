<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemSP.aspx.cs" Inherits="ShopPet.ThemSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assest/css/themsp.css" rel="stylesheet" />
</head>
<body>
    <div class="app">
        <%--<span id="tgian" runat="server">hello</span>--%>
        <!-- top bar trên cùng -->
        <div class="topbar_big">
            <div class="topbar">
                <div class="topbar_left">Cửa hàng bán đồ và phụ kiện cho thú cưng</div>
                <div class="topbar_right">
                    <div class="dangky" id="dangky" runat="server">
                       <a href="DangKi.aspx" >Đăng ký</a>
                    </div>
                    <span>|</span>
                    <a href="DangNhap.aspx">Đăng nhập</a>
                    
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
                <form method="get" action="Xulytimkiem.aspx" class="search">
                    <div class="search">
                        <input type="text" name="search" id="search" autocomplete="off"/>
                        <input type="button"><i class="ti-search"></i> 
                    </div>
                 </form>
                
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
                    <li><a href="ThemSP.aspx">Thêm SP</a></li>
                </ul>

            </div>
            
        </div>
        <hr>
        <br>
        <!--Thêm sp-->
    <form action="" method="post"> 
      <table class="tableStyle" border="1"> 
        <tr>
            <th class="table1" colspan="2"> <h2>Thêm sản phẩm </h2> </th>
          </tr>
          <tr>
            <th> Tên sản phẩm </th>
            <td > <input type="text" id="ten sp"  placeholder=" Nhập tên sp "/></td>
          </tr>

          <tr>
            <th> Giá sản phẩm </th>
            <td > <input type="text" placeholder=" Nhập giá sp "/></td>
          </tr>
        
          <tr>
            <th> Mô tả sản phẩm </th>
            <td >
              <textarea>

              </textarea>
            </td>
          </tr>
          <tr>
            <th> Ảnh sản phẩm </th>
            <td >
              <input type="file" name="avatar">
            </td>
          </tr>
          <tr>
            <th> Danh mục sản phẩm </th>
            <td >
              <label>
              <input type="checkbox" name="phụ kiện cho chó"> Phụ kiện cho chó
              </label>
              <br/>
              <label>
              <input type="checkbox" name="phụ kiện cho mèo"> Phụ kiện cho mèo
              </label>
            </td>
          </tr>
          <tr>
            <th colspan="2">
              <input type="reset" name="reset" value="Reset">
              <input type="submit" name="OK" value="OK">
            </th>
          </tr>
       </table> 
    </form> 
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

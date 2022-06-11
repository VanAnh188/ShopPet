<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="ShopPet.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assest/css/dangky.css" rel="stylesheet" />
</head>
<body>
    <div class="main">
        <form method="POST" class="form" id="form1" runat="server">
            <div class="dk_title_logo">
                    <p>ĐĂNG NHẬP</p>
            </div>
            <div class="spacer"></div>
  
          <div class="form-group">
            <label for="email" class="form-label">Email</label>
            <input id="email" name="email" type="text" placeholder="VD: email@domain.com" class="form-control"/>
            <span class="form-message" id="email_loi"></span>
        </div>
  
          <div class="form-group">
            <label for="password" class="form-label">Mật khẩu</label>
            <input id="password" name="password" type="password" placeholder="Nhập mật khẩu" class="form-control"/>
            <span class="form-message" id="password_loi"></span>
        </div>
  
          <button class="form-submit">Đăng nhập</button>
            <br />
            <br />
            <div>Bạn chưa có tài khoản? <a href="DangKy.aspx">Đăng ký</a></div>
        </form>
      </div>
</body>
</html>

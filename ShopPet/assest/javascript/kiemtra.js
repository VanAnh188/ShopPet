function checkdulieu() {
    
    // Không để trống
    fullname = document.getElementById("fullnameDK").value;
    ten_loi = document.getElementById("tenDK_loi");
    checkloi = true;
    if (fullname == "") {
        ten_loi.innerHTML = "Vui lòng điền thông tin";
        checkloi = false;
    }

    // Email phải có @, có ít nhất 1 dấu . sau @
    email = document.getElementById("emailDK").value;
    email_loi = document.getElementById("emailDK_loi");
    if (email == "") {
        email_loi.innerHTML = "Vui lòng điền thông tin";
        checkloi = false;
    } else {
        if (email.indexOf("@gmail.com") >= 0) {
            //email_loi.innerHTML = "ok";
        } else {
            email_loi.innerHTML = "email không đúng định dạng";
            checkloi = false;
        }
    }

    password = document.getElementById("passwordDK").value;
    mk_loi = document.getElementById("mkDK_loi");
    if (password == "") {
        mk_loi.innerHTML = "Vui lòng điền thông tin";
        checkloi = false;
    }
    return checkloi;
}
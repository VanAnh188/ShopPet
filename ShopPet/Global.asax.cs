using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ShopPet
{
    public class Global : System.Web.HttpApplication
    {
        public const string san_pham = "sanpham";

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["user"] = new List<CUser>();
            List<CUser> arrUser = new List<CUser>();
            arrUser.Add(new CUser() { name = "Anh", email = "a@gmail.com", password = "1234" });
            Application["user"] = arrUser;
            ///list sản phẩm
            //Application["product"] = new List<CProduct>();
            //List<CProduct> arrProduct = new List<CProduct>();
            ArrayList arrProduct = new ArrayList();
            arrProduct.Add(new CProduct()
            {
                id = "1",
                type="cho",
                image = "./assest/img/Cho/sp-01.jpg",
                name = "Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg",
                price = "115000 ",
                detail = "Sản phẩm Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg là loại thức ăn hạt dành riêng cho chó nhỏ tầm dưới 12 tháng tuổi. Dòng sản phẩm SmartHeart đang ngày càng được ưa chuộng trong cộng đồng thú cưng vì hương vi thơm ngon, dễ ăn và được các bé cún yêu thích."
            });
            arrProduct.Add(new CProduct()
            {
                id = "2",
                type="cho",
                image = "./assest/img/Cho/sp-02.jpg",
                name = "Sữa Bột Predogen cho chó hộp 110g",
                price = "42000 ",
                detail = "Sữa bột dành cho chó PREDOGEN được sản xuất theo công thức của WONDERLIFE PHARMA  (mỹ) là một thực phẩm bổ dưỡng cho chó yêu của bạn ngoài những thức ăn thông thường, giúp chó yêu cảm thấy ngon miệng hơn, bồi bổ cơ thể và cung cấp những thứ cần thiết để phát triển toàn diện."
            });

            arrProduct.Add(new CProduct()
            {
                id = "3",
                type = "cho",
                image = "./assest/img/Cho/sp-03.png",
                name = "Dụng Cụ Lấy Lông Chó Mèo Bám Dính",
                price = "145000",
                detail = "Dụng Cụ Lấy Lông Chó Mèo Bám Dính được làm từ nhựa ABS. Nhựa ABS là loại nhựa có độ cứng, độ bền cực cao. Sản phẩm có khả năng chịu lực tốt, không dễ bị trày xước. Đặc biệt, loại nhựa này hoàn toàn đảm bảo an toàn cho người sử dụng, không mùi, không chất hoá học."
            });

            arrProduct.Add(new CProduct()
            {
                id = "4",
                type = "cho",
                image = "./assest/img/Cho/sp-04.jpg",
                name = "Sữa Tắm SOS Cho Chó Lông Trắng",
                price = "120000",
                detail = "- Sữa Tắm SOS Cho Chó Lông Trắng màu xanh ngọc dành riêng cho chó có lông màu trắng. Có tác dụng làm mềm mượt lông, phục hồi hư tổn đối với thú cưng có bộ lông bị khô, xơ trở nên bóng, khỏe, trắng hơn và không bị bạc màu."
            });

            arrProduct.Add(new CProduct()
            {
                id = "5",
                type = "cho",

                image = "./assest/img/Cho/sp-05.jpg",
                name = "Áo Mùa Hè Teddy Sọc Cho Chó",
                price = "85000",
                detail = "Áo Mùa Hè Teddy Sọc Cho Chó Mèo được làm từ những chất liệu vải khô thoáng nhất. Chủ yếu là từ vải cotton giúp thấm mồ hôi hiệu quả. Đồng thời, trong những ngày thời tiết mùa hè thì sản phẩm này sẽ giúp trao đổi không khí, khiến thú cưng thấy dễ chịu, mát mẻ hơn."
            });

            arrProduct.Add(new CProduct()
            {
                id = "6",
                type = "cho",
                image = "./assest/img/Cho/sp-06.jpg",
                name = "Khay vệ sinh vuông cho chó thành cao có cọc",
                price = "170000",
                detail = "Khay vệ sinh cho chó được thiết kế dành riêng cho chó đi vệ sinh, nên hộp đi vệ sinh cho bên mình nhập về có kiểu dáng bắt mắt, chất lượng nhựa bền, đẹp. Đối tượng: phù hợp với các dòng chó như Pomeranian, Binchon, pooder, minpincher … vv."
            });

            arrProduct.Add(new CProduct()
            {
                id = "7",
                type = "cho",
                image = "./assest/img/Cho/sp-07.jpg",
                name = "Nệm Hình Tròn Có Hoa Văn Cho Thú Cưng",
                price = "180000",
                detail = "Nệm Hình Tròn Có Hoa Văn Cho Thú Cưng được làm từ chất liệu vải bông ấm áp, dễ vệ sinh. Rất phù hợp cho chó khi trời sang đông. Nệm Hình Tròn Có Hoa Văn Cho Thú Cưng sử dụng gam màu xám dễ vệ sinh, sạch sẽ. Đây chắc chắn sẽ là nơi thư giãn lý tưởng, làm hài lòng những chú cún con xinh xắn."
            });


            arrProduct.Add(new CProduct()
            {
                id = "8",
                type = "cho",
                image = "./assest/img/Cho/sp-08.jpg",
                name = "Lồng Đen Cao Cấp Cho Chó",
                price = "690000",
                detail = "Sản phẩm Lồng Đen Cao Cấp Cho Chó là một sản phẩm hữu ích và tiện lợi. Với Lồng Đen Cao Cấp Cho Chó bạn có thể dễ dàng kiểm soát cún cưng. Với sự tiện lợi và an toàn, lồng đen cao cấp là sự lựa chọn yêu thích của nhiều chủ nhân nuôi thú cưng."
            });

            arrProduct.Add(new CProduct()
            {
                id = "9",
                type = "cho",
                image = "./assest/img/Cho/sp-09.jpg",
                name = "Vòng Cổ 1.5cm Cho Chó",
                price = "18000",
                detail = "Vòng cổ cho chó với thiết kế dày dặn và chắc chắn. Chiếc vòng cổ này sẽ nằm thật gọn gàng trên cổ thú cưng khiến chúng vô cùng đáng yêu. Vòng Cổ 1.5cm Cho Chó sẽ là một công cụ đắc lực cho bạn. Nó giúp bạn dễ dàng quản lý chú chó nghịch ngợm của mình hơn."
            });

            arrProduct.Add(new CProduct()
            {
                id = "10",
                type = "cho",
                image = "./assest/img/Cho/sp-10.jpg",
                name = "Kính Thời Trang Cho Thú Cưng",
                price = "35000",
                detail = "Sản phẩm Kính Thời Trang Cho Thú Cưng được làm từ những chất liệu an toàn với thú cưng. Chất liệu chủ yếu là nhựa tự nhiên, không độc hại cho thú cưng. Đồng thời, chất liệu nhựa có độ bền cực cao, chịu va đập tốt. Trời chuyển hè, những tia nắng gắt có thể chiếu vào mắt các bạn thú cưng. Vì vậy hãy bảo vệ đôi mắt của các bé bằng cách đeo Kính Thời Trang Cho Thú Cưng."
            });


            //sanpham cho meo

            arrProduct.Add(new CProduct()
            {
                id = "11",
                type = "meo",
                image = "./assest/img/Meo/sp-11.jpg",
                name = "Sữa Bột Precaten cho mèo hộp 110g",
                price = "42000",
                detail = "Sữa bột dành cho Mèo PRECATEN được sản xuất theo công thức của WONDERLIFE PHARMA (Mỹ) là một thực phẩm bổ dưỡng cho mèo yêu của bạn. ngoài những thức ăn thông thường, sữa giúp bé mèo cảm thấy ngon miệng hơn, bồi bổ cơ thể và cung cấp những thứ cần thiết để phát triển toàn diện."
            });

            arrProduct.Add(new CProduct()
            {
                id = "12",
                type = "meo",
                image = "./assest/img/Meo/sp-12.jpg",
                name = "Thức Ăn Khô Cho Mèo Cat Eye 1.5kg",
                price = "150000",
                detail = "Thức Ăn Khô Cho Mèo Cat Eye 1.5Kg được phối trộn đặc biệt dành cho mèo mọi lứa tuổi để giảm chứng rụng lông, cải thiện bộ lông mèo và cải thiện tiêu hóa. Với những thành phần dễ tiêu hóa và cực kỳ ngon miệng sẽ giúp tăng cường hệ thống miễn dịch, cải thiện khả năng hấp thụ dinh dưỡng, tăng cường sức khỏe đại tràng và giảm lãng phí thức ăn ăn vào của mèo."
            });

            arrProduct.Add(new CProduct()
            {
                id = "13",
                type = "meo",
                image = "./assest/img/Meo/sp-13.jpg",
                name = "Bánh Thưởng Dạng Kem Vị Cá Hồi Me-O",
                price = "45000",
                detail = "Sản phẩm Bánh Thưởng Dạng Kem Me-O Vị Cá Hồi là kết quả của các chuyên gia đến từ Thái Lan. Được nhập khẩu tại Thái Lan, với chất lượng an toàn. Đây là 1 dòng sản phẩm thuộc thương hiệu Me-O rất quen thuộc với chúng ta rồi! Me-O là thương hiệu có nguồn gốc từ Thái Lan, chuyên sản xuất các sản phẩm dành cho mèo."
            });




            arrProduct.Add(new CProduct()
            {
                id = "14",
                type = "meo",
                image = "./assest/img/Meo/sp-14.jpg",
                name = "Đồ Chơi Đèn Tia Laser Cho Mèo",
                price = "25000",
                detail = "Đồ Chơi Đèn Tia Laser Cho Mèo được làm từ hợp kim không gỉ, đảm bảo rất an toàn với người sử dụng. Các chất liệu để làm ra sản phẩm đều đã được kiểm nghiệm kỹ lưỡng. Bạn hoàn toàn có thể an tâm về chất lượng của sản phẩm này khi mua cho mèo nhà mình."
            });

            arrProduct.Add(new CProduct()
            {
                id = "15",
                type = "meo",
                image = "./assest/img/Meo/sp-15.jpg",
                name = "Xịt Khử Mùi Dưỡng Lông Budle Budle Cho Chó Mèo",
                price = "150000",
                detail = "Với công dụng chính là khử mùi của chó mèo, Xịt Khử Mùi Dưỡng Lông Budle Budle Cho Chó Mèo có thể dùng để khử mùi nơi ngủ và các vật dụng khác của thú cưng. Hơn nữa còn có tác dụng khử trùng, kháng khuẩn, loại bỏ hoàn toàn các vi khuẩn, nấm hay ký sinh gây hai."
            });

            arrProduct.Add(new CProduct()
            {
                id = "16",
                type = "meo",
                image = "./assest/img/Meo/sp-16.jpg",
                name = "Bát Thép Không Gỉ Gắn Chuồng Cho Chó Mèo",
                price = "65000",
                detail = "Bát Thép Không Gỉ Gắn Chuồng Cho Chó Mèo được thiết kế hết sức tinh xảo. Điểm nổi bật chính là phần khoá xoay được làm chắc chắn, giúp cố định bát ở chuồng. Bên cạnh đó, lòng bát để đựng thức ăn có độ sâu vừa đủ, giúp chó mèo ăn dễ dàng hơn."
            });

            arrProduct.Add(new CProduct()
            {
                id = "17",
                type = "meo",
                image = "./assest/img/Meo/sp-17.jpg",
                name = "Nhà Đệm Có Mái Cửa Vuông Màu Vàng",
                price = "233000",
                detail = "Nhà Đệm Có Mái Cửa Vuông Màu Vàng cho thú cưng chất liệu mềm mại. Mái nhà cũng làm bằng đệm lớp vải sọc kẻ rất đặc biệt. Bên trong có lót đệm dễ dàng vệ sinh. Lót đệm êm sẽ giúp thú cưng ngủ thoải mái hơn. Mùa đông cũng sẽ ấm áp hơn rất nhiều đấy ạ!!."
            });

            arrProduct.Add(new CProduct()
            {
                id = "18",
                type = "meo",
                image = "./assest/img/Meo/sp-18.jpg",
                name = "Khay Vệ Sinh Cho Mèo",
                price = "116000",
                detail = "Khay Vệ Sinh Cho Mèo làm bằng nhựa cứng cao cấp, bền chắc, an toàn cho thú cưng. Xung quanh có viền bao giống như một nhà vệ sinh thu nhỏ cho mèo nhà bạn. Các chất liệu nhựa được sử dụng đều an toàn, dễ dàng chùi rửa. Đảm bảo không để lại những vết bẩn."
            });

            arrProduct.Add(new CProduct()
            {
                id = "19",
                type = "meo",
                image = "./assest/img/Meo/sp-19.png",
                name = "Yếm teddy kèm túi và dây dắt cho mèo",
                price = "140000",
                detail = "Yếm teddy kèm túi và dây dắt cho chó mèo sẽ là sự lựa chọn rất tốt cho bạn. Sản phẩm không làm đau mà lại dễ dàng giúp bạn quản lý thú cưng hơn. Yếm kèm 1 túi nhỏ rất tiện dụng cho các bạn đựng tiền hoặc các đồ dùng nhỏ gọn."
            });

            arrProduct.Add(new CProduct()
            {
                id = "20",
                type = "meo",
                image = "./assest/img/Meo/sp-20.jpg",
                name = "Đồ Chơi Con Rối Âm Thanh Cho Thú Cưng",
                price = "45000",
                detail = "Đồ Chơi Con Rối Âm Thanh Cho Thú Cưng là đồ chơi không thể thiếu cho thú cưng của bạn. Món đồ chơi này sẽ giúp các bạn thú cưng không còn cắn xé đồ vật trong nhà nữa. Thậm chí còn giúp chúng vận động linh hoạt hơn. Sản phẩm được làm từ những chất liệu an toàn với thú cưng.Đảm bảo không ảnh hưởng tới sức khoẻ của các bé."
            });
            ///Application["product"] = arrProduct;
            Application[san_pham] = arrProduct;


        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["dangnhap"]= 0;
            Session["giohang"] = new ArrayList();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
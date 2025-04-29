namespace LearnNote.REST
{
    class REST
    {
        public static void Main()
        {
            /* REST(REpresentational State Transfer)
                - is an architectural style.
                - during the development phase, API developers can implement REST in a variety of ways.
             * Separation of Concerns: RESTful APIs promote a clear separation between client and server, allowing them to evolve independently.
             * Constraints of REST:
                  1. Client - Server: Separate [user_interface (or client)] from [data_storage/logic (or server)] for independent evolution.
                  2. */ Stateless(); /*
                  3. */ Cacheability(); /*
                  4. */ UniformInterface(); /*
                  5. */ Layered_System(); /*
                  6. */ Code_on_Demand(); /*
            /*/
        }

        public static void Stateless()
        {
            /*
             * Khác với khi chúng ta truy cập web, trình duyệt sẽ có session và cookie để hỗ trợ phân biệt request đấy là của ai, thông tin trước đó là gì.
             * Trong REST, nếu một request cần xác thực quyền truy cập, chúng sẽ phải dùng thêm thông tin trong header.
             * Ví dụ như thông tin Authorization sẽ mang theo một user token. Hiện có 3 cơ chế Authentication chính:
                  1. HTTP Basic
                  2. JSON Web Token (JWT)
                  3. OAuth2
            /*/
        }

        public static void Cacheability()
        {
            /* 
             * Khả năng lưu trữ vào bộ nhớ đệm: Responses are labeled as cacheable or not, allowing clients and intermediaries to store responses for efficiency, vd:   
                - Server return info của một sản phẩm ít thay đổi, nó có thể bao gồm các tiêu đề HTTP như Cache-Control: public, max-age=3600.
                - Điều này chỉ định rằng trình duyệt (máy khách) hoặc một CDN (trung gian) có thể lưu trữ phản hồi này trong tối đa 1 giờ.
                - Nếu máy khách yêu cầu lại thông tin sản phẩm đó trong vòng 1 giờ, nó có thể lấy dữ liệu trực tiếp từ bộ nhớ đệm mà không cần gửi yêu cầu mới đến máy chủ.
            /*/
        }

        public static void UniformInterface()
        {
            /* Standardized interaction between clients and servers through:
               1. Resource Identification(Định danh tài nguyên): URIs identify resources(Tài nguyên xác định thông qua URI), vd:
                - /users để quản lý người dùng.
                - /products để quản lý sản phẩm.
               2. Resource Manipulation(thao tác) Through Representations, vd:
                - Gửi yêu cầu POST với dữ liệu JSON để tạo một người dùng mới. Nhận phản hồi JSON chứa thông tin người dùng đã tạo.
               3. Self-Descriptive Messages: Messages explain how to process them (e.g., media types), vd:
                - Content-Type: image/jpeg cho biết rằng phần thân của phản hồi là một hình ảnh [image/png, image/jpeg, image/gif].
                - Content-Type: audio ... [audio/wav, audio/mpeg].
                - Content-Type: video ... [video/mp4, video/ogg].
                - Content-Type: application ... [application/json, application/pdf, application/xml, application/octet-stream].
               4. HATEOAS (Hypermedia as the Engine of Application State), vd:
                - Khi yêu cầu thông tin về một đơn hàng, phản hồi có thể bao gồm các liên kết như <link rel="update" href="/orders/123">
            để cho biết client có thể gửi yêu cầu PUT đến URL đó để cập nhật đơn hàng.
             /*/
        }

        public static void Layered_System()
        {
            /*
             * Trong kiến trúc REST, có thể có nhiều "lớp" phần mềm giữa ứng dụng của bạn(client) và máy chủ(server) chứa dữ liệu thực tế. Ví dụ:
                - Bộ cân bằng tải (Load Balancer): Giống như lễ tân của tòa nhà, nó nhận yêu cầu của bạn và chuyển đến một trong nhiều "nhân viên"(máy chủ) đang rảnh.
            Bạn không biết có bao nhiêu máy chủ đang hoạt động.
                - Máy chủ Proxy: Giống như một người trợ lý, nó có thể xử lý một số công việc trước khi chuyển yêu cầu đi hoặc sau khi nhận phản hồi
            (ví dụ: kiểm tra quyền, lưu vào bộ nhớ đệm). Ứng dụng của bạn có thể không biết rằng nó đang nói chuyện với một proxy chứ không phải máy chủ cuối cùng.
             * Lợi ích:
                - Linh hoạt: Bạn có thể thêm hoặc thay đổi các lớp (ví dụ: thêm bộ cân bằng tải để xử lý nhiều người dùng hơn) mà không làm ảnh hưởng đến ứng dụng của bạn.
                - Bảo mật: Các lớp trung gian có thể thêm các biện pháp bảo mật.
                - Khả năng mở rộng: Dễ dàng thêm nhiều máy chủ hơn ở lớp ứng dụng mà không cần thay đổi máy khách.
            /*/
        }

        public static void Code_on_Demand()
        {
            /*
             * Trong REST, máy chủ có thể gửi một đoạn mã(thường là JavaScript) cùng với dữ liệu phản hồi.
            Máy khách(thường là trình duyệt web) sau đó có thể thực thi đoạn mã này để thay đổi cách nó hiển thị hoặc xử lý dữ liệu.
            Lưu ý quan trọng: Đây là một ràng buộc tùy chọn. Không phải tất cả các hệ thống RESTful đều sử dụng nó.
            Nó thường được thấy rõ nhất trong ngữ cảnh của các ứng dụng web động (single-page applications - SPA).
             * Lợi ích (khi được sử dụng):
                - Tăng tính tương tác: Cho phép tạo ra các ứng dụng web phong phú và động hơn.
                - Giảm tải cho máy chủ: Một số logic xử lý có thể được chuyển sang phía máy khách.
            /*/
        }
    }
}
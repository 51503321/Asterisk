/*
 * URI(Uniform Resource Identifier), bao gồm URI và URL
 * Nó dùng để xác định tài tài nguyên bởi chính xác nơi lấy nó hoặc tên của nó, và tất nhiên là có thể bằng cả hai.
 * 1.https://www.sample.com.vn/logo.jpg
 * 2.https://www.sample.com/logo.ico
 * 3.https://www.sample.com/logo.png
 * 4.ftp://sample/files/document.doc
 * 5.https://www.sample.com
 * 1.urn:isbn:978-0132350884
 * 
 * URL(Uniform Resource Locator). Nó là một dạng của URI, nó sẽ thể hiện chính xác cách ta có thể lấy tài nguyên về, ví dụ từ 1 -> 5 là URL.
 * 1 url bao gồm hypertext transfer(or protocal) + subdomain + domain + .com(or .com.vn or .gov.vn)
 * URL là một dạng của URI, nên tất cả URL có thể gọi là URI, tuy nhiên sẽ không có chiều ngược lại, vì URI còn có một dạng khác nữa, là URN.
 * 
 * URN(Uniform Resource Name), khác URL ở chỗ nó sẽ không chỉ cho ta chính xác sử dụng giao thức hay cách nào để lấy tài nguyên,
 * thay vì đó nó sẽ cung cấp cho ta định danh của tài nguyên này trên mạng,
 * định danh này sẽ là duy nhất theo thời gian,
 * hay nói cách khác là nếu không có biến động lớn.
/*/
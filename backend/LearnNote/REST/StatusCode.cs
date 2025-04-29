/* StatusCode
 * 201 Created – Trả về khi một Resouce vừa được tạo thành công.
 * 204 No Content – Trả về khi Resource xoá thành công.
 * 304 Not Modified – Client có thể sử dụng dữ liệu cache, resource server không đổi gì.
 * 400 Bad Request – Request không hợp lệ
 * 401 Unauthorized – Request cần có xác thực.
 * 403 Forbidden – bị từ chối không cho phép.
 * 404 Not Found – Không tìm thấy resource từ URI
 * 405 Method Not Allowed – Phương thức không cho phép với user hiện tại.
 * 410 Gone – Resource không còn tồn tại, Version cũ đã không còn hỗ trợ.
 * 415 Unsupported Media Type – Không hỗ trợ kiểu Resource này.
 * 422 Unprocessable Entity – Dữ liệu không được xác thực
 * 429 Too Many Requests – Request bị từ chối do bị giới hạn
/*/
// lint-staged là công cụ giúp chạy linter chỉ trên những file đã được staged (những file bạn đã git add)
// Kết hợp Husky và lint-staged, chúng ta sẽ có một quy trình tự động hóa hoàn hảo:
// - Developer thêm code và chạy git add
// - Khi chạy git commit, Husky sẽ kích hoạt hook pre-commit
// - Hook này sẽ chạy lint-staged
// - lint-staged sẽ chạy các linter, formatter... chỉ trên những file đã staged
// - Nếu có lỗi, commit sẽ bị chặn lại

// https://viblo.asia/p/husky-pre-commit-kham-pha-co-ban-14-EoW4oQZrLml?fbclid=IwZXh0bgNhZW0CMTEAAR7h-t84xNg3_V28uUgXadZUsLuJ0lQup3ubKfhZEC4yvcHcAfWF-jg8ARY9EQ_aem_viA-0IipZFd6LEnpIKHRQw

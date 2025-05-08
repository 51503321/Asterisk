/* https://restfulapi.net/resource-naming/
 * Giải thích về 3 categories in resources
 * document:
    * document resource is a singular concept(khái niệm số ít) that is akin(tương tự) to an object instance or database record.
 * store resource(client-managed repository of resources). It allows the client to put(store) and get(retrieve)
resources using a client-defined key.
 * kết luận: store resource are about letting clients manage their own named pieces of data within a defined scope
 * ví dụ:
    * PUT /configs/user123/theme: With a request body like { "value": "dark" }
    * GET /configs/user123/theme return { "value": "dark" }
 /*/
// The JSON.stringify() static method converts a JavaScript value to a JSON string.
// The JSON.parse() static method parses a JSON string, constructing the JavaScript value or object described by the string.
// const json = '{"result":true, "count":42}';
// const obj = JSON.parse(json);
// console.log(obj.count); Expected output: 42

// Thêm một chi tiết nữa đó là một nhược điểm khi sử dụng deep copy JSON.parse() và JSON.stringify()\
// đó là đôi khi bị miss những tham số của bạn, nêu tham số đó bạn gán underfined hoặc NaN
// ví dụ:
JSON.parse(
    JSON.stringify({
        a: new Date(),
        b: NaN,
        c: new Function(),
        d: undefined,
        e: function () {},
        f: Number,
        g: false,
        h: Infinity,
    }),
);

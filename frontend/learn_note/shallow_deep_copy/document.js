// 1.
// For shallow copies, a shallow copy of an object is a copy whose properties share the same references
// only the top-level properties are copied, not the values of nested objects. Therefore:
// Re-assigning top-level properties of the copy does not affect the source object.
// Re-assigning nested object properties of the copy does affect the source object.

// More formally, two objects o1 and o2 are shallow copies if:
// They are not the same object (o1 !== o2).
// The properties of o1 and o2 have the same names in the same order.
// The values of their properties are equal.
// Their prototype chains are equal.

// Giải thích shallow copy:
// Shallow copy nhiệm vụ của nó chỉ copy những giá trị nông,
// nghĩa là nó chỉ sao chép các giá trị đối tượng bình thường nhưng các giá trị lồng nhau vẫn sử dụng reference đến một đối tượng ban đầu.
// Notes: reference type trong javascript tổng thể có 3 loại: Array, function và object.

// 2.
// For deep copies, a deep copy of an object is a copy whose properties do not share the same references

// We can now define deep copies more formally as:
// They are not the same object (o1 !== o2).
// The properties of o1 and o2 have the same names in the same order.
// The values of their properties are deep copies of each other.
// Their prototype chains are structurally equivalent.

// Tóm lại:
// Shallow copy => Object.assign() và Spread Operator.
// Deep Copy => JSON.parse() và JSON.stringify().

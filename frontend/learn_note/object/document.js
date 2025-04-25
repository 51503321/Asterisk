// - The Object.assign() static method copies all enumerable own properties from one or more source objects to a target object. It returns
// the modified target object.
// - Properties in the target object are overwritten by properties in the sources if they have the same key.
// - Later sources' properties overwrite earlier ones.

const target = { a: 1, b: 2 };
const source = { b: 4, c: 5 };
const returnedTarget = Object.assign(target, source);
console.log(target); // Expected output: Object { a: 1, b: 4, c: 5 }

// - Cloning an object
const obj1 = { a: 0, b: { c: 0 } };
const obj2 = Object.assign({}, obj1);
// obj2 will be a new object containing a shallow copy of the properties from obj1. Importantly, obj1 itself remains unchanged.
const obj3 = Object.assign(obj1, { b: { c: 1 } });
// obj1 is modified and obj2 becomes another name pointing to the same object in memory as obj1.
console.log(obj1 === obj2); // false
console.log(obj1 === obj3); // true

// - Merging objects
const o1 = { a: 1 };
const o2 = { b: 2 };
const o3 = { c: 3 };
const obj = Object.assign(o1, o2, o3);
// obj is {a: 1, b:2, c:3}

// - Merging objects with same properties
const o11 = { a: 1, b: 1, c: 1 };
const o21 = { b: 2, c: 2 };
const o31 = { c: 3 };
const obj11 = Object.assign({}, o11, o21, o13);
// obj11 is { a: 1, b: 2, c: 3 };

// - Primitives will be wrapped to objects
// Primitives will be wrapped, null and undefined will be ignored.
// Note => only string wrappers can have own enumerable properties.
const v1 = 'abc'; // primitive
const v2 = true; // primitive
const v3 = 10; //primitive
const v4 = Symbol('foo'); // symbol;
const obj111 = Object.assign({}, v1, null, v2, undefined, v3, v4);
console.log(obj111); // { "0": "a", "1": "b", "2": "c" }

const number = Object.assign(3, { a: 1 });
console.log(number); // Number {3, a: 1}
console.log(typeof number); // object
console.log(number.a + 10); // 11
console.log(number + 10); // 13

// null and undefined as targets throw TypeError
try {
    Object.assign(null, { a: 1 });
} catch (e) {
    console.log(e.message); // "Cannot convert undefined or null to object"
}

// - Exceptions will interrupt the ongoing copying task
const target1 = Object.defineProperty({}, 'foo', {
    value: 1,
    writable: false,
}); // target.foo is a read-only property

Object.assign(target1, { bar: 2 }, { foo2: 3, foo: 3, foo3: 3 }, { baz: 4 });
console.log(target.bar); // 2, the first source was copied successfully.
console.log(target.foo2); // 3, the first property of the second source was copied successfully.
console.log(target.foo); // 1, exception is thrown here.
console.log(target.foo3); // undefined, assign method has finished, foo3 will not be copied.
console.log(target.baz); // undefined, the third source will not be copied either.
// => thực tế khi compile thì đã lỗi ngay từ console.log đầu tiên

const object = {
    name: 'John',
    age: 30,
    city: 'New York',
};

const { name, age, city } = object; // nếu đặt name sẽ báo lỗi đối với file .tsx
const objectAge = object['age'];

const a = 'foo';
const b = 42;
const c = {};
const o = { a, b, c }; // Shorthand property names
console.log(o.a === { a }.a); // true

const a1 = { x: 1, x: 2 };
console.log(a1); // {x: 2}

// Spread properties

// Spread syntax (...)
const obj1 = { key1: 'value1' };
const array1 = [...obj1]; // TypeError: obj is not iterable

const array2 = [1, 2, 3];
const obj2 = { ...array2 }; // { 0: 1, 1: 2, 2: 3 }

// All primitives can be spread in objects. Only strings have enumerable own properties, and spreading.
// -> Anything else doesn't create properties on the new object.
const obj3 = { ...true, ...'test', ...10 };
// { '0': 't', '1': 'e', '2': 's', '3': 't' }

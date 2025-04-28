// Copying and merging objects
const obj1 = { foo: 'bar', x: 42 };
const obj2 = { bar: 'baz', y: 13 };
const mergedObj = { ...obj1, ...obj2 }; // { foo: 'bar', x: 42, bar: 'baz', y: 13 }

const a = 'foo';
const b = 42;
const c = {};
const o = { a, b, c }; // Shorthand property names
console.log(o.a === { a }.a); // true

// Overriding properties
const obj11 = { foo: 'bar', x: 42 };
const obj21 = { foo: 'baz', y: 13 };
const mergedObj1 = { x: 41, ...obj11, ...obj21, y: 9 }; // {x: 42, foo: 'baz', y: 9}
const mergedObj11 = { x: 41, ...obj21, ...obj11, y: 9 }; // {x: 42, foo: 'bar', y: 9}
const mergedObj111 = { x: 41, y: 9, ...obj21, ...obj11 }; // {x: 42, foo: 'bar', y: 13}
const a1 = { x: 1, x: 2 }; // {x: 2}
// => the property takes the last value assigned while remaining in the position it was originally set.

// Conditionally adding properties to an object
const isSummer = false;
const fruits = {
    apple: 10,
    banana: 5,
    ...(isSummer ? { watermelon: 30 } : {}),
    ...(isSummer && { watermelonAnotherway: 30 }),
}; // { apple: 10, banana: 5, watermelon: 30 } or { apple: 10, banana: 5 }

// Comparing with Object.assign()
const obj111 = { foo: 'bar', x: 42 };
Object.assign(obj111, { x: 1337 }); //{ foo: 'bar', x: 1337 };

// another way to merge objects
const obj1111 = { foo: 'bar', x: 42 };
const obj2111 = { foo: 'baz', y: 13 };
const merge = (...objects) => objects.reduce((acc, cur) => ({ ...acc, ...cur }));
const mergedObj1111 = merge(obj1111, obj2111); //{ foo: 'baz', x: 42, y: 13 };

// All primitives can be spread in objects. Only strings have enumerable own properties, and spreading.
// -> Anything else doesn't create properties on the new object.
const obj3 = { ...true, ...'test', ...10 };
// { '0': 't', '1': 'e', '2': 's', '3': 't' }

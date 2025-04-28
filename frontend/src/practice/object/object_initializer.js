// Computed property names
let i = 0;
const a = {
    [`foo${++i}`]: i, // a.foo1: 1
    [`foo${++i}`]: i, // a.foo2: 2
    [`foo${++i}`]: i, // a.foo3: 3
};

const b = {
    [`foo${i++}`]: i, // a.foo0: 1
    [`foo${i++}`]: i, // a.foo1: 2
    [`foo${i++}`]: i, // a.foo2: 3
};

let j = 0;
const c = 1 + j++;
// c = 1
const d = 1 + ++j;
// d = 3

const items = ['A', 'B', 'C'];
const obj = {
    [items]: 'Hello',
};
console.log(obj); // A,B,C: "Hello"
console.log(obj['A,B,C']); // "Hello"

const param = 'size';
const config = {
    [param]: 12,
    [`mobile${param.charAt(0).toUpperCase()}${param.slice(1)}`]: 4,
}; // {size: 12, mobileSize: 4}

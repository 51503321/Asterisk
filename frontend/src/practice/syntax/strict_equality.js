null === null; // true
undefined === undefined; // true
1 === 1; // true
0 === false; // false
3 === new Number(3); // false
'1' === 1; // false
'hello' === 'hello'; // true

const object1 = {
    key: 'value',
};

const object2 = {
    key: 'value',
};

console.log(object1 === object2); // false
console.log(object1 === object1); // true

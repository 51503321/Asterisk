// 1. The spread (...) syntax allows an iterable, such as an array or string, to be expanded in places.
// In an object literal, the spread syntax enumerates the properties of an object and adds the key-value pairs to the object being created.
// Spread syntax can be used when all elements from an object or array need to be included in a new array or object,
// In a way, spread syntax is the opposite of rest syntax.
// Spread syntax "expands" an array into its elements, while rest syntax collects multiple elements and "condenses"(ngưng tụ)
// them into a single element

import { spread_in_function_call } from '../../src/practice/spread/spread_in_function_call';
import { spread_in_array_literal } from '../../src/practice/spread/spread_in_array_literal';
import { spread_in_object_literal } from '../../src/practice/spread/spread_in_object_literal';

// 2. The rest parameter syntax allows a function to accept an indefinite number of arguments as an array
function myFun(a, b, ...manyMoreArgs /* manyMoreArgs sẽ là mảng */) {
    console.log('a', a); // a, one
    console.log('b', b); // b, two
    console.log('manyMoreArgs', manyMoreArgs); // manyMoreArgs, ["three", "four", "five", "six"]
}

function myFun(a, b, ...[i, e, f, g, h]) {
    console.log('a', a); // a, one
    console.log('b', b); // b, two
    console.log('i', i); // i, three
    console.log('e', e); // e, four
}

myFun('one', 'two', 'three', 'four', 'five', 'six');

let arr2 = [0, 1, 2];
function myFun(a, b, ...leftOver) {
    return [a, b, 3, ...leftOver];
}
arr2 = myFun(...arr2); // [0, 1, 3, 2]

const sumArr = [1, 2, 3].reduce(add, 0); // with initial value to avoid when the array is empty, sumArr = 6

// accumulator là biến cộng dồn
function add(accumulator, a) {
    return accumulator + a;
}

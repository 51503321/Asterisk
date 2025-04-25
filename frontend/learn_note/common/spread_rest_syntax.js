// 1. The spread (...) syntax allows an iterable, such as an array or string, to be expanded in places.
// In an object literal, the spread syntax enumerates the properties of an object and adds the key-value pairs to the object being created.
// Spread syntax can be used when all elements from an object or array need to be included in a new array or object,
// In a way, spread syntax is the opposite of rest syntax.

import { spread_in_function_call } from '../../src/practice/spread/spread_in_function_call';
import { spread_in_array_literal } from '../../src/practice/spread/spread_in_array_literal';

// 2. The rest parameter syntax allows a function to accept an indefinite number of arguments as an array
function myFun(a, b, ...manyMoreArgs) {
    console.log('a', a); // a, one
    console.log('b', b); // b, two
    console.log('manyMoreArgs', manyMoreArgs); // manyMoreArgs, ["three", "four", "five", "six"]
}

function myFun(a, b, ...[i, e, f, g, h]) {
    console.log('a', a); // a, one
    console.log('b', b); // b, two
    console.log('i', i); // three
    console.log('e', e); // four
}

// manyMoreArgs sẽ là mảng
myFun('one', 'two', 'three', 'four', 'five', 'six');

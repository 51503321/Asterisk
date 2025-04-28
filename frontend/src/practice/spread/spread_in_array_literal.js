const parts = ['shoulders', 'knees'];
const lyrics = ['head', ...parts, 'and', 'toes'];
//  ["head", "shoulders", "knees", "and", "toes"]

// - Copying an array
const arr1 = [1, 2, 3];
const arr2 = [...arr1]; // like arr.slice(0, 3) => You can use spread syntax to make a shallow copy
arr2.push(4); // arr2 becomes [1, 2, 3, 4], arr remains unaffected

// - Spread syntax effectively goes one level deep while copying an array. Therefore, it may be unsuitable for copying multidimensional arrays.
const arr3 = [[1], [2], [3]];
const arr4 = [...arr3];

// .shift().shift() -> mảng hiện tại remove [x], còn mảng dính ref(do spread sẽ shallow copy array) thì remove x và còn []
// arr4[index].shift().shift() -> lỗi
// arr4[index].shift() or ar4.shift().shift() -> đúng

// do: ar4.shift().shift()
// result => arr4 = [[2], [3]]
// result arr3 = [[], [2], [3]]

// - A better way to concatenate arrays
let arr11 = [0, 1, 2];
const arr21 = [3, 4, 5];
arr1 = [...arr11, ...arr21];

// Conditionally adding values to an array
const isSummer = false;
const fruits = ['apple', 'banana', ...(isSummer ? ['watermelon'] : [])];

const parts = ['shoulders', 'knees'];
const lyrics = ['head', ...parts, 'and', 'toes'];
//  ["head", "shoulders", "knees", "and", "toes"]

// Copying an array
const arr1 = [1, 2, 3];
const arr2 = [...arr1]; // like arr.slice(0, 3) => You can use spread syntax to make a shallow copy
arr2.push(4); // arr2 becomes [1, 2, 3, 4]
// arr remains unaffected

// Spread syntax effectively goes one level deep while copying an array. Therefore, it may be unsuitable for copying multidimensional arrays.
const arr3 = [[1], [2], [3]];
const arr4 = [...arr3];
arr4.shift().shift(); // 1
// arr3 is affected as well:
console.log(arr3); // [[], [2], [3]]

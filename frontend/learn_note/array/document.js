// insert element at specific index
const arr = [0, 1, 2];
arr.splice(0, 0, [4]); // arr11 = [[4], 0, 1, 2]

const numbers = [1, 2, 4, 5];
const index = 2;
const newNumbers = [...numbers.slice(0, index), 3, ...numbers.slice(index)]; // Output: [1, 2, 3, 4, 5]

// nếu không dùng splice thì sao?
function insertAtIndex(arr, index, value) {
    const newArr = [];
    for (let i = 0; i < arr.length; i++) {
        if (i === index) newArr.push(value);
        newArr.push(arr[i]);
    }

    //case index is out of range
    if (index >= arr.length) {
        newArr.push(value);
    }

    return newArr;
}

// splice method
const arr1 = [0, 1, 2];
arr1.splice(1, 2, [4]); // arr = [0, [4]]

const arr2 = [0, 1, 2];
arr2.splice(0, 2, [4]); // arr = [[4], 2]

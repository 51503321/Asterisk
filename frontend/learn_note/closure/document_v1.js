function makeAdder(x) {
    return function (y) {
        return x + y;
    };
}
const add5 = makeAdder(5); // closures
const add10 = makeAdder(10); // closures
// They share the same function body definition, but store different lexical environments.
// In add5's lexical environment, x is 5, while in the lexical environment for add10, x is 10.

// why we don't use this instead
function makeAdder_two_params(x, y) {
    return x + y;
}

/* Explain:
1. makeAdder(x) allows you to create new functions that are "specialized" to add a specific value (x) to any argument they receive later (y).
2. The inner function returned by makeAdder(x) forms(tao thanh) a closure over the x variable from its outer scope.
This means the inner function "remembers" the value of x even after makeAdder(x) has finished executing.
This allows you to encapsulate the value of x within the created function (add5, add10).
The value of x is not directly accessible or modifiable from the outside.
3. Functions like makeAdder are often used in conjunction with higher-order functions 
(functions that take other functions as arguments or return functions).
 */
const numbers = [1, 2, 3];
const addThree = makeAdder(3);
const addedNumbers = numbers.map(addThree); // [4, 5, 6]

/*
 * This will immediately fired before onClick happen, because we are calling the function directly 
within the onClick prop instead of passing a reference to a function that should be executed when the
click happen, both btn-1 and btn-2 will be fired before onClick happen.
 */

function makeSizer_v1(size) {
    document.body.style.fontSize = `${size}px`;
}

const makeSizer_v2 = size => (document.body.style.fontSize = `${size}px`);

/* wrong */
<button id="btn-1" onClick={makeSizer_v1}>
    12
</button>;

<button id="btn-2" onClick={makeSizer_v2}>
    12
</button>;

/* correct way to process onclick event:
 * The key is the presence of the parentheses (). When you have onClick={makeSizer_v2(12)}, you are executing makeSizer_v2(12) immediately 
and passing its return value to onClick.
 * To execute makeSizer_v2(12) only on click, you need to wrap it in another function (like an anonymous arrow function)
so that you are passing a function reference to onClick.
 */

function makeSizer_correctway(size) {
    return function () {
        document.body.style.fontSize = `${size}px`;
    };
}

<button id="size-12" onClick={() => makeSizer_v2(12)}>
    12
</button>;

<button id="size-12" onClick={makeSizer_correctway(12)}>
    12
</button>;

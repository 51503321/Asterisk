/* Closure
 * The combination of a function bundled(đi kèm) together (enclosed)(gửi kèm) with references to its surrounding state(the lexical environment).
 * Gives a function access to its outer scope.
 * In JavaScript, closures are created every time a function is created, at function creation time.
 */

/* Lexical scoping
 * This is an example of lexical scoping, which describes how a parser resolves variable names(bộ phân tích cú pháp giải quyết tên biến) 
when functions are nested.
 */
function init() {
    var name = 'Mozilla';
    function displayName() {
        console.log(name); // displayName() is the inner function, that forms a closure.
    }
    displayName();
}
init();

/* Scoping with let and const
 * Before ES6, JavaScript variables only had two kinds of scopes: function scope and global scope.
 * Variables declared with var are either function-scoped or global-scoped,
depending on whether they are declared within a function or outside a function.
 */

if (Math.random() > 0.5) {
    var x = 1;
} else {
    var x = 2;
}
console.log(x);
/* The above code should throw an error on the console.log line,
because we are outside the scope of x in either block. However, because blocks don't create scopes for var
the var statements here actually create a global variable. */

if (Math.random() > 0.5) {
    const x = 1;
} else {
    const x = 2;
}
console.log(x); // ReferenceError: x is not defined
/* In ES6, JavaScript introduced the let and const declarations allow you to create block-scoped variables(except var).
 */

/* Closure
 * is the combination of a function and the lexical environment within which that function was declared.
 * Lexical scoping is the foundation for closures.
 */

function outerFunction() {
    let outerVar = 'Hello from outer';
    function innerFunction() {
        console.log(outerVar); // innerFunction accesses outerVar from its lexical scope
    }
    return innerFunction;
}

let myInnerFunc = outerFunction(); // myInnerFunc now holds a reference to innerFunction
myInnerFunc(); // Output: "Hello from outer" (even though outerFunction has finished)

// c2
outerFunction()();

// c3
const myOtherFunc = outerFunction()();
myOtherFunc;

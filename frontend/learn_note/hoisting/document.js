/*
 * Move the declaration of functions, variables, classes, or imports to the top of their scope.
 *
 * Any of the following behaviors may be regarded as hoisting:
1. Being able to use a variable's value in its scope before the line it is declared. ("Value hoisting") -> [import declarations].
2. Being able to reference a variable in its scope before the line it is declared, without throwing a ReferenceError,
but the value is always undefined. ("Declaration hoisting") -> [var declarations].
3. The declaration of the variable causes behavior changes in its scope before the line in which it is declared -> [let, const, class declarations].
4. The side effects of a declaration are produced before evaluating the rest of the code that contains it -> [import declarations].
 */

// function hoisting
function sumArray(array) {
    return array.reduce(sum_hoisting);
    function sum_hoisting(a, b) {
        return a + b;
    }
}
sumArray([5, 10, 8]); // => 23

/* another example about hoisting */
for (var i = 0; i < 5; i++) {
    setTimeout(function () {
        console.log(i);
    }, i * 1000);
} // print 5, five times

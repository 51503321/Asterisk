/* Closure scope chain
 */
const e = 10;
function sum(a) {
    return function (b) {
        return function (c) {
            // outer functions scope
            return function (d) {
                // local scope
                return a + b + c + d + e;
            };
        };
    };
}

const sumA = sum(1);
const sumB = sumA(2); // inner function with param b remember the variable value from outer scope.
console.log(sum(1)(2)(3)(4)); // 20

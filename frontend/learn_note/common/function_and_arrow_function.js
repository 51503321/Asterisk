/* Arrow functions
 * Don't have their own bindings to this, arguments, or super, and should not be used as methods.
 * cannot be used as constructors. Calling them with new throws a TypeError.
 *
 *
 *
 *
 *
 */

/* 1. Arrow function expressions
 * (a, b, ...r) => {}; Rest parameters.
 * (a = 400, b = 20, c) => {}; Default parameters.
 * ([a, b] = [10, 20]) => {}; Default parameters.
 * ({ a, b } = { a: 10, b: 20 }) => {}; destructuring.
 * (() => a + b + 100)(); how to call anonymous function.
 */

/* ex1 */
const materials = ['Hydrogen', 'Helium', 'Lithium', 'Beryllium'];
console.log(materials.map(material => material.length)); //[8, 6, 7, 9]
const func_v1 = () => ({ foo: 1 }); // { foo: 1 }
const func_v2 = () => {
    foo: 1;
}; // return error

/* 2. Cannot be used as methods */
/* ex2.1 */
const obj = {
    i: 10,
    b: () => console.log(this.i, this), // arrow function expressions do not have their own this
    c() {
        console.log(this.i, this);
    },
};
obj.b(); // logs undefined
obj.c(); // logs 10, Object { /* … */ }

/* ex2.2 */
class ClassWithArrowFunction {
    a = 1;
    autoBoundMethod = () => {
        console.log(this.a);
    };
}

const c = new ClassWithArrowFunction();
c.autoBoundMethod(); // 1
const { autoBoundMethod } = c;
autoBoundMethod(); // 1

/**/

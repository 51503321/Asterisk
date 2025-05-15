/*
 * Variable hoisting
 */
console.log(x === undefined); // true
var x = 3;

(function () {
    console.log(x); // undefined
    var x = 'local value';
})();

console.log(x); // ReferenceError
const x = 3;

console.log(y); // ReferenceError
let y = 3;

/*
 * Function hoisting
 */
func_declaration(); // work
function func_declaration() {
    console.log('func_declaration');
}

func_expression(); //TypeError: func_expression is not a function.
var func_expression = function () {
    console.log('func_expression');
};

/*
 * Class declaration hoisting
 */
new MyClass(); // ReferenceError: Cannot access 'MyClass' before initialization
class MyClass {}

/*
 * Import declarations are hoisted
 */
const myCanvas = new Canvas('myCanvas', document.body, 480, 320); // work
myCanvas.create();
import { Canvas } from './modules/canvas.js';
myCanvas.createReportList();

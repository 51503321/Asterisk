/* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Closures#creating_closures_in_loops_a_common_mistake
 */

function showHelp(help) {
    document.getElementById('help').textContent = help;
}

function makeHelpCallback(help) {
    return function () {
        showHelp(help);
    };
}

function setupHelp() {
    var helpText = [
        { id: 'email', help: 'Your email address' },
        { id: 'name', help: 'Your full name' },
        { id: 'age', help: 'Your age (you must be over 16)' },
    ];

    /*
     * i variable will have a function scope instead and if create closures within the loop that refer to i,
    those closures will all end up referencing the same i variable.
     */
    for (var i = 0; i < helpText.length; i++) {
        // Variables declared with var(item) have function scope, regardless(bất kể) of block-level constructs like for loops or if statements.
        var item = helpText[i]; // remove this if using anonymous closures

        // wrong
        document.getElementById(item.id).onfocus = function () {
            // this anonymous function is function expression and closures.
            // A closure is created when an inner function (the anonymous function in this case)
            // retains access to variables in its outer (lexical) scope, even after the outer function (the for loop and setupHelp function)
            // has finished executing.
            showHelp(item.help);
        };

        // correct way 1
        // Rather than the callbacks all sharing a single lexical environment,
        // the makeHelpCallback function creates a new lexical environment for each callback
        document.getElementById(item.id).onfocus = makeHelpCallback(item.help);

        // correct way 2, use anonymous closures
        (function () {
            var item = helpText[i];
            document.getElementById(item.id).onfocus = function () {
                showHelp(item.help);
            };
        })(); // Immediate event listener attachment with the current value of item (preserved until iteration).
    }
}

/* Line 41: This is the anonymous function that is immediately invoked (the IIFE) */
/* Line 43: This anonymous function forms the closure */

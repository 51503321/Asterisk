// Babel is a JavaScript compiler
// Babel is a toolchain that is mainly used to convert ECMAScript 2015+ code into a backwards compatible version of JavaScript
// in current and older browsers or environments.
// => Babel takes JavaScript code written in one version (usually a newer, more feature-rich version like ES6+ or even experimental proposals) and converts it into equivalent JavaScript code that can run in older JavaScript environments
// => Transform syntax

// Babel Input: ES2015 arrow function
[1, 2, 3].map((n) => n + 1);

// Babel Output: ES5 equivalent
[1, 2, 3].map(function (n) {
  return n + 1;
});

// Babel Input: React component with JSX:
function MyComponent() {
  return (
    <div>
      <h1>Hello, React!</h1>
      <p>This is JSX.</p>
    </div>
  );
}

// Babel Output: Transform above JSX into JavaScript:
function MyComponent() {
  return React.createElement(
    "div",
    null,
    React.createElement("h1", null, "Hello, React!"),
    React.createElement("p", null, "This is JSX."),
  );
}

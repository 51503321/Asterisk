// () parentheses
// [] bracket
// {} curly bracket

// call immediately
(() => console.log(1 + 1))();

(function () {
    console.log('Ok');
})();

// What are the features of React?
// Use of Virtual DOM instead of Real DOM, JSX, Server-side rendering, Unidirectional data flow or data binding, Reusable components

// What is JSX?

// What is the difference between Real DOM and Virtual DOM?

// Can we change the state of the component directly?
// No, we can't change the state of the component directly.
// State can only be changed by using setState() method. Changing the state variable directly won't re-render the component.

// React Fiber?

// What is the difference between react and react-dom packages?
// The package react contains only the renderer-agnostic code i.e. the core React library, algorithm for computing changes in the UI and other helpers.
// The package react-dom contains the code specific to the DOM rendering of React components.

// What is the difference between class components and function components?
// There are no lifecycle methods similar to class components available in functional components;
// you can use React hooks instead to manage the component lifecycle.

// What are Higher-Order Components (HOCs)?
// is a function that takes a component and returns a new component. Basically, it's a pattern that is derived from React's compositional nature.

// How to render HTML in React?
// You can use dangerouslySetInnerHTML prop to render HTML in React.
// It is used to set HTML directly from React. You should be careful while using this property as it can cause XSS attacks.

// What is Reconciliation in React?

//useContext
//useMemo
//Explain the concept of error boundaries in React.

//What are fragments in React?
//React doesn't allow returning multiple elements from a component. You can use fragments to return multiple elements.

//How to render React components as static HTML string?
//The renderToString function in React is part of the react-dom/server package and is used to render React components
// on the server-side to a static HTML string. It is commonly used for server-side rendering (SSR) in React.

//What are Server Components in React?

//How to lazy load components in React?
//What is `Suspense` in React?

//How does React Virtual DOM work?
// Virtual DOM works in this steps:
// Whenever any underlying data changes, new virtual DOM representation will be created.
// Then the difference between the previous DOM representation and the new one is calculated.
// Once the calculations are done, the real DOM will be updated with only the things that have actually changed.

//How do Server Components differ from Client Components?
// Server Components are rendered on the server and do not require client-side JavaScript for rendering.
// While Server Components and Client components can coexist in the same app, Server Components can import and render Client components.

//What is the difference between stateful and stateless components?
//The main difference between stateful and stateless components is one has state and the other doesn't.
//  Stateful components keep track of changes to their state and re-render themselves when the state changes. Stateless components, on the other hand, render whatever is passed to them via props or always render the same thing.

//Why you shouldn't use `index` as a key in React lists and iterators?
//What is the naming convention for React components?
//How to render a list in React?
//Can you use hooks in Server Components?
//What is Strict Mode in React and why is it useful?

//Strict Mode is a tool in React for highlighting potential problems in an application. By wrapping a component tree with StrictMode, React will activate additional checks and warnings for its descendants. This doesn't affect the production build but provides insights during development.
import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';

const root = createRoot(document.getElementById('root'));
root.render(
    <StrictMode>
        <App />
    </StrictMode>,
);
// In Strict Mode, React does a few extra things during development:
// It renders components twice to catch bugs caused by impure rendering.
// It runs side-effects (like data fetching) twice to find mistakes in them caused by missing effect cleanup.
// It checks if deprecated APIs are used, and logs a warning message to the console if so.

//How do you investigate a slow React app and identify performance bottlenecks?

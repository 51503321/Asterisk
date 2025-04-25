import { createRoot } from 'react-dom/client';
// import GIÁN TIẾP đến file
import ComponentDefault, { Component } from './BabelPluginDefault/index'; // export { default as Components } from './Components.tsx';
import { describe } from 'node:test';

// import trưc tiếp đến file
// - import default component, 2 cách:
// import Componentssss from './BabelPluginDefault/Component.tsx'; // sửa tên component vẫn map qua được component default
// import { default as ComponentDefault } from './BabelPluginDefault/Component.tsx';

// - import named component, 2 cách:
// import { Component } from './BabelPluginDefault/Component.tsx';
// import { Component as ComponentNotDefault } from './BabelPluginDefault/Component.tsx';

const domNode = document.getElementById('navigation');
const root = createRoot(domNode);
root.render(<>1</>);

// const obj = {
//     foo: 1,
//     get bar() {
//         return 2;
//     },
// };

// function callBackFunc(accumulator, a) {
//     console.log(accumulator);
//     console.log(a);
// }

// function completeAssign(target, ...sources) {
//     sources.forEach(source => {
//         // Object.keys(source): ['foo', 'bar']
//         // const descriptors = Object.keys(source).reduce((des, key, index) => {
//         //     des[key] = Object.getOwnPropertyDescriptor(source, key);
//         //     // console.log(des[key]);
//         //     return des;
//         // }, {});
//         // console.log(descriptors);
//     });
// }

// const copy = completeAssign({}, obj);

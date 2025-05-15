/* Import GIÁN TIẾP đến file
 * import ComponentDefault, { Component } from './BabelPluginDefault/index';
 */

/* Import TRỰC TIẾP đến file
 * Import default component:
1. import Componentssss from './BabelPluginDefault/Component.tsx'; // sửa tên component vẫn map qua được component default.
2. import { default as ComponentDefault } from './BabelPluginDefault/Component.tsx';

 * Import named component:
1. import { Component } from './BabelPluginDefault/Component.tsx';
2. import { Component as ComponentNotDefault } from './BabelPluginDefault/Component.tsx';
 */

import ReactDOM from 'react-dom/client';
import App from './App';

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
root.render(<App />);

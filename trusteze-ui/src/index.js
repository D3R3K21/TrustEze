import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App.js';
import reportWebVitals from './reportWebVitals';




const root = ReactDOM.createRoot(document.getElementById('root'));

root.render(
  <React.StrictMode>
     <link href="https://fonts.googleapis.com/css2?family=Josefin+Sans:wght@400;600&display=swap" rel="stylesheet"/>
     <link href="https://fonts.cdnfonts.com/css/tt-tsars-a-trial" rel="stylesheet"/>
    <App />
  </React.StrictMode>
);

reportWebVitals();

import React from 'react';
import Login from './components/Login.js';
import HomePage from './components/HomePage.js';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import PrivateRoutes from './PrivateRoutes.js';
import Header from './components/AuthenticatedHeader.js';

function App() {
    return (
<BrowserRouter>
      <Routes>
      <Route path="/login" element={<Login />}/>
      <Route path="/contact"  element={<HomePage />} />
      <Route element={<PrivateRoutes />}>
      <Route path="/"  element={<HomePage />} />
      
      <Route path="/about"  element={<HomePage />} />
      </Route>
      </Routes>
    </BrowserRouter>
      );
}

export default App;
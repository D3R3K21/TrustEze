import React from 'react';
import Login from './components/Login.js';
import HomePage from './components/HomePage.js';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import PrivateRoutes from './PrivateRoutes.js';

function App() {
    return (
      <BrowserRouter>
      <Routes>
      <Route path="/login" element={<Login />}/>
      <Route element={<PrivateRoutes />}>
          <Route path="/"  element={<HomePage />} />
      </Route>
      </Routes>
    </BrowserRouter>
      );
}

export default App;
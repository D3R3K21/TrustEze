import '../css/HomePage.css';
import React, { useState, useEffect } from 'react';

function HomePage() {
  const [data, setData] = useState(null);

  useEffect(() => {
    fetch('http://api.trusteze.co/listings')
      .then(response => response.json())
      .then(json => setData(json))
      .catch(error => console.error(error));
  }, []);

  useEffect(() => {
    // Initialize dark mode based on user preference
    const toggleSwitch = document.getElementById('mode-toggle');
    const currentMode = localStorage.getItem('mode') || 'dark-mode';
    
    if (currentMode === 'light-mode') {
      document.body.classList.add('light-mode');
      toggleSwitch.checked = true;
    }

    toggleSwitch.addEventListener('change', () => {
      if (toggleSwitch.checked) {
        document.body.classList.add('light-mode');
        localStorage.setItem('mode', 'light-mode');
      } else {
        document.body.classList.remove('light-mode');
        localStorage.setItem('mode', 'dark-mode');
      }
    });
  }, []);

  return (
    <div>
      {renderHomePage()}
     {/* {data ? <pre>{createTable(data)}</pre> : 'Loading...'} */}
    </div>
  );
}

function renderHomePage() {
  return (
    //TODO:(drose) move Header to its own component
    <>
      <header className="header">
      <div className="title-container">
        TRUSTKEYS
        <div className="subtitle">
          <span className="line"></span>
          <span className="subtitle-text">HOMES</span>
        </div>
      </div>

      <nav className="nav-menu">
        <a href="#">Home</a>
        <a href="#">Listings</a>
        <a href="#">About</a>
        <a href="#">Contact</a>
      </nav>
      </header>

      <section className="search-bar">
        <div className="search-bar-content">
          <h1>Find Your Home Today</h1>
          <input type="text" placeholder="Enter an address, city, or ZIP code" />
          <button>Search</button>
        </div>
      </section>

      <section className="main-content">
        <h2>Latest and Featured Properties</h2>
        <div className="listing-container">
          <div className="listing-item">
            <img src="https://img-v2.gtsstatic.net/reno/imagereader.aspx?imageurl=https%3A%2F%2Fsir.azureedge.net%2F1194i215%2Ff3jwp7v9fr9zmatjqmj75emsv5i215&option=N&h=472&permitphotoenlargement=false" alt="Property 1" />
            <div className="listing-details">
              <h3>Property 1</h3>
              <p>Location: City, State</p>
              <p>Price: $1,000,000</p>
            </div>
          </div>
          <div className="listing-item">
            <img src="https://toptenrealestatedeals.com/wp-content/uploads/2019/06/wk_55ad5802246c2.jpg" alt="Property 2" />
            <div className="listing-details">
              <h3>Property 2</h3>
              <p>Location: City, State</p>
              <p>Price: $850,000</p>
            </div>
          </div>
          <div className="listing-item">
            <img src="https://www.precisioncraft.com/wp-content/uploads/2023/05/okanogan-thumb.jpg" alt="Property 3" />
            <div className="listing-details">
              <h3>Property 3</h3>
              <p>Location: City, State</p>
              <p>Price: $750,000</p>
            </div>
          </div>
        </div>
      </section>

      <footer>
        <div className="footer-links">
          <a href="#">About Us</a>
          <a href="#">Contact</a>
          <a href="#">Terms of Service</a>
          <a href="#">Privacy Policy</a>
        </div>
        <div className="toggle-container">
          <span className="toggle-label">Dark Mode</span>
          <label className="switch">
            <input type="checkbox" id="mode-toggle" />
            <span className="slider"></span>
          </label>
        </div>
      </footer>
    </>
  );
}

function createTable(data) {

  return (
    <table>
      <tr key={"header"}>
        <th>Id</th>
        <th>Street Name</th>
      </tr>
      {data.results.map((item) => (
        <tr key="123">
         <td> {item.id}</td>
         <td> {item.standardFields.streetName}</td>
        </tr>
      ))}
    </table>
  );
}

export default HomePage;

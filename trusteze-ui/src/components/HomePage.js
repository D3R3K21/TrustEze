import '../css/HomePage.css';
import React, { useState, useEffect } from 'react';

function HomePage() {
  const [data, setData] = useState(null);

  useEffect(() => {
    fetch('http://api.trusteze.co/listings')
      .then(response => response.json())
      .then(json => setData(json))
      .catch(error => console.error(error));

    // Initialize dark mode functionality
    allowDarkMode();
  }, []);

  return (
    <div>
      {renderHomePage()}
      {/* {data ? <pre>{createTable(data)}</pre> : 'Loading...'} */}
    </div>
  );
}

function allowDarkMode() {
  // Get the toggle switch element
  const toggleSwitch = document.getElementById('mode-toggle');
  
  // Check if the toggle switch exists
  if (toggleSwitch) {
    // Load initial mode from local storage or default to dark mode
    const savedMode = localStorage.getItem('theme') || 'dark-mode';
    document.body.classList.add(savedMode);
    
    // Update the checkbox based on the saved mode
    toggleSwitch.checked = savedMode === 'light-mode';

    // Toggle between dark and light modes
    toggleSwitch.addEventListener('change', function () {
      if (toggleSwitch.checked) {
        document.body.classList.remove('dark-mode');
        document.body.classList.add('light-mode');
        localStorage.setItem('theme', 'light-mode');  // Save mode to local storage
      } else {
        document.body.classList.remove('light-mode');
        document.body.classList.add('dark-mode');
        localStorage.setItem('theme', 'dark-mode');  // Save mode to local storage
      }
    });
  }
}

function renderHomePage() {
  return (
<>
//TODO:(drose) move header to own component
  <header class="header">

  </header>
      <div class="title-container">
          TRUSTKEYS
          <div class="subtitle">
              <span class="line"></span>
              <span class="subtitle-text">HOMES</span>
          </div>
     </div>

      <nav class="nav-menu">
          <a href="#">Home</a>
          <a href="#">Listings</a>
          <a href="#">About</a>
          <a href="#">Contact</a>
      </nav>
      

   <section class="search-bar">
       <div class="search-bar-content">
           <h1>Find Your Home Today</h1>
           <input type="text" placeholder="Enter an address, city, or ZIP code"/>
           <button>Search</button>
       </div>
   </section>


   <section class="main-content">
       <h2>Latest and Featured Properties</h2>
       <div class="listing-container">
           <div class="listing-item">
               <img src="https://img-v2.gtsstatic.net/reno/imagereader.aspx?imageurl=https%3A%2F%2Fsir.azureedge.net%2F1194i215%2Ff3jwp7v9fr9zmatjqmj75emsv5i215&option=N&h=472&permitphotoenlargement=false" alt="Property 1"/>
               <div class="listing-details">
                   <h3>Property 1</h3>
                   <p>Location: City, State</p>
                   <p>Price: $1,000,000</p>
               </div>
           </div>
           <div class="listing-item">
               <img src="https://toptenrealestatedeals.com/wp-content/uploads/2019/06/wk_55ad5802246c2.jpg" alt="Property 2"/>
               <div class="listing-details">
                   <h3>Property 2</h3>
                   <p>Location: City, State</p>
                   <p>Price: $850,000</p>
               </div>
           </div>
           <div class="listing-item">
               <img src="https://www.precisioncraft.com/wp-content/uploads/2023/05/okanogan-thumb.jpg" alt="Property 3"/>
               <div class="listing-details">
                   <h3>Property 3</h3>
                   <p>Location: City, State</p>
                   <p>Price: $750,000</p>
               </div>
           </div>
       </div>
   </section>

  <footer>
      <div class="footer-links">
          <a href="#">About Us</a>
          <a href="#">Contact</a>
          <a href="#">Terms of Service</a>
          <a href="#">Privacy Policy</a>
      </div>
      <div class="toggle-container">
          <span class="toggle-label">Dark Mode</span>
          <label class="switch">
              <input type="checkbox" id="mode-toggle"/>
              <span class="slider"></span>
          </label>
      </div>
  </footer>

</>);

}

export default HomePage;

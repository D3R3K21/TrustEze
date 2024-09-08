import '../css/HomePage.css';
import { Link } from "react-router-dom";

function AuthenticatedHeader() {

  return (
    <header className="header">

  
        <div className="title-container">
            TRUSTKEYS
            <div className="subtitle">
                <span className="line"></span>
                <span className="subtitle-text">HOMES</span>
            </div>
        </div>

      <nav className="nav-menu">
        <Link to="/">Home</Link>
        <Link to="/listings">Listings</Link>
        <Link to="/about">About</Link>
        <Link to="/contact">Contact</Link>
      </nav>
    </header>
  );
}

export default AuthenticatedHeader;
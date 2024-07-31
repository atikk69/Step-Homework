import React from 'react';
import '../styles/Footer.css'; // Make sure this file exists and contains the CSS

const Footer = () => {
  return (
    <footer className="footer">
      <div className="footer-content">
        <h4 className="footer-title">Let's keep in touch!</h4>
        <h5 className="footer-subtitle">
          Find us on any of these platforms, we respond 1-2 business days.
        </h5>
        <div className="icon-container">
          <a className="icon instagram" aria-label="Instagram" href="https://www.instagram.com/cristiano" target="_blank" rel="noopener noreferrer"></a>
          <a className="icon x" aria-label="X" href="https://x.com/elonmusk" target="_blank" rel="noopener noreferrer"></a>
          <a className="icon codepen" aria-label="CodePen" href="https://codepen.io/megh-bari" target="_blank" rel="noopener noreferrer"></a>
          <a className="icon linkedin" aria-label="LinkedIn" href="https://www.linkedin.com/in/megh-bari-2b0700314/" target="_blank" rel="noopener noreferrer"></a>
          <a className="icon github" aria-label="GitHub" href="https://github.com/atikk69" target="_blank" rel="noopener noreferrer"></a>
        </div>
        <div className="footer-bottom">
          <hr />
          <div className="footer-bottom-content">
            <div className="footer-copyright">
              Copyright © <span id="get-current-year">2024</span> by
              <a href="https://www.creative-tim.com" target="_blank" rel="noopener noreferrer">
                Black Boss
              </a>
            </div>
          </div>
        </div>
      </div>
    </footer>
  );
};

export default Footer;

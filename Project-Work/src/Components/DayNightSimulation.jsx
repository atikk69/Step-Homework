import React, { useState } from 'react';
import '../styles/DayNightSimulation.css'; // Импортируем стили

const DayNightSimulation = () => {
  const [isNight, setIsNight] = useState(false);

  const toggleNightMode = () => {
    setIsNight(!isNight);
  };

  return (
    <div id="fullpage" className={isNight ? 'night' : ''}>
      <div className="section">
        <p id="info">Scroll down...</p>
        <div className="time-circle">
          <div className="sun"></div>
          <div className="moon">
            <div></div>
            <div></div>
            <div></div>
          </div>
          <div className="stars">
            <div></div>
            <div></div>
            <div></div>
            <div></div>
            <div></div>
            <div></div>
            <div></div>
          </div>
          <div className="water"></div>
        </div>
        <div id="intro-text">
          <h1>day night simulation</h1>
          <h4>by Szymon Stypa, inspired by pens on Codepen</h4>
        </div>
      </div>
      <div id="small-switch" className={isNight ? 'switched' : ''} onClick={toggleNightMode}>
        <div id="small-circle"></div>
      </div>
    </div>
  );
};

export default DayNightSimulation;

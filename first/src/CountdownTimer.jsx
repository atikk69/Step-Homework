import React, { useState, useRef, useEffect } from 'react';

const CountdownTimer = () => {
  const [time, setTime] = useState(0);
  const [seconds, setSeconds] = useState(0);
  const [isActive, setIsActive] = useState(false);
  const [isPaused, setIsPaused] = useState(false);
  const intervalRef = useRef(null);

  useEffect(() => {
    if (isActive && !isPaused && seconds > 0) {
      intervalRef.current = setInterval(() => {
        setSeconds((seconds) => seconds - 1);
      }, 1000);
    } else if (seconds === 0) {
      clearInterval(intervalRef.current);
      setIsActive(false);
    }
    return () => clearInterval(intervalRef.current);
  }, [isActive, isPaused, seconds]);

  const handleStart = () => {
    setSeconds(time);
    setIsActive(true);
    setIsPaused(false);
  };

  const handleStop = () => {
    clearInterval(intervalRef.current);
    setIsPaused(true);
  };

  const handleResume = () => {
    setIsPaused(false);
  };

  const handleReset = () => {
    clearInterval(intervalRef.current);
    setSeconds(0);
    setTime(0);
    setIsActive(false);
    setIsPaused(false);
  };

  return (
    <div className="flex flex-col items-center bg-white p-6 rounded-lg shadow-lg">
      <h1 className="text-2xl font-bold mb-4">Countdown Timer</h1>
      <input
        type="number"
        value={time}
        onChange={(e) => setTime(e.target.value)}
        disabled={isActive && !isPaused}
        className="border rounded p-2 mb-4 w-24 text-center"
      />
      <div className="flex space-x-2 mb-4">
        {!isActive && !isPaused && (
          <button onClick={handleStart} className="bg-blue-500 text-white py-2 px-4 rounded">Start</button>
        )}
        {isActive && !isPaused && (
          <button onClick={handleStop} className="bg-yellow-500 text-white py-2 px-4 rounded">Stop</button>
        )}
        {isPaused && (
          <button onClick={handleResume} className="bg-green-500 text-white py-2 px-4 rounded">Resume</button>
        )}
        <button onClick={handleReset} className="bg-red-500 text-white py-2 px-4 rounded">Reset</button>
      </div>
      <div>
        <h2 className="text-xl font-semibold text-blue-600">{seconds} seconds remaining</h2>
      </div>
    </div>
  );
};

export default CountdownTimer;
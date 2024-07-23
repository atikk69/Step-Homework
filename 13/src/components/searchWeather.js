import React, { useState } from 'react';

export default function SearchWeather() {
    const [weatherData, setWeatherData] = useState(null);
    const [loading, setLoading] = useState(false);

    const getWeather = async (event) => {
        event.preventDefault();
        const input = document.getElementById("search").value;

        if (input !== "") {
            setLoading(true);

            try {
                const response = await fetch(`https://api.openweathermap.org/data/2.5/weather?q=${input}&appid=be51dbd00b7b45db76c243848e3ca63f`);
                if (!response.ok) {
                    throw new Error('Network response was not ok ' + response.statusText);
                }
                const data = await response.json();
                setWeatherData(data);
            } catch (error) {
                console.error('Error fetching weather data:', error);
                setWeatherData(null);
            } finally {
                setLoading(false);
            }
        }
    };

    const formatTime = (timestamp) => {
        return new Date(timestamp * 1000).toLocaleTimeString();
    };

    const isDaytime = () => {
        if (!weatherData) return true;
        const currentTime = Math.floor(new Date().getTime() / 1000);
        const sunriseTime = weatherData.sys.sunrise;
        const sunsetTime = weatherData.sys.sunset;
        return currentTime >= sunriseTime && currentTime < sunsetTime;
    };

    return (
        <div style={{ maxWidth: '700px', margin: '100px auto', padding: '20px', border: '1px solid #ccc', borderRadius: '5px', boxShadow: '0 2px 10px rgba(0,0,0,0.1)' }}>
            <form className="flex items-center">
                <label htmlFor="voice-search" className="sr-only">Search</label>
                <div className="relative w-full">
                    <div className="flex absolute inset-y-0 left-0 items-center pl-3 pointer-events-none">
                        <svg aria-hidden="true" className="w-5 h-5 text-gray-500 dark:text-gray-400" fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                            <path fillRule="evenodd" d="M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z" clipRule="evenodd"></path>
                        </svg>
                    </div>
                    <input type="text" id="search" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Azerbaijan, Baku, Moscow..." required />
                    <button type="button" className="flex absolute inset-y-0 right-0 items-center pr-3">
                        <svg aria-hidden="true" className="w-4 h-4 text-gray-500 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white" fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                            <path fillRule="evenodd" d="M7 4a3 3 0 016 0v4a3 3 0 11-6 0V4zm4 10.93A7.001 7.001 0 0017 8a1 1 0 10-2 0A5 5 0 015 8a1 1 0 00-2 0 7.001 7.001 0 006 6.93V17H6a1 1 0 100 2h8a1 1 0 100-2h-3v-2.07z" clipRule="evenodd"></path>
                        </svg>
                    </button>
                </div>
                <button type="submit" className="inline-flex items-center py-2.5 px-3 ml-2 text-sm font-medium text-white bg-blue-700 border border-blue-700 hover:bg-blue-800"
                    onClick={getWeather}>
                    <svg aria-hidden="true" className="mr-2 -ml-1 w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"></path>
                    </svg>
                    Search
                </button>
            </form>

            {loading && <div className="text-center mt-4">Loading...</div>}
            {weatherData && (
                <div className="mt-4">
                    <h2 className="text-2xl font-semibold">{weatherData.name}</h2>
                    <div className="flex items-center">
                        <div className="text-3xl font-bold">
                            {(weatherData.main.temp - 273.15).toFixed(1)} °C
                        </div>
                        <div className="ml-2">
                            <img src={`http://openweathermap.org/img/wn/${weatherData.weather[0].icon}.png`} alt="Weather Icon" />
                        </div>
                    </div>
                    <div className="text-lg mt-2">
                        {weatherData.weather[0].description}
                    </div>
                    <div className="text-lg mt-2">
                        <strong>Sunrise:</strong> {formatTime(weatherData.sys.sunrise)}
                    </div>
                    <div className="text-lg mt-2">
                        <strong>Sunset:</strong> {formatTime(weatherData.sys.sunset)}
                    </div>
                    <div className="mt-4">
                        {isDaytime() ? (
                            <img
                                src="https://vinsweb.org/wp-content/uploads/2020/04/AtHome-Sun-1080x810-1.jpg"
                                alt="Sun Icon"
                                width="200"
                                height="150"
                            />
                        ) : (
                            <img
                                src="https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/FullMoon2010.jpg/1200px-FullMoon2010.jpg"
                                alt="Moon Icon"
                                width="200"
                                height="150"
                            />
                        )}
                    </div>

                </div>
            )}
        </div>
    );
}
import React from 'react';
import './App.css';
import BlogPosts from './components/blog';
import CityInfo from './components/city';
import Movie from './components/movie';

function App() {
  return (
    <div className="App">
      {/* <BlogPosts /> */}
      {/* <CityInfo/> */}
      <Movie/>
    </div>
  );
}

export default App;
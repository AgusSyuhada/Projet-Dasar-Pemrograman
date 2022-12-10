import React, { Component } from 'react';
import Logo from './logounri.png';
import './App.css';
import Account from './components/Account';
import Blog from './components/Blog';
import User from './components/User';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

class App extends Component {
  render() {
    return (
      <Router>
        <div>
          <Link to="/">Home </Link>
          <Link to="/account">| Account </Link>
          <Link to="/Blog">| Blog</Link>

          <hr />
          <img src={Logo} className="App-logo" alt="logo" />

          <Routes>
            <Route exact path="/" element={<User />} />
            <Route path="/account" element={<Account />} />
            <Route path="/blog" element={<Blog />} />
          </Routes>
        </div>
      </Router>
    );
  }
};

export default App;
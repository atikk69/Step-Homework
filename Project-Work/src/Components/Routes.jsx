import React from "react";
import App from "../App";
import Home from "../Pages/Home"
import Catalog from "../Pages/Catalog";
import About from "../Pages/About";
import Login from "../Pages/Login";
import Register from "../Pages/Register";

const authChildren = [
    {
        path: "login",
        element: <Login/>
    },    
    {
        path: "register",
        element: <Register/>
    },

]

const appRoutes = [
    {
        path: "/",
        element: <Home />,
    },
    {
        path: "home",
        element: <Home />,
    },
    {
        path: "catalog",
        element: <Catalog />,
    },
    {
        path: "about",
        element: <About />,
    },
    {
        path: "auth",
        children: authChildren,
    },
]

const app = [
    {
        element: <App />,
        children: appRoutes
    }
];

export default app;
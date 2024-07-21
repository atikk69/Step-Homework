import React from "react";
import App from "../App";
import Home from "../Pages/Home"
import Catalog from "../Pages/Catalog";
import About from "../Pages/About";

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
    }
];

const app = [
    {
        element: <App />,
        children: appRoutes
    }
];

export default app;
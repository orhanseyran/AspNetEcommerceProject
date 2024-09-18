
import ReactDOM from 'react-dom/client';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';

import '@splidejs/react-splide/css';

// or other themes
import '@splidejs/react-splide/css/skyblue';
import '@splidejs/react-splide/css/sea-green';

// or only core styles
import '@splidejs/react-splide/css/core';

import Home from "./pages/Home";
import Product from './pages/Product';
import Cart from './pages/Cart';
import Checkout from './pages/Checkout';
import Shop from './pages/shop';
import Blog from './pages/Blog';
import BlogDetail from './pages/BlogDetail';
import Contact from './pages/contact';
import Login from './components/LoginRegister/Login';





const router = createBrowserRouter([
  {
    path: "/",

    element: < Home />,

  },
  {
    path : "/product-detail/:id",
    element : <Product/>
  },
  {
    path : "/cart",
    element : <Cart/>

  },
  {
    path : "/checkout",
    element : <Checkout/>
  },
  {
    path : "/shop",
    element : <Shop/>

  },
  {
    path : "/blog",
    element : <Blog/>

  },
  {
    path:"/blog-detail/:id",
    element : <BlogDetail/>

  },
  {
    path:"/contact",
    element : <Contact/>
  },
  {
    path:"/login",
    element : <Login/>
  }

]);

ReactDOM.createRoot(document.getElementById("root")).render(

    <RouterProvider router={router} />

);

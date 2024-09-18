import axios from "axios";
import { useState } from "react";


const LoginRegister = () => {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [error,setError] = useState("");

    const Login = (e) => {
        e.preventDefault();


        // Axios POST isteği
        axios.post("http://localhost:5272/LoginRegister/Login", {
            email: email,
            password: password
        }, 
        {
            headers: {
              'Content-Type': 'multipart/form-data'
            }
        })
        .then((res) => {
            console.log(res.data);
            localStorage.setItem("token", res.data.token);
            localStorage.setItem("user", JSON.stringify(res.data.user));
          
                window.location.href = "/";
           
        })
        .catch((err) => {

            console.error('Login failed:', err.response?.data || err.message);
            setError(err.response?.data || err.message);
            setTimeout(() => {
                setError(null);
            }, 5000);
        });
        // console.log(email,password);
    };

    const Logout = () => {
        axios({
            method: 'get',
            url: 'http://localhost:5272/LoginRegister/Logout',
        })
        .then(response => {
            localStorage.removeItem("token");
            localStorage.removeItem("user");
            window.location.href = "/";
            console.log(response);
        })
        .catch(error => {
            setError(error)
            setTimeout(() => {
                setError(null);
            }, 5000);
        });
    };

    return {
        Login,
        error,
        setEmail,
        setPassword,
        email,
        password,
        Logout
    };
}
export default LoginRegister
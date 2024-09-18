import axios from "axios";
import { useState } from "react";
import { useNavigate } from "react-router-dom";


const Products = () => {
    const [products, setProduct] = useState([]);
    const [detail, setDetail] = useState("");


    const getProducts = () => {
        axios({
            method: 'get',
            url: 'http://localhost:5272/Api/Product',
        })
            .then(response => {
                setProduct(response.data);
                
            })
            .catch(error => console.log(error));
    }
    const navigate = useNavigate();
    const ProductDetail = (id) =>{
        axios({
        
            method: 'get',
        
            url: `http://localhost:5272/Api/ProductDetail/${id}`,
        
        
        
        })
        
            .then(response => {


                
                setDetail(response.data);
                
            })
        
            .catch(error => {
                navigate("/")
                console.log(error)
            })
          
    }

    return {
        getProducts,
        products,
        ProductDetail,
        detail
        
    }
}

export default Products;
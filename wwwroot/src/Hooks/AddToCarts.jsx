import axios from "axios";

const AddToCarts = () =>{

    const cartAdd = (id, quantity, username) => {
        axios({
            method: 'post',
            url: `http://localhost:5272/api/ProductAddCart/${id}/${quantity}`,
            data: {
                username: username
            },
            headers: {
               "Content-Type": "multipart/form-data"
                
            }
        })
            .then(response => {
                console.log(response)
            })
            .catch(error => console.log(error));
    }

    return {
        cartAdd
    }
}
export default AddToCarts;
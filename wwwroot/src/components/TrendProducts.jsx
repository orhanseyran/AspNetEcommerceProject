import { useEffect } from "react";
import Products from "../Hooks/Products";
import Deals from "./HomeComponents/Deals";
import TrendingProduct from "./HomeComponents/TrendingProduct";


export default function TrendProducts() {
  const { products ,getProducts } = Products();
  useEffect(() => {
    getProducts();
  }, []);
  console.log(products);
  
  return (
    <div>
<section className="bg-grey-1 section-padding pt-100 pb-80 mb-80">
  <div className="container">
    <h1 className="mb-80 text-center">Trend Ürünler</h1>
    <div className="row product-grid">
      {products.map((product) => (
        <TrendingProduct key={product.id} product={product} />
      ))}
     

      {/*end product card*/}
    </div>
    {/*row*/}
    <h1 className="text-center mt-100 mb-80">En Çok Satılanlar</h1>
    <div className="row">
        <Deals/>



    </div>
  </div>
</section>

      
    </div>
  )
}

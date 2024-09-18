import { Link } from "react-router-dom";

export default function MinProduct() {
  return (
    <article className="row align-items-center hover-up">
    <figure className="col-md-4 mb-0">
    <Link to="/product-detail/1"><a href="shop-product-right.html"><img src="/src/assets/imgs/shop/thumbnail-3.jpg" alt /></a></Link>  
    </figure>
    <div className="col-md-8 mb-0">
      <h6>
       <Link to="/product-detail/1"><a href="">Nestle Original Coffee-Mate Coffee Creamer</a></Link> 
      </h6>
      <div className="product-rate-cover">
        <div className="product-rate d-inline-block">
          <div className="product-rating" style={{width: '90%'}} />
        </div>
        <span className="font-small ml-5 text-muted"> (4.0)</span>
      </div>
      <div className="product-price">
        <span>$32.85</span>
        <span className="old-price">$33.8</span>
      </div>
    </div>
  </article>
  )
}

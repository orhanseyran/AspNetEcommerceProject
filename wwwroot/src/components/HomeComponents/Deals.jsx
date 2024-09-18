import { Link } from "react-router-dom";

export default function Deals() {
  return (
<div className="col-xl-3 col-lg-4 col-md-6">
  <div className="product-cart-wrap style-2 wow animate__animated animate__fadeInUp" data-wow-delay={0}>
    <div className="product-img-action-wrap">
      <div className="product-img">
        <Link to="/product-detail/1">
          <a>
            <img src="/src/assets/imgs/banner/banner-5.png" alt="Ürün Resmi" />
          </a>
        </Link>
      </div>
    </div>
    <div className="product-content-wrap">
      <div className="deals-countdown-wrap">
        <div className="deals-countdown" data-countdown="2025/03/25 00:00:00" />
      </div>
      <div className="deals-content">
        <h2><a href="shop-product-right.html">Baldo Prinç </a></h2>
        <div className="product-rate-cover">
          <div className="product-rate d-inline-block">
            <div className="product-rating" style={{width: '90%'}} />
          </div>
          <span className="font-small ml-5 text-muted"> (4.0)</span>
        </div>
        <div>
          <span className="font-small text-muted">Üretici: <a href="vendor-details-1.html">adresimde.com</a></span>
        </div>
        <div className="product-card-bottom">
          <div className="product-price">
            <span>90 TL</span>
            <span className="old-price">120 TL</span>
          </div>
          <div className="add-cart">
            <Link to="/product-detail/1">
              <a className="add" href="shop-cart.html"><i className="fi-rs-shopping-cart mr-5" />Ürünü İncele</a>
            </Link>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>

  )
}

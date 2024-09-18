import { Link } from "react-router-dom";


import PropTypes from 'prop-types';


export default function TrendingProduct({ product }) {
  return (
    <div className="col-lg-1-5 col-md-4 col-12 col-sm-6">
        <div className="product-cart-wrap mb-30">
          <div className="product-img-action-wrap">
            <div className="product-img product-img-zoom">
              <Link to="/product-detail/1">
                <img className="default-img" src="/src/assets/imgs/shop/product-1-1.jpg" alt="" />
                <img className="hover-img" src="/src/assets/imgs/shop/product-1-2.jpg" alt="" />
              </Link>
            </div>
            <div className="product-action-1">
              <a aria-label="Add To Wishlist" className="action-btn" href="shop-wishlist.html"><i className="fi-rs-heart" /></a>
              <a aria-label="Compare" className="action-btn" href="shop-compare.html"><i className="fi-rs-shuffle" /></a>
            </div>
            <div className="product-badges product-badges-position product-badges-mrg">
              <span className="hot">Yeni Eklenen</span>
            </div>
          </div>
          <div className="product-content-wrap">
            <div className="product-category">
              <a href="shop-grid-right.html">Sebze</a>
            </div>
            <Link to={`/product-detail/${product.id}`}>
              <h2>{product.name}</h2>
            </Link>
            <div className="product-rate-cover">
              <div className="product-rate d-inline-block">
                <div className="product-rating" style={{width: '90%'}} />
              </div>
              <span className="font-small ml-5 text-muted"> (4.0)</span>
            </div>
            <div>
              <span className="font-small text-muted">By <a href="vendor-details-1.html">adresimde.com</a></span>
            </div>
            <div className="product-card-bottom">
              <div className="product-price">
                <span>20 TL</span>
                <span className="old-price">32.8 TL</span>
              </div>
              <div className="add-cart">
                <Link to="/product-detail/1" className="add">
                  <i className="fi-rs-shopping-cart mr-5" />Satın Al
                </Link> 
              </div>
            </div>
          </div>
        </div>
      </div>
  )
}

TrendingProduct.propTypes = {
  product: PropTypes.shape({
    name: PropTypes.string.isRequired,
    id: PropTypes.oneOfType([PropTypes.string, PropTypes.number]).isRequired,
  }).isRequired,
}



export default function ShopProducts() {
  return (
    <div className="col-lg-1-5 col-md-4 col-12 col-sm-6">
    <div className="product-cart-wrap mb-30">
      <div className="product-img-action-wrap">
        <div className="product-img product-img-zoom">
          <a href="shop-product-right.html">
            <img className="default-img" src="/src/assets/imgs/shop/product-1-1.jpg" alt />
            <img className="hover-img" src="/src/assets/imgs/shop/product-1-2.jpg" alt />
          </a>
        </div>
        <div className="product-action-1">
          <a aria-label="Add To Wishlist" className="action-btn" href="shop-wishlist.html"><i className="fi-rs-heart" /></a>
          <a aria-label="Compare" className="action-btn" href="shop-compare.html"><i className="fi-rs-shuffle" /></a>
          <a aria-label="Quick view" className="action-btn" data-bs-toggle="modal" data-bs-target="#quickViewModal"><i className="fi-rs-eye" /></a>
        </div>
        <div className="product-badges product-badges-position product-badges-mrg">
          <span className="hot">Hot</span>
        </div>
      </div>
      <div className="product-content-wrap">
        <div className="product-category">
          <a href="shop-grid-right.html">Snack</a>
        </div>
        <h2><a href="shop-product-right.html">Seeds of Change Organic Quinoe</a></h2>
        <div className="product-rate-cover">
          <div className="product-rate d-inline-block">
            <div className="product-rating" style={{width: '90%'}} />
          </div>
          <span className="font-small ml-5 text-muted"> (4.0)</span>
        </div>
        <div>
          <span className="font-small text-muted">By <a href="vendor-details-1.html">NestFood</a></span>
        </div>
        <div className="product-card-bottom">
          <div className="product-price">
            <span>$28.85</span>
            <span className="old-price">$32.8</span>
          </div>
          <div className="add-cart">
            <a className="add" href="shop-cart.html"><i className="fi-rs-shopping-cart mr-5" />Add </a>
          </div>
        </div>
      </div>
    </div>
  </div>
  )
}


export default function Related() {
  return (
    <div className="col-lg-3 col-md-4 col-12 col-sm-6">
    <div className="product-cart-wrap hover-up">
      <div className="product-img-action-wrap">
        <div className="product-img product-img-zoom">
          <a href="shop-product-right.html" tabIndex={0}>
            <img className="default-img" src="/src/assets/imgs/shop/product-2-1.jpg" alt />
            <img className="hover-img" src="/src/assets/imgs/shop/product-2-2.jpg" alt />
          </a>
        </div>
        <div className="product-action-1">
          <a aria-label="Quick view" className="action-btn small hover-up" data-bs-toggle="modal" data-bs-target="#quickViewModal"><i className="fi-rs-search" /></a>
          <a aria-label="Add To Wishlist" className="action-btn small hover-up" href="shop-wishlist.html" tabIndex={0}><i className="fi-rs-heart" /></a>
          <a aria-label="Compare" className="action-btn small hover-up" href="shop-compare.html" tabIndex={0}><i className="fi-rs-shuffle" /></a>
        </div>
        <div className="product-badges product-badges-position product-badges-mrg">
          <span className="hot">Hot</span>
        </div>
      </div>
      <div className="product-content-wrap">
        <h2><a href="shop-product-right.html" tabIndex={0}>Ulstra Bass Headphone</a></h2>
        <div className="rating-result" title="90%">
          <span> </span>
        </div>
        <div className="product-price">
          <span>$238.85 </span>
          <span className="old-price">$245.8</span>
        </div>
      </div>
    </div>
  </div>
  )
}

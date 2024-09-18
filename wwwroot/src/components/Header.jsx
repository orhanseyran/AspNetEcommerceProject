import { Link } from "react-router-dom";
import LoginRegister from "../Hooks/LoginRegister";


export default function Header() {
  var token = localStorage.getItem("token");
  var user = localStorage.getItem("user");
  const auth = JSON.parse(user);

  const {Logout} = LoginRegister();


  return (
<div>
<div className="modal fade custom-modal" id="quickViewModal" aria-labelledby="quickViewModalLabel" aria-hidden="true">
  <div className="modal-dialog">
    <div className="modal-content">
      <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" />
      <div className="modal-body">
        <div className="row">
          <div className="col-md-6 col-sm-12 col-xs-12 mb-md-0 mb-sm-5">
            <div className="detail-gallery">
              <span className="zoom-icon"><i className="fi-rs-search" /></span>
              {/* MAIN SLIDES */}
              <div className="product-image-slider">
                <figure className="border-radius-10">
                  <img src="assets/imgs/shop/product-16-2.jpg" alt="product image" />
                </figure>
                <figure className="border-radius-10">
                  <img src="assets/imgs/shop/product-16-1.jpg" alt="product image" />
                </figure>
                <figure className="border-radius-10">
                  <img src="assets/imgs/shop/product-16-3.jpg" alt="product image" />
                </figure>
                <figure className="border-radius-10">
                  <img src="assets/imgs/shop/product-16-4.jpg" alt="product image" />
                </figure>
                <figure className="border-radius-10">
                  <img src="assets/imgs/shop/product-16-5.jpg" alt="product image" />
                </figure>
                <figure className="border-radius-10">
                  <img src="assets/imgs/shop/product-16-6.jpg" alt="product image" />
                </figure>
                <figure className="border-radius-10">
                  <img src="assets/imgs/shop/product-16-7.jpg" alt="product image" />
                </figure>
              </div>
              {/* THUMBNAILS */}
              <div className="slider-nav-thumbnails">
                <div><img src="assets/imgs/shop/thumbnail-3.jpg" alt="product image" /></div>
                <div><img src="assets/imgs/shop/thumbnail-4.jpg" alt="product image" /></div>
                <div><img src="assets/imgs/shop/thumbnail-5.jpg" alt="product image" /></div>
                <div><img src="assets/imgs/shop/thumbnail-6.jpg" alt="product image" /></div>
                <div><img src="assets/imgs/shop/thumbnail-7.jpg" alt="product image" /></div>
                <div><img src="assets/imgs/shop/thumbnail-8.jpg" alt="product image" /></div>
                <div><img src="assets/imgs/shop/thumbnail-9.jpg" alt="product image" /></div>
              </div>
            </div>
            {/* End Gallery */}
          </div>
          <div className="col-md-6 col-sm-12 col-xs-12">
            <div className="detail-info pr-30 pl-30">
              <span className="stock-status out-stock"> Sale Off </span>
              <h3 className="title-detail"><a href="shop-product-right.html" className="text-heading">Seeds of Change Organic Quinoa, Brown</a></h3>
              <div className="product-detail-rating">
                <div className="product-rate-cover text-end">
                  <div className="product-rate d-inline-block">
                    <div className="product-rating" style={{width: '90%'}} />
                  </div>
                  <span className="font-small ml-5 text-muted"> (32 reviews)</span>
                </div>
              </div>
              <div className="clearfix product-price-cover">
                <div className="product-price primary-color float-left">
                  <span className="current-price text-brand">$38</span>
                  <span>
                    <span className="save-price font-md color3 ml-15">26% Off</span>
                    <span className="old-price font-md ml-15">$52</span>
                  </span>
                </div>
              </div>
              <div className="detail-extralink mb-30">
                <div className="detail-qty border radius">
                  <a href="#" className="qty-down"><i className="fi-rs-angle-small-down" /></a>
                  <span className="qty-val">1</span>
                  <a href="#" className="qty-up"><i className="fi-rs-angle-small-up" /></a>
                </div>
                <div className="product-extra-link2">
                  <button type="submit" className="button button-add-to-cart"><i className="fi-rs-shopping-cart" />Add to cart</button>
                </div>
              </div>
              <div className="font-xs">
                <ul>
                  <li className="mb-5">Vendor: <span className="text-brand">Nest</span></li>
                  <li className="mb-5">MFG:<span className="text-brand"> Jun 4.2022</span></li>
                </ul>
              </div>
            </div>
            {/* Detail Info */}
          </div>
        </div>
      </div>
    </div>
  </div>
</div>

  <header className="header-area header-style-2 header-style-2 header-height-2">
    <div className="mobile-promotion">
      <span>Grand opening, <strong>up to 15%</strong> off all items. Only <strong>3 days</strong> left</span>
    </div>
    <div className="header-top header-top-ptb-1 d-none d-lg-block">
      <div className="container">
        <div className="row align-items-center">
          <div className="col-xl-3 col-lg-4">
            <div className="header-info">
              <ul>
                <li><a href="page-about.htlm">Biz Kimiz</a></li>
                <li><a href="page-account.html">Hesabım</a></li>
                <li><a href="shop-wishlist.html">Beğeni Listem</a></li>
                <li><a href="shop-order.html">Sipariş Takip</a></li>
              </ul>
            </div>
          </div>

          <div className="col-xl-3 col-lg-4">
            <div className="header-info header-info-right">
        
            </div>
          </div>
        </div>
      </div>
    </div>
    <div className="header-middle header-middle-ptb-1 d-none d-lg-block">
      <div className="container">
        <div className="header-wrap">
          <div  className="logo text-end ">
           <Link to="/" ><a><img src="/src/assets/logo.png" alt="logo" style={{ width:280 }} /></a></Link> 
          </div>
          <div className="header-right">
            <div style={{ marginLeft:100 }} className="search-style-2">
              <form action="#">

                <input style={{ textAlign:"center" }} type="text" placeholder="Şimdi Ürün Ara..." />
              </form>
            </div>
            <div className="header-action-right">
              <div className="header-action-2">

                <div className="header-action-icon-2">
                  <a href="shop-compare.html">
                    <img className="svgInject" alt="Nest" src="/src/assets/imgs/theme/icons/icon-compare.svg" />
                    <span className="pro-count blue">3</span>
                  </a>
                  <a href="shop-compare.html"><span className="lable ml-0">Karşılaştır</span></a>
                </div>
                <div className="header-action-icon-2">
                  <a href="shop-wishlist.html">
                    <img className="svgInject" alt="Nest" src="/src/assets/imgs/theme/icons/icon-heart.svg" />
                    <span className="pro-count blue">6</span>
                  </a>
                  <a href="shop-wishlist.html"><span className="lable">Beğeniler</span></a>
                </div>
                <div className="header-action-icon-2">
                  <a className="mini-cart-icon" href="shop-cart.html">
                    <img alt="Nest" src="/src/assets/imgs/theme/icons/icon-cart.svg" />
                    <span className="pro-count blue">2</span>
                  </a>
                  <a href="shop-cart.html"><span className="lable">Sepetim</span></a>
                  <div className="cart-dropdown-wrap cart-dropdown-hm2">
                    <ul>
                      <li>
                        <div className="shopping-cart-img">
                          <a href="shop-product-right.html"><img alt="Nest" src="/src/assets/imgs/shop/thumbnail-3.jpg" /></a>
                        </div>
                        <div className="shopping-cart-title">
                          <h4><a href="shop-product-right.html">Daisy Casual Bag</a></h4>
                          <h4><span>1 × </span>$800.00</h4>
                        </div>
                        <div className="shopping-cart-delete">
                          <a href="#"><i className="fi-rs-cross-small" /></a>
                        </div>
                      </li>

                    </ul>
                    <div className="shopping-cart-footer">
                      <div className="shopping-cart-total">
                        <h4>Total <span>$4000.00</span></h4>
                      </div>
                      <div className="shopping-cart-button">
                       <Link to="/cart"><a>Sepetim</a></Link> 
                       <Link to="/checkout"><a >Ödeme</a></Link> 
                      </div>
                    </div>
                  </div>
                </div>
                
                <div className="header-action-icon-2">
                  {
                    token ?
                    (
                    <div className="header-action-icon-2">
                      <a href="page-account.html">
                        <img className="svgInject" alt="Nest" src="/src/assets/imgs/theme/icons/icon-user.svg" />
                      </a>
                      <a href="page-account.html"><span className="lable ml-0">  {auth.userName } </span></a>
                      <div className="cart-dropdown-wrap cart-dropdown-hm2 account-dropdown">
                        <ul>
                          <li><a href="page-account.html"><i className="fi fi-rs-user mr-10" />My Account</a></li>
                          <li><a href="page-account.html"><i className="fi fi-rs-location-alt mr-10" />Order Tracking</a></li>
                          <li><a href="page-account.html"><i className="fi fi-rs-label mr-10" />My Voucher</a></li>
                          <li><a href="shop-wishlist.html"><i className="fi fi-rs-heart mr-10" />My Wishlist</a></li>
                          <li><a href="page-account.html"><i className="fi fi-rs-settings-sliders mr-10" />Setting</a></li>
                          <li><a onClick={Logout}><i className="fi fi-rs-sign-out mr-10" />Çıkış Yap</a></li>
                        </ul>
                      </div>
                    </div>


                    ):
                     (
                      <div>
                   <a href="page-account.html">
                      <img className="svgInject" alt="Nest" src="/src/assets/imgs/theme/icons/icon-user.svg" />
                    </a>
                    <Link to="/login" ><a href="/login"><span className="lable ml-0">Giriş Yap</span></a></Link>
                      </div>
         
                    )

                  }

                  {/* <div className="cart-dropdown-wrap cart-dropdown-hm2 account-dropdown">
                    <ul>
                      <li>
                        <a href="page-account.html"><i className="fi fi-rs-user mr-10" />My Account</a>
                      </li>
                      <li>
                        <a href="page-account.html"><i className="fi fi-rs-location-alt mr-10" />Order Tracking</a>
                      </li>
                      <li>
                        <a href="page-account.html"><i className="fi fi-rs-label mr-10" />My Voucher</a>
                      </li>
                      <li>
                        <a href="shop-wishlist.html"><i className="fi fi-rs-heart mr-10" />My Wishlist</a>
                      </li>
                      <li>
                        <a href="page-account.html"><i className="fi fi-rs-settings-sliders mr-10" />Setting</a>
                      </li>
                      <li>
                        <a href="page-login.html"><i className="fi fi-rs-sign-out mr-10" />Sign out</a>
                      </li>
                    </ul>
                  </div>  */}
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div className="header-bottom header-bottom-bg-color sticky-bar">
      <div className="container">
        <div className="header-wrap header-space-between position-relative">
          <div className="logo logo-width-1 d-block d-lg-none">
            <a href="index.html"><img src="/src/assets/logo.png" alt="logo" /></a>
          </div>
          <div className="header-nav d-none d-lg-flex">
            <div className="main-categori-wrap d-none d-lg-block">
              <a className="categories-button-active" >
                <span className="fi-rs-apps" /> <span className="et">Trend</span> Kategoriler
                <i className="fi-rs-angle-down" />
              </a>
              <div className="categories-dropdown-wrap categories-dropdown-active-large font-heading">
                <div className="d-flex categori-dropdown-inner">
                  <ul>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-1.svg" alt />Milks and Dairies</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-2.svg" alt />Clothing &amp; beauty</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-3.svg" alt />Pet Foods &amp; Toy</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-4.svg" alt />Baking material</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-5.svg" alt />Fresh Fruit</a>
                    </li>
                  </ul>
                  <ul className="end">
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-6.svg" alt />Wines &amp; Drinks</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-7.svg" alt />Fresh Seafood</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-8.svg" alt />Fast food</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-9.svg" alt />Vegetables</a>
                    </li>
                    <li>
                      <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-10.svg" alt />Bread and Juice</a>
                    </li>
                  </ul>
                </div>
                <div className="more_slide_open" style={{display: 'none'}}>
                  <div className="d-flex categori-dropdown-inner">
                    <ul>
                      <li>
                        <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/icon-1.svg" alt />Milks and Dairies</a>
                      </li>
                      <li>
                        <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/icon-2.svg" alt />Clothing &amp; beauty</a>
                      </li>
                    </ul>
                    <ul className="end">
                      <li>
                        <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/icon-3.svg" alt />Wines &amp; Drinks</a>
                      </li>
                      <li>
                        <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/icon-4.svg" alt />Fresh Seafood</a>
                      </li>
                    </ul>
                  </div>
                </div>
                <div className="more_categories"><span className="icon" /> <span className="heading-sm-1">Show more...</span></div>
              </div>
            </div>
            <div className="main-menu main-menu-padding-1 main-menu-lh-2 d-none d-lg-block font-heading">
              <nav>
                <ul>
                  <li className="hot-deals"><img src="/src/assets/imgs/theme/icons/icon-hot-white.svg" alt="hot deals" /> <Link to="/shop">Yeni Gelenler</Link></li>
                  <li>
                   <Link to="/"><a >Ana Sayfa</a></Link> 
                  </li>
                  {/* <li>
                    <a href="page-about.html">About</a>
                  </li> */}
                  <li>
                    <Link to="/shop">Mağaza
                    </Link>
                  </li>


                  <li>
                   <Link to="/blog">Blog </Link> 

                  </li>

                  <li>
                   <Link to="/contact">İletişim</Link> 
                  </li>
                </ul>
              </nav>
            </div>
          </div>
          <div className="hotline d-none d-lg-flex">
            <img src="/src/assets/imgs/theme/icons/icon-headphone-white.svg" alt="hotline" />
            <p>05527898945<span>24/7 Destek</span></p>
          </div>
          <div className="header-action-icon-2 d-block d-lg-none">
            <div className="burger-icon burger-icon-white">
              <span className="burger-icon-top" />
              <span className="burger-icon-mid" />
              <span className="burger-icon-bottom" />
            </div>
          </div>
          <div className="header-action-right d-block d-lg-none">
            <div className="header-action-2">
              <div className="header-action-icon-2">
                <a href="shop-wishlist.html">
                  <img alt="Nest" src="/src/assets/imgs/theme/icons/icon-heart.svg" />
                  <span className="pro-count white">4</span>
                </a>
              </div>
              <div className="header-action-icon-2">
                <a className="mini-cart-icon" href="#">
                  <img alt="Nest" src="/src/assets/imgs/theme/icons/icon-cart.svg" />
                  <span className="pro-count white">2</span>
                </a>
                <div className="cart-dropdown-wrap cart-dropdown-hm2">
                  <ul>
                    <li>
                      <div className="shopping-cart-img">
                        <a href="shop-product-right.html"><img alt="Nest" src="/src/assets/imgs/shop/thumbnail-3.jpg" /></a>
                      </div>
                      <div className="shopping-cart-title">
                        <h4><a href="shop-product-right.html">Plain Striola Shirts</a></h4>
                        <h3><span>1 × </span>$800.00</h3>
                      </div>
                      <div className="shopping-cart-delete">
                        <a href="#"><i className="fi-rs-cross-small" /></a>
                      </div>
                    </li>
                    <li>
                      <div className="shopping-cart-img">
                        <a href="shop-product-right.html"><img alt="Nest" src="/src/assets/imgs/shop/thumbnail-4.jpg" /></a>
                      </div>
                      <div className="shopping-cart-title">
                        <h4><a href="shop-product-right.html">Macbook Pro 2022</a></h4>
                        <h3><span>1 × </span>$3500.00</h3>
                      </div>
                      <div className="shopping-cart-delete">
                        <a href="#"><i className="fi-rs-cross-small" /></a>
                      </div>
                    </li>
                  </ul>
                  <div className="shopping-cart-footer">
                    <div className="shopping-cart-total">
                      <h4>Total <span>$383.00</span></h4>
                    </div>
                    <div className="shopping-cart-button">
                    <Link to="/cart">Sepetim</Link>  
                      <Link to="/checkout">Ödeme</Link> 

                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </header>
<div className="mobile-header-active mobile-header-wrapper-style">
  <div className="mobile-header-wrapper-inner">
    <div className="mobile-header-top">
      <div className="mobile-header-logo">
       <Link to="/"><a href="index.html"><img src="/src/assets/logo.png" alt="logo" /></a></Link> 
      </div>
      <div className="mobile-menu-close close-style-wrap close-style-position-inherit">
        <button className="close-style search-close">
          <i className="icon-top" />
          <i className="icon-bottom" />
        </button>
      </div>
    </div>
    <div className="mobile-header-content-area">
      <div className="mobile-search search-style-3 mobile-header-border">
        <form action="#">
          <input type="text" placeholder="Search for items…" />
          <button type="submit"><i className="fi-rs-search" /></button>
        </form>
      </div>
      <div className="mobile-menu-wrap mobile-header-border">
        {/* mobile menu start */}
        <nav>
          <ul className="mobile-menu font-heading">
            <li className="menu-item-has-children">
              <a href="index.html">Home</a>
              <ul className="dropdown">
                <li><a href="index.html">Home 1</a></li>
                <li><a href="index-2.html">Home 2</a></li>
                <li><a href="index-3.html">Home 3</a></li>
                <li><a href="index-4.html">Home 4</a></li>
                <li><a href="index-5.html">Home 5</a></li>
                <li><a href="index-6.html">Home 6</a></li>
              </ul>
            </li>
            <li className="menu-item-has-children">
              <a href="shop-grid-right.html">shop</a>
              <ul className="dropdown">
                <li><a href="shop-grid-right.html">Shop Grid – Right Sidebar</a></li>
                <li><a href="shop-grid-left.html">Shop Grid – Left Sidebar</a></li>
                <li><a href="shop-list-right.html">Shop List – Right Sidebar</a></li>
                <li><a href="shop-list-left.html">Shop List – Left Sidebar</a></li>
                <li><a href="shop-fullwidth.html">Shop - Wide</a></li>
                <li className="menu-item-has-children">
                  <a href="#">Single Product</a>
                  <ul className="dropdown">
                    <li><a href="shop-product-right.html">Product – Right Sidebar</a></li>
                    <li><a href="shop-product-left.html">Product – Left Sidebar</a></li>
                    <li><a href="shop-product-full.html">Product – No sidebar</a></li>
                    <li><a href="shop-product-vendor.html">Product – Vendor Infor</a></li>
                  </ul>
                </li>
                <li><a href="shop-filter.html">Shop – Filter</a></li>
                <li><a href="shop-wishlist.html">Shop – Wishlist</a></li>
                <li><a href="shop-cart.html">Shop – Cart</a></li>
                <li><a href="shop-checkout.html">Shop – Checkout</a></li>
                <li><a href="shop-compare.html">Shop – Compare</a></li>
                <li className="menu-item-has-children">
                  <a href="#">Shop Invoice</a>
                  <ul className="dropdown">
                    <li><a href="shop-invoice-1.html">Shop Invoice 1</a></li>
                    <li><a href="shop-invoice-2.html">Shop Invoice 2</a></li>
                    <li><a href="shop-invoice-3.html">Shop Invoice 3</a></li>
                    <li><a href="shop-invoice-4.html">Shop Invoice 4</a></li>
                    <li><a href="shop-invoice-5.html">Shop Invoice 5</a></li>
                    <li><a href="shop-invoice-6.html">Shop Invoice 6</a></li>
                  </ul>
                </li>
              </ul>
            </li>
            <li className="menu-item-has-children">
              <a href="#">Vendors</a>
              <ul className="dropdown">
                <li><a href="vendors-grid.html">Vendors Grid</a></li>
                <li><a href="vendors-list.html">Vendors List</a></li>
                <li><a href="vendor-details-1.html">Vendor Details 01</a></li>
                <li><a href="vendor-details-2.html">Vendor Details 02</a></li>
                <li><a href="vendor-dashboard.html">Vendor Dashboard</a></li>
                <li><a href="vendor-guide.html">Vendor Guide</a></li>
              </ul>
            </li>
            <li className="menu-item-has-children">
              <a href="#">Mega menu</a>
              <ul className="dropdown">
                <li className="menu-item-has-children">
                  <a href="#"> Fashion</a>
                  <ul className="dropdown">
                    <li><a href="shop-product-right.html">Dresses</a></li>
                    <li><a href="shop-product-right.html">Blouses &amp; Shirts</a></li>
                    <li><a href="shop-product-right.html">Hoodies &amp; Sweatshirts</a></li>
                    <li><a href="shop-product-right.html"> Sets</a></li>
                  </ul>
                </li>
                <li className="menu-item-has-children">
                  <a href="#"> Fashion</a>
                  <ul className="dropdown">
                    <li><a href="shop-product-right.html">Jackets</a></li>
                    <li><a href="shop-product-right.html">Casual Faux Leather</a></li>
                    <li><a href="shop-product-right.html">Genuine Leather</a></li>
                  </ul>
                </li>
                <li className="menu-item-has-children">
                  <a href="#">Technology</a>
                  <ul className="dropdown">
                    <li><a href="shop-product-right.html">Gaming Laptops</a></li>
                    <li><a href="shop-product-right.html">Ultraslim Laptops</a></li>
                    <li><a href="shop-product-right.html">Tablets</a></li>
                    <li><a href="shop-product-right.html">Laptop Accessories</a></li>
                    <li><a href="shop-product-right.html">Tablet Accessories</a></li>
                  </ul>
                </li>
              </ul>
            </li>
            <li className="menu-item-has-children">
              <a href="blog-category-fullwidth.html">Blog</a>
              <ul className="dropdown">
                <li><a href="blog-category-grid.html">Blog Category Grid</a></li>
                <li><a href="blog-category-list.html">Blog Category List</a></li>
                <li><a href="blog-category-big.html">Blog Category Big</a></li>
                <li><a href="blog-category-fullwidth.html">Blog Category Wide</a></li>
                <li className="menu-item-has-children">
                  <a href="#">Single Product Layout</a>
                  <ul className="dropdown">
                    <li><a href="blog-post-left.html">Left Sidebar</a></li>
                    <li><a href="blog-post-right.html">Right Sidebar</a></li>
                    <li><a href="blog-post-fullwidth.html">No Sidebar</a></li>
                  </ul>
                </li>
              </ul>
            </li>
            <li className="menu-item-has-children">
              <a href="#">Pages</a>
              <ul className="dropdown">
                <li><a href="page-about.html">About Us</a></li>
                <li><a href="page-contact.html">Contact</a></li>
                <li><a href="page-account.html">My Account</a></li>
                <li><a href="page-login.html">Login</a></li>
                <li><a href="page-register.html">Register</a></li>
                <li><a href="page-forgot-password.html">Forgot password</a></li>
                <li><a href="page-reset-password.html">Reset password</a></li>
                <li><a href="page-purchase-guide.html">Purchase Guide</a></li>
                <li><a href="page-privacy-policy.html">Privacy Policy</a></li>
                <li><a href="page-terms.html">Terms of Service</a></li>
                <li><a href="page-404.html">404 Page</a></li>
              </ul>
            </li>
            <li className="menu-item-has-children">
              <a href="#">Language</a>
              <ul className="dropdown">
                <li><a href="#">English</a></li>
                <li><a href="#">French</a></li>
                <li><a href="#">German</a></li>
                <li><a href="#">Spanish</a></li>
              </ul>
            </li>
          </ul>
        </nav>
        {/* mobile menu end */}
      </div>
      <div className="mobile-header-info-wrap">
        <div className="single-mobile-header-info">
          <a href="page-contact.html"><i className="fi-rs-marker" /> Our location </a>
        </div>
        <div className="single-mobile-header-info">
          <a href="page-login.html"><i className="fi-rs-user" />Log In / Sign Up </a>
        </div>
        <div className="single-mobile-header-info">
          <a href="#"><i className="fi-rs-headphones" />(+01) - 2345 - 6789 </a>
        </div>
      </div>
      <div className="mobile-social-icon mb-50">
        <h6 className="mb-15">Follow Us</h6>
        <a href="#"><img src="assets/imgs/theme/icons/icon-facebook-white.svg" alt /></a>
        <a href="#"><img src="assets/imgs/theme/icons/icon-twitter-white.svg" alt /></a>
        <a href="#"><img src="assets/imgs/theme/icons/icon-instagram-white.svg" alt /></a>
        <a href="#"><img src="assets/imgs/theme/icons/icon-pinterest-white.svg" alt /></a>
        <a href="#"><img src="assets/imgs/theme/icons/icon-youtube-white.svg" alt /></a>
      </div>
      <div className="site-copyright">Copyright 2022 © Nest. All rights reserved. Powered by AliThemes.</div>
    </div>
  </div>
</div>

</div>

  )
}

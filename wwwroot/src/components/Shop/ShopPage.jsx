import ShopProducts from "./Components/ShopProducts";

export default function ShopPage() {
  return (
<main className="main">
  <div className="page-header mt-30 mb-50">
    <div className="container">
      <div className="archive-header">
        <div className="row align-items-center">
          <div className="col-xl-3">
            <h1 className="mb-15">Atıştırmalık</h1>
            <div className="breadcrumb">
              <a href="index.html" rel="nofollow"><i className="fi-rs-home mr-5" />Anasayfa</a>
              <span /> Mağaza <span /> Atıştırmalık
            </div>
          </div>
          <div className="col-xl-9 text-end d-none d-xl-block">
            <ul className="tags-list">
              <li className="hover-up">
                <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Lahana</a>
              </li>
              <li className="hover-up active">
                <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Brokoli</a>
              </li>
              <li className="hover-up">
                <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Enginar</a>
              </li>
              <li className="hover-up">
                <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Kereviz</a>
              </li>
              <li className="hover-up mr-0">
                <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Ispanak</a>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div className="container mb-30">
    <div className="row flex-row-reverse">
      <div className="col-lg-4-5">
        <div className="shop-product-fillter">
          <div className="totall-product">
            <p>Sizin için <strong className="text-brand">29</strong> ürün bulduk!</p>
          </div>
          <div className="sort-by-product-area">
            <div className="sort-by-cover mr-10">
              <div className="sort-by-product-wrap">
                <div className="sort-by">
                  <span><i className="fi-rs-apps" />Göster:</span>
                </div>
                <div className="sort-by-dropdown-wrap">
                  <span> 50 <i className="fi-rs-angle-small-down" /></span>
                </div>
              </div>
              <div className="sort-by-dropdown">
                <ul>
                  <li><a className="active" href="#">50</a></li>
                  <li><a href="#">100</a></li>
                  <li><a href="#">150</a></li>
                  <li><a href="#">200</a></li>
                  <li><a href="#">Tümü</a></li>
                </ul>
              </div>
            </div>
            <div className="sort-by-cover">
              <div className="sort-by-product-wrap">
                <div className="sort-by">
                  <span><i className="fi-rs-apps-sort" />Sıralama:</span>
                </div>
                <div className="sort-by-dropdown-wrap">
                  <span> Öne Çıkanlar <i className="fi-rs-angle-small-down" /></span>
                </div>
              </div>
              <div className="sort-by-dropdown">
                <ul>
                  <li><a className="active" href="#">Öne Çıkanlar</a></li>
                  <li><a href="#">Fiyat: Düşükten Yükseğe</a></li>
                  <li><a href="#">Fiyat: Yüksekten Düşüğe</a></li>
                  <li><a href="#">Çıkış Tarihi</a></li>
                  <li><a href="#">Ortalama Puan</a></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
        <div className="row product-grid">
            <ShopProducts/>

        </div>
        <div className="pagination-area mt-20 mb-20">
          <nav aria-label="Page navigation example">
            <ul className="pagination justify-content-start">
              <li className="page-item">
                <a className="page-link" href="#"><i className="fi-rs-arrow-small-left" /></a>
              </li>
              <li className="page-item"><a className="page-link" href="#">1</a></li>
              <li className="page-item active"><a className="page-link" href="#">2</a></li>
              <li className="page-item"><a className="page-link" href="#">3</a></li>
              <li className="page-item"><a className="page-link dot" href="#">...</a></li>
              <li className="page-item"><a className="page-link" href="#">6</a></li>
              <li className="page-item">
                <a className="page-link" href="#"><i className="fi-rs-arrow-small-right" /></a>
              </li>
            </ul>
          </nav>
        </div>
        <section className="section-padding pb-5">
          <div className="section-title">
            <h3 className>Günün Fırsatları</h3>
            <a className="show-all" href="shop-grid-right.html">
              Tüm Fırsatlar
              <i className="fi-rs-angle-right" />
            </a>
          </div>
          <div className="row">
            <div className="col-xl-3 col-lg-4 col-md-6">
              <div className="product-cart-wrap style-2">
                <div className="product-img-action-wrap">
                  <div className="product-img">
                    <a href="shop-product-right.html">
                      <img src="/src/assets/imgs/banner/banner-5.png" alt />
                    </a>
                  </div>
                </div>
                <div className="product-content-wrap">
                  <div className="deals-countdown-wrap">
                    <div className="deals-countdown" data-countdown="2025/03/25 00:00:00" />
                  </div>
                  <div className="deals-content">
                    <h2><a href="shop-product-right.html">Seeds of Change Organik Kinoa, Kahverengi</a></h2>
                    <div className="product-rate-cover">
                      <div className="product-rate d-inline-block">
                        <div className="product-rating" style={{width: '90%'}} />
                      </div>
                      <span className="font-small ml-5 text-muted"> (4.0)</span>
                    </div>
                    <div>
                      <span className="font-small text-muted">Tarafından <a href="vendor-details-1.html">NestFood</a></span>
                    </div>
                    <div className="product-card-bottom">
                      <div className="product-price">
                        <span>$32.85</span>
                        <span className="old-price">$33.8</span>
                      </div>
                      <div className="add-cart">
                        <a className="add" href="shop-cart.html"><i className="fi-rs-shopping-cart mr-5" />Ekle </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div className="col-xl-3 col-lg-4 col-md-6">
              <div className="product-cart-wrap style-2">
                <div className="product-img-action-wrap">
                  <div className="product-img">
                    <a href="shop-product-right.html">
                      <img src="/src/assets/imgs/banner/banner-6.png" alt />
                    </a>
                  </div>
                </div>
                <div className="product-content-wrap">
                  <div className="deals-countdown-wrap">
                    <div className="deals-countdown" data-countdown="2026/04/25 00:00:00" />
                  </div>
                  <div className="deals-content">
                    <h2><a href="shop-product-right.html">Perdue Simply Smart Organics Glutensiz</a></h2>
                    <div className="product-rate-cover">
                      <div className="product-rate d-inline-block">
                        <div className="product-rating" style={{width: '90%'}} />
                      </div>
                      <span className="font-small ml-5 text-muted"> (4.0)</span>
                    </div>
                    <div>
                      <span className="font-small text-muted">Tarafından <a href="vendor-details-1.html">Old El Paso</a></span>
                    </div>
                    <div className="product-card-bottom">
                      <div className="product-price">
                        <span>$24.85</span>
                        <span className="old-price">$26.8</span>
                      </div>
                      <div className="add-cart">
                        <a className="add" href="shop-cart.html"><i className="fi-rs-shopping-cart mr-5" />Ekle </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div className="col-xl-3 col-lg-4 col-md-6 d-none d-lg-block">
              <div className="product-cart-wrap style-2">
                <div className="product-img-action-wrap">
                  <div className="product-img">
                    <a href="shop-product-right.html">
                      <img src="/src/assets/imgs/banner/banner-7.png" alt />
                    </a>
                  </div>
                </div>
                <div className="product-content-wrap">
                  <div className="deals-countdown-wrap">
                    <div className="deals-countdown" data-countdown="2027/03/25 00:00:00" />
                  </div>
                  <div className="deals-content">
                    <h2><a href="shop-product-right.html">Signature Odun Ateşinde Mantar</a></h2>
                    <div className="product-rate-cover">
                      <div className="product-rate d-inline-block">
                        <div className="product-rating" style={{width: '80%'}} />
                      </div>
                      <span className="font-small ml-5 text-muted"> (3.0)</span>
                    </div>
                    <div>
                      <span className="font-small text-muted">Tarafından <a href="vendor-details-1.html">Progresso</a></span>
                    </div>
                    <div className="product-card-bottom">
                      <div className="product-price">
                        <span>$12.85</span>
                        <span className="old-price">$13.8</span>
                      </div>
                      <div className="add-cart">
                        <a className="add" href="shop-cart.html"><i className="fi-rs-shopping-cart mr-5" />Ekle </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div className="col-xl-3 col-lg-4 col-md-6 d-none d-xl-block">
              <div className="product-cart-wrap style-2">
                <div className="product-img-action-wrap">
                  <div className="product-img">
                    <a href="shop-product-right.html">
                      <img src="/src/assets/imgs/banner/banner-8.png" alt />
                    </a>
                  </div>
                </div>
                <div className="product-content-wrap">
                  <div className="deals-countdown-wrap">
                    <div className="deals-countdown" data-countdown="2025/02/25 00:00:00" />
                  </div>
                  <div className="deals-content">
                    <h2><a href="shop-product-right.html">Ahududu Suyu ile Simply Limonata</a></h2>
                    <div className="product-rate-cover">
                      <div className="product-rate d-inline-block">
                        <div className="product-rating" style={{width: '80%'}} />
                      </div>
                      <span className="font-small ml-5 text-muted"> (3.0)</span>
                    </div>
                    <div>
                      <span className="font-small text-muted">Tarafından <a href="vendor-details-1.html">Yoplait</a></span>
                    </div>
                    <div className="product-card-bottom">
                      <div className="product-price">
                        <span>$15.85</span>
                        <span className="old-price">$16.8</span>
                      </div>
                      <div className="add-cart">
                        <a className="add" href="shop-cart.html"><i className="fi-rs-shopping-cart mr-5" />Ekle </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>
        {/*Günün Fırsatları Bitti*/}
      </div>
      <div className="col-lg-1-5 primary-sidebar sticky-sidebar">
        <div className="sidebar-widget widget-category-2 mb-30">
          <h5 className="section-title style-1 mb-30">Kategori</h5>
          <ul>
            <li>
              <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-1.svg" alt />Süt &amp; Süt Ürünleri</a><span className="count">30</span>
            </li>
            <li>
              <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-2.svg" alt />Giyim</a><span className="count">35</span>
            </li>
            <li>
              <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-3.svg" alt />Evcil Hayvan Mamaları </a><span className="count">42</span>
            </li>
            <li>
              <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-4.svg" alt />Unlu Mamuller</a><span className="count">68</span>
            </li>
            <li>
              <a href="shop-grid-right.html"> <img src="/src/assets/imgs/theme/icons/category-5.svg" alt />Taze Meyve</a><span className="count">87</span>
            </li>
          </ul>
        </div>
        {/* Fiyata Göre Filtrele */}
        <div className="sidebar-widget price_range range mb-30">
          <h5 className="section-title style-1 mb-30">Fiyata Göre Filtrele</h5>
          <div className="price-filter">
            <div className="price-filter-inner">
              <div id="slider-range" className="mb-20" />
              <div className="d-flex justify-content-between">
                <div className="caption">Fiyat: <strong id="slider-range-value1" className="text-brand" /></div>
                <div className="caption">Fiyat: <strong id="slider-range-value2" className="text-brand" /></div>
              </div>
            </div>
          </div>
          <div className="list-group">
            <div className="list-group-item mb-10 mt-10">
              <label className="fw-900">Renk</label>
              <div className="custome-checkbox">
                <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox1" defaultValue />
                <label className="form-check-label" htmlFor="exampleCheckbox1"><span>Kırmızı (56)</span></label>
                <br />
                <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox2" defaultValue />
                <label className="form-check-label" htmlFor="exampleCheckbox2"><span>Yeşil (78)</span></label>
                <br />
                <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox3" defaultValue />
                <label className="form-check-label" htmlFor="exampleCheckbox3"><span>Mavi (54)</span></label>
              </div>
              <label className="fw-900 mt-15">Ürün Durumu</label>
              <div className="custome-checkbox">
                <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox11" defaultValue />
                <label className="form-check-label" htmlFor="exampleCheckbox11"><span>Yeni (1506)</span></label>
                <br />
                <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox21" defaultValue />
                <label className="form-check-label" htmlFor="exampleCheckbox21"><span>Yenilenmiş (27)</span></label>
                <br />
                <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox31" defaultValue />
                <label className="form-check-label" htmlFor="exampleCheckbox31"><span>Kullanılmış (45)</span></label>
              </div>
            </div>
          </div>
          <a href="shop-grid-right.html" className="btn btn-sm btn-default"><i className="fi-rs-filter mr-5" /> Filtrele</a>
        </div>
        {/* Ürünler sidebar Widget */}
        <div className="sidebar-widget product-sidebar mb-30 p-30 bg-grey border-radius-10">
          <h5 className="section-title style-1 mb-30">Yeni Ürünler</h5>
          <div className="single-post clearfix">
            <div className="image">
              <img src="/src/assets/imgs/shop/thumbnail-3.jpg" alt="#" />
            </div>
            <div className="content pt-10">
              <h5><a href="shop-product-detail.html">Chen Hırka</a></h5>
              <p className="price mb-0 mt-5">$99.50</p>
              <div className="product-rate">
                <div className="product-rating" style={{width: '90%'}} />
              </div>
            </div>
          </div>
          <div className="single-post clearfix">
            <div className="image">
              <img src="/src/assets/imgs/shop/thumbnail-4.jpg" alt="#" />
            </div>
            <div className="content pt-10">
              <h6><a href="shop-product-detail.html">Chen Kazak</a></h6>
              <p className="price mb-0 mt-5">$89.50</p>
              <div className="product-rate">
                <div className="product-rating" style={{width: '80%'}} />
              </div>
            </div>
          </div>
          <div className="single-post clearfix">
            <div className="image">
              <img src="/src/assets/imgs/shop/thumbnail-5.jpg" alt="#" />
            </div>
            <div className="content pt-10">
              <h6><a href="shop-product-detail.html">Renkli Ceket</a></h6>
              <p className="price mb-0 mt-5">$25</p>
              <div className="product-rate">
                <div className="product-rating" style={{width: '60%'}} />
              </div>
            </div>
          </div>
        </div>
        <div className="banner-img wow fadeIn mb-lg-0 animated d-lg-block d-none">
          <img src="/src/assets/imgs/banner/banner-11.png" alt />
          <div className="banner-text">
            <span>Organik</span>
            <h4>
              %17 Tasarruf <br />
              <span className="text-brand">Organik</span><br />
              Meyve Suyunda
            </h4>
          </div>
        </div>
      </div>
    </div>
  </div>
</main>


  )
}

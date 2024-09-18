import { Link } from "react-router-dom";
import Post from "./BlogComponets/Post";

export default function Blogs() {
  return (
<main className="main">
<div className="page-header mt-30 mb-75">
  <div className="container">
    <div className="archive-header">
      <div className="row align-items-center">
        <div className="col-xl-3">
          <h1 className="mb-15">Blog &amp;</h1>
          <div className="breadcrumb">
            <Link to="/">
              <i className="fi-rs-home mr-5" />Ana Sayfa
            </Link>
            <span /> Blog &amp;
          </div>
        </div>
        <div className="col-xl-9 text-end d-none d-xl-block">
          <ul className="tags-list">
            <li className="hover-up">
              <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Alışveriş</a>
            </li>
            <li className="hover-up active">
              <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Tarifler</a>
            </li>
            <li className="hover-up">
              <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Mutfak</a>
            </li>
            <li className="hover-up">
              <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Haberler</a>
            </li>
            <li className="hover-up mr-0">
              <a href="blog-category-grid.html"><i className="fi-rs-cross mr-10" />Yemek</a>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</div>

  <div className="page-content mb-50">
    <div className="container">
      <div className="row">
        <div className="col-lg-12">
          <div className="shop-product-fillter mb-50">
            <div className="totall-product">
              <h2>
                <img className="w-36px mr-10" src="/src/assets/imgs/theme/icons/category-1.svg" alt />
                En Son Yayınlanan Bloglar
              </h2>
            </div>
            <div className="sort-by-product-area">
              <div className="sort-by-cover mr-10">
                <div className="sort-by-product-wrap">
                  <div className="sort-by">
                    <span><i className="fi-rs-apps" />Show:</span>
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
                    <li><a href="#">All</a></li>
                  </ul>
                </div>
              </div>
              <div className="sort-by-cover">
                <div className="sort-by-product-wrap">
                  <div className="sort-by">
                    <span><i className="fi-rs-apps-sort" />Sort:</span>
                  </div>
                  <div className="sort-by-dropdown-wrap">
                    <span>Featured <i className="fi-rs-angle-small-down" /></span>
                  </div>
                </div>
                <div className="sort-by-dropdown">
                  <ul>
                    <li><a className="active" href="#">Featured</a></li>
                    <li><a href="#">Newest</a></li>
                    <li><a href="#">Most comments</a></li>
                    <li><a href="#">Release Date</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
          <div className="loop-grid">
            <div className="row">
              <Post/>

            </div>
          </div>
          <div className="pagination-area mt-15 mb-sm-5 mb-lg-0">
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
        </div>
      </div>
    </div>
  </div>
</main>


  )
}

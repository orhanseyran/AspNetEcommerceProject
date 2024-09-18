
export default function Post() {
  return (
    <article className="col-xl-3 col-lg-4 col-md-6 text-center hover-up mb-30 animated">
    <div className="post-thumb">
      <a href="blog-post-right.html">
        <img className="border-radius-15" src="/src/assets/imgs/blog/blog-1.png" alt />
      </a>
      <div className="entry-meta">
        <a className="entry-meta meta-2" href="blog-category-grid.html"><i className="fi-rs-heart" /></a>
      </div>
    </div>
    <div className="entry-content-2">
      <h6 className="mb-10 font-sm"><a className="entry-meta text-muted" href="blog-category-grid.html">Side Dish</a></h6>
      <h4 className="post-title mb-15">
        <a href="blog-post-right.html">The Intermediate Guide to Healthy Food</a>
      </h4>
      <div className="entry-meta font-xs color-grey mt-10 pb-10">
        <div>
          <span className="post-on mr-10">25 April 2022</span>
          <span className="hit-count has-dot mr-10">126k Views</span>
          <span className="hit-count has-dot">4 mins read</span>
        </div>
      </div>
    </div>
  </article>
  )
}

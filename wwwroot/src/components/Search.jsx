
export default function Search() {
  return (
    <div>
      <section className="hero-3 position-relative align-items">
        <h2 className="mb-30 text-center">Sana Yakın Mağazalardan Ürün Ara</h2>
        <form className="form-subcriber d-flex mb-30 text-center">
          <input type="email" placeholder="Dometes , Ekmek , Biftek Eti ..." tabIndex={-1} />
          <button className="btn" type="submit" tabIndex={-1}>Ara </button>
        </form>
        <ul className="list-inline nav nav-tabs links font-xs text-center">
          <li className="list-inline-item nav-item"><a className="nav-link font-xs" href="shop-grid-right.html">Kek</a></li>
          <li className="list-inline-item nav-item"><a className="nav-link font-xs" href="shop-grid-right.html">Kahve</a></li>
          <li className="list-inline-item nav-item"><a className="nav-link font-xs" href="shop-grid-right.html">Evcil Hayvan</a></li>
          <li className="list-inline-item nav-item"><a className="nav-link font-xs" href="shop-grid-right.html">Vejeteryan</a></li>
        </ul>
      </section>

      
    </div>
  )
}

import MinProduct from "../../HomeComponents/MinProduct";

export default function RecentlAdded() {
  return (
    <div className="col-xl-3 col-lg-4 col-md-6 mb-sm-5 mb-md-0 d-none d-lg-block wow animate__animated animate__fadeInUp" data-wow-delay=".2s">
    <h4 className="section-title style-1 mb-30 animated animated">Yeni Eklenenler</h4>
    <div className="product-list-small animated animated">
    <MinProduct/>

    </div>
  </div>
  )
}

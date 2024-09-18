
export default function Carts() {
  return (
    <main className="main">
    <div className="page-header breadcrumb-wrap">
        <div className="container">
        <div className="breadcrumb">
            <a href="index.html" rel="nofollow"><i className="fi-rs-home mr-5" />Home</a>
            <span /> Shop
            <span /> Cart
        </div>
        </div>
    </div>
    <div className="container mb-80 mt-50">
        <div className="row">
        <div className="col-lg-8 mb-40">
            <h1 className="heading-2 mb-10">Your Cart</h1>
            <div className="d-flex justify-content-between">
            <h6 className="text-body">There are <span className="text-brand">3</span> products in your cart</h6>
            <h6 className="text-body"><a href="#" className="text-muted"><i className="fi-rs-trash mr-5" />Clear Cart</a></h6>
            </div>
        </div>
        </div>
        <div className="row">
        <div className="col-lg-8">
            <div className="table-responsive shopping-summery">
            <table className="table table-wishlist">
                <thead>
                <tr className="main-heading">
                    <th className="custome-checkbox start pl-30">
                    <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox11" defaultValue />
                    <label className="form-check-label" htmlFor="exampleCheckbox11" />
                    </th>
                    <th scope="col" colSpan={2}>Product</th>
                    <th scope="col">Unit Price</th>
                    <th scope="col">Quantity</th>
                    <th scope="col">Subtotal</th>
                    <th scope="col" className="end">Remove</th>
                </tr>
                </thead>
                <tbody>
                <tr className="pt-30">
                    <td className="custome-checkbox pl-30">
                    <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox1" defaultValue />
                    <label className="form-check-label" htmlFor="exampleCheckbox1" />
                    </td>
                    <td className="image product-thumbnail pt-40"><img src="/src/assets/imgs/shop/product-1-1.jpg" alt="#" /></td>
                    <td className="product-des product-name">
                    <h6 className="mb-5"><a className="product-name mb-10 text-heading" href="shop-product-right.html">Field Roast Chao Cheese Creamy Original</a></h6>
                    <div className="product-rate-cover">
                        <div className="product-rate d-inline-block">
                        <div className="product-rating" style={{width: '90%'}}>
                        </div>
                        </div>
                        <span className="font-small ml-5 text-muted"> (4.0)</span>
                    </div>
                    </td>
                    <td className="price" data-title="Price">
                    <h4 className="text-body">$2.51 </h4>
                    </td>
                    <td className="text-center detail-info" data-title="Stock">
                    <div className="detail-extralink mr-15">
                        <div className="detail-qty border radius">
                        <a href="#" className="qty-down"><i className="fi-rs-angle-small-down" /></a>
                        <span className="qty-val">1</span>
                        <a href="#" className="qty-up"><i className="fi-rs-angle-small-up" /></a>
                        </div>
                    </div>
                    </td>
                    <td className="price" data-title="Price">
                    <h4 className="text-brand">$2.51 </h4>
                    </td>
                    <td className="action text-center" data-title="Remove"><a href="#" className="text-body"><i className="fi-rs-trash" /></a></td>
                </tr>

                </tbody>
            </table>
            </div>
            <div className="divider-2 mb-30" />
            <div className="cart-action d-flex justify-content-between">
            <a className="btn "><i className="fi-rs-arrow-left mr-10" />Continue Shopping</a>
            <a className="btn  mr-10 mb-sm-15"><i className="fi-rs-refresh mr-10" />Update Cart</a>
            </div>
            <div className="row mt-50">

            <div className="col-lg-5">
                <div className="p-40">
                <h4 className="mb-10">Apply Coupon</h4>
                <p className="mb-30"><span className="font-lg text-muted">Using A Promo Code?</span></p>
                <form action="#">
                    <div className="d-flex justify-content-between">
                    <input className="font-medium mr-15 coupon" name="Coupon" placeholder="Enter Your Coupon" />
                    <button className="btn"><i className="fi-rs-label mr-10" />Apply</button>
                    </div>
                </form>
                </div>
            </div>
            </div>
        </div>
        <div className="col-lg-4">
            <div className="border p-md-4 cart-totals ml-30">
            <div className="table-responsive">
                <table className="table no-border">
                <tbody>
                    <tr>
                    <td className="cart_total_label">
                        <h6 className="text-muted">Subtotal</h6>
                    </td>
                    <td className="cart_total_amount">
                        <h4 className="text-brand text-end">$12.31</h4>
                    </td>
                    </tr>
                    <tr>
                    <td scope="col" colSpan={2}>
                        <div className="divider-2 mt-10 mb-10" />
                    </td>
                    </tr>
                    <tr>
                    <td className="cart_total_label">
                        <h6 className="text-muted">Shipping</h6>
                    </td>
                    <td className="cart_total_amount">
                        <h5 className="text-heading text-end">Free </h5></td></tr> <tr>
                    <td className="cart_total_label">
                        <h6 className="text-muted">Estimate for</h6>
                    </td>
                    <td className="cart_total_amount">
                        <h5 className="text-heading text-end">United Kingdom </h5></td></tr> <tr>
                    <td scope="col" colSpan={2}>
                        <div className="divider-2 mt-10 mb-10" />
                    </td>
                    </tr>
                    <tr>
                    <td className="cart_total_label">
                        <h6 className="text-muted">Total</h6>
                    </td>
                    <td className="cart_total_amount">
                        <h4 className="text-brand text-end">$12.31</h4>
                    </td>
                    </tr>
                </tbody>
                </table>
            </div>
            <a href="#" className="btn mb-20 w-100">Proceed To CheckOut<i className="fi-rs-sign-out ml-15" /></a>
            </div>
        </div>
        </div>
    </div>
    </main>
  )
}

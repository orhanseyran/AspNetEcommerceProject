
export default function Contacts() {
  return (
<main className="main pages">
  <div className="page-header breadcrumb-wrap">
    <div className="container">
      <div className="breadcrumb">
        <a href="index.html" rel="nofollow"><i className="fi-rs-home mr-5" />Anasayfa</a>
        <span /> Sayfalar <span /> İletişim
      </div>
    </div>
  </div>
  <div className="page-content pt-50">
    <div className="container">
      <div className="row">
        <div className="col-xl-10 col-lg-12 m-auto">

        </div>
      </div>
    </div>

    <div className="container">
      <div className="row">
        <div className="col-xl-10 col-lg-12 m-auto">
          <section className="mb-50">
            <div className="row mb-60">
              <div className="col-md-4 mb-4 mb-md-0">
                <h4 className="mb-15 text-brand">Ofis</h4>
                205 North Michigan Avenue, Suite 810<br />
                Chicago, 60601, ABD<br />
                <abbr title="Phone">Telefon:</abbr> (123) 456-7890<br />
                <abbr title="Email">E-posta: </abbr>contact@Evara.com<br />
                <a className="btn btn-sm font-weight-bold text-white mt-20 border-radius-5 btn-shadow-brand hover-up"><i className="fi-rs-marker mr-5" />Haritayı Gör</a>
              </div>
              <div className="col-md-4 mb-4 mb-md-0">
                <h4 className="mb-15 text-brand">Stüdyo</h4>
                205 North Michigan Avenue, Suite 810<br />
                Chicago, 60601, ABD<br />
                <abbr title="Phone">Telefon:</abbr> (123) 456-7890<br />
                <abbr title="Email">E-posta: </abbr>contact@Evara.com<br />
                <a className="btn btn-sm font-weight-bold text-white mt-20 border-radius-5 btn-shadow-brand hover-up"><i className="fi-rs-marker mr-5" />Haritayı Gör</a>
              </div>
              <div className="col-md-4">
                <h4 className="mb-15 text-brand">Mağaza</h4>
                205 North Michigan Avenue, Suite 810<br />
                Chicago, 60601, ABD<br />
                <abbr title="Phone">Telefon:</abbr> (123) 456-7890<br />
                <abbr title="Email">E-posta: </abbr>contact@Evara.com<br />
                <a className="btn btn-sm font-weight-bold text-white mt-20 border-radius-5 btn-shadow-brand hover-up"><i className="fi-rs-marker mr-5" />Haritayı Gör</a>
              </div>
            </div>
            <div className="row">
              <div className="col-xl-8">
                <div className="contact-from-area padding-20-row-col">
                  <h5 className="text-brand mb-10">İletişim Formu</h5>
                  <h2 className="mb-10">Bize Bir Mesaj Bırakın</h2>
                  <p className="text-muted mb-30 font-sm">E-posta adresiniz yayımlanmayacak. Zorunlu alanlar işaretlenmiştir *</p>
                  <form className="contact-form-style mt-30" id="contact-form" action="#" method="post">
                    <div className="row">
                      <div className="col-lg-6 col-md-6">
                        <div className="input-style mb-20">
                          <input name="name" placeholder="Adınız" type="text" />
                        </div>
                      </div>
                      <div className="col-lg-6 col-md-6">
                        <div className="input-style mb-20">
                          <input name="email" placeholder="E-postanız" type="email" />
                        </div>
                      </div>
                      <div className="col-lg-6 col-md-6">
                        <div className="input-style mb-20">
                          <input name="telephone" placeholder="Telefon Numaranız" type="tel" />
                        </div>
                      </div>
                      <div className="col-lg-6 col-md-6">
                        <div className="input-style mb-20">
                          <input name="subject" placeholder="Konu" type="text" />
                        </div>
                      </div>
                      <div className="col-lg-12 col-md-12">
                        <div className="textarea-style mb-30">
                          <textarea name="message" placeholder="Mesajınız" defaultValue={""} />
                        </div>
                        <button className="submit submit-auto-width" type="submit">Mesaj Gönder</button>
                      </div>
                    </div>
                  </form>
                  <p className="form-messege" />
                </div>
              </div>
              <div className="col-lg-4 pl-50 d-lg-block d-none">
                <img className="border-radius-15 mt-50" src="/src/assets/imgs/page/contact-2.png" alt="İletişim Görseli" />
              </div>
            </div>
          </section>
        </div>
      </div>
    </div>
  </div>
</main>


  )
}

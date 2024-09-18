import RecentlAdded from "./_components/RecentlyAdded/RecentlAdded";
import TopRated from "./_components/TopRated/TopRated";
import TopSelling from "./_components/TopSelling/TopSelling";
import TrendProducts from "./_components/TrendProduct/TrendProducts";


export default function Footer() {
  return (
    <div>
<footer className="main">
  <section className="section-padding mb-30">
    <div className="container">
      <div className="row">
        <TopSelling/>
        <TrendProducts/>
        <RecentlAdded/>
        <TopRated/>
      </div>
    </div>
  </section>
  {/*Son 4 sütun*/}
  <section className="section-padding footer-mid">
    <div className="container pt-15 pb-20">
      <div className="row">
        <div className="col">
          <div className="widget-about font-md mb-md-3 mb-lg-3 mb-xl-0 wow animate__animated animate__fadeInUp" data-wow-delay={0}>
            <div className="logo mb-30">
              <a href="index.html" className="mb-15"><img src="/src/assets/logo.png" alt="logo" /></a>
              <p className="font-lg text-heading">Şimdi Popüler Süper Marketler Adresinde</p>
            </div>
            <ul className="contact-infor">
              <li><img src="/src/assets/imgs/theme/icons/icon-location.svg" alt /><strong>Adres: </strong> <span>5171 W Campbell Ave, Kent, Utah 53127 ABD</span></li>
              <li><img src="/src/assets/imgs/theme/icons/icon-contact.svg" alt /><strong>Bize Ulaşın:</strong><span>(+91) - 540-025-124553</span></li>
              <li><img src="/src/assets/imgs/theme/icons/icon-email-2.svg" alt /><strong>Email:</strong><span>sale@Nest.com</span></li>
              <li><img src="/src/assets/imgs/theme/icons/icon-clock.svg" alt /><strong>Çalışma Saatleri:</strong><span>10:00 - 18:00, Paz - Cts</span></li>
            </ul>
          </div>
        </div>
        <div className="footer-link-widget col wow animate__animated animate__fadeInUp" data-wow-delay=".1s">
          <h4 className="widget-title">Şirket</h4>
          <ul className="footer-list mb-sm-5 mb-md-0">
            <li><a href="#">Hakkımızda</a></li>
            <li><a href="#">Teslimat Bilgileri</a></li>
            <li><a href="#">Gizlilik Politikası</a></li>
            <li><a href="#">Şartlar ve Koşullar</a></li>
            <li><a href="#">İletişim</a></li>
            <li><a href="#">Destek Merkezi</a></li>
            <li><a href="#">Kariyer</a></li>
          </ul>
        </div>
        <div className="footer-link-widget col wow animate__animated animate__fadeInUp" data-wow-delay=".2s">
          <h4 className="widget-title">Hesap</h4>
          <ul className="footer-list mb-sm-5 mb-md-0">
            <li><a href="#">Giriş Yap</a></li>
            <li><a href="#">Sepeti Görüntüle</a></li>
            <li><a href="#">Favorilerim</a></li>
            <li><a href="#">Siparişimizi Takip Et</a></li>
            <li><a href="#">Yardım Talebi</a></li>
            <li><a href="#">Nakliye Detayları</a></li>
            <li><a href="#">Ürünleri Karşılaştır</a></li>
          </ul>
        </div>
        <div className="footer-link-widget col wow animate__animated animate__fadeInUp" data-wow-delay=".3s">
          <h4 className="widget-title">Kurumsal</h4>
          <ul className="footer-list mb-sm-5 mb-md-0">
            <li><a href="#">Satıcı Ol</a></li>
            <li><a href="#">Ortaklık Programı</a></li>
            <li><a href="#">Çiftlik İşletmesi</a></li>
            <li><a href="#">Çiftlik Kariyerleri</a></li>
            <li><a href="#">Tedarikçilerimiz</a></li>
            <li><a href="#">Erişilebilirlik</a></li>
            <li><a href="#">Kampanyalar</a></li>
          </ul>
        </div>
        <div className="footer-link-widget col wow animate__animated animate__fadeInUp" data-wow-delay=".4s">
          <h4 className="widget-title">Popüler</h4>
          <ul className="footer-list mb-sm-5 mb-md-0">
            <li><a href="#">Süt ve Aromalı Sütler</a></li>
            <li><a href="#">Tereyağı ve Margarin</a></li>
            <li><a href="#">Yumurta Alternatifleri</a></li>
            <li><a href="#">Reçeller</a></li>
            <li><a href="#">Ekşi Krema ve Soslar</a></li>
            <li><a href="#">Çay ve Kombucha</a></li>
            <li><a href="#">Peynir</a></li>
          </ul>
        </div>
        <div className="footer-link-widget widget-install-app col wow animate__animated animate__fadeInUp" data-wow-delay=".5s">
          <h4 className="widget-title">Uygulamayı İndirin</h4>
          <p className>App Store veya Google Play den</p>
          <div className="download-app">
            <a href="#" className="hover-up mb-sm-2 mb-lg-0"><img className="active" src="/src/assets/imgs/theme/app-store.jpg" alt="App Store" /></a>
            <a href="#" className="hover-up mb-sm-2"><img src="/src/assets/imgs/theme/google-play.jpg" alt="Google Play" /></a>
          </div>
          <p className="mb-20">Güvenli Ödeme Yöntemleri</p>
          <img className src="/src/assets/imgs/theme/payment-method.png" alt="Ödeme Yöntemleri" />
        </div>
      </div>
    </div>
  </section>
  <div className="container pb-30 wow animate__animated animate__fadeInUp" data-wow-delay={0}>
    <div className="row align-items-center">
      <div className="col-12 mb-30">
        <div className="footer-bottom" />
      </div>
      <div className="col-xl-4 col-lg-6 col-md-6">
        <p className="font-sm mb-0">© 2024, <strong className="text-brand">Orhan Seyran</strong> - React E-ticaret Şablonu <br />Tüm hakları saklıdır</p>
      </div>
      <div className="col-xl-4 col-lg-6 text-center d-none d-xl-block">

      </div>
      <div className="col-xl-4 col-lg-6 col-md-6 text-end d-none d-md-block">
        <div className="mobile-social-icon">
          <h6>Bizi Takip Edin</h6>
          <a href="#"><img src="/src/assets/imgs/theme/icons/icon-facebook-white.svg" alt="Facebook" /></a>
          <a href="#"><img src="/src/assets/imgs/theme/icons/icon-twitter-white.svg" alt="Twitter" /></a>
          <a href="#"><img src="/src/assets/imgs/theme/icons/icon-instagram-white.svg" alt="Instagram" /></a>
          <a href="#"><img src="/src/assets/imgs/theme/icons/icon-pinterest-white.svg" alt="Pinterest" /></a>
          <a href="#"><img src="/src/assets/imgs/theme/icons/icon-youtube-white.svg" alt="YouTube" /></a>
        </div>
        <p className="font-sm">İlk abone olduğunuzda </p>
      </div>
    </div>
  </div>
</footer>


      
    </div>
  )
}

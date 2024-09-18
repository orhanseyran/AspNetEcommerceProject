import { useEffect } from "react";

const Imports = () => {
  useEffect(() => {
    const scriptUrls = [

      "/src/assets/js/vendor/jquery-3.6.0.min.js",
      "/src/assets/js/vendor/jquery-migrate-3.3.0.min.js",
      "/src/assets/js/vendor/bootstrap.bundle.min.js",
      "/src/assets/js/plugins/slick.js",

      "/src/assets/js/plugins/wow.js",



      "/src/assets/js/plugins/counterup.js",
      "/src/assets/js/plugins/jquery.countdown.min.js",



  
      "/src/assets/js/main.js?v=5.6",
      "/src/assets/js/shop.js?v=5.6"
    ];

    // Scriptleri dinamik olarak sayfaya ekleyelim
    scriptUrls.forEach((url) => {
      const script = document.createElement('script');
      script.src = url;
      script.async = true;
      document.body.appendChild(script);
    });
    window.scrollTo({ top: 0, behavior: "smooth" });

    // Cleanup: Sayfa kapatılırken scriptleri kaldırmak
    return () => {
      document.querySelectorAll('script').forEach((script) => {
        if (scriptUrls.includes(script.src)) {
          document.body.removeChild(script);
        }
      });
    };
  }); // Bileşen mount olduğunda sadece bir kez çalışır

  return null; // UI'ya bir şey render etmenize gerek yok
};

export default Imports;
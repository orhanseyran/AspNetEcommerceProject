import { useEffect } from "react";
import LoginRegister from "../../Hooks/LoginRegister";
import Footer from "../Footer";
import Header from "../Header";

export default function Login() {
    const {setPassword,setEmail,Login,error,email,password} = LoginRegister();


    useEffect(() => {
        if (localStorage.getItem("token")) {
            window.location.href = "/";
        }
    }, []);





  return (
    <div>
        <Header/>
<main className="main pages">
  <div className="page-header breadcrumb-wrap">
    <div className="container">
      <div className="breadcrumb">
        <a href="index.html" rel="nofollow"><i className="fi-rs-home mr-5" />Ana SAYFA</a>
        <span /> Giriş Yap <span /> 
      </div>
    </div>
  </div>
  <div className="page-content pt-150 pb-150">
    <div className="container">
      <div className="row">
        <div className="col-xl-8 col-lg-10 col-md-12 m-auto">
          <div className="row">
            <div className="col-lg-6 pr-30 d-none d-lg-block">
              <img className="border-radius-15" src="/src/assets/imgs/page/login-1.png" alt />
            </div>
            <div className="col-lg-6 col-md-8">
                {
                    error ? (
                        <div className="alert alert-danger" role="alert">
                            <strong>{error}</strong>
                        </div>
                    ) : (
                        ""
                    )
                }

    

                
              <div className="login_wrap widget-taber-content background-white">
                <div className="padding_eight_all bg-white">
                  <div className="heading_s1">
                    <h1 className="mb-5">Giriş Yap</h1>
                    <p className="mb-30">Hesabın Yok Mu? <a href="page-register.html">Yeni Hesap Oluştur</a></p>
                  </div>
                  <form method="post" onSubmit={Login}>
                    <div className="form-group">
                      <input type="text" required name="email" value={email} onChange={(e) => setEmail(e.target.value)} placeholder="Email Adresiniz *" />
                    </div>
                    <div className="form-group">
                      <input required type="password" value={password} onChange={(e) => setPassword(e.target.value)} name="password" placeholder="Şifreniz *" />
                    </div>
                    {/* <div className="login_footer form-group">
                      <div className="chek-form">
                        <input type="text" required name="email" placeholder="Security code *" />
                      </div>
                      <span className="security-code">
                        <b className="text-new">8</b>
                        <b className="text-hot">6</b>
                        <b className="text-sale">7</b>
                        <b className="text-best">5</b>
                      </span>
                    </div> */}
                    <div className="login_footer form-group mb-50">
                      <div className="chek-form">
                        <div className="custome-checkbox">
                          <input className="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox1" defaultValue />
                          <label className="form-check-label" htmlFor="exampleCheckbox1"><span>Beni Hatırla</span></label>
                        </div>
                      </div>
                      <a className="text-muted" href="#">Şifremi Unuttum ?</a>
                    </div>
                    <div className="form-group">
                      <button type="submit" className="btn btn-heading btn-block hover-up" name="login">Giriş Yap</button>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</main>
<Footer/>
    </div>

  )
}

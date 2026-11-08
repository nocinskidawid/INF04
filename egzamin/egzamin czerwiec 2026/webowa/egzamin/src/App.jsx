import { useState } from 'react'
import 'bootstrap/dist/css/bootstrap.css'

function App() {
  const [adres, setAdres] = useState("")
  const [login, setLogin] = useState("")
  const [wygeneruj, setWygeneruj] = useState(true)
  const [haslo, setHaslo] = useState("")
  const [wynik, setWynik] = useState({adres:"", login:"", haslo:""})
  const Wyswietl = (e)=>{
    e.preventDefault();
    setWynik({adres,login,haslo}) 
    if (wygeneruj) 
    {
      setHaslo("Haslo wygenerowane losowo")
    }
  }


  return (
    <>
    <div className="blok1" class="align-items-start">
      <h1>Menedżer haseł - wykonał 1111</h1>
      <form class="form-control text-start">
        <label>Adres WWW:</label><br></br>
        <input onChange={(e)=>setAdres(e.target.value)} className="adres" type="text" placeholder="Adres strony WWW"/><br></br>
        <label>Login:</label><br></br>
        <input onChange={(e)=>setLogin(e.target.value)}  className="login"type="text" placeholder="Twój login"/><br></br>
        <input onChange={(e)=>setWygeneruj(e.target.checked)}  type="checkbox" DefaultChecked={true}/>
        <label>Wygeneruj hasło</label><br></br>
        <label>Hasło:</label><br></br>
        <input disabled={wygeneruj} onChange={(e)=>setHaslo(e.target.value)}  className="haslo" type="password"/><br></br>
        <button type="button" class="btn btn-primary" onClick={Wyswietl}>Zapisz</button>
      </form>
    </div >
    <div className="blok2" class="text-start">
      <p class="margin-3 text-primary">Adres: {wynik.adres}</p>
      <p class="margin-3">Login: {wynik.login}</p>
      <p class="margin-3">Hasło: {wynik.haslo}</p>
    </div>
    </>
  )
}

export default App

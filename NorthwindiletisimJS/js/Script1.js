window.onload = function () {

    
    
    
    const isim = document.querySelector("#isim");
    const soyisim = document.querySelector("#soyisim");
    const email = document.querySelector("#email");
    const adres = document.querySelector("#adres");
    const verigir = document.querySelector("#verigir");
    const liste = document.querySelector("#liste");

    verigir.onclick = function () {

        

        var tIsim = document.createElement("td");
        var tSoyisim = document.createElement("td");
        var tEmail = document.createElement("td");
        var tAdres = document.createElement("td");

        tIsim.textContent = isim.value;
        tSoyisim.textContent = soyisim.value;
        tEmail.textContent = email.value;
        tAdres.textContent = adres.value;

        var tr = document.createElement("tr");

        tr.appendChild(tIsim);
        tr.appendChild(tSoyisim);
        tr.appendChild(tEmail);
        tr.appendChild(tAdres);

        liste.appendChild(tr);

        isim.value = "";
        soyisim.value = "";
        email.value = "";
        adres.value = "";

        
        isim.focus();
    }
    

}


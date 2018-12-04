window.onload = initEvents;

function initEvents() {
    document.getElementById("btnMostrarLista").addEventListener("click", llamadaAJAX, false);
}


function llamadaAJAX() {
    var miLlamada = new XMLHttpRequest();
    //miLlamada.open('GET', '/Home/Index');
    miLlamada.open('GET', 'https://apirestpersonaslz.azurewebsites.net/api/personas');
    
    miLlamada.onreadystatechange = function () {
        alert(miLlamada.readyState);
        if (miLlamada.readyState < 4) {
            //alert('He entrado');
            document.getElementById('textoObjetivo').innerHTML = "cargando...";
        } else {
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                document.getElementById('textoObjetivo').innerHTML = miLlamada.responseText;
            }
        }
    };
    
    miLlamada.send();
}
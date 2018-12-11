window.onload = initEvents;

function initEvents() {
    document.getElementById("btnMostrarLista").addEventListener("click", llamadaAJAX_v2, false);
}

//------------------------ LISTADO COMPLETO --------------------------------------------------------
function llamadaAJAX() {
    var miLlamada = new XMLHttpRequest();
    //miLlamada.open('GET', '/Home/Index');
    miLlamada.open('GET', 'https://apirestpersonaslz.azurewebsites.net/api/personas');
    
    miLlamada.onreadystatechange = function () {
        alert(miLlamada.readyState);
        if (miLlamada.readyState < 4) {
            
            document.getElementById('textoObjetivo').innerHTML = "cargando...";
        } else {
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                document.getElementById('textoObjetivo').innerHTML = miLlamada.responseText;
            }
        }
    };
    
    miLlamada.send();
}

//------------------------CON UN OBJETO PERSONA----------------------------------------------

function llamadaAJAX_v2() {
    var miLlamada = new XMLHttpRequest();
    //miLlamada.open('GET', '/Home/Index');
    miLlamada.open('GET', 'https://apirestpersonaslz.azurewebsites.net/api/personas');
    
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            document.getElementById('textoObjetivo').innerHTML = "cargando...";
        } else {
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {

                var miPersona = new Persona();
                var arrayPersonas = JSON.parse(miLlamada.responseText);
                document.getElementById('textoObjetivo').innerHTML = arrayPersonas[0].nombre + " " + arrayPersonas[0].apellidos;

            }
        }
    };
    
    miLlamada.send();
}

class Persona {
    constructor(idPersona, nombre, apellidos, fechaNacimiento, direccion, telefono, idDepartamento) {
        this.idPersona = idPersona;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.fechaNacimiento = fechaNacimiento;
        this.direccion = direccion;
        this.telefono = telefono;
        this.idDepartamento = idDepartamento;
    }
}

window.onload = inicializarPagina();

function inicializarPagina() {
    cargarTabla();
}

function cargarTabla() {

    var myObj, x, txt = "";

    var miLlamada = new XMLHttpRequest();
    miLlamada.open('GET', 'https://apirestpersonaslz.azurewebsites.net/api/personas');

    miLlamada.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            myObj = JSON.parse(miLlamada.responseText);
            txt += "<table border='1' class=\"mdl-data-table mdl-js-data-table\">"
            txt += "<tr><th>" + "Nombre" + "</th><th>" + "Apellidos"
                + "</th><th>" + "Fecha de Nacimiento" + "</th><th>" + "Teléfono"
                + "</th><th>" + "Dirección" + "</th></tr>";
            for (x in myObj) {
                txt += "<tr><td class=\"mdl-data-table__cell--non-numeric\">" + myObj[x].nombre
                    + "</td><td class=\"mdl-data-table__cell--non-numeric\">" + myObj[x].apellidos
                    + "</td><td class=\"mdl-data-table__cell--non-numeric\">" + myObj[x].fechaNacimiento
                    + "</td><td class=\"mdl-data-table__cell--non-numeric\">" + myObj[x].telefono
                    + "</td><td class=\"mdl-data-table__cell--non-numeric\">" + myObj[x].direccion
                    + "</td><td class=\"mdl-data-table__cell--non-numeric\">" //Botones
                    + "<button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored\" id=\" " + myObj[x].idPersona +" \">EDITAR</button>" + " "
                        + "<button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent\">ELIMINAR</button>"
                    +"</td></tr>";

                // class = "mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored"

            }
            txt += "</table>"
            document.getElementById("demo").innerHTML = txt;
        }
    };
    miLlamada.send();
}
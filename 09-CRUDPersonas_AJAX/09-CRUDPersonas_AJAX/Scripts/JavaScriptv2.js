window.onload = inicializarPagina;

function inicializarPagina() {
    cargar();
    initEvents()
}

function initEvents() {
    document.getElementById("btnNuevo").addEventListener("click", clickNuevo, false);
}


function cargar() {

    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://apirestpersonaslz.azurewebsites.net/api/personas");

    //Mientras viene
    miLlamada.onreadystatechange = function () {

        if (miLlamada.readyState < 4) {
            //cargando
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                var arrayPersonas = JSON.parse(miLlamada.responseText);
                genera_tabla(arrayPersonas);

            }
    };
    //Mientras 
    miLlamada.send();
}

function genera_tabla(arrayPersonas) {

    var divTabla = document.getElementById("divTablaPersona");
    var cols = Object.keys(arrayPersonas[0]);

    var tabla = document.createElement("table");
    var tblBody = document.createElement("tbody");

    for (var i = 0; i < arrayPersonas.length; i++) {

        var hilera = document.createElement("tr");
   
        for (var prop in arrayPersonas[0]) {
            var celda = document.createElement("td");
            var textoCelda = document.createTextNode(arrayPersonas[i][prop]);        
            celda.appendChild(textoCelda);
            hilera.appendChild(celda);
        }

        var botonEditar = document.createElement("td");
        var textoEditar = document.createElement("input");

        textoEditar.setAttribute("type", "button");
        textoEditar.setAttribute("value", "Editar");
        textoEditar.setAttribute("class", "mdl-button mdl-js-button mdl-button--raised mdl-button--colored");
        botonEditar.appendChild(textoEditar);
        botonEditar.setAttribute("id", arrayPersonas[i].idPersona);
        botonEditar.addEventListener("click", clickEditar, false);
        hilera.appendChild(botonEditar);

        var botonBorrar = document.createElement("td");
        var textoBorrar = document.createElement("input");

        textoBorrar.setAttribute("type", "button");
        textoBorrar.setAttribute("value", "Borrar");
        textoBorrar.setAttribute("class", "mdl-button mdl-js-button mdl-button--raised mdl-button--accent");
        botonBorrar.appendChild(textoBorrar);
        //botonEditar.addEventListener("click", clickEditar , false);
        hilera.appendChild(botonBorrar);

        tblBody.appendChild(hilera);
    }

    tabla.appendChild(tblBody);

    divTabla.appendChild(tabla);

    tabla.setAttribute("border", "2");
    tabla.setAttribute("class", "mdl-data-table mdl-js-data-table");
    celda.setAttribute("class", "mdl-data-table__cell--non-numeric");
}



function clickEditar() {

    alert(this.id); //this es quien ha llamado a la funcion, en este caso el boton

}

function clickNuevo() {

    //alert('nuevo'); //this es quien ha llamado a la funcion, en este caso el boton

    var modal = document.getElementById('myModal');

    // Get the button that opens the modal
    var btn = document.getElementById("btnNuevo");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks on the button, open the modal 
    btn.onclick = function () {
        modal.style.display = "block";
    }

    // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
        modal.style.display = "none";
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }

}
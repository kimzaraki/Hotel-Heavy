//var galleto = document.cookie;
//galleto = 'usuario=cock;path=/';
//document.cookie = 'usuario=cock;path=/';
var user_json = {}



//FUNCIONES PARA COOKIES Y LOCAL STORAGE


//INICIA EL SCRIPT XD
function iniciar() {galletas = splitcookies();for (let i = 0; i < galletas.length; i++)document.cookie=galletas[i];}

//DIVIDE LAS GALLETAS EN UN ARRAY SEPARADO POR LOS ;
function splitcookies(){return localStorage[0].replace(' ','').split(';');}

//INICIAR SESION
function iniciar_sesion(usuario, contra)
{
    if (validar(usuario, contra)){
    user_json["user"] = usuario;
    user_json["pass"] = contra;
    }
    document.cookie = "user="+user_json.user;
    alert (document.cookie);
}
function get_cookie(cname)
{
    var galletas = document.cookie.split(';');
    for (let i = 0; i < galletas.length; i++) {
        if (galletas[i].replace(' ', '').substring(0, cname.length) 
        == cname){alert(galletas[i]); break;}
    }
}

function validar(usr, pass)
{if (usr == "pelenga" && pass == "wa")
    return true;return false;}

//NO TOCAR, ES DE KIM ABURRIDA
function validarFormulario() {
    // obtener los valores de los campos del formulario
    var nombre = document.getElementById("nombre").value;
    var correo = document.getElementById("correo").value;
    var telefono = document.getElementById("telefono").value;
    var fechaLlegada = document.getElementById("fecha-llegada").value;
    var fechaSalida = document.getElementById("fecha-salida").value;
    var habitacion = document.getElementById("habitacion").value;

    // verificar que todos los campos estén completos
    if (nombre == "" || correo == "" || telefono == "" || fechaLlegada == "" || fechaSalida == "" || habitacion == "") {
        alert("Por favor completa todos los campos del formulario.");
        return false; // detener el envío del formulario
    }
    // validar el formato del correo electrónico
    var expresionRegular = /\S+@\S+\.\S+/;
    if (!expresionRegular.test(correo)) {
        alert("Por favor ingresa un correo electrónico válido.");
        return false; // detener el envío del formulario
    }

    // si se han completado todos los campos y el correo electrónico es válido, enviar el formulario
    return true;
}
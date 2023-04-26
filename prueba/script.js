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
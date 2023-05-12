<!DOCTYPE html>
<html onended="localStorage[0]=document.cookie">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>&#x1F3E8; HOTEL HEAVY &#x1F3E8;
	</title>
    <link rel="stylesheet" href="css/login.css">
	<script src="js/login.js" defer></script> 
</head>
<body onload="iniciar()">

<div style="
    display: flex;
    flex-direction: row;
    width: 100%;
"><div></div><div class="login_container">
    <h1 class="txt">🤘 LOGIN 🤘
        <buton class="txt" style="position:relative;float: right;background-color:#f22;padding:3px 15px;border:2px solid;border-radius:100%" onclick="d.innerHTML='';">X</buton></h1>
    <!--!esta es la funcionalidad del boton-->
            <!-- <form action="reservar.php" method="post"> -->
                
            <form action="index.php" method="post" style="
    margin: auto;
">
                <label class="txt" for="nombre">Usuario:</label>
                <input class="txt" type="text" name="nombre" id="nombre" required="">
                <label class="txt" for="pass">Contraseña:</label>
                <input class="txt" type="password" name="pass" id="pass" required="">
                <div></div>
                <input class="txt" id="b_login" type="submit" value="Login">
    
    <!--</form>!-->
</form></div><div></div></div>

	


</body>
</html>

<!--// datos de conexión a la base de datos
$host = "localhost";
$username = "tu_usuario";
$password = "tu_contraseña";
$dbname = "hotel";

// crear conexión a la base de datos
$conn = new mysqli($host, $username, $password, $dbname);

// verificar si hubo un error en la conexión
if ($conn->connect_error) {
    die("Error de conexión a la base de datos: " . $conn->connect_error);
}

// obtener los valores de los campos del formulario
$nombre = $_POST["nombre"];
$correo = $_POST["correo"];
$telefono = $_POST["telefono"];
$fechaLlegada = $_POST["fecha-llegada"];
$fechaSalida = $_POST["fecha-salida"];
$habitacion = $_POST["habitacion"];

// preparar la consulta SQL
$sql = "INSERT INTO reservas (nombre, correo, telefono, fecha_llegada, fecha_salida, habitacion) VALUES ('$nombre', '$correo', '$telefono', '$fechaLlegada', '$fechaSalida', '$habitacion')";

// ejecutar la consulta
if ($conn->query($sql) === TRUE) {
    echo "Reserva guardada correctamente";
} else {
    echo "Error al guardar la reserva: " . $conn->error;
}

// cerrar la conexión a la base de datos
$conn->close();-->

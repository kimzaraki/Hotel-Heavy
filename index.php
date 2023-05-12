

<?php
// $datos = $_POST;

if (!isset($_COOKIE['primera_vez']))
{
    
    setcookie('primera_vez','1');
    // echo "Primera vEZ
    // <script src='js/menu.js' defer></script>";
    // setcookie('','1');
}
else
{
    if (isset($_COOKIE['sesion'])) if ($_COOKIE['sesion']=='1')    
        {unset($_POST['nombre']);unset($_POST['pass']);print_r("XD");}
    if (isset($_POST['nombre']) && isset($_POST['pass']))
    {
        // echo 'el wey va a iniciar sesion';
        $url = 'http://localhost:8000/clientes/login/'.$_POST['nombre'].'_'.$_POST['pass'];
    $json = file_get_contents($url);

    // $encoded = json_decode($json);
    // print_r();
    
print_r("<script id='autod' defer>var jason =".$json."autod=document.getElementById('autod');
    if (jason.sesion=='1')
    {document.cookie='usuario='+jason.nombre;
    document.cookie=';correo='+jason.correo;
    document.cookie=';sesion='+jason.sesion;}
    // else removecookies();
    //autod.remove();</script>");
    }

}
    
render(); 

// print_r($me);
function render(){
echo "
<!DOCTYPE html>
<html>
<head>
    <meta charset='UTF-8'>
    <!-- <meta http-equiv='X-UA-Compatible' content='IE=edge'> -->
    <!-- <meta name='viewport' content='width=device-width, initial-scale=1.0'> -->
    <title>Hotel Heavy</title>
    <link rel='icon' type='image/x-icon' href='img/logo.png'>
    <link rel='stylesheet' href='css/main.css'>
    <script src='js/menu.js' defer></script>
    <!-- FUENTE DE METALEROS -->
    <link rel='preconnect' href='https://fonts.googleapis.com'>
    <link rel='preconnect' href='https://fonts.gstatic.com' crossorigin>
    <link href='https://fonts.googleapis.com/css2?family=Metal+Mania&display=swap' rel='stylesheet'>
</head>";
echo " 
<body onload='init()' style='margin:0'>
<!-- <main> -->
<section id='BARRITA_TOP'>
<div class='bar' style='position: fixed;top: 0;overflow: hidden;'>
    <div class='top'>
        <div class='items'>
            <div id='logo' class='item logo'
                onclick='alert(\"Haz de cuenta que te mandamos a la pagina principal, osea el index\");'><img
                    class='png' src='img/logo.png'><img class='png' src='img/logo.png'>
                <div class='txt'>HOTEL HEAVY</div>
            </div>
            <div id='items' class='item list'>
                <div class='txt'>reservaciones</div>
                <div class='txt'>buscar 🔎</div>
            </div>
            <div style='font-size:2vh' id='myself' class='item user'
                onclick='login()'>
                <div style='margin-right:1vh' class='img'><img style='margin-right:1vh' class='png'
                        src='img/user.png' alt='soy ese'>
                    <div class='txt'>INICIA SESION</div>
                </div>
            </div>

        </div>
    </div>
    <div class='bottom'></div>
</div>
</section>
<section id='dynamic' style='position: fixed;top: 50%;left: 50%;transform: translate(-50%, -50%);'>

</section>

<section id='content'>
<!-- </main> -->

<!-- CONTENIDO :V -->
<p>SOY EL PRIMERO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>SOLO SOY UN PARRAFO QUE DEMUESTRA QUE EL CONTENIDO JALA COMO EN BLOQUESITO Y SI SE ACABA EL ESPACIO, SE VA A LA SIGUIENTE LINEA
    XDDDD
</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
<p>PITO PITO PITO</p>
</section>
</body>
</html>";

}
?>




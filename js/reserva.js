var checkin = document.getElementById("dtp_checkin"), checkout = document.getElementById("dtp_checkout");

//INICIA EL DOCUMENTO RESERVAR.HTML
function iniciar()
{
    var hoy = fecha();
    formatdate(checkin);
    // console.log(hoy.getDay());
    checkin.date = hoy.toLocaleDateString('en-US');
    // hoy.toLocaleDateString('en-US');
}


//FUNCION PARA CONSEGUIR FECHA DE HOY
function fecha(){
    return new Date();
    // date = date.split('/');
        // d = date[0];
        // m = date[1];
        // y = date[2];
    // checkin.
}

function formatdate(dtp)
{
    var td = fecha();var tom = td.getDate()+1;
    a=tom.toLocaleDateString('en-US').split('/');
    //a[0] m //a[1] d // a[2] y
    if (a[0].length == 1) a[0] = "0"+a[0];
    if (a[1].length == 1) a[0] = "0"+a[1];
    console.log(a);
    checkin.value = a[2]+ "-"+a[0]+"-"+a[1];
}
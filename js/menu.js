let logo = document.getElementById("logo");
let myself = document.getElementById("myself");
let items = document.getElementById("items");

let dynamic = document.getElementById('dynamic');

async function login(obj)
{
    var txt = await get_e('objetos/login_container.html', obj);
    dynamic.innerHTML = txt;dynamic.style.left="25%";dynamic.style.top="25%";
}



function init() {
  cambiar();addEventListener("resize", (event) => {});onresize = (event) => {cambiar();};
}

function cambiar() {
  const menubar_h = document.getElementsByClassName("bar")[0].offsetHeight;
  const content = document.getElementById("content");
  content.style.marginTop = `${menubar_h + 20}px`;
  const ancho = window.screen.width;
  if (ancho>=800)
  {
    logo.innerHTML =
    '<img class="png" src="img/logo.png"><img class="png" src="img/logo.png"><div style="font-size:4vh" class="txt">HOTEL HEAVY</div>';
  myself.innerHTML =
    '<div style="margin-right:1vh" class="img"><img style="margin-right:1vh" class="png" src="img/user.png" alt="soy ese"><div class="txt">@me</div></div>';
  items.innerHTML =
    '<div class="txt">reservaciones</div><div class="txt">buscar habitacion 🔎</div>';
  items.style = "font-size:3vh";
    if (ancho<900)
    {
        items.style.fontSize="2vh"; 
  logo.children[1].style.fontSize = "1.7vh";
    }
    else{        items.style.fontSize="3vh"; 
    logo.children[1].style.fontSize = "2vh";}
  }
  else
  {
    logo.innerHTML =
          '<img class="png" src="img/logo.png"><div style="font-size:2vh" class="txt">HOTEL HEAVY</div>';
        myself.innerHTML =
          '<div style="margin-right:1vh;font-size:2vh" class="img"><img style="margin-right:1vh" class="png" src="img/user.png" alt="soy ese"><div class="txt">@me</div></div>';
        items.innerHTML = "";
   
  }

}

//Altura: ${window.screen.height}`)};

async function get_e(url)
{
    var txt = await fetch(url);
    txt = await txt.text();
    return txt;
}
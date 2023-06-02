import requests as r

from sql.controllers import generic_query as q
from flask import jsonify


from app import app

from procesos import date as fecha




from sql.query import login as l
from sql.query.reservaciones import consultar_reservacion as reservacion

from sql.query.ventas import ventas
from sql.query.clientes import clientes
from sql.query.productos import productos

from sql.query import empleado as empleados
from sql.query.reservaciones import reservacion as reservas
from sql.query.habitaciones import habitacion as room, web as habitacionesweb

#WEB
from sql.query.productos import web as productosweb
from sql.query.ventas import web as ventasweb
from sql.query.reservaciones import web as reservacionesweb, alterar as chk


#LOGIN // FUNCIONANDO AL 100%
@app.route('/login&u=<user>&p=<password>')
def login(user, password):return (l.q_login(user, password))

#FUNCION CONSULTAR HABITACIONES DISPONIBLES // FUNCIONANDO AL 100%
@app.route("/fechasdisponibles/<checkin>_<checkout>")
def fechas(checkin, checkout):return (reservacion.buscar_d(checkin, checkout))

@app.route("/rooms/<id>")
def buscar_cuarto(id): return room.buscar(id)
# @app.route("/rooms/crear/<tipo>")
# def buscar_cuarto(id): return room.buscar(id)
@app.route("/rooms/tipos")
def tipos_habitacion(): return room.tipos()
@app.route("/rooms/estados")
def estados_habitacion(): return room.estados()
@app.route("/rooms/crear/p=<piso>_a=<apt>_t=<tipo>")
def crear_habitacion(piso, apt, tipo): return room.crear(piso, apt, tipo)
@app.route("/rooms/editar/p=<piso>_a=<apt>_e=<estado>")
def editar_habitacion(piso, apt, estado): return room.editar(piso, apt, estado)
# def buscar_cuarto(id): return q.execute("drop view vw_habitaciones_d")
#NO HACE NADA LOL, SOLO UN EASTER EGG TONTO XD // XD
# @app.route('/')
# def root(): return '<button id="b" style="text-align: center; margin: 50px; '\
#            'padding: 10px;" onclick="alert(\'EL ª-LAN subneteo\');">'\
#            'Has descubierto el easter egg papu</button>'

#ID MAXIMA DE UNA TABLA // FUNCIONANDO AL 100%
@app.route('/maxid/<par>')
def maxid(par):return ((q.query_db(f"call max_val('{par}')"))[0][0])

#BUSCAR UN CLIENTE POR SU TELEFONO O SU CURP //FUNCIONANDO AL 100%
@app.route('/clientes/c=<curp>_p=<phone>')
def buscarcliente(curp, phone):return clientes.buscar(curp, phone)


#
#OBSOLETO PROBABLEMENTE
#
@app.route('/estados.json')
def estado():
    query = f"select * from estados"
    json = {};a=0
    json["estados"] = []
    fetched = q.query_db(query)
    for i in fetched:
        json["estados"].append(i[1])
    # return str(fetched)
    return jsonify(json)



#EDITAR DATOS DE UN CLIENTE
@app.route('/clientes/edit/i=<id>_n=<name>_m=<mail>_p=<phone>_c=<curp>_pw=<pwd>')
def editar(id, name, mail, phone, curp, pwd):return clientes.editar(id, name, mail, phone, curp, pwd)

#CREAR CLIENTE CON ID
@app.route('/clientes/create/i=<id>_n=<name>_m=<mail>_p=<phone>_c=<curp>_pw=<pwd>')
def crear_cliente(id, name, mail, phone, curp, pwd):return clientes.crear(id, name, mail, phone, curp, pwd)

@app.route('/clientes/login/<u>_<p>')
def login_c(u,p):return clientes.login(u,p)

#BUSCAR UN PRODUCTO EN BASE A LOS PARAMETROS DADOS
#primer parametro = minimo
#segundo parametro = maximo
#tercer parametro = estado del prod
@app.route('/productos/<pars>')
def productos_f(pars):return productos.filtrar(pars)

#CREAR JSON DE LOS PRODUCTOS DISPONIBLES
@app.route('/productos.json')
def productos_json():return productos.productos()

#CREA UN REPORTE HTML DEL LISTADO DE PRODUCTOS FILTRADOS
@app.route('/productos/web/<pars>_<empleado>_<r>')
def productos_web(pars, empleado,r ):return productosweb.renderear(pars, empleado, r)

#CREA UN REPORTE HTML DEL LISTADO DE HABITACIONES
@app.route('/habitaciones/web/<pars>_<empleado>_<s>')
def habitaciones_web(pars, empleado, s):return habitacionesweb.renderear(pars, empleado, s)

#EN PRUEBAS
@app.route('/reservar/<id>+<idc>+<ad>+<kid>+<checkin>+<checkout>+<id_h>')
def reservar(id,idc,ad,kid,checkin,checkout,id_h): return reservas.reservar(id,idc,ad,kid,checkin,checkout,id_h)


@app.route('/reservar/mult/<id>_<idc>_<pars>_<ide>')
def reservarmult(id, idc, pars, ide): return reservas.reservar_mult(id,idc, pars, ide)
@app.route('/reservaciones/web/<timestamp>')
def informe_reservacion(timestamp): return reservacionesweb.renderear(timestamp)

@app.route('/reservaciones/<ts>')
def b_reservaciones(ts):return reservacion.buscar(ts)
@app.route('/alterar/<ts>_<e>')
def alterar(ts,e): return chk.alterar(ts,e)
@app.route('/checkin/<ts>')
def checkin(ts): return chk.checkin(ts)
#RETORNA TODOS LOS DATOS DE UN USUARIO
@app.route('/empleados/<id>')
def buscar_usuario(id):return empleados.buscar(id)

#GENERA UN JSON DE UNA VENTA
@app.route('/ventas/<id>')
def ventas_json(id):return ventas.ventas(id)
#GENERA UN REPORTE HTML DE UNA VENTA
@app.route('/ventas/web/<id>_<empleado>_<docname>')
def ventas_web(id, empleado, docname):return ventasweb.renderear(id, empleado, docname)
@app.route('/web/login/u=<u>&p=<p>')
def login_web(u, p):return l.q_login_web(u,p)

@app.route('/post/<dest>{_}<msg>')
def posting(dest, msg):
    a = r.post('http://localhost/kim/recuperar.php', data={"mensaje":msg.replace('\e', ' ').replace('Ã±', 'ñ'),"destino":dest})
    
    return str(a.status_code)
#Corre la APP
app.run(host='0.0.0.0', debug=True, port=8000)

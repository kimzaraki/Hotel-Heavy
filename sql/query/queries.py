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

#WEB
from sql.query.productos import web as productosweb
from sql.query.ventas import web as ventasweb
from sql.query.reservaciones import web as reservacionesweb


#LOGIN // FUNCIONANDO AL 100%
@app.route('/login&u=<user>&p=<password>')
def login(user, password):return (l.q_login(user, password))

#FUNCION CONSULTAR HABITACIONES DISPONIBLES // FUNCIONANDO AL 100%
@app.route("/fechasdisponibles/<checkin>_<checkout>")
def fechas(checkin, checkout):return (reservacion.buscar_d(checkin, checkout))

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
@app.route('/estado.json')
def estado():
    query = f"select * from estados"
    json = {};a=0
    fetched = q.query_db(query)
    for i in fetched:
        json[f"e{a}"] = {
            "id" :  i[0],
            "estado" : i[1]
        };a+=1
    # return str(fetched)
    return jsonify(json)



#EDITAR DATOS DE UN CLIENTE
@app.route('/clientes/edit/i=<id>_n=<name>_m=<mail>_p=<phone>_c=<curp>')
def editar(id, name, mail, phone, curp):return clientes.editar(id, name, mail, phone, curp)

#CREAR CLIENTE CON ID
@app.route('/clientes/create/i=<id>_n=<name>_m=<mail>_p=<phone>_c=<curp>')
def crear_cliente(id, name, mail, phone, curp):return clientes.crear(id, name, mail, phone, curp)



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
@app.route('/productos/web/<pars>_<empleado>')
def productos_web(pars, empleado):
    print("a")
    return productosweb.renderear(pars, empleado)

#EN PRUEBAS
@app.route('/reservar/<id>+<idc>+<ad>+<kid>+<checkin>+<checkout>+<id_h>')
def reservar(id,idc,ad,kid,checkin,checkout,id_h): return reservas.reservar(id,idc,ad,kid,checkin,checkout,id_h)


@app.route('/reservar/mult/<id>_<idc>_<pars>_<ide>')
def reservarmult(id, idc, pars, ide): return reservas.reservar_mult(id,idc, pars, ide)
@app.route('/reservaciones/web/<timestamp>')
def informe_reservacion(timestamp): return reservacionesweb.renderear(timestamp)

@app.route('/reservaciones/<ts>')
def b_reservaciones(ts):return reservacion.buscar(ts)

#RETORNA TODOS LOS DATOS DE UN USUARIO
@app.route('/empleados/<id>')
def buscar_usuario(id):return empleados.buscar(id)

#GENERA UN JSON DE UNA VENTA
@app.route('/ventas/<id>')
def ventas_json(id):return ventas.ventas(id)
#GENERA UN REPORTE HTML DE UNA VENTA
@app.route('/ventas/web/<id>_<empleado>_<docname>')
def ventas_web(id, empleado, docname):return ventasweb.renderear(id, empleado, docname)


#Corre la APP
app.run(host='0.0.0.0', debug=True, port=80)

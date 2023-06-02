from sql.controllers import generic_query as q
from flask import jsonify
from procesos import procedimiento as proc
def buscar(id):
    query = f"select * from vw_habitaciones_d where id = '{id}'"
    r = q.query_db(query)
    # print(r)
    # return r
    return crearjson(r)

def tipos():
    query = "select name, descripcion from productos"
    r = q.query_db(query); i=0;json={}
    for room in r:
        json[f"r{i}"]= {"tipo":room[0].split(' ')[1], "descripcion": room[1]};i+=1
    return jsonify(json)
def estados():
    query = "select estado from estados"
    r = q.query_db(query); i=0;json={}
    for estado in r:
        json[f"e{i}"]= estado[0];i+=1
    return jsonify(json)

def maxroom():return proc.maxid("habitaciones")
    
def crearjson(f):
    if f == []: return {"encontrado" : '0'}
    room=f[0]
    
    if not room[7]: room[7] = 'Nadie'
    json = {
        "encontrado" : '1',
        "id": room[0],
        "estado": room[3],
        "piso": room[1],
        "apt":room[2],
        "tipo":room[4].split(' ')[1],
        "descripcion":room[5],
        "precio":room[6],
        "ultimo_cliente":room[7]
    }
    # if not room[7]: print("XD")
    return jsonify(json)

def crear(piso, apt, tipo):
    quwu = f"select * from habitaciones where piso = '{piso}' and num_habitacion = '{apt}'"
    #return quwu
    busqueda = q.query_db(quwu)

    if busqueda != []: return "0"
    if buscar_h(piso, apt) != []: return "0"
    qe = f"insert into habitaciones values \
    ('{int(maxroom())+1}','{piso}', '{apt}', '1', '{tipo}')"
    q.execute(qe)
    return "1"
def editar(piso, apt, estado):
    a = buscar_h(piso, apt)[0]
    if a == []: return "0"
    qe = f"update habitaciones set estado = '{estado}' where id = '{a[0]}'"
    # return qe
    q.execute(qe);return "1"

buscar_h = lambda piso, apt: q.query_db(f"select * from habitaciones where piso=? and num_habitacion=?", (piso, apt))

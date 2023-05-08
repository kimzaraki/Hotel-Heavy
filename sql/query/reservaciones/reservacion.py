#import datetime
from datetime import datetime

from sql.controllers import generic_query as q
from flask import jsonify
from procesos import date as fecha
from sql.query import empleado as q_emp



def reservar(id,idc,ad,kid,checkin,checkout,id_h):
    date = fecha.timestamp()
    query = f"insert into reservaciones values ('{id}','{idc}','{str(date)}','{checkin}', '{checkout}' , '{ad}', '{kid}', '{id_h}')"
    q.execute(query)
    return "Reservacion de forma satisfactoria"


def reservar_q(vals):
    q.execute(f"insert into reservaciones values {vals}")
    return fecha.timestamp()


def reservar_mult(id, idc, valores, ide):
    valores = valores[:-1];print(valores)
    reservas = valores.split('>');date = fecha.timestamp();cadena = ''
    for i in reservas:
        i = i.split('+')
        ci = datetime.strptime(i[0], '%d%m%Y')
        co = datetime.strptime(i[1], '%d%m%Y')
        diferencia = co- ci
        dias = diferencia.days
        print("total: $" + str(dias))
        total = i[0]
        cadena += f"('{id}', '{idc}', '{str(date)}', '{i[0]}', '{i[1]}', '{i[2]}', '{i[3]}', {ide}) ,"
    cadena = cadena[:-1]
    return reservar_q(cadena)

def buscar_disponibles(timestamp):
    fr = q.query_db(f"select * from reservaciones where fechahr_solicitud = '{timestamp}'")
    n = "NO SE ENCONTRO NADA :C"
    if fr == []: return ([],[],[])
    cliente = q.query_db(f"select * from clientes where id = '{fr[0][1]}'")[0]
    json = {
        "cliente" : cliente[0],
        "empleado" : q_emp.get(fr[0][7]),
        "checkin" : fr[0][3],"checkout" : fr[0][4]
    }; n=0;filas=""
    checkin = fr[0][3]
    fw = q.query_db(f"select * from vw_reservaciones where Fecha = '{timestamp}'")
    q2 = f"select Presio from vw_habitaciones "; c = "where"
    for i in fr:
        q2 += f"{c} id = '{i[7]}' ";c = "or"
    f2= q.query_db(q2)
    return (fr, f2, fw)
from sql.controllers import generic_query as q
from flask import jsonify


def alterar(ts, estado):
    (rooms, vw_rooms)= get_reservation(ts)
    if vw_rooms==[]:return {"encontrado":"0"}
    (json,q2)=get_json_and_q(rooms,vw_rooms,True)
    ocupado(q2, estado)
    return jsonify(json)

def checkin(ts):
    (rooms, vw_rooms)= get_reservation(ts)
    if vw_rooms==[]:return {"encontrado":"0"}
    (json)=get_json_and_q(rooms,vw_rooms,False)
    return jsonify(json)
    
def get_reservation(ts):
    rooms= q.query_db(f"select * from reservaciones where fechahr_solicitud = '{ts}'")
    vw_rooms= q.query_db(f"select * from vw_reservaciones where Fecha = '{ts}'")
    return (rooms,vw_rooms)
def ocupado(q2, estado):
    print(f"update habitaciones set estado = '{estado}' where {q2}")
    q.execute(f"update habitaciones set estado = '{estado}' where {q2}")
def get_json_and_q(r1,vw_r1,b):
    json={};rs=[];json['rooms']=[];json['datos']={}
    json['datos']['cliente']=vw_r1[0][2]
    json['datos']['checkin']=str(vw_r1[0][4])
    json['datos']['checkout']=str(vw_r1[0][5])
    (json,rs) = get_json(json,vw_r1)
    query=get_q(rs)
    if not b: return json
    return(json,query)
def get_json(json, vw_r1):
    rs=[]
    for i in range(len(vw_r1)):
        d_room = vw_r1[i]
        json['rooms'].append(
            {
                "subtotal":d_room[11],
                "personas":d_room[6],
                "apt":d_room[8],
                "piso":d_room[9]
            }
        )
        rs.append(f"id = '{d_room[i]}' or ")
        print (d_room)
        print(i)
    return (json,rs)
def get_q(rs):
    query =''
    for i in rs:
        query += i
    return query[0:-3]

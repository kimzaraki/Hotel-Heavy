from sql.controllers import generic_query as q
from flask import jsonify
from sql.query import empleado as q_emp

def ventas(id):
    query = f"select p.ID_reservacion , prod.name , c.id, c.name, c.telefono, c.correo, p.Noches , p.fecha, prod.precio \
from vw_reservaciones p \
left join clientes c on p.ID_reservacion  = c.id \
left join habitaciones p2 on p.ID_habitacion  = p2.id \
left join productos prod on prod.id = p2.id_prod \
where p.Fecha  = {id}"
    fetched = q.query_db(query)
    json = {"encontrado" : ""}
    if fetched==[]: 
        json["encontrado"] = "0";return jsonify(json)
    json={
        "encontrado" : "1",
        "cliente" : fetched[0][3],
        "correo" : fetched[0][5],
        "telefono" : fetched[0][4],
        "fecha" : {

            "d" : str(fetched[0][7][0:2]),
            "m" : str(fetched[0][7][2:4]),
            "y" : str(fetched[0][7][-4:])
        },
        "articulos" : {
            "nombre" : {
        
            },
            "cantidades" : {
        },
            "precios" : {
        }
        }   
    }

    a = 0
    for i in fetched:
        json['articulos']['nombre'][f"a{a}"]= f"{i[1]}"
        json['articulos']["cantidades"][f'c{a}']= f"{i[6]}"
        json['articulos']["precios"][f"p{a}"]= f"{i[8]}"
        a+=1
    return jsonify(json)
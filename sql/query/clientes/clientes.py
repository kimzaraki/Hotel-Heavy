from sql.controllers import generic_query as q
from flask import jsonify


#BUSCAR CLIENTE
def buscar(curp, phone):
    query = f"select * from clientes "
    json = {
        "encontrado" : "0"
    }
    if curp == "$" and phone == "$":
        json["encontrado"] = "0"
        return json
    elif phone == "$":
        query += f"where curp = '{curp}'"
    elif curp == "$":
        query += f"where telefono = {phone}"
    else:
        fetched = q.query_db(query + f"where curp = '{curp}'")
        fetched2 = q.query_db(query + f"where telefono = {phone}")
        if fetched != [] and fetched2 != []:
            if fetched[0][4] == fetched2[0][4]:
                json = crear_json(fetched)
                return jsonify(json)
    fetched = q.query_db(query)
    if fetched != []:
        json = crear_json(fetched)
    return jsonify(json)


#CREAR CLIENTE
def crear(id, name, mail, phone, curp):
    mail = mail.replace(">", '.')
    query = f"insert into clientes values('{id}','{name}','{phone}','{mail}','{curp}')"
    q.execute(query)
    return(f"SE HA AGREGADO nombre = {name}\ntelefono = '{phone}'\ncorreo = '{mail}'\ncurp = '{curp}'\n al usuario con el id {id}")

def editar(id, name, mail, phone, curp):
    mail = mail.replace(">", '.')
    query = f"update clientes set name = '{name}', telefono = '{phone}', correo = '{mail}', curp = '{curp}' where id = '{id}'"
    q.execute(query)
    return(f"SE HA MODIFICADO nombre = {name}\ntelefono = '{phone}'\ncorreo = '{mail}'\ncurp = '{curp}'\n al usuario con el id {id}")

#CREAR JSON
def crear_json(t):
    json ={
        "encontrado" : "1",
        "id" : t[0][0],
        "nombre" : t[0][1],
        "telefono" : t[0][2],
        "correo" : t[0][3],
        "curp" : t[0][4]
    }
    return json
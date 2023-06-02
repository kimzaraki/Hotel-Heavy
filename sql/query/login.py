from sql.controllers import generic_query as q
from flask import jsonify
#NO TOCAR, TODO ESTA GENIAL
def q_login(user, password):
    query = f"SELECT * FROM empleados where usuario = '{user}'"
    # print(query)
    json = {}
    fetched = q.query_db(query)
    if fetched != []:
        # print("trae cosillas")
        json["id"]= fetched[0][0]
        json["user"]= fetched[0][1]
        json["nombre"]= fetched[0][4]
#usuario no encontrado
    else:
        json["sesion"] = "2"
        return json
    # print(fetched)
    
    pwd = fetched[0][2]
    
    print(fetched)
    # if fetched[0] == null: return '2'
    # return str(fetched)

#login correcto
    if password == pwd: json["sesion"] = "1"
#contraseña incorrecta
    else: json["sesion"] = "0"
    return jsonify(json)




def q_login_web(user, password):
    par = "telefono"
    if "@" in user: par = "correo"
    #quitar el espacio final
    if user[-1]==' ': user = user[0:-1]
    #si hay un espacio despues de esto hay espacios
    if ' ' in user: return {"sesion":"0", "error": "Espacio en el numero"}
    #si es un telefono y no mide 10
    if len(user) != 10 and par[0] == 't': return {"sesion":"0", "error": "Telefono incorrecto"}
    query = f"SELECT * FROM clientes where {par} = '{user}'"
    # print(query)
    fetched = q.query_db(query); json = {}
    if fetched != []:
        # print("trae cosillas")
        json["id"]= fetched[0][0]
        json["phone"]= fetched[0][2]
        json["correo"]= fetched[0][3]
        json["nombre"]= fetched[0][1]
        json["curp"]= fetched[0][4]
#usuario no encontrado
    else: return {"sesion": "2"}
    # print(fetched)
    pwd = fetched[0][5]
    
    print(fetched)
    # if fetched[0] == null: return '2'
    # return str(fetched)

#login correcto
    if password == pwd: json["sesion"] = "1"
#contraseña incorrecta
    else: json["sesion"] = "0"
    return jsonify(json)
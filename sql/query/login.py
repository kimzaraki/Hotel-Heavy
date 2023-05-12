from sql.controllers import generic_query as q
from flask import jsonify
#NO TOCAR, TODO ESTA GENIAL
def q_login(user, password):
    query = f"SELECT * FROM empleados where usuario = '{user}'"
    # print(query)
    fetched = q.query_db(query)
    # print(fetched)
    json = {
        "id" : "",
        "user" : "",
        "nombre" : "",
        "sesion" : ""
    }
    pwd = fetched[0][2]
    if fetched != []:
        print("trae cosillas")
        json["id"]= fetched[0][0]
        json["user"]= fetched[0][1]
        json["nombre"]= fetched[0][4]
#usuario no encontrado
    else:
        json["sesion"] = "2"
    print(fetched)
    # if fetched[0] == null: return '2'
    # return str(fetched)

#login correcto
    if password == pwd: json["sesion"] = "1"
#contraseña incorrecta
    else: json["sesion"] = "0"
    return jsonify(json)
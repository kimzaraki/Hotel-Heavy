from sql.controllers import generic_query as q
from flask import jsonify
def get(id): return q.query_db(f"select * from empleados where id = {id}")[0][4]

def buscar(id):
    query = f'SELECT e.id, e.usuario, e.nombre, p.puesto, p.salario FROM empleados e left join puestos p on e.puesto = p.id where e.id = {id}'
    # print(query)
    
    fetched = q.query_db(query)

    # print(fetched)
    if fetched != []:
        usuario = fetched[0]
#usuario no encontrado
    else: return jsonify({"encontrado" : "0"})
    json={}
    json["encontrado"] = "1";json["id"] = usuario[0]
    json["usuario"] = usuario[1];json["puesto"] = usuario[3]
    json["nombre"] = usuario[2]; json["salario"] = usuario[4]
    return jsonify(json)
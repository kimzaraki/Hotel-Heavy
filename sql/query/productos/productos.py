from sql.controllers import generic_query as q
from flask import jsonify


def productos():
    query = f"select p.id, p.name, p.descripcion, p.precio, e.estado, c.categoria from productos p left join estados e on p.estado = e.id left join categorias c on p.categoria = c.id"
    fetched = q.query_db(query)
    json = crear_json(fetched)
    return jsonify(json)
def filtrar(pars):
    lista = pars.split('+')
    # return (lista)
    params = []
    if lista[0] == "$":params.append(False)
    else: params.append(True)
    if lista[1] == "$":params.append(False)
    else: params.append(True)
    if lista[2] == "$":params.append(False)
    else: params.append(True)
    query = "select p.id, p.name, p.descripcion, p.precio, e.estado, c.categoria from productos p left join estados e on p.estado = e.id left join categorias c on p.categoria = c.id "
    # print(params)
    #si se filtra between
    if params[0] == True and params[1] == True :
        query+= f"where p.precio >= {lista[0]} and p.precio <= {lista[1]}"
        #estado elegido
        if params[2] == True:
            query+= f" and p.estado = {lista[2]}"
    #si se filtra mayor igual a
    elif params[0] == True:
        query+= f"where p.precio >= {lista[0]}"
        if params[2] == True:
            query+= f" and p.estado = {lista[2]}"
    elif params[1] == True:
        query+= f"where p.precio <= {lista[1]}"
        if params[2] == True:
            query+= f" and p.estado = {lista[2]}"
    elif params[2] == True:
        query+= f"where p.estado = {lista[2]}"
    # print(query)
    # if 
    fetched = q.query_db(query)
    json = crear_json(fetched)
    # print(str(fetched))
    # json = crear_json(fetched)
    return jsonify(json)


#crear json
def crear_json(fetched):
    json = {};a=0
    for i in fetched:
        json[f"p{a}"] = {
            "id" : i[0],
            "nombre" : i[1],
            "desc" : i[2],
            "precio" : i[3],
            "estado" : i[4],
            "categoria" : i[5],
        }
        a+=1
    return (json)
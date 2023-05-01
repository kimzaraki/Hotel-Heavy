from sql.controllers import generic_query as q
from flask import jsonify

from sql.query import archivo as file
from sql.query import empleado as q_emp
from procesos import date as fecha
def renderear(pars, empleado):
    lista = pars.split('+')
    # return (lista)
    params = []
    if lista[0] == "$":params.append(False)
    else: params.append(True)
    if lista[1] == "$": params.append(False) 
    else: params.append(True)
    if lista[2] == "$": params.append(False)
    else: params.append(True)
    if lista[3] == "$": params.append(False)
    else: params.append(True)
    if lista[4] == "$": params.append(False)
    else: params.append(True)
    if lista[5] == "$": params.append(False)
    else: params.append(True)
    if lista[6] == "$": params.append(False)
    else: params.append(True)
    empleado = q_emp.get(empleado)
    # print(empleado)
    query = "select p.id, p.name, p.descripcion, p.precio, e.estado, c.categoria from productos p left join estados e on p.estado = e.id left join categorias c on p.categoria = c.id"
    min = "0";max = lista[1]
    if lista[0] != "$": 
        min = lista[0]
    add = False; maxear = False
    if max == "$": maxear = True
    fetched = q.query_db(query)
    #json = crear_json_prods(fetched)
    htmlfile="";rows=""
    # return str(json)
    for i in fetched:
        # print((i))
        add = False
        if (maxear): max = i[3]
        if not params[3] and not params[4] and not params[5] and not params[6]: 
            if comparar(i[3], min, max): 
                add = True
        else:
            if params[3]: 
                if i[5] == "Habitaciones" * comparar(i[3], min, max): add = True
            if params[4]: 
                print(i[5])
                if i[5] == "Servicios" * comparar(i[3], min, max): add = True
            if params[5]: 
                if i[5] == "Alimentos" * comparar(i[3], min, max): add = True
            if params[6]: 
                if i[5] == "Bebidas"* comparar(i[3], min, max): add = True
            # if 
        # print(add)
        # print(str(add))
        if add: 
            rows = add_table(rows, i)
    # print(rows)
    
    # for i in fetched:
    #     params[]
    htmlfile = file.read('webon/reporte_p.html')
    htmlfile = htmlfile.replace("@FILAS", rows)
    htmlfile = htmlfile.replace("@NOMBREEMP", empleado)
    htmlfile = htmlfile.replace("@FECHA", fecha.hoy())
    
    return htmlfile

#Agregar tabla web
def add_table(tabla, i):
    tabla += "<tr>"
    tabla += "<td>" + f"{i[1]}: {i[2]}" + "</td>"
    tabla += "<td>" + f"{i[5]}"+ "</td>"
    tabla += "<td>" + f"${i[3]}" + "</td>"
    tabla += "<td>" + f"{i[4]}" + "</td>"
    tabla += "</tr>"
    # print(tabla)
    # print (tabla + "QUE TONTA")
    return tabla


#COMPARACION ENTRE VALORES FILTRADOS
def comparar(val, min, max):
    return comparar_min(val, min) and comparar_max(val, max)
def comparar_min(val,min):
    return(int(val) >= int(min))
def comparar_max(val,max):
    return (int(val) <= int(max))
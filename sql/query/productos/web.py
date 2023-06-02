from sql.controllers import generic_query as q
from flask import jsonify

from sql.query import archivo as file
from sql.query import empleado as q_emp
from procesos import date as fecha
def renderear(pars, empleado, r):
    lista = pars.split('+')
    # return (lista)
    params = []
    filtro = ""
    if lista[0] == "$":params.append(False)
    else: 
        filtro += f"Precio min: ${lista[0]}, "
        params.append(True)
    if lista[1] == "$": params.append(False) 
    else: 
        filtro += f"Precio max: ${lista[1]}, "
        params.append(True)
    if lista[2] == "$": params.append(False)
    else: params.append(True)
    empleado = q_emp.get(empleado)
    # print(empleado)
    query = "select * from productos"
    f2 = q.query_db("select * from estados");e=[]
    for i in f2: e.append(i)
    min = "0";max = lista[1]
    if params[0]: min = lista[0]
    add = False; maxear = False
    if params[1]: maxear = True
    if params[2]: filtro += f"Estado: {e[int(lista[2])-1][1]}, "
    fetched = q.query_db(query)
    #json = crear_json_prods(fetched)
    htmlfile="";rows=""
    # return str(json)
    r = r=="1"
    # return str(r)
    fetched.sort(key=sort_precio, reverse=r)
    for i in fetched:
        # print((i))
        if params[0] and int(i[3]) < int(lista[0]):continue
        if params[1] and int(i[3]) > int(lista[1]):continue
        if params[2] and int(i[4]) != int(lista[2]):continue
        rows += add_table(i, e[int(i[4])-1])
    # print(rows)
    
    # for i in fetched:
    #     params[]
    if filtro == "": filtro = "Todos, "
    if not r: filtro += "Orden ascendente, "
    else: filtro += "Orden descendiente, "
    filtro = filtro[0:-2]
    htmlfile = file.read('webon/reporte_p.html').replace("@FILAS", rows)\
    .replace("@NOMBREEMP", empleado).replace("@FECHA", fecha.hoy()).replace("@FILTRO", filtro)
    
    return htmlfile

#Agregar tabla web
def add_table(i, e):
    return f"<tr><td>{i[1]}: {i[2]}</td><td>${i[3]}</td><td>{e[1]}</td></tr>"
    # print(tabla)
    # print (tabla + "QUE TONTA")
def sort_precio(a): return int(a[3])
def sort_nombre(a): return a[1]

#COMPARACION ENTRE VALORES FILTRADOS
def comparar(val, min, max):
    return comparar_min(val, min) and comparar_max(val, max)
def comparar_min(val,min):
    return(int(val) >= int(min))
def comparar_max(val,max):
    return (int(val) <= int(max))
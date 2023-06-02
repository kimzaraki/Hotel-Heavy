from flask import jsonify

from sql.controllers import generic_query as q
from sql.query import archivo as file
from sql.query import empleado as q_emp
from procesos import date as fecha

def renderear(pars, empleado, s):
    lista = pars.split('+')
    params = [lista[0] != "$", lista[1] != "$", lista[2] != "$"]
    empleado = q_emp.get(empleado)
    # return (params)
    query = "SELECT * FROM habitaciones";e=[];t=[]
    for i in q.query_db("SELECT * FROM estados"): e.append(i)
    for i in q.query_db("SELECT * FROM productos"): t.append(i)
    rows = ""
    
    fetched = q.query_db(query)
    # 
    (fetched, f) = ordenar(s, fetched)
    # return str(fetched)
    for i in fetched:
        # print(params[0])
        # print(f"{i[1]}, {lista[0]}")
        if params[0] and i[1] != lista[0]:continue
        if params[1]: 
            if t[int(lista[1])][0] != i[4]:continue
        # else: print(lista[1])
        if params[2]:
            print (i[3])
            if e[int(lista[2])][0] != i[3]:continue
        # else: print(f'{i[3]}. {e[int(lista[2])-1][0]}')
        rows += add_table(i, e[int(i[3])-1], t[int(i[4])-1])
    
    filtro = ""
    if lista[0] != "$":
        filtro += f"Piso: {lista[0]}, "
    if lista[1] != "$":
        filtro += f"Tipo: {t[int(lista[1])][1]}, "
    if lista[2] != "$":
        filtro += f"Estado: {e[int(lista[2])][1]}, "
    
    if filtro == "":
        filtro = "Todos, "
    filtro += f
    filtro = filtro[:-2]
    
    htmlfile = file.read('webon/reporte_h.html').replace("@FILAS", rows)\
        .replace("@NOMBREEMP", empleado).replace("@FECHA", fecha.hoy()).replace("@FILTRO", filtro)
    return htmlfile

#sort
#piso, apt, estado
def sort_piso(num): return int(num[1])
def sort_apt(num): return int(num[2])
def sort_estado(stri):return stri[3]
def sort_tipo(stri):return int(stri[4])

def ordenar(s, f):

    if s == '0': 
        return (sorted(f, key=lambda x: (int(x[1]), int(x[2]))), "Ordenado por piso y apt, ascendente, ")
    if s == '1':
        return (sorted(f, key=lambda x: (int(x[1]), int(x[2])), reverse = True), "Ordenado por piso y apt, descendiente, ")
    if s == '2':
        # return (f,"a")
        return (sorted(f, key=sort_estado), "Ordenado por estado, ascendente")
    if s == '3': 
        return (sorted(f, key=sort_estado, reverse=True), "Ordenado por estado, descendiente")
    if s == '4': 
        return (sorted(f,key=sort_tipo, reverse=False), "Ordenado por tipo, ascendente")
    if s == '5': 
        return (sorted(f,key=sort_tipo, reverse=True), "Ordenado por tipo, descendiente")
    return f
# Agregar tabla web
def add_table(i, estado, tipo):
    return f"<tr><td>{i[1]}</td><td>{i[2]}</td><td>{tipo[1]}</td><td>{estado[1]}</td></tr>"

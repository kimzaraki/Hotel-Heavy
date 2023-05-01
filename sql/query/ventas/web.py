from sql.controllers import generic_query as q
from flask import jsonify
from sql.query import empleado as q_emp
from procesos import date as fecha
from sql.query import archivo as file


def renderear(id, empleado, docname):
    query = "select p.id_order, p2.name, c.id, c.name, c.telefono, c.correo, p.cantidad, p.fecha, p2.precio, p2.descripcion from pedidos p right join clientes c on p.id_cliente = c.id right join productos p2 on p.id_prod = p2.id where p.id_order  = " + id
    fetched = q.query_db(query)
    empleado = q_emp.get(empleado)
    print(empleado)
    json={
        "cliente" : fetched[0][3],
        "fecha" : {

            "d" : str(fetched[0][7][0:2]),
            "m" : str(fetched[0][7][2:4]),
            "y" : str(fetched[0][7][-4:])
        }
    }
    htmlfile = "";filas = ""
    total=0
    htmlfile+= file.read('webon/gastao.html')
    for i in fetched:
        #filas += add_tr([i[1], i[6], f"${i[8]}", f"${str(int(i[6])*int(i[8]))}", i[6]])
        
        filas += f"<tr><td>{i[1]}: {i[9]}</td><td>{i[6]}</td><td>${i[8]}</td><td>${int(i[8])*int(i[6])}</td></tr>"
        total+= int(i[6])*int(i[8])
    date = fecha.fecha(json['fecha']['m'], json['fecha']['d'], json['fecha']['y'])
    htmlfile = htmlfile.replace("@FILAS", filas)
    htmlfile = htmlfile.replace("@NOMBRECEP", empleado)
    htmlfile = htmlfile.replace("@FECHA", date)
    htmlfile = htmlfile.replace("@NOMBRECLI", fetched[0][3])
    htmlfile = htmlfile.replace("@NUMERO", fetched[1][0])
    htmlfile = htmlfile.replace("@DOCUMENTO", docname)
    htmlfile = htmlfile.replace("@TOTAL", f"${total}")

    # return str(fetched)
    print(filas)
    return (htmlfile)


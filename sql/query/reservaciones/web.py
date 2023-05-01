from sql.query import archivo as file
from sql.controllers import generic_query as q
from flask import jsonify
from sql.query import empleado as q_emp
from procesos import date as fecha
from sql.query.reservaciones import reservacion as r
def renderear(timestamp):
    html = file.read("webon/reservacion.html")
    #fetched = q.query_db(f"select * from vw_reservaciones_web where Fecha = '{timestamp}'")
    (fr, f2, fw) = r.buscar_disponibles(timestamp)
    print('TABLA RESERVACIONES')
    print(fr)
    print('VW RESERVACIONES TIMESTAMP')
    print(fw)
    print('PRESIOS XD')
    print(f2)
    cliente = q.query_db(f"select * from clientes where id = '{fr[0][1]}'")[0]
    json = {
        "cliente" : fw[0][1],
        "empleado" : fw[0][8],
        "checkin" : fr[0][3],"checkout" : fr[0][4]
    }; n=0;filas=""
    n=0;total=0

    #
    print('aun jala')
    for i in fw:
        # json[f"r{n}"]={
        #     "personas" : i[4]
        # }
        filas+= f"<tr><td>{i[9]}: {i[10]}</td><td align='center'>{i[6]}</td><td align='center'>{i[7]}\
            </td><td align='center'>{i[5]}</td><td align='center'>{i[5]}</td><td>${int(f2[n][0]) * int(i[12])}</td></tr>";total+=(int(f2[n][0]) * int(i[12]));n+=1
    html = html.replace("@FILAS", filas).replace("@NOMBRECLI", json["cliente"]).replace("@MAIL", cliente[3]).replace("@PHONE", cliente[2])\
    .replace("@CI", fecha.fecha(json["checkin"])).replace("@CO", fecha.fecha(json["checkout"])).replace("@EMPLEADO", json["empleado"])\
    .replace("@TOTAL", f"${total}").replace("@TIMESTAMP", timestamp)
    return html
        
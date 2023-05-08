from sql.query import archivo as file
from sql.controllers import generic_query as q
from flask import jsonify
from sql.query import empleado as q_emp
from procesos import date as fecha
from sql.query.reservaciones import reservacion as r
def renderear(timestamp):
    html = file.read("webon/reservacion.html")
    #fetched = q.query_db(f"select * from vw_reservaciones_web where Fecha = '{timestamp}'")
    (fr, f2,fw) = r.buscar_disponibles(timestamp)
    print('TABLA RESERVACIONES')
    print(fr)
    print('VW RESERVACIONES TIMESTAMP')
    print(fw)
    print('PRESIOS XD')
    print(f2)
    cliente = q.query_db(f"select * from clientes where id = '{fr[0][1]}'")[0]
    json = {
        "cliente" : fw[0][2],
        "empleado" : fw[0][10],
        "checkin" : fr[0][3],"checkout" : fr[0][4]
    }; n=0;filas=""
    n=0;total=0
    # return jsonify(json)
    #
    # print('aun jala')
    for i in fw:
        filas+= f"<tr><td>{i[7]}</td><td align='center'>{i[9]}</td><td align='center'>{i[8]}\
            </td><td align='center'>{i[6]}</td><td align='center'>{i[12]}</td><td>${int(i[12]) * int(i[11])}</td></tr>";total+=(int(i[11]) * int(i[12]));n+=1
    html = html.replace("@FILAS", filas).replace("@NOMBRECLI", json["cliente"]).replace("@MAIL", cliente[3]).replace("@PHONE", cliente[2])\
    .replace("@CI", fecha.fecha(json["checkin"])).replace("@CO", fecha.fecha(json["checkout"])).replace("@EMPLEADO", json["empleado"])\
    .replace("@TOTAL", f"${total}").replace("@TIMESTAMP", timestamp)
    return html
        
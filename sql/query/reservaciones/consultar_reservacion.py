from sql.controllers import generic_query as q
from flask import jsonify

def buscar_d(checkin, checkout):
    query = f"select * from vw_reservaciones WHERE STR_TO_DATE('{checkin}', '%d%m%Y') BETWEEN check_in  AND check_out or STR_TO_DATE('{checkout}', '%d%m%Y') BETWEEN check_in  AND check_out"
    fetched = q.query_db(query);n=0;json = {}
    for i in fetched:
        checkin = str(i[2]).split('-');checkout = str(i[3]).split('-')
        json[f'r{n}'] = {"room": i[7]};n+=1
    query2 = "select * from vw_habitaciones where estado = 'disponible' or estado = 'en uso' "
    for i in json:
        if i.startswith('r'):
            element = json[i]
            query2 += f"and id !='{element['room']}' "
    habitaciones = q.query_db(query2)
    json = {};n=0
    # return str(habitaciones)
    for i in habitaciones:
        json[f'r{n}'] ={
            "id" : i[0],
            "piso" : i[1],
            "apt" : i[2],
            "nombre" : i[4],
            "estado" : i[3],
            "precio" : i[6]           
        }
        n+=1
    return jsonify(json)
    # {
    #     public string id { get; set; }
    #     public string piso { get; set; }
    #     public string apt { get; set; }
    #     public string nombre { get; set; }
    #     public string precio { get; set; }
    #     public string estado { get; set; }
def buscar(ts):
    query = f"select * from  vw_r_json WHERE Fecha = '{ts}'"
    print('xd')
    fetched = q.query_db(query);n=0;json = {}
    for i in fetched:
        checkin = str(i[3]).split('-');checkout = str(i[4]).split('-')
        # json[f'r{n}'] = {"room": i[7]};n+=1
        json[f"r{n}"] = {
            "apt" : i[7],
            "piso" : i[6],
            "habitacion" : i[9],
            "descripcion" : i[10],
            "id" : i[0],
            "estado" : i[11],
            "precio" : i[12],
            "cliente" : i[1],
            "empleado" : i[8],
            'checkin' : checkin,
            'checkout' : checkout,
            "timestamp" : i[2],
            "personas" : i[5],

        }
        n+=1    
    return jsonify(json)
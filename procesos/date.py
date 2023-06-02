from datetime import datetime 
# FORMATEA LA FECHA CON MDY
def fecha_mdy(m, d, y):
    return f'{d} de {get_mon(m)} del {y}'

def fecha(cad8):
    d = cad8[0:2]
    m = cad8[2:4]
    y = cad8[4:8]
    return f'{d} de {get_mon(m)} del {y}'

#DA EL OBJ DE AHORA MISMO
def getnow():
    return datetime.now()
def timestamp():
    t = datetime.now();return f"{round(str(t.day))}{round(str(t.month))}{t.year}{round(str(t.hour))}{round(str(t.minute))}"
def round(val):
    if int(val) < 10:
        return f"0{val}"
    return val
def get_mon(m):
    if m == "01" or m == "1": return "enero"
    if m == "02" or m == "2": return "febrero"
    if m == "03" or m == "3": return "marzo"
    if m == "04" or m == "4": return "abril"
    if m == "05" or m == "5": return "mayo"
    if m == "06" or m == "6": return "junio"
    if m == "07" or m == "7": return "julio"
    if m == "08" or m == "8": return "agosto"
    if m == "09" or m == "9": return "septiembre"
    if m == "10": return "octubre"
    if m == "11": return "noviembre"
    if m == "12": return "diciembre"
def AMPM(hora, min):
    ap = "AM"
    if hora>=12:
        ap = "PM"
        if hora != 12: hora-=12
    return f"{hora} : {min} {ap}"
def hoy():
    now = getnow()
    # if int(now.hour) >= 12: 
    #     minutos += " PM"; hr = int(hr)-12
    # else: minutos += " AM"
    # print(now.month)
    # hora = str(now.hour)
    # if len(hora) == 1:hora = f"0{hora}"
    return f"{now.day} de {get_mon(str(now.month))} del {now.year} / {AMPM(now.hour, now.minute)}"

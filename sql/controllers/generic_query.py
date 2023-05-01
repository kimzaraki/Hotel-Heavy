from sql import conexion as sql_conn
def query_db(query, args=()):
    conn = sql_conn.get_db_connection()
    cursor = conn.cursor()
    cursor.execute(query, args)
    results = cursor.fetchall()
    #print(results)
    cursor.close()
    conn.close()
    return results
def execute(query, args=()):
    conn = sql_conn.get_db_connection()
    cursor = conn.cursor()
    cursor.execute(query)
    conn.commit()
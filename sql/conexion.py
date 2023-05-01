import pyodbc

#DATABASE DE AWS

def get_db_connection():
    conn = pyodbc.connect("Driver={MySQL ODBC 8.0 Unicode Driver};"
                          "Server=<your server>;"
                          "Database=<Your server Database>;"
                          "UID=<Your user for database>;"
                          "PWD=<your password>;"
                          "charset=utf8mb4")
    return conn

#DATABASE DE LA PC DEL PAKO TONTA
# def get_db_connection():
#     conn = pyodbc.connect("Driver={MySQL ODBC 8.0 Unicode Driver};"
#                           "Server=localhost;"
#                           "Database=esotilin;"
#                           "UID=root;"
#                           "PWD=minmin789;"
#                           "charset=utf8mb4")
#     return conn
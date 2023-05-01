from flask import Flask
import pyodbc
from sql.query import queries as q

app = Flask(__name__)

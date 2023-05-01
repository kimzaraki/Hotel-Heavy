using Newtonsoft.Json;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using _rest = proyecto.procedimientos.rest;
namespace proyecto.formsu
{
    internal class instancias
    {
        static menu.menu menu;
        public instancias() { }
        public static menu.menu get_menu()
        {
            if (menu == null)
            { menu = new menu.menu(); }
            return menu;
        }
    }
    class usuario
    {
        public static string nombre;
        public static string id;
        public static string user;
        public static usuario _inst = null;
        private usuario(string _nombre, string _id, string _user)
        {
            nombre = _nombre;
            id = _id;
            user = _user;
        }
        public static void newsesion(string _nombre, string _id, string _user)
        {
            _inst = new usuario(_nombre, _id, _user);
        }
    }
    class cliente
    {
        public static string id, nombre, telefono, correo, curp;
        public static cliente _inst = null;
        private cliente(string _id, string _nombre, string _telefono, string _correo, string _curp)
        {
            id = _id; nombre = _nombre; telefono = _telefono; correo = _correo; curp = _curp;
        }
        public static void newuser(string id, string nombre, string telefono, string correo, string curp)
        {
            _inst = new cliente(id, nombre, telefono, correo, curp);
        }
    }
    /*
    public class Producto
    {
        public string desc { get; set; }
        public string estado { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
        public string precio { get; set; }
        public string categoria { get; set; }
    }
    public class lista_articulos
    {
        public static List<Producto> lista = new List<Producto>();
        public static void load()
        {
            var productos = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(_rest.consume("http://localhost/productos.json"));
            foreach (var producto in productos) lista.Add(producto.Value);

        }

    }
    */
    public class habitacion
    {
        public string id { get; set; }
        public string piso { get; set; }
        public string apt { get; set; }
        public string nombre { get; set; }
        public string precio { get; set; }
        public string estado { get; set; }
    }
    public class lista_habitaciones
    {
        public static List<habitacion> lista;
        public static bool load(string checkin, string checkout)
        {
            lista = new List<habitacion>();
            lista.Clear();
            string j = _rest.consume($"http://localhost/fechasdisponibles/{checkin}_{checkout}");
            if (j[0] != '{') return false; 
            var json = JsonConvert.DeserializeObject<Dictionary<string, habitacion>>(j);
            foreach (var p in json) lista.Add(p.Value);
            return true;
        }
    }
}

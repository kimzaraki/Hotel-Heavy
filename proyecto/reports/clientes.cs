using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inst = proyecto.formsu;
using _rest = proyecto.procedimientos.rest;
using Krypton.Toolkit;
using Newtonsoft.Json;
using proyecto.procedimientos;

namespace proyecto.reports
{
    internal class clientes : KryptonPanel
    {
        public static string[] buscar(string phone, string curp)
        {
            string[] pars = {"$","$"};
            if (validar_curp(curp)) pars[0] = curp;
            else MessageBox.Show("NO HAY NADA EN CURP LOL");
            if (validar_telefono(phone)) pars[1] = phone;
            else MessageBox.Show("NO HAY NADA EN TELEFONO LOL");
            if (pars[0] == "$" && pars[1] == "$") { MessageBox.Show("BUSQUEDA INVALIDA"); return null;}
            string[] fetched = {"", "", "",  "", ""};
            dynamic json = JsonConvert.DeserializeObject(_rest.consume($"http://localhost/clientes/c={pars[0]}_p={pars[1]}"));
            if (json.encontrado == "0") return null;
            fetched[0] = json.id;
            fetched[1] = json.nombre;
            fetched[2] = json.telefono;
            fetched[3] = json.curp;
            fetched[4] = json.correo;
            inst.cliente.newuser(fetched[0], fetched[1], fetched[2], fetched[4], fetched[3]);
            return fetched;
        }
        public static string[] buscar(string id)
        {
            string[] pars = { "$", "$" };
            if (validar_curp(id)) pars[0] = id;
            if (validar_telefono(id)) pars[1] = id;
            if (pars[0] == "$" && pars[1] == "$") { MessageBox.Show("BUSQUEDA INVALIDA"); return null; }
            string[] fetched = { "", "", "", "", "" };
            dynamic json = JsonConvert.DeserializeObject(_rest.consume($"http://localhost/clientes/c={pars[0]}_p={pars[1]}"));
            if (json.encontrado == "0") return null;
            fetched[0] = json.id;
            fetched[1] = json.nombre;
            fetched[2] = json.telefono;
            fetched[3] = json.curp;
            fetched[4] = json.correo;
            inst.cliente.newuser(fetched[0], fetched[1], fetched[2], fetched[4], fetched[3]);
            return fetched;
        }
        public static void guardar(string id, string name, string phone, string mail, string curp, bool toedit)
        {
            //if (inst.cliente._inst == null) {
                //si el tb es de solo lectura esta editando
                if (!toedit) crear(id, name, phone, mail, curp);
                else editar(id, name, phone, mail, curp);
                agregarcliente(id, name, phone, mail, curp);

            //}
        }
        public static void agregarcliente(string id, string name, string phone, string mail, string curp) {
            inst.cliente.newuser(id, name, phone, mail, curp);
        }
        public static void crear(string id, string name, string phone, string mail, string curp)
        {
            MessageBox.Show("SE ESTA CREANDO EL CLIENTE");
            _rest.consume($"http://localhost/clientes/create/i={id}_n={name}_m={mail.Replace('.', '>')}_p={phone}_c={curp}");
            MessageBox.Show("CLIENTE CREADO CON EXITO");
        } public static void editar(string id, string name, string phone, string mail, string curp)
        {
            MessageBox.Show("SE ESTA EDITANDO EL CLIENTE");
            _rest.consume($"http://localhost/clientes/edit/i={id}_n={name}_m={mail.Replace('.', '>')}_p={phone}_c={curp}");
            MessageBox.Show("DATOS DEL CLIENTE EDITADOS CON EXITO");
        }
        public static bool validar_curp(string c) 
        { if (c.Length == 18) return true; return false; }
        public static bool validar_telefono(string c) 
        { if (c.Length == 10) return true; return false; }
        public static void toggle_readmode(KryptonTextBox t, bool c)
        {
            if (c) t.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            else t.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            t.ReadOnly = !c;
        }
    }
}

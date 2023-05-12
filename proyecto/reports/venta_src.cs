using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using kr = Krypton.Toolkit;
using dinusuario = proyecto.formsu.usuario;
using _rest = proyecto.procedimientos.rest;
using mt = proyecto.procedimientos;
using Krypton.Toolkit;


//YA JALA AL PUTAZO, NO TOCAR :V
namespace proyecto.reports
{
    internal class venta_src
    {
        public static void save(string id)
        {
            SaveFileDialog save = new SaveFileDialog();//guiardar el archivo
            save.DefaultExt = "pdf";
            save.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss")); //especificicamos el tipo de archivo y nombre
            //CORREGIR ESTO
            string url = ($"http://localhost/reservaciones/web/{id}");
            if (save.ShowDialog() == DialogResult.OK)
            {var generar = new topdf(url, save.FileName);}
        }

        public static void buscar(KryptonTextBox t_id, KryptonTextBox tb_cliente, KryptonTextBox tb_mail, KryptonTextBox tb_phone, DataGridView tabla)
        {
            if (t_id.Text == "") { MessageBox.Show("Campos Vacios"); t_id.Focus(); return; }
            string json = _rest.consume($"http://localhost/ventas/{t_id.Text}");
            //MessageBox.Show(json);
            if (json[0] != '{') { MessageBox.Show("Hubo un error en la BD"); t_id.Focus(); return; }
            dynamic p = JsonConvert.DeserializeObject(json);
            if (p.encontrado == "0") { MessageBox.Show("Venta no encontrada"); t_id.Focus(); t_id.SelectAll(); return;}
            tb_cliente.Text = p.cliente;
            tb_mail.Text = p.correo;
            tb_phone.Text = p.telefono;
            //int i = 0, j = 0;


            var nombresArticulos = new List<string>();
            foreach (string nombre in p.articulos.nombre)
            {nombresArticulos.Add(nombre);}

            var cantidades = new List<string>();
            foreach (string cantidad in p.articulos.cantidades)
            {cantidades.Add(cantidad);}

            var precios = new List<string>();
            foreach (string precio in p.articulos.precios)
            {precios.Add(precio);}

            // Alimentar la tabla con los datos de los artículos
            int total = 0;
            for (int i = 0; i < nombresArticulos.Count; i++)
            {
                string nombreArticulo = nombresArticulos.ElementAt(i);
                string cantidad = cantidades.ElementAt(i);
                string precio = precios.ElementAt(i);
                //string total = (int.Parse(cantidad.ToString()) * int.Parse(precio.ToString())).ToString();
                //MessageBox.Show($"{nombreArticulo}, {cantidad}, {precio}");
                tabla.Rows.Add(nombreArticulo, cantidad, "$" + precio, "$" + (mt.mathsu.toint(cantidad) * mt.mathsu.toint(precio)).ToString());
                total += mt.mathsu.toint(cantidad) * mt.mathsu.toint(precio);
            }
            tabla.Rows.Add("", "", "TOTAL", total.ToString());
        }
    }
}

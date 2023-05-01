using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using mt = proyecto.procedimientos;
using venta = proyecto.reports.venta_src;
using clientes = proyecto.reports.clientes;
using r_prods = proyecto.reports.reporte_prods;
using inst = proyecto.formsu;
using proyecto.procedimientos;
using System.DirectoryServices.ActiveDirectory;
using proyecto.reports;

using proyecto.reserva;
using proyecto.formsu;

namespace proyecto.menu
{
    public partial class menu : KryptonForm
    {
        reservar p_reserva = reservar.get_inst();
        p_reporte p_r_prods = p_reporte.get_inst();
        bool toedit = false;
        //NO TOCAR
        public menu()
        {InitializeComponent();
            Controls.Add(p_r_prods);
            Controls.Add(p_reserva);
            ocultar_peneles();
        }

        private void ventazToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        //
        //MENU
        //
        //CARGANDO
        /*
        private void menu_Load(object sender, EventArgs e)
        {
            //this.Controls.Add(r); r.Visible = false;
            //private navegador brw = new navegador();
            foreach (inst.Producto p in inst.lista_articulos.lista) {
                cb_s_articulo.Items.Add(p.nombre);
            }
            this.Text = "QUE DESEA HACER MIAPA?";
            ocultar_peneles();
            //brw.browsah.Url = ("http://localhost/");
            //brw.Visible = true;
        }*/
        //OCULTAR TODOS LOS MODULOS (PANELES)
        private void ocultar_peneles()
        { foreach (KryptonPanel p in Controls.OfType<KryptonPanel>()) p.Visible = false; }
        //CERRANDOLO POR COMPLETO
        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        { Application.Exit(); }
        //
        //PANEL DE VENTAS GEIS (CONSULTAR VENTA)
        //
        //CARGAR MODULO
        private void consultarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultar_peneles();
            mt.limpieza.limpiar(p_venta, tabla);
            this.Text = "CONSULTA DE VENTAS";
            p_venta.Visible = true;
            //var fr = new proyecto.reports.Generate_report(); fr.Show();this.Hide();
        }
        //GUARDAR PDF
        private void b_save_Click(object sender, EventArgs e)
        {venta.save(tb_cs_id.Text);}
        //BUSCAR VENTA
        private void b_buscar_Click(object sender, EventArgs e)
        {venta.buscar(tb_cs_id, tb_cliente, tb_mail, tb_phone, tabla);}
        //REINICIAR MODULO
        private void b_reiniciar_Click(object sender, EventArgs e)
        {mt.limpieza.limpiar(p_venta, tabla);}
        //
        //PANEL DE REPORTE DE PRODUCTOS
        //
        //MOSTRAR PANEL
        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultar_peneles();
            this.Text = "GENERADOR DE REPORTES DE PRODUCTOS";
            p_r_prods.Visible = true;
        }

        //PANEL DE CLIENTES (BUSCAR/AGREGAR)
        //
        //MOSTRAR PANEL
        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultar_peneles();
            this.Text = "APARTADO DE CLIENTES";
            canedit(false);
            limpieza.limpiar(p_clientes);
            p_clientes.Visible= true;
        }

        private void b_cc_buscar_Click(object sender, EventArgs e)
        {search();}
        //AGREGAR CLIENTE
        private void b_cc_agregar_Click(object sender, EventArgs e)
        { add(); }
        public void add()
        {
            string idmax = mt.rest.consume("http://localhost/maxid/clientes");
            clr(t_cc_curp); clr(t_cc_phone); clr(t_cc_mail); clr(t_cc_name);
            t_cc_name.Focus();
            t_cc_id.Text = $"{mathsu.toint(idmax) + 1}"; toedit = false;
            if (t_cc_curp.ReadOnly == true) { canedit(true); t_cc_name.Focus(); }
        }
        //EDITAR EL READONLY DE LOS BOTONES
        private void b_cc_editar_Click(object sender, EventArgs e)
        {if (t_cc_id.Text != "")
            {
                toedit = true;
                //clientes.toggle_readmode(t_cc_id, false);
                bool a = t_cc_curp.ReadOnly; canedit(a);
                t_cc_name.Focus(); t_cc_name.SelectAll();
            }
            else MessageBox.Show("NO PUEDES EDITAR UN CAMPO VACIO");
        }
        //PONE EN EDIT A TODOS LOS TB DE ABAJO

        private void canedit(bool a)
        {
            clientes.toggle_readmode(t_cc_curp, a);
            clientes.toggle_readmode(t_cc_phone, a);
            clientes.toggle_readmode(t_cc_name, a);
            clientes.toggle_readmode(t_cc_mail, a);
        }
        private void clr(KryptonTextBox t) {t.Clear();}
        private void b_cc_guardar_Click(object sender, EventArgs e){save();}
        void save(){clientes.guardar(t_cc_id.Text, t_cc_name.Text, t_cc_phone.Text, t_cc_mail.Text, t_cc_curp.Text, toedit);}
        void search(){
            string[] vals = clientes.buscar(t_cc_cid_b.Text);
            if (vals == null) { MessageBox.Show("No se encontro nada"); return; }
            t_cc_id.Text = vals[0];t_cc_name.Text = vals[1];t_cc_phone.Text = vals[2];
            t_cc_curp.Text = vals[3];t_cc_mail.Text = vals[4];
            canedit(false);clientes.toggle_readmode(t_cc_id, false);
        }
        private void detect_enter(object sender, KeyEventArgs e)
        {if (e.KeyCode == Keys.Enter) save();}

        private void enter_buscar(object sender, KeyEventArgs e)
        {if (e.KeyCode == Keys.Enter) search();}

        /*private void select_art(object sender, EventArgs e)
        { tb_s_precio.Text = inst.lista_articulos.lista[cb_s_articulo.SelectedIndex].precio; }
        */
        private void sumar_cant_rueda(object sender, MouseEventArgs e)
        {
            if (((KryptonTextBox)sender).Text == "") ((KryptonTextBox)sender).Text = "1";
            int cantidad = int.Parse(((KryptonTextBox)sender).Text);
            if (e.Delta > 0) cantidad++; else if (cantidad!=0)cantidad--;
            ((KryptonTextBox)sender).Text = cantidad.ToString();
        }

        //
        //PANEL DE RESERVAS
        //
        //AGREGAR RESERVACION
        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {ocultar_peneles();Text = "RESERVAR HABITACIONES";p_reserva.Visible = true;
            //r.Visible= true;
            //r.Size = new System.Drawing.Size(850, 500);
        }

        private void st_add_Click(object sender, EventArgs e)
        {
            ocultar_peneles();mt.limpieza.limpiar(p_venta, tabla);
            //toggle_cs_items(true, 180);
            this.Text = "AGREGAR ARTICULOS A VENTAS";
            p_venta.Visible = true;
        }
        /*
        private void b_s_plus_Click(object sender, EventArgs e)
        {
            int index = cb_s_articulo.SelectedIndex;
            Producto _p = lista_articulos.lista.ElementAt(index);
            DataGridViewRow row = buscar_fila(tabla, _p.nombre);
            //row[];
        }
        */
        DataGridViewRow buscar_fila(DataGridView t, string dato)
        {
            foreach (DataGridViewRow row in t.Rows) if (row.Cells["Articulos"].Value.ToString() != null)
                    if (row.Cells["Articulos"].Value.ToString() == dato) return row;
            return null;
        }
    }
}

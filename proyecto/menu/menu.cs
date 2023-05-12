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
using proyecto.usuario;
using _rest = proyecto.procedimientos.rest;
namespace proyecto.menu
{
    public partial class menu : KryptonForm
    {
        reservar p_reserva = reservar.get_inst();
        p_reporte p_r_prods = p_reporte.get_inst();
        checkin_checkout p_checkin = new checkin_checkout(paleta.p);
        clientes p_clientes = new clientes(paleta.p);
        bool toedit = false;
        //NO TOCAR
        public menu()
        {InitializeComponent();
            Controls.Add(p_r_prods);
            Controls.Add(p_reserva);
            Controls.Add(p_checkin);
            Controls.Add(p_clientes);
            paleta.set(p_venta);
            ocultar_peneles();
        }

        private void ventazToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        //
        //MENU
        //
        //CARGANDO
        private void menu_Load(object sender, EventArgs e)
        {
            //this.Controls.Add(r); r.Visible = false;
            //private navegador brw = new navegador();
            
            this.Text = "QUE DESEA HACER MIAPA?";
            ocultar_peneles();
            //brw.browsah.Url = ("http://localhost/");
            //brw.Visible = true;
        }
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
        { cambiar_p("CONSULTA DE VENTAS", p_venta);mt.limpieza.limpiar(p_venta, tabla);
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
        {cambiar_p("GENERADOR DE REPORTES DE PRODUCTOS",p_r_prods);}
        //GUARDAR PDF
        
        void toggle_cs_items(bool si, int tabla_y)
        {
            tabla.Location = new System.Drawing.Point(0, tabla_y);
        }

        void cambiar_p(string txt, KryptonPanel p)
        {ocultar_peneles();Text=txt;p.Visible=true;}
        //
        //PANEL DE CLIENTES (BUSCAR/AGREGAR)
        //
        //MOSTRAR PANEL
        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {cambiar_p("APARTADO DE CLIENTES", p_clientes);limpieza.limpiar(p_clientes);}
        //
        //PANEL DE RESERVAS
        //
        //AGREGAR RESERVACION
        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiar_p("RESERVAR HABITACIONES", p_reserva);
            //r.Visible= true;
            //r.Size = new System.Drawing.Size(850, 500);
        }

        private void st_add_Click(object sender, EventArgs e)
        {cambiar_p("AGREGAR ARTICULOS A VENTAS", p_venta);mt.limpieza.limpiar(p_venta, tabla);}

        private void checkInCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        { cambiar_p("CHECKIN Y CHECKOUT", p_checkin); }

        private void agregar_mod_habitaciones_click(object sender, EventArgs e)
        {

        }
    }
}

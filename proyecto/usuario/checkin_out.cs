using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Krypton.Toolkit;
using Newtonsoft.Json;
using proyecto.formsu;
using proyecto.procedimientos;
using proyecto.Properties;
using proyecto.reserva;
using _rest = proyecto.procedimientos.rest;
namespace proyecto.usuario
{
    public partial class checkin_out : KryptonForm
    {
        bool inout = false;
        public checkin_out()
        { InitializeComponent();
            //paleta.set(this);
            t_chk_ts.Focus(); cambiar_estado();
        }

        private void checkin_out_FormClosing(object sender, FormClosingEventArgs e)
        { Application.Exit(); }

        private void checkin_out_Load(object sender, EventArgs e)
        {}

        private void reaparecer(object sender, EventArgs e)
        { limpiar(this);t_chk_ts.Focus();

        }

        private void limpiar_click(object sender, EventArgs e)
        { limpiar(this);

        }
        private void limpiar(dynamic item)
        { chk_dtv_h.Rows.Clear();
            //LIMPIA TODO ALV;
            foreach (Control c in item.Controls) {
                if (c is KryptonPanel p) limpiar(p); else if (c is KryptonTextBox t) t.Clear();
            }
            t_chk_ts.Focus();
        }
        private void boton_inout(object sender, EventArgs e)
        {
            cambiar_estado();
        }
        private void cambiar_estado()
        {
            inout = !inout; limpiar(this);
            if (inout) cambiar_colores(Color.Lime, Color.Cyan, chk_btn_change, Resources._in, "IN");
            else cambiar_colores(Color.DarkRed, Color.Red, chk_btn_change, Resources._out, "OUT");
        }
        private void cambiar_colores(Color c1, Color c2, KryptonButton b, Image img, string chk)
        {
            b.OverrideDefault.Back.Color1 = c1; b.OverrideDefault.Back.Color2 = c2;
            b.StateCommon.Back.Color1 = c1; b.StateCommon.Back.Color2 = c2;
            b.StateCommon.Back.Image = img; l_estado.Text = $"Check-{chk}";
        }


        private void busqueda(object sender, EventArgs e)
        {
            buscar(t_chk_ts.Text);
        }
        private void buscar(string ts)
        {
            string url = $"http://localhost/checkin/{ts}";
            string json = _rest.consume(url);
            dynamic data = JsonConvert.DeserializeObject(json);
            if (data != null)
            {
                if (data.rooms != null)
                {
                    List<habitacion_reservada> habitaciones = new List<habitacion_reservada>();
                    foreach (var room in data.rooms)
                    {
                        habitacion_reservada habitacion = new habitacion_reservada()
                        {
                            subtotal = room.subtotal,
                            personas = room.personas,
                            piso = room.piso,
                            apt = room.apt
                        };
                        habitaciones.Add(habitacion);
                    }
                    reservacion_d detalles = new reservacion_d()
                    {
                        cliente = data.datos.cliente,
                        checkin = data.datos.checkin,
                        checkout = data.datos.checkout
                    };
                    reservacion reserva = new reservacion(detalles, habitaciones);
                    t_chk_cliente.Text = reserva.detalles.cliente;
                    t_chk_checkin.Text = reserva.detalles.checkin;
                    t_chk_checkout.Text = reserva.detalles.checkout;
                    int total = 0;
                    foreach(habitacion_reservada r in habitaciones)
                    {chk_dtv_h.Rows.Add(r.personas, r.piso, r.apt, $"${r.subtotal}");
                        total += int.Parse(r.subtotal);
                    }t_chk_total.Text = $"${total}";
                }
                else
                {
                    // handle case where there are no rooms in the reservation
                }
            }
            else
            {
                // handle case where JSON string could not be deserialized
            }

        }


        private void chk_btn_change_Click(object sender, EventArgs e)
        {
            cambiar_estado();
        }

        private void boton_guardar_click(object sender, EventArgs e)
        {
            guardar();
        }
        private void guardar()
        {string url = $"http://localhost/alterar/{t_chk_ts.Text}_";
            /*Si esta en modo checkin cambia a ocupado las habitaciones\
            Caso contrario, la pondra en limpieza porque el cliente va
            de salida, y nimodo que dejemos bien puerco el cuarto*/
            if (inout) url += "2"; else url += "5";
            dynamic json = JsonConvert.DeserializeObject(_rest.consume(url));
            
        }
    }
}

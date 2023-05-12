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
using proyecto.reports;
using proyecto.reserva;
using _rest = proyecto.procedimientos.rest;
namespace proyecto.usuario
{
    public partial class checkin_out : KryptonForm
    {
        bool inout = false;
        bool limpio = true;
        public checkin_out()
        { InitializeComponent();
            //checkin_checkout c = new checkin_checkout(paleta.p);
            //this.Controls.Add(c);
            this.Palette = paleta.p;
            foreach (dynamic co in this.Controls) co.Palette = paleta.p;           
            //paleta.set(this);
            //t_chk_ts.Focus(); cambiar_estado();
        }

    }
}

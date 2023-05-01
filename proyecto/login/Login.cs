using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto.reserva;
using proyecto.usuario;
using RestSharp;

using inst = proyecto.formsu.instancias;
using Krypton.Toolkit;
using json = proyecto.procedimientos.rest;
using proyecto.formsu;
using mt = proyecto.procedimientos.mathsu;
using Newtonsoft.Json;
using dinusuario = proyecto.formsu.usuario;
namespace proyecto.login
{
    
    public partial class login : KryptonForm
    {
        public login()
        {
            InitializeComponent();
        }
        private void bt_log_Click(object sender, EventArgs e)
        {log();}
        void log()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (t_u.Text == "" || t_p.Text == "") { MessageBox.Show("Campos Vacios"); return; }
             dynamic p= JsonConvert.DeserializeObject(json.consume("http://localhost/login&u=" + t_u.Text + "&p=" + t_p.Text));

            //MessageBox.Show((p).ToString());
            if ((p).ToString() == "3") { MessageBox.Show(final("3")); return; }
            MessageBox.Show(final(mt.str(p.sesion)));
            if (mt.str(p.sesion) == "1") {
                dinusuario.newsesion((p.nombre).ToString(), (p.id).ToString(), (p.user).ToString());
                menu.menu fr_menu = inst.get_menu(); fr_menu.Show(); this.Hide(); 
            }
        }
        string final(string chr)
        {
            switch (chr)
            {
                case "1": return "Se ha logeado correctamente";
                case "0": return "Contraseña o usuario invalidos";
                case "2": return "Usuario no encontrado";
                case "3": return "Conexion al servidor no exitosa";
            }
            return (chr);
        }
        void bt_log_wheel(object sender, MouseEventArgs e)
        {
            //parriba
            if (e.Delta > 0) { MessageBox.Show("^"); }
            //pa bajo
            else if (e.Delta < 0) { MessageBox.Show("AAAAH MEDIOMETROOO"); }
        }
        private void bt_log_KeyDown(object sender, KeyEventArgs e)
        {if(e.KeyCode == Keys.Enter)log();}

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {Application.Exit();}
    }
}

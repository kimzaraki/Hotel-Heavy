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
using proyecto.reserva;


//NO TOCAR, YA AGARRA MIRREY
namespace proyecto.reports
{
    internal class clientes : KryptonPanel
    {
        bool toedit = false;
        public clientes(paleta p) { init(p); }
        private KryptonPalette kryptonPalette1;
        //public KryptonPanel p_clientes;
        private Label l_c_detalles;
        private KryptonButton b_cc_guardar;
        private KryptonButton b_cc_agregar;
        private KryptonButton b_cc_editar;
        private Label l_c_id;
        private KryptonButton b_cc_buscar;
        private Label l_c_id_b;
        private KryptonTextBox t_cc_cid_b;
        private Label l_c_phone;
        private KryptonTextBox t_cc_curp;
        private Label l_c_mail;
        private KryptonTextBox t_cc_phone;
        private Label l_c_curp;
        private Label l_c_name;
        private Label l_c_pass;
        private KryptonTextBox t_cc_name;
        private KryptonTextBox t_cc_pass;
        private KryptonTextBox t_cc_id;
        private KryptonTextBox t_cc_mail;
        private paleta p;
        public void init(paleta p)
        {
            this.kryptonPalette1 = p;
            //this.p_clientes = new Krypton.Toolkit.KryptonPanel();
            this.l_c_detalles = new System.Windows.Forms.Label();
            this.b_cc_guardar = new Krypton.Toolkit.KryptonButton();
            this.b_cc_agregar = new Krypton.Toolkit.KryptonButton();
            this.b_cc_editar = new Krypton.Toolkit.KryptonButton();
            this.l_c_id = new System.Windows.Forms.Label();
            this.b_cc_buscar = new Krypton.Toolkit.KryptonButton();
            this.l_c_id_b = new System.Windows.Forms.Label();
            this.t_cc_cid_b = new Krypton.Toolkit.KryptonTextBox();
            this.l_c_phone = new System.Windows.Forms.Label();
            this.t_cc_curp = new Krypton.Toolkit.KryptonTextBox();
            this.l_c_mail = new System.Windows.Forms.Label();
            this.t_cc_phone = new Krypton.Toolkit.KryptonTextBox();
            this.l_c_curp = new System.Windows.Forms.Label();
            this.l_c_name = new System.Windows.Forms.Label();
            this.t_cc_name = new Krypton.Toolkit.KryptonTextBox();
            this.t_cc_id = new Krypton.Toolkit.KryptonTextBox();
            this.t_cc_mail = new Krypton.Toolkit.KryptonTextBox();
            this.l_c_pass = new System.Windows.Forms.Label();
            this.t_cc_pass = new Krypton.Toolkit.KryptonTextBox();
            // 
            // p_clientes
            // 
            Controls.Add(this.l_c_detalles);
            Controls.Add(this.b_cc_guardar);
            Controls.Add(this.b_cc_agregar);
            Controls.Add(this.b_cc_editar);
            Controls.Add(this.l_c_id);
            Controls.Add(this.b_cc_buscar);
            Controls.Add(this.l_c_id_b);
            Controls.Add(this.t_cc_cid_b);
            Controls.Add(this.l_c_phone);
            Controls.Add(this.t_cc_curp);
            Controls.Add(this.l_c_mail);
            Controls.Add(this.l_c_pass);
            Controls.Add(this.t_cc_phone);
            Controls.Add(this.l_c_curp);
            Controls.Add(this.l_c_name);
            Controls.Add(this.t_cc_name);
            Controls.Add(this.t_cc_id);
            Controls.Add(this.t_cc_mail);
            Controls.Add(this.t_cc_pass);
            Location = new System.Drawing.Point(10, 70);
            MaximumSize = new System.Drawing.Size(850, 450);
            Name = "p_clientes";
            Size = new System.Drawing.Size(850, 450);
            TabIndex = 18;
            Visible = false;
            this.VisibleChanged += Clientes_VisibleChanged;
            // 
            // l_c_detalles
            // 
            this.l_c_detalles.AutoSize = true;
            this.l_c_detalles.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_c_detalles.Location = new System.Drawing.Point(220, 84);
            this.l_c_detalles.Name = "l_c_detalles";
            this.l_c_detalles.Size = new System.Drawing.Size(314, 32);
            this.l_c_detalles.TabIndex = 12;
            this.l_c_detalles.Text = "DETALLES DEL CLIENTE";
            // 
            // b_cc_guardar
            // 
            this.b_cc_guardar.CornerRoundingRadius = -1F;
            this.b_cc_guardar.Location = new System.Drawing.Point(551, 300);
            this.b_cc_guardar.Name = "b_cc_guardar";
            this.b_cc_guardar.Size = new System.Drawing.Size(105, 35);
            this.b_cc_guardar.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.b_cc_guardar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_cc_guardar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_cc_guardar.TabIndex = 10;
            this.b_cc_guardar.Values.Text = "GUARDAR";
            b_cc_guardar.Click += new EventHandler(b_cc_guardar_Click);
            // 
            // b_cc_agregar
            // 
            this.b_cc_agregar.CornerRoundingRadius = -1F;
            this.b_cc_agregar.Location = new System.Drawing.Point(551, 188);
            this.b_cc_agregar.Name = "b_cc_agregar";
            this.b_cc_agregar.Size = new System.Drawing.Size(105, 32);
            this.b_cc_agregar.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.b_cc_agregar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_cc_agregar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.b_cc_agregar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_cc_agregar.TabIndex = 9;
            this.b_cc_agregar.Values.Text = "AGREGAR";
            b_cc_agregar.Click += new EventHandler(b_cc_agregar_Click);
            // 
            // b_cc_editar
            // 
            this.b_cc_editar.CornerRoundingRadius = -1F;
            this.b_cc_editar.Location = new System.Drawing.Point(551, 139);
            this.b_cc_editar.Name = "b_cc_editar";
            this.b_cc_editar.Size = new System.Drawing.Size(105, 35);
            this.b_cc_editar.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.b_cc_editar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_cc_editar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.b_cc_editar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_cc_editar.TabIndex = 3;
            this.b_cc_editar.Values.Text = "EDITAR";
            b_cc_editar.Click += new EventHandler(b_cc_editar_Click);

            // 
            // l_c_id
            // 
            this.l_c_id.AutoSize = true;
            this.l_c_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_c_id.Location = new System.Drawing.Point(405, 147);
            this.l_c_id.Name = "l_c_id";
            this.l_c_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_c_id.Size = new System.Drawing.Size(27, 19);
            this.l_c_id.TabIndex = 7;
            this.l_c_id.Text = "ID";
            // 
            // b_cc_buscar
            // 
            this.b_cc_buscar.CornerRoundingRadius = -1F;
            this.b_cc_buscar.Location = new System.Drawing.Point(551, 20);
            this.b_cc_buscar.Name = "b_cc_buscar";
            this.b_cc_buscar.Size = new System.Drawing.Size(105, 35);
            this.b_cc_buscar.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.b_cc_buscar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_cc_buscar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.b_cc_buscar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_cc_buscar.TabIndex = 2;
            this.b_cc_buscar.Values.Text = "BUSCAR";
            b_cc_buscar.Click += new EventHandler(b_buscar_click);
            // 
            // l_c_id_b
            // 
            this.l_c_id_b.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_c_id_b.Location = new System.Drawing.Point(-2, 25);
            this.l_c_id_b.Name = "l_c_id_b";
            this.l_c_id_b.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_c_id_b.Size = new System.Drawing.Size(263, 19);
            this.l_c_id_b.TabIndex = 6;
            this.l_c_id_b.Text = "ID (Telefono/Curp)";
            // 
            // t_cc_cid_b
            // 
            this.t_cc_cid_b.Location = new System.Drawing.Point(267, 20);
            this.t_cc_cid_b.MaxLength = 18;
            this.t_cc_cid_b.Name = "t_cc_cid_b";
            this.t_cc_cid_b.Size = new System.Drawing.Size(267, 23);
            this.t_cc_cid_b.TabIndex = 1;
            this.t_cc_cid_b.KeyDown += new System.Windows.Forms.KeyEventHandler(enter_buscar);
            // 
            // l_c_phone
            // 
            this.l_c_phone.AutoSize = true;
            this.l_c_phone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_c_phone.Location = new System.Drawing.Point(89, 230);
            this.l_c_phone.Name = "l_c_phone";
            this.l_c_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_c_phone.Size = new System.Drawing.Size(81, 19);
            this.l_c_phone.TabIndex = 9;
            this.l_c_phone.Text = "Telefono";
            // 
            // t_cc_curp
            // 
            this.t_cc_curp.Location = new System.Drawing.Point(176, 300);
            this.t_cc_curp.Name = "t_cc_curp";
            this.t_cc_curp.ReadOnly = true;
            this.t_cc_curp.Size = new System.Drawing.Size(358, 23);
            this.t_cc_curp.TabIndex = 8;
            // 
            // t_cc_pass
            // 
            this.t_cc_pass.Location = new System.Drawing.Point(176, 300 + 38);
            this.t_cc_pass.Name = "t_cc_pass";
            this.t_cc_pass.ReadOnly = true;
            this.t_cc_pass.Size = new System.Drawing.Size(358, 23);
            this.t_cc_pass.TabIndex = 9;
            this.t_cc_pass.PasswordChar = '*';
            this.t_cc_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(enter_save);
            // 
            // l_c_mail
            // 
            this.l_c_mail.AutoSize = true;
            this.l_c_mail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_c_mail.Location = new System.Drawing.Point(107, 266);
            this.l_c_mail.Name = "l_c_mail";
            this.l_c_mail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_c_mail.Size = new System.Drawing.Size(63, 19);
            this.l_c_mail.TabIndex = 9;
            this.l_c_mail.Text = "Correo";
            // 
            // t_cc_phone
            // 
            this.t_cc_phone.Location = new System.Drawing.Point(176, 226);
            this.t_cc_phone.Name = "t_cc_phone";
            this.t_cc_phone.ReadOnly = true;
            this.t_cc_phone.Size = new System.Drawing.Size(358, 23);
            this.t_cc_phone.TabIndex = 6;
            // 
            // l_c_curp
            // 
            this.l_c_curp.AutoSize = true;
            this.l_c_curp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_c_curp.Location = new System.Drawing.Point(125, 304);
            this.l_c_curp.Name = "l_c_curp";
            this.l_c_curp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_c_curp.Size = new System.Drawing.Size(45, 19);
            this.l_c_curp.TabIndex = 9;
            this.l_c_curp.Text = "Curp";
            // 
            // l_c_pass
            // 
            this.l_c_pass.AutoSize = true;
            this.l_c_pass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_c_pass.Location = new System.Drawing.Point(89 - 15, 304 + 38);
            this.l_c_pass.Name = "l_c_pass";
            this.l_c_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_c_pass.Size = new System.Drawing.Size(81, 19);
            this.l_c_pass.TabIndex = 9;
            this.l_c_pass.Text = "Contraseña";
            // 
            // l_c_name
            // 
            this.l_c_name.AutoSize = true;
            this.l_c_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_c_name.Location = new System.Drawing.Point(107, 192);
            this.l_c_name.Name = "l_c_name";
            this.l_c_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_c_name.Size = new System.Drawing.Size(63, 19);
            this.l_c_name.TabIndex = 9;
            this.l_c_name.Text = "Nombre";
            // 
            // t_cc_name
            // 
            this.t_cc_name.Location = new System.Drawing.Point(176, 185);
            this.t_cc_name.Name = "t_cc_name";
            this.t_cc_name.ReadOnly = true;
            this.t_cc_name.Size = new System.Drawing.Size(358, 23);
            this.t_cc_name.TabIndex = 5;
            // 
            // t_cc_id
            // 
            this.t_cc_id.Location = new System.Drawing.Point(445, 139);
            this.t_cc_id.Name = "t_cc_id";
            this.t_cc_id.ReadOnly = true;
            this.t_cc_id.Size = new System.Drawing.Size(89, 23);
            this.t_cc_id.TabIndex = 4;
            // 
            // t_cc_mail
            // 
            this.t_cc_mail.Location = new System.Drawing.Point(176, 262);
            this.t_cc_mail.Name = "t_cc_mail";
            this.t_cc_mail.ReadOnly = true;
            this.t_cc_mail.Size = new System.Drawing.Size(358, 23);
            this.t_cc_mail.TabIndex = 7;

            //mueve todo para donde deseemos en sincronia
            foreach (Control c in Controls) c.Location = new Point(c.Location.X + 50, c.Location.Y);
        }

        public static string[] buscar(string phone, string curp)
        {
            string[] pars = { "$", "$" };
            if (validar_curp(curp)) pars[0] = curp;
            else MessageBox.Show("NO HAY NADA EN CURP LOL");
            if (validar_telefono(phone)) pars[1] = phone;
            else MessageBox.Show("NO HAY NADA EN TELEFONO LOL");
            if (pars[0] == "$" && pars[1] == "$") { MessageBox.Show("BUSQUEDA INVALIDA"); return null; }
            string[] fetched = { "", "", "", "", "" };
            dynamic json = JsonConvert.DeserializeObject(_rest.consume($"http://localhost/clientes/c={pars[0]}_p={pars[1]}"));
            if (json.encontrado == "0") return null;
            fetched[0] = json.id;
            fetched[1] = json.nombre;
            fetched[2] = json.telefono;
            fetched[3] = json.curp;
            fetched[4] = json.correo;
            inst.cliente.newuser(fetched[0], fetched[1], fetched[2], fetched[4], fetched[3], fetched[5]);
            return fetched;
        }
        public static string[] buscar(string id)
        {
            string[] pars = { "$", "$" };
            if (validar_curp(id)) pars[0] = id;
            if (validar_telefono(id)) pars[1] = id;
            if (pars[0] == "$" && pars[1] == "$") { MessageBox.Show("BUSQUEDA INVALIDA"); return null; }
            string[] fetched = { "", "", "", "", "","" };
            dynamic json = JsonConvert.DeserializeObject(_rest.consume($"http://localhost/clientes/c={pars[0]}_p={pars[1]}"));
            if (json.encontrado == "0") return null;
            fetched[0] = json.id;
            fetched[1] = json.nombre;
            fetched[2] = json.telefono;
            fetched[3] = json.curp;
            fetched[4] = json.correo;
            fetched[5] = json.pass;
            inst.cliente.newuser(fetched[0], fetched[1], fetched[2], fetched[4], fetched[3], fetched[5]);
            return fetched;
        }
        public static void guardar(string id, string name, string phone, string mail, string curp, string pass, bool toedit)
        {
            //if (inst.cliente._inst == null) {
            //si el tb es de solo lectura esta editando
            name= name.Replace(' ','+');
            pass= pass.Replace(' ','+');
            if (!toedit) crear(id, name, phone, mail, curp, pass);
            else editar(id, name, phone, mail, curp, pass);
            agregarcliente(id, name, phone, mail, curp, pass);

            //}
        }
        void search()
        {
            string[] vals = buscar(t_cc_cid_b.Text);
            if (vals == null) { MessageBox.Show("No se encontro nada"); return; }
            t_cc_id.Text = vals[0]; t_cc_name.Text = vals[1]; t_cc_phone.Text = vals[2];
            t_cc_curp.Text = vals[3]; t_cc_mail.Text = vals[4];t_cc_pass.Text = vals[5];
            canedit(false); toggle_readmode(t_cc_id, false);
        }
        private void canedit(bool a)
        {
            clientes.toggle_readmode(t_cc_curp, a);
            clientes.toggle_readmode(t_cc_phone, a);
            clientes.toggle_readmode(t_cc_name, a);
            clientes.toggle_readmode(t_cc_mail, a);
            clientes.toggle_readmode(t_cc_pass, a);
        }
        public static void agregarcliente(string id, string name, string phone, string mail, string curp, string pass)
        {
            inst.cliente.newuser(id, name, phone, mail, curp, pass);
        }
        public static void crear(string id, string name, string phone, string mail, string curp, string pass)
        {
            MessageBox.Show("SE ESTA CREANDO EL CLIENTE");
            _rest.consume($"http://localhost/clientes/create/i={id}_n={name}_m={mail.Replace('.', '>')}_p={phone}_c={curp}_pw={pass}");
            MessageBox.Show("CLIENTE CREADO CON EXITO");
        }
        public static void editar(string id, string name, string phone, string mail, string curp, string pass)
        {
            MessageBox.Show("SE ESTA EDITANDO EL CLIENTE");
            _rest.consume($"http://localhost/clientes/edit/i={id}_n={name}_m={mail.Replace('.', '>')}_p={phone}_c={curp}_pw={pass}");
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
        void save() { guardar(t_cc_id.Text, t_cc_name.Text, t_cc_phone.Text, t_cc_mail.Text, t_cc_curp.Text, t_cc_pass.Text, toedit); }
        public void add()
        {
            string idmax = _rest.consume("http://localhost/maxid/clientes");
            clr(t_cc_curp); clr(t_cc_phone); clr(t_cc_mail); clr(t_cc_name);
            t_cc_name.Focus();
            t_cc_id.Text = $"{mathsu.toint(idmax) + 1}"; toedit = false;
            if (t_cc_curp.ReadOnly == true) { canedit(true); t_cc_name.Focus(); }
        }
        private void clr(KryptonTextBox t) { t.Clear(); }
        void b_buscar_click(object sender, EventArgs e)
        { search(); }
        private void enter_save(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) save(); }

        private void enter_buscar(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) search(); }

        private void b_cc_editar_Click(object sender, EventArgs e)
        {
            if (t_cc_id.Text != "")
            {
                toedit = true;
                //clientes.toggle_readmode(t_cc_id, false);
                bool a = t_cc_curp.ReadOnly; canedit(a);
                t_cc_name.Focus(); t_cc_name.SelectAll();
            }
            else MessageBox.Show("NO PUEDES EDITAR UN CAMPO VACIO");
        }
        private void b_cc_guardar_Click(object sender, EventArgs e) { save(); }
        private void b_cc_agregar_Click(object sender, EventArgs e){ add(); }
        private void Clientes_VisibleChanged(object? sender, EventArgs e)
        { toedit = false; canedit(toedit); }
    }
}

using Krypton.Toolkit;
using proyecto.formsu;
using proyecto.menu;
using proyecto.reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TA JOYA, NO TOCAR YA
using _rest = proyecto.procedimientos.rest;
namespace proyecto.reports
{
    internal class reservar : KryptonPanel
    {
        int numero = 0;
        String[] cliente;


        private KryptonDateTimePicker dtp_rs_checkout;
        private KryptonDateTimePicker dtp_rs_checkin;
        //private KryptonComboBox cb_rs_tipo;
        private KryptonTextBox t_rs_correo;
        private KryptonLabel kryptonLabel5;
        private KryptonTextBox t_rs_telefono;
        private KryptonLabel kryptonLabel4;
        private KryptonTextBox t_rs_nombre;
        private KryptonLabel kryptonLabel3;
        private KryptonTextBox t_rs_id;
        private KryptonLabel l_rs_checkout;
        private KryptonLabel l_rs_checkin;
        private KryptonLabel l_rs_id;
        private FlowLayoutPanel flp_rs_Disponibles;
        private KryptonPanel p_flp_d;
        private KryptonLabel l_p_flp_d;
        private KryptonButton b_rs_reservar;
        private KryptonButton b_rs_buscar;
        private KryptonButton b_rs_buscar_usuario;
        //private KryptonButton b_rs_add_room;
        private FlowLayoutPanel flp_habitaciones;
        private KryptonPanel p_flp_h;
        private KryptonLabel l_p_flp_h;
        public  reservar()
        { iniciar(); }

        private static reservar inst;
        public static reservar get_inst()
        {if (inst == null) inst = new reservar(); return inst;}

        void iniciar()
        {
            
            this.dtp_rs_checkout = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtp_rs_checkin = new Krypton.Toolkit.KryptonDateTimePicker();
            //this.cb_rs_tipo = new Krypton.Toolkit.KryptonComboBox();
            this.t_rs_correo = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.t_rs_telefono = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.t_rs_nombre = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.t_rs_id = new Krypton.Toolkit.KryptonTextBox();
            this.l_rs_checkout = new Krypton.Toolkit.KryptonLabel();
            this.l_rs_checkin = new Krypton.Toolkit.KryptonLabel();
            this.l_rs_id = new Krypton.Toolkit.KryptonLabel();
            this.flp_rs_Disponibles = new System.Windows.Forms.FlowLayoutPanel();
            this.p_flp_d = new Krypton.Toolkit.KryptonPanel();
            this.l_p_flp_d = new Krypton.Toolkit.KryptonLabel();
            this.b_rs_reservar = new Krypton.Toolkit.KryptonButton();
            this.b_rs_buscar = new Krypton.Toolkit.KryptonButton();
            this.b_rs_buscar_usuario = new Krypton.Toolkit.KryptonButton();
            //this.b_rs_add_room = new Krypton.Toolkit.KryptonButton();
            this.flp_habitaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.p_flp_h = new Krypton.Toolkit.KryptonPanel();
            this.l_p_flp_h = new Krypton.Toolkit.KryptonLabel();





            // 
            // dtp_rs_checkout
            // 
            this.dtp_rs_checkout.CornerRoundingRadius = -1F;
            this.dtp_rs_checkout.CustomFormat = "dddd, d \'de\' MMMM \'del\' yyyy";
            this.dtp_rs_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_rs_checkout.Location = new System.Drawing.Point(628, 50);
            this.dtp_rs_checkout.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_rs_checkout.MinDate = new System.DateTime(2023, 4, 6, 0, 0, 0, 0);
            this.dtp_rs_checkout.Name = "dtp_rs_checkout";
            this.dtp_rs_checkout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_rs_checkout.Size = new System.Drawing.Size(212, 21);
            this.dtp_rs_checkout.TabIndex = 30;


            this.dtp_rs_checkout.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.dtp_rs_checkout.Value = DateTime.Now;
            // 
            // dtp_rs_checkin
            // 
            this.dtp_rs_checkin.CornerRoundingRadius = -1F;
            this.dtp_rs_checkin.CustomFormat = "dddd, d \'de\' MMMM \'del\' yyyy";
            this.dtp_rs_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_rs_checkin.Location = new System.Drawing.Point(628, 8 - 8);
            this.dtp_rs_checkin.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_rs_checkin.MinDate = new System.DateTime(2023, 4, 6, 0, 0, 0, 0);
            this.dtp_rs_checkin.Name = "dtp_rs_checkin";
            this.dtp_rs_checkin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_rs_checkin.Size = new System.Drawing.Size(212, 21);
            this.dtp_rs_checkin.TabIndex = 29;


            this.dtp_rs_checkin.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.dtp_rs_checkout.Value = DateTime.Now.AddDays(1);
            // 
            // cb_rs_tipo
            // 
            /*
            this.cb_rs_tipo.CornerRoundingRadius = -1F;
            this.cb_rs_tipo.DropDownWidth = 160;
            this.cb_rs_tipo.IntegralHeight = false;
            this.cb_rs_tipo.Location = new System.Drawing.Point(425, 97-30);
            this.cb_rs_tipo.Name = "cb_rs_tipo";
            this.cb_rs_tipo.Size = new System.Drawing.Size(160, 21);
            this.cb_rs_tipo.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cb_rs_tipo.TabIndex = 28;
            this.cb_rs_tipo.Text = "kryptonComboBox1";
            */
            // 
            // kryptonMaskedTextBox4
            // 
            this.t_rs_correo.Location = new System.Drawing.Point(90, 95);
            this.t_rs_correo.Name = "kryptonMaskedTextBox4";
            this.t_rs_correo.Size = new System.Drawing.Size(264, 23);
            this.t_rs_correo.TabIndex = 26;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(9, 95);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(75, 23);
            this.kryptonLabel5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel5.TabIndex = 23;
            this.kryptonLabel5.Values.Text = "ID";
            // 
            // kryptonMaskedTextBox3
            // 
            this.t_rs_telefono.Location = new System.Drawing.Point(90, 66 );
            this.t_rs_telefono.Name = "kryptonMaskedTextBox3";
            this.t_rs_telefono.Size = new System.Drawing.Size(264, 23);
            this.t_rs_telefono.TabIndex = 25;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(9, 66);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(75, 23);
            this.kryptonLabel4.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel4.TabIndex = 22;
            this.kryptonLabel4.Values.Text = "Telefono";
            // 
            // kryptonMaskedTextBox2
            // 
            this.t_rs_nombre.Location = new System.Drawing.Point(90, 37);
            this.t_rs_nombre.Name = "kryptonMaskedTextBox2";
            this.t_rs_nombre.Size = new System.Drawing.Size(264, 23);
            this.t_rs_nombre.TabIndex = 27;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(9, 37);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 23);
            this.kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel3.TabIndex = 21;
            this.kryptonLabel3.Values.Text = "Nombre";
            // 
            // ID GEI
            // 
            this.t_rs_id.Location = new System.Drawing.Point(217 - 60, 8 - 8);
            this.t_rs_id.Name = "t_rs_id";
            this.t_rs_id.Size = new System.Drawing.Size(137, 23);
            this.t_rs_id.TabIndex = 24;
            // 
            // kryptonLabel7
            // 
            this.l_rs_checkout.AutoSize = false;
            this.l_rs_checkout.Location = new System.Drawing.Point(488, 55);
            this.l_rs_checkout.Name = "kryptonLabel7";
            this.l_rs_checkout.Size = new System.Drawing.Size(134, 21);
            this.l_rs_checkout.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.l_rs_checkout.TabIndex = 20;
            this.l_rs_checkout.Values.Text = "Fecha de check-out";
            // 
            // kryptonLabel6
            // 
            this.l_rs_checkin.AutoSize = false;
            this.l_rs_checkin.Location = new System.Drawing.Point(488, 4);
            this.l_rs_checkin.Name = "kryptonLabel6";
            this.l_rs_checkin.Size = new System.Drawing.Size(134, 21);
            this.l_rs_checkin.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.l_rs_checkin.TabIndex = 19;
            this.l_rs_checkin.Values.Text = "Fecha de check-in";
            // 
            // b_rs_buscar
            // 
            this.b_rs_buscar_usuario.CornerRoundingRadius = -1F;
            this.b_rs_buscar_usuario.Location = new System.Drawing.Point(380 - 85, 0);
            this.b_rs_buscar_usuario.Name = "b_rs_buscar_usuario";
            this.b_rs_buscar_usuario.Size = new System.Drawing.Size(140, 30);
            this.b_rs_buscar_usuario.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.b_rs_buscar_usuario.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.b_rs_buscar_usuario.TabIndex = 14;
            this.b_rs_buscar_usuario.Values.Text = "Buscar Usuario";
            this.b_rs_buscar_usuario.Click += new EventHandler(buscar_usuario);
            // 
            // kryptonLabel2
            // 
            this.l_rs_id.AutoSize = false;
            this.l_rs_id.Location = new System.Drawing.Point(9, 8 - 8);
            this.l_rs_id.Name = "kryptonLabel2";
            this.l_rs_id.Size = new System.Drawing.Size(150, 23);
            this.l_rs_id.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.l_rs_id.TabIndex = 18;
            this.l_rs_id.Values.Text = "ID   (Telefono/Curp)";
            // 
            // flp_rs_Disponibles
            // 
            this.flp_rs_Disponibles.AutoScroll = true;
            this.flp_rs_Disponibles.AutoScrollMargin = new System.Drawing.Size(3, 0);
            this.flp_rs_Disponibles.Controls.Add(this.p_flp_d);
            this.flp_rs_Disponibles.Location = new System.Drawing.Point(420, 162);
            this.flp_rs_Disponibles.Name = "flp_rs_Disponibles";
            this.flp_rs_Disponibles.Size = new System.Drawing.Size(420, 315);
            this.flp_rs_Disponibles.TabIndex = 17;
            // 
            // habitacion_disponible
            // 
            this.p_flp_d.Controls.Add(this.l_p_flp_d);
            this.p_flp_d.Location = new System.Drawing.Point(3, 3);
            this.p_flp_d.Name = "habitacion_disponible";
            this.p_flp_d.Size = new System.Drawing.Size(395, 36);
            this.p_flp_d.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.l_p_flp_d.Location = new System.Drawing.Point(3, 8);
            this.l_p_flp_d.Name = "kryptonLabel1";
            this.l_p_flp_d.Size = new System.Drawing.Size(311, 23);
            this.l_p_flp_d.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_p_flp_d.TabIndex = 0;
            this.l_p_flp_d.Values.Text = "Lista de Habitaciones Disponibles";
            // 
            // b_rs_reservar
            // 
            this.b_rs_reservar.CornerRoundingRadius = -1F;
            this.b_rs_reservar.Location = new System.Drawing.Point(680, 124);
            this.b_rs_reservar.Name = "b_rs_reservar";
            this.b_rs_reservar.Size = new System.Drawing.Size(160, 30);
            this.b_rs_reservar.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.b_rs_reservar.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.b_rs_reservar.TabIndex = 15;
            this.b_rs_reservar.Values.Text = "Hacer Reservacion";
            this.b_rs_reservar.Click += new EventHandler(reservar_click);
            // 
            // b_rs_buscar
            // che
            this.b_rs_buscar.CornerRoundingRadius = -1F;
            this.b_rs_buscar.Location = new System.Drawing.Point(425, 124);
            this.b_rs_buscar.Name = "b_rs_buscar";
            this.b_rs_buscar.Size = new System.Drawing.Size(160, 30);
            this.b_rs_buscar.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.b_rs_buscar.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.b_rs_buscar.TabIndex = 14;
            this.b_rs_buscar.Values.Text = "Buscar";
            this.b_rs_buscar.Click += new EventHandler(busqueda_click);
            // 
            // b_rs_add_room
            // 
            /*
            this.b_rs_add_room.CornerRoundingRadius = -1F;
            this.b_rs_add_room.Location = new System.Drawing.Point(9, 124);
            this.b_rs_add_room.Name = "b_rs_add_room";
            this.b_rs_add_room.Size = new System.Drawing.Size(160, 30);
            this.b_rs_add_room.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.b_rs_add_room.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.b_rs_add_room.TabIndex = 16;
            this.b_rs_add_room.Values.Text = "Agregar";
            this.b_rs_add_room.Click += new EventHandler(add_click);
            */
            // 
            // flp_habitaciones
            // 
            this.flp_habitaciones.AutoScroll = true;
            this.flp_habitaciones.AutoScrollMargin = new System.Drawing.Size(3, 0);
            this.flp_habitaciones.Controls.Add(this.p_flp_h);
            this.flp_habitaciones.Location = new System.Drawing.Point(9, 162);
            this.flp_habitaciones.Name = "flp_habitaciones";
            this.flp_habitaciones.Size = new System.Drawing.Size(345, 312);
            this.flp_habitaciones.TabIndex = 13;
            this.flp_habitaciones.ControlRemoved += flp_borrado;
            // 
            // kryptonPanel2
            // 
            this.p_flp_h.Controls.Add(this.l_p_flp_h);
            this.p_flp_h.Location = new System.Drawing.Point(3, 3);
            this.p_flp_h.Name = "kryptonPanel2";
            this.p_flp_h.Size = new System.Drawing.Size(339, 36);
            this.p_flp_h.TabIndex = 0;
            // 
            // kryptonLabel8
            // 
            this.l_p_flp_h.Location = new System.Drawing.Point(3, 8);
            this.l_p_flp_h.Name = "kryptonLabel8";
            this.l_p_flp_h.Size = new System.Drawing.Size(220, 23);
            this.l_p_flp_h.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_p_flp_h.TabIndex = 0;
            this.l_p_flp_h.Values.Text = "Habitaciones a reservar";
            // 
            // p_reservar
            // 
            this.Controls.Add(this.dtp_rs_checkout);
            this.Controls.Add(this.dtp_rs_checkin);
            //this.Controls.Add(this.cb_rs_tipo);
            this.Controls.Add(this.t_rs_correo);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.t_rs_telefono);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.t_rs_nombre);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.t_rs_id);
            this.Controls.Add(this.l_rs_checkout);
            this.Controls.Add(this.l_rs_checkin);
            this.Controls.Add(this.l_rs_id);
            this.Controls.Add(this.flp_rs_Disponibles);
            this.Controls.Add(this.b_rs_reservar);
            this.Controls.Add(this.b_rs_buscar_usuario);
            this.Controls.Add(this.b_rs_buscar);
            //this.Controls.Add(this.b_rs_add_room);
            this.Controls.Add(this.flp_habitaciones);
            this.Location = new System.Drawing.Point(10, 70);
            this.Name = "p_reservar";
            this.Size = new System.Drawing.Size(850, 500);
            this.TabIndex = 0;

            KryptonManager mg = new KryptonManager();
            mg.GlobalPalette = p;
            clientes.toggle_readmode(this.t_rs_id, true);

        }
        paleta p = new paleta();
        void borrar(KryptonPanel p){ p.Dispose(); }
        string set_n() { numero++; return numero.ToString(); }
        void agregar(p_rooms pd)
        {
            panel_hab p = new panel_hab(set_n(), pd);
            p.linked = pd;p.room = pd.room;
            flp_habitaciones.Controls.Add(p);
        }
        void borrar(habitacion item)
        {foreach (Control c in flp_habitaciones.Controls)
                if (c is panel_hab p)
                {
                    if (item == p.room) p.Dispose();
                    else MessageBox.Show("Habitacion no encontrada, ERROR\nERRORERRORERRORERROR XD");
                }
        }
        private void agregar_hab(object sender, EventArgs e)
        {
            if (sender is Control c)
            {
                //MessageBox.Show("esta jalando entonces");
                p_rooms p = c.Parent as p_rooms;
                if (p.selected) agregar(p);
                else {borrar(p.room); }
            }
        }
        private void anticlick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("AUTOSCROLL = FALSO");
                flp_habitaciones.AutoScroll = !flp_habitaciones.AutoScroll;
            }
        }
        private void alterar(object sender, EventArgs e)
        {
            if (sender is Control c)
            {
                MessageBox.Show("BOTON TONTA");
            }
        }
        private void cancelar(panel_hab p)
        {p.linked.cambiar();}
        bool preguntar(string pregunta, string title)
        {
            //MessageBox pregunta = new MessageBox()
            
            DialogResult respuesta = MessageBox.Show(pregunta, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) return true;
            return false;

        }
        void crear_usuario(){ SendKeys.Send("^b"); }
        private void buscar_usuario(object sender, EventArgs e)
        {
            if (t_rs_id.Text == "") { MessageBox.Show("No hay nada para buscar"); return; }
            mouse(Cursors.WaitCursor);
            this.cliente = clientes.buscar(t_rs_id.Text);
            if (cliente == null) {
                //MessageBox.Show("NO SE ENCONTRO NADA");
                if (preguntar("¿Usuario no encontrado\nDesea crear un nuevo usuario?", "Usuario no encontrado")) { crear_usuario(); return; } else { t_rs_id.Focus(); t_rs_id.SelectAll(); }
            }
            else
            {
                t_rs_nombre.Text = cliente[1];
                t_rs_telefono.Text = cliente[2];
                t_rs_correo.Text = cliente[4];
            }
            mouse(Cursors.Default);
        }
        void mouse(Cursor c) { Cursor.Current = c; }

        private void flp_borrado(object sender, ControlEventArgs e){ renombrar(); }
        private void renombrar()
        {numero = 0;foreach (Control c in flp_habitaciones.Controls)if (c is panel_hab panel) panel.l_room.Text = "Habitacion #" + set_n();}

        private void busqueda_click(object sender, EventArgs e)
        {
            mouse(Cursors.WaitCursor);
            var lista = new List<habitacion>();
            string ci = dtp_rs_checkin.Value.ToString("ddMMyyyy"), co = dtp_rs_checkout.Value.ToString("ddMMyyyy");
            //MessageBox.Show($"Check IN: {ci}\nCheck OUT: {co}");
            if (proyecto.formsu.lista_habitaciones.load(ci, co)) { lista = proyecto.formsu.lista_habitaciones.lista; }
            else { MessageBox.Show("No se puede conectar al servidor"); return; }limpiar();
            //MessageBox.Show("AA");
            foreach (var item in lista)
            {
                //MessageBox.Show(item.piso);
                // MessageBox.Show(item.nombre);
                var owo = new p_rooms();
                owo.l_info.Text = $"{item.nombre}\r\n\r\nPiso #{item.piso} Apt. #{item.apt}\r\n${item.precio}";
                owo.l_disponible.Text = item.estado;
                flp_rs_Disponibles.Controls.Add(owo); owo.room = item;
                owo.b_add.Click += new EventHandler(agregar_hab);
            }
            mouse(Cursors.Default);
        }
        private void reservar_click(object sender, EventArgs e)
        {
            if (t_rs_nombre.Text == "") {MessageBox.Show("No se puede reservar anonimamente\nIngrese datos del cliente"); return; }
            if (flp_habitaciones.Controls.Count == 1) {MessageBox.Show("No se puede hacer reservacion vacia" +
                "\nDebe tener una habitacion reservada"); return; }
            int total = 0; string cadena = "Concepto de reservacion:\n\n";
            Cursor.Current = Cursors.WaitCursor; string id = _rest.consume("http://localhost/maxid/reservaciones");
            string ci = dtp_rs_checkin.Value.ToString("ddMMyyyy"), co = dtp_rs_checkout.Value.ToString("ddMMyyyy");
            string _url = ""; id = $"{int.Parse(id) + 1}";
            foreach (Control panel in flp_habitaciones.Controls)
            {
                if (panel is panel_hab _p)
                {

                    total += (int.Parse(_p.room.precio) * (int)(dtp_rs_checkout.Value - dtp_rs_checkin.Value).TotalDays);
                    cadena += $"{_p.room.nombre} // Piso #{_p.room.piso} // APT. #{_p.room.apt}\n\n";
                    string text = _p.t_p.Text; if (text == "") text = "1";
                    _url += $"{ci}+{co}+{_p.t_p.Text}+{_p.room.id}>";
                    ///reservar/mult/<id>_<idc>_<pars>_<ide>
                    //_rest.consume($"http://localhost/reservar/{id}+{cliente[0]}+{_p.t_adult.Text}+{_p.t_kid.Text}+{ci}+{co}+{_p.room.id}");
                }
            }MessageBox.Show(_url);
            string timestamp = _rest.consume($"http://localhost/reservar/mult/{id}_{cliente[0]}_{_url}_{formsu.usuario.id}");
            MessageBox.Show($"Cliente: {cliente[0]}\nUsuario: {formsu.usuario.id}");
            Cursor.Current = Cursors.Default;
            cadena += $"\nTotal: ${total}"; MessageBox.Show(cadena);
            if (preguntar($"{cadena}\n\nDesea generar PDF?", "Reservacion creada satisfactoriamente")) 
            {save(timestamp); limpiar(); }
        }

        public static void save(string timestamp)
        {
            SaveFileDialog _save = new SaveFileDialog();//guiardar el archivo
            _save.DefaultExt = "pdf";
            _save.FileName = $"R_{timestamp}.pdf"; //especificicamos el tipo de archivo y nombre
            //CORREGIR ESTO
            string url = ($"http://localhost/reservaciones/web/{timestamp}");
            if (_save.ShowDialog() == DialogResult.OK)
            { MessageBox.Show("guardando coso rancio"); ; var generar = new topdf(url, _save.FileName); }
        }

        void generar_pdf()
        {
        }

        private void limpiar()
        {
            flp_habitaciones.Controls.Clear();flp_habitaciones.Controls.Add(p_flp_h);
            flp_rs_Disponibles.Controls.Clear();flp_rs_Disponibles.Controls.Add(p_flp_d);
        }
    }
}

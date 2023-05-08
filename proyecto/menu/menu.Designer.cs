using proyecto.reports;
using proyecto.reserva;

namespace proyecto.menu
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menu_st = new System.Windows.Forms.MenuStrip();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.p_venta = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.b_buscar = new Krypton.Toolkit.KryptonButton();
            this.tabla = new Krypton.Toolkit.KryptonDataGridView();
            this.Articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_cs_save = new Krypton.Toolkit.KryptonButton();
            this.tb_cs_id = new Krypton.Toolkit.KryptonTextBox();
            this.tb_phone = new Krypton.Toolkit.KryptonTextBox();
            this.tb_mail = new Krypton.Toolkit.KryptonTextBox();
            this.tb_cliente = new Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p_menu = new Krypton.Toolkit.KryptonPanel();
            this.p_clientes = new Krypton.Toolkit.KryptonPanel();
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
            this.menu_st.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_venta)).BeginInit();
            this.p_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_clientes)).BeginInit();
            this.p_clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_st
            // 
            this.menu_st.BackColor = System.Drawing.Color.LemonChiffon;
            this.menu_st.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu_st.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventazToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menu_st.Location = new System.Drawing.Point(0, 0);
            this.menu_st.Name = "menu_st";
            this.menu_st.Size = new System.Drawing.Size(864, 24);
            this.menu_st.TabIndex = 0;
            this.menu_st.Text = "menuStrip1";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarToolStripMenuItem,
            this.checkInCheckOutToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reservarToolStripMenuItem
            // 
            this.reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            this.reservarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reservarToolStripMenuItem.Text = "Reservar";
            this.reservarToolStripMenuItem.Click += new System.EventHandler(this.reservarToolStripMenuItem_Click);
            // 
            // checkInCheckOutToolStripMenuItem
            // 
            this.checkInCheckOutToolStripMenuItem.Name = "checkInCheckOutToolStripMenuItem";
            this.checkInCheckOutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.checkInCheckOutToolStripMenuItem.Text = "Check in / Check out";
            this.checkInCheckOutToolStripMenuItem.Click += new System.EventHandler(this.checkInCheckOutToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.consultarClienteToolStripMenuItem.Text = "Buscar/Agregar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // ventazToolStripMenuItem
            // 
            this.ventazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarVentaToolStripMenuItem});
            this.ventazToolStripMenuItem.Name = "ventazToolStripMenuItem";
            this.ventazToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventazToolStripMenuItem.Text = "Ventas";
            this.ventazToolStripMenuItem.Click += new System.EventHandler(this.ventazToolStripMenuItem_Click);
            // 
            // consultarVentaToolStripMenuItem
            // 
            this.consultarVentaToolStripMenuItem.Name = "consultarVentaToolStripMenuItem";
            this.consultarVentaToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + F";
            this.consultarVentaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.consultarVentaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.consultarVentaToolStripMenuItem.Text = "Consultar Venta";
            this.consultarVentaToolStripMenuItem.Click += new System.EventHandler(this.consultarVentaToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarToolStripMenuItem,
            this.reporteDeProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarModificarToolStripMenuItem
            // 
            this.agregarModificarToolStripMenuItem.Name = "agregarModificarToolStripMenuItem";
            this.agregarModificarToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.agregarModificarToolStripMenuItem.Text = "Agregar / Modificar";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de productos";
            this.reporteDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductosToolStripMenuItem_Click);
            // 
            // p_venta
            // 
            this.p_venta.Controls.Add(this.kryptonButton1);
            this.p_venta.Controls.Add(this.b_buscar);
            this.p_venta.Controls.Add(this.tabla);
            this.p_venta.Controls.Add(this.b_cs_save);
            this.p_venta.Controls.Add(this.tb_cs_id);
            this.p_venta.Controls.Add(this.tb_phone);
            this.p_venta.Controls.Add(this.tb_mail);
            this.p_venta.Controls.Add(this.tb_cliente);
            this.p_venta.Controls.Add(this.label5);
            this.p_venta.Controls.Add(this.label3);
            this.p_venta.Controls.Add(this.label2);
            this.p_venta.Controls.Add(this.label1);
            this.p_venta.Location = new System.Drawing.Point(10, 70);
            this.p_venta.MaximumSize = new System.Drawing.Size(850, 500);
            this.p_venta.Name = "p_venta";
            this.p_venta.Size = new System.Drawing.Size(850, 500);
            this.p_venta.TabIndex = 1;
            this.p_venta.Visible = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.Location = new System.Drawing.Point(442, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(128, 35);
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton1.TabIndex = 23;
            this.kryptonButton1.ToolTipValues.Image = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonButton1.Values.Text = "REINICIAR";
            this.kryptonButton1.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_buscar
            // 
            this.b_buscar.CornerRoundingRadius = -1F;
            this.b_buscar.Location = new System.Drawing.Point(290, 0);
            this.b_buscar.Name = "b_buscar";
            this.b_buscar.Size = new System.Drawing.Size(128, 35);
            this.b_buscar.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.b_buscar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_buscar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_buscar.TabIndex = 38;
            this.b_buscar.ToolTipValues.Image = global::proyecto.Properties.Resources.bt_minus;
            this.b_buscar.Values.Text = "BUSCAR";
            this.b_buscar.Click += new System.EventHandler(this.b_buscar_Click);
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulos,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.tabla.Location = new System.Drawing.Point(0, 169);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowTemplate.Height = 25;
            this.tabla.Size = new System.Drawing.Size(850, 212);
            this.tabla.TabIndex = 35;
            // 
            // Articulos
            // 
            this.Articulos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Articulos.HeaderText = "Articulo";
            this.Articulos.Name = "Articulos";
            this.Articulos.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // b_cs_save
            // 
            this.b_cs_save.CornerRoundingRadius = -1F;
            this.b_cs_save.Location = new System.Drawing.Point(639, 418);
            this.b_cs_save.Name = "b_cs_save";
            this.b_cs_save.Size = new System.Drawing.Size(211, 54);
            this.b_cs_save.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.b_cs_save.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_cs_save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_cs_save.TabIndex = 23;
            this.b_cs_save.ToolTipValues.Image = global::proyecto.Properties.Resources.bt_tikito;
            this.b_cs_save.Values.Text = "Generar PDF";
            this.b_cs_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // tb_cs_id
            // 
            this.tb_cs_id.Location = new System.Drawing.Point(75, 0);
            this.tb_cs_id.Name = "tb_cs_id";
            this.tb_cs_id.Size = new System.Drawing.Size(209, 23);
            this.tb_cs_id.TabIndex = 27;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(677, 76);
            this.tb_phone.MaxLength = 10;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.ReadOnly = true;
            this.tb_phone.Size = new System.Drawing.Size(135, 23);
            this.tb_phone.TabIndex = 26;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(375, 76);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.ReadOnly = true;
            this.tb_mail.Size = new System.Drawing.Size(216, 23);
            this.tb_mail.TabIndex = 25;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(90, 77);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.ReadOnly = true;
            this.tb_cliente.Size = new System.Drawing.Size(209, 23);
            this.tb_cliente.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefono 📞";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Correo ✉️";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cliente 🤵";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID VENTA🆔";
            // 
            // p_menu
            // 
            this.p_menu.Location = new System.Drawing.Point(10, 20);
            this.p_menu.MaximumSize = new System.Drawing.Size(850, 60);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(850, 40);
            this.p_menu.StateCommon.Color1 = System.Drawing.Color.LemonChiffon;
            this.p_menu.StateCommon.Color2 = System.Drawing.Color.LemonChiffon;
            this.p_menu.TabIndex = 2;
            // 
            // p_clientes
            // 
            this.p_clientes.Controls.Add(this.l_c_detalles);
            this.p_clientes.Controls.Add(this.b_cc_guardar);
            this.p_clientes.Controls.Add(this.b_cc_agregar);
            this.p_clientes.Controls.Add(this.b_cc_editar);
            this.p_clientes.Controls.Add(this.l_c_id);
            this.p_clientes.Controls.Add(this.b_cc_buscar);
            this.p_clientes.Controls.Add(this.l_c_id_b);
            this.p_clientes.Controls.Add(this.t_cc_cid_b);
            this.p_clientes.Controls.Add(this.l_c_phone);
            this.p_clientes.Controls.Add(this.t_cc_curp);
            this.p_clientes.Controls.Add(this.l_c_mail);
            this.p_clientes.Controls.Add(this.t_cc_phone);
            this.p_clientes.Controls.Add(this.l_c_curp);
            this.p_clientes.Controls.Add(this.l_c_name);
            this.p_clientes.Controls.Add(this.t_cc_name);
            this.p_clientes.Controls.Add(this.t_cc_id);
            this.p_clientes.Controls.Add(this.t_cc_mail);
            this.p_clientes.Location = new System.Drawing.Point(10, 70);
            this.p_clientes.MaximumSize = new System.Drawing.Size(850, 450);
            this.p_clientes.Name = "p_clientes";
            this.p_clientes.Size = new System.Drawing.Size(850, 450);
            this.p_clientes.TabIndex = 17;
            this.p_clientes.Visible = false;
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
            this.b_cc_guardar.Click += new System.EventHandler(this.b_cc_guardar_Click);
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
            this.b_cc_agregar.Click += new System.EventHandler(this.b_cc_agregar_Click);
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
            this.b_cc_editar.Click += new System.EventHandler(this.b_cc_editar_Click);
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
            this.b_cc_buscar.Click += new System.EventHandler(this.b_cc_buscar_Click);
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
            this.t_cc_cid_b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_buscar);
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
            this.t_cc_curp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detect_enter);
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
            this.t_cc_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detect_enter);
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
            this.t_cc_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detect_enter);
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
            this.t_cc_mail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detect_enter);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.p_menu);
            this.Controls.Add(this.p_venta);
            this.Controls.Add(this.menu_st);
            this.Controls.Add(this.p_clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_st;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            this.menu_st.ResumeLayout(false);
            this.menu_st.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_venta)).EndInit();
            this.p_venta.ResumeLayout(false);
            this.p_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_clientes)).EndInit();
            this.p_clientes.ResumeLayout(false);
            this.p_clientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MenuStrip menu_st;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem reservarToolStripMenuItem;
        private ToolStripMenuItem checkInCheckOutToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem consultarClienteToolStripMenuItem;
        private ToolStripMenuItem ventazToolStripMenuItem;
        private ToolStripMenuItem consultarVentaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem agregarModificarToolStripMenuItem;
        private ToolStripMenuItem reporteDeProductosToolStripMenuItem;
        //private Krypton.Toolkit.KryptonPanel p_venta;
        private Krypton.Toolkit.KryptonPanel p_menu;
        private Krypton.Toolkit.KryptonButton b_cs_save;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonPanel p_venta;
        private Krypton.Toolkit.KryptonTextBox tb_cliente;
        private Krypton.Toolkit.KryptonTextBox tb_mail;
        private Krypton.Toolkit.KryptonTextBox tb_phone;
        private Krypton.Toolkit.KryptonTextBox tb_cs_id;
        private Krypton.Toolkit.KryptonDataGridView tabla;
        private DataGridViewTextBoxColumn Articulos;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Importe;
        public Krypton.Toolkit.KryptonPanel p_clientes;
        private Label l_c_detalles;
        private Krypton.Toolkit.KryptonButton b_cc_editar;
        private Label l_c_id;
        private Krypton.Toolkit.KryptonButton b_cc_buscar;
        private Label l_c_id_b;
        private Krypton.Toolkit.KryptonTextBox t_cc_cid_b;
        private Label l_c_phone;
        private Krypton.Toolkit.KryptonTextBox t_cc_curp;
        private Label l_c_mail;
        private Krypton.Toolkit.KryptonTextBox t_cc_phone;
        private Label l_c_curp;
        private Label l_c_name;
        private Krypton.Toolkit.KryptonTextBox t_cc_name;
        private Krypton.Toolkit.KryptonTextBox t_cc_id;
        private Krypton.Toolkit.KryptonTextBox t_cc_mail;
        private Krypton.Toolkit.KryptonButton b_cc_guardar;
        private Krypton.Toolkit.KryptonButton b_cc_agregar;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton b_buscar;
    }
}
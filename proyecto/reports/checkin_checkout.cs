using Krypton.Toolkit;
using Newtonsoft.Json;
using proyecto.formsu;
using proyecto.Properties;
using proyecto.reserva;
using proyecto.usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Krypton.Toolkit;
using Newtonsoft.Json;
using proyecto.formsu;
using proyecto.procedimientos;
using proyecto.Properties;
using proyecto.reserva;
using _rest = proyecto.procedimientos.rest;
using System.Runtime.InteropServices.ObjectiveC;
using PuppeteerSharp.Input;



//ESTE FALTA VALIDAR BIEN EL PRECIO, HABITACION Y APT CON LA API, SI GUSTAS MOVERLE, NP
//PERO COMENTA "//ATTE: @USER"
namespace proyecto.reports
{
    internal class checkin_checkout : KryptonPanel
    {
        private KryptonButton b_chk_buscar;
        private KryptonTextBox t_chk_ts;
        private KryptonLabel l_codigo_ts;
        private KryptonTextBox t_chk_cliente;
        private KryptonTextBox t_chk_checkin;
        private KryptonTextBox t_chk_checkout;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel4;
        private KryptonDataGridView chk_dtv_h;
        private KryptonButton b_chk_clear;
        private KryptonPanel p_checkin;
        private paleta kryptonPalette1;
        private KryptonButton chk_btn_change;
        private KryptonLabel l_estado;
        private KryptonLabel kryptonLabel5;
        private KryptonTextBox t_chk_total;
        private KryptonButton b_save;
        //private KryptonPanel kryptonPanel1;
        private DataGridViewTextBoxColumn personas;
        private DataGridViewTextBoxColumn piso;
        private DataGridViewTextBoxColumn Apt;
        private DataGridViewTextBoxColumn subtotal;

        private void init(paleta p)
        {
            //this.components = new System.ComponentModel.Container();
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkin_out));
            this.b_chk_buscar = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = p;
            this.t_chk_ts = new Krypton.Toolkit.KryptonTextBox();
            this.l_codigo_ts = new Krypton.Toolkit.KryptonLabel();
            this.t_chk_cliente = new Krypton.Toolkit.KryptonTextBox();
            this.t_chk_checkin = new Krypton.Toolkit.KryptonTextBox();
            this.t_chk_checkout = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.chk_dtv_h = new Krypton.Toolkit.KryptonDataGridView();
            this.personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_chk_clear = new Krypton.Toolkit.KryptonButton();
            this.p_checkin = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.t_chk_total = new Krypton.Toolkit.KryptonTextBox();
            this.chk_btn_change = new Krypton.Toolkit.KryptonButton();
            this.l_estado = new Krypton.Toolkit.KryptonLabel();
            this.b_save = new Krypton.Toolkit.KryptonButton();
            //this.kryptonPanel1 = new paleta();
            // 
            // b_chk_buscar
            // 
            this.b_chk_buscar.CornerRoundingRadius = -1F;
            this.b_chk_buscar.Location = new System.Drawing.Point(564+59, 20);
            this.b_chk_buscar.Name = "b_chk_buscar";
            this.b_chk_buscar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_chk_buscar.OverrideDefault.Back.Color2 = System.Drawing.Color.Yellow;
            this.b_chk_buscar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_chk_buscar.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_chk_buscar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_chk_buscar.Palette = this.kryptonPalette1;
            this.b_chk_buscar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.b_chk_buscar.Size = new System.Drawing.Size(107, 38);
            this.b_chk_buscar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_chk_buscar.TabIndex = 0;
            this.b_chk_buscar.Values.Text = "Buscar";
            this.b_chk_buscar.Click += new System.EventHandler(this.busqueda);
            // 
            // kryptonPalette1
            // 
            
            // 
            // t_chk_ts
            // 
            this.t_chk_ts.Location = new System.Drawing.Point(404+51, 20);
            this.t_chk_ts.MinimumSize = new System.Drawing.Size(0, 33);
            this.t_chk_ts.Name = "t_chk_ts";
            this.t_chk_ts.Palette = this.kryptonPalette1;
            this.t_chk_ts.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.t_chk_ts.Size = new System.Drawing.Size(154, 37);
            this.t_chk_ts.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.t_chk_ts.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.t_chk_ts.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_chk_ts.TabIndex = 1;
            this.t_chk_ts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            // 
            // kryptonLabel1
            // 
            this.l_codigo_ts.AutoSize = false;
            this.l_codigo_ts.Location = new System.Drawing.Point(174+59, 25);
            this.l_codigo_ts.Name = "kryptonLabel1";
            this.l_codigo_ts.Palette = this.kryptonPalette1;
            this.l_codigo_ts.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.l_codigo_ts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_codigo_ts.Size = new System.Drawing.Size(222, 32);
            this.l_codigo_ts.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.l_codigo_ts.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_codigo_ts.TabIndex = 2;
            this.l_codigo_ts.Values.Text = "Codigo de reservacion";
            // 
            // t_chk_cliente
            // 
            this.t_chk_cliente.Location = new System.Drawing.Point(117, 4);
            this.t_chk_cliente.MinimumSize = new System.Drawing.Size(0, 33);
            this.t_chk_cliente.Name = "t_chk_cliente";
            this.t_chk_cliente.Palette = this.kryptonPalette1;
            this.t_chk_cliente.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.t_chk_cliente.ReadOnly = true;
            this.t_chk_cliente.Size = new System.Drawing.Size(238, 37);
            this.t_chk_cliente.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_chk_cliente.TabIndex = 1;
            // 
            // t_chk_checkin
            // 
            this.t_chk_checkin.Location = new System.Drawing.Point(117, 43);
            this.t_chk_checkin.MinimumSize = new System.Drawing.Size(0, 33);
            this.t_chk_checkin.Name = "t_chk_checkin";
            this.t_chk_checkin.Palette = this.kryptonPalette1;
            this.t_chk_checkin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.t_chk_checkin.ReadOnly = true;
            this.t_chk_checkin.Size = new System.Drawing.Size(238, 37);
            this.t_chk_checkin.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_chk_checkin.TabIndex = 1;
            // 
            // t_chk_checkout
            // 
            this.t_chk_checkout.Location = new System.Drawing.Point(117, 82);
            this.t_chk_checkout.MinimumSize = new System.Drawing.Size(0, 33);
            this.t_chk_checkout.Name = "t_chk_checkout";
            this.t_chk_checkout.Palette = this.kryptonPalette1;
            this.t_chk_checkout.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.t_chk_checkout.ReadOnly = true;
            this.t_chk_checkout.Size = new System.Drawing.Size(238, 37);
            this.t_chk_checkout.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_chk_checkout.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(0, 6);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel2.Size = new System.Drawing.Size(100, 32);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Cliente";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(0, 44);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel3.Size = new System.Drawing.Size(100, 32);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Check-IN";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(0, 83);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel4.Size = new System.Drawing.Size(100, 32);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Check-OUT";
            // 
            // chk_dtv_h
            // 
            this.chk_dtv_h.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chk_dtv_h.ColumnHeadersHeight = 15;
            this.chk_dtv_h.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.chk_dtv_h.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personas,
            this.piso,
            this.Apt,
            this.subtotal});
            this.chk_dtv_h.Location = new System.Drawing.Point(361, 3);
            this.chk_dtv_h.Name = "chk_dtv_h";
            this.chk_dtv_h.Palette = this.kryptonPalette1;
            this.chk_dtv_h.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.chk_dtv_h.RowHeadersVisible = false;
            this.chk_dtv_h.RowHeadersWidth = 30;
            this.chk_dtv_h.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.chk_dtv_h.RowTemplate.Height = 25;
            this.chk_dtv_h.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chk_dtv_h.Size = new System.Drawing.Size(470, 236);
            this.chk_dtv_h.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.chk_dtv_h.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_dtv_h.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_dtv_h.TabIndex = 3;
            // 
            // personas
            // 
            this.personas.HeaderText = "Personas";
            this.personas.Name = "personas";
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            // 
            // Apt
            // 
            this.Apt.HeaderText = "Apt";
            this.Apt.Name = "Apt";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // kryptonButton2
            // 
            this.b_chk_clear.CornerRoundingRadius = -1F;
            this.b_chk_clear.Location = new System.Drawing.Point(677+59, 20);
            this.b_chk_clear.Name = "kryptonButton2";
            this.b_chk_clear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_chk_clear.OverrideDefault.Back.Color2 = System.Drawing.Color.Yellow;
            this.b_chk_clear.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_chk_clear.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_chk_clear.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_chk_clear.Palette = this.kryptonPalette1;
            this.b_chk_clear.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.b_chk_clear.Size = new System.Drawing.Size(107, 38);
            this.b_chk_clear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_chk_clear.TabIndex = 0;
            this.b_chk_clear.Values.Text = "Limpiar";
            this.b_chk_clear.Click += new System.EventHandler(this.limpiar_click);
            // 
            // p_checkin
            // 
            this.p_checkin.Controls.Add(this.chk_dtv_h);
            this.p_checkin.Controls.Add(this.t_chk_cliente);
            this.p_checkin.Controls.Add(this.kryptonLabel5);
            this.p_checkin.Controls.Add(this.kryptonLabel4);
            this.p_checkin.Controls.Add(this.t_chk_total);
            this.p_checkin.Controls.Add(this.t_chk_checkout);
            this.p_checkin.Controls.Add(this.kryptonLabel3);
            this.p_checkin.Controls.Add(this.t_chk_checkin);
            this.p_checkin.Controls.Add(this.kryptonLabel2);
            this.p_checkin.Location = new System.Drawing.Point(16, 64);
            this.p_checkin.MaximumSize = new System.Drawing.Size(850, 500);
            this.p_checkin.Name = "p_checkin";
            this.p_checkin.Palette = this.kryptonPalette1;
            this.p_checkin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.p_checkin.Size = new System.Drawing.Size(850, 280);
            this.p_checkin.TabIndex = 4;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(0, 207);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel5.Size = new System.Drawing.Size(100, 32);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Total";
            // 
            // t_chk_total
            // 
            this.t_chk_total.Location = new System.Drawing.Point(117, 206);
            this.t_chk_total.MinimumSize = new System.Drawing.Size(0, 33);
            this.t_chk_total.Name = "t_chk_total";
            this.t_chk_total.Palette = this.kryptonPalette1;
            this.t_chk_total.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.t_chk_total.ReadOnly = true;
            this.t_chk_total.Size = new System.Drawing.Size(238, 37);
            this.t_chk_total.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_chk_total.TabIndex = 1;
            // 
            // chk_btn_change
            // 
            this.chk_btn_change.CornerRoundingRadius = 45F;
            this.chk_btn_change.Location = new System.Drawing.Point(5, 9);
            this.chk_btn_change.Name = "chk_btn_change";
            this.chk_btn_change.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chk_btn_change.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.chk_btn_change.Palette = this.kryptonPalette1;
            this.chk_btn_change.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.chk_btn_change.Size = new System.Drawing.Size(45, 45);
            this.chk_btn_change.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.chk_btn_change.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.chk_btn_change.StateCommon.Border.Rounding = 45F;
            this.chk_btn_change.TabIndex = 0;
            this.chk_btn_change.Values.Text = "";
            this.chk_btn_change.Click += new System.EventHandler(this.chk_btn_change_Click);
            // 
            // l_estado
            // 
            this.l_estado.AutoSize = false;
            this.l_estado.Location = new System.Drawing.Point(56, 9);
            this.l_estado.Name = "l_estado";
            this.l_estado.Size = new System.Drawing.Size(136, 43);
            this.l_estado.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.l_estado.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_estado.TabIndex = 2;
            this.l_estado.Values.Text = "Check-IN";
            // 
            // kryptonButton1
            // 
            this.b_save.CornerRoundingRadius = -1F;
            this.b_save.Location = new System.Drawing.Point(575, 350);
            this.b_save.Name = "kryptonButton1";
            this.b_save.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_save.OverrideDefault.Back.Color2 = System.Drawing.Color.Yellow;
            this.b_save.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_save.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_save.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_save.Palette = this.kryptonPalette1;
            this.b_save.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.b_save.Size = new System.Drawing.Size(209, 38);
            this.b_save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_save.TabIndex = 0;
            this.b_save.Values.Text = "Guardar Cambios";
            this.b_save.Click += new System.EventHandler(this.boton_guardar_click);
            // 
            // kryptonPanel1
            // 
            Controls.Add(this.p_checkin);
            Controls.Add(this.l_codigo_ts);
            Controls.Add(this.t_chk_ts);
            Controls.Add(this.b_chk_clear);
            Controls.Add(this.chk_btn_change);
            Controls.Add(this.b_save);
            Controls.Add(this.b_chk_buscar);
            Controls.Add(this.l_estado);
            Location = new System.Drawing.Point(10, 70);
            MaximumSize = new System.Drawing.Size(850, 500);
            Name = "kryptonPanel1";
            Palette = this.kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Size = new System.Drawing.Size(850, 500);
            TabIndex = 5;
            // 
            // checkin_out
            // 
        }


        private void enter(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) buscar(t_chk_ts.Text); }



        bool inout = false;
        bool limpio = true;
        public checkin_checkout(paleta p)
        {
            init(p);
            //paleta.set(this);
            //foreach (dynamic co in Controls) co.Palette = paleta.p;
            t_chk_ts.Focus(); cambiar_estado();
        }

        private void checkin_out_FormClosing(object sender, FormClosingEventArgs e)
        { Application.Exit(); }

        private void checkin_out_Load(object sender, EventArgs e)
        { }

        private void reaparecer(object sender, EventArgs e)
        {
            limpiar(this); t_chk_ts.Focus();

        }

        private void limpiar_click(object sender, EventArgs e)
        {
            limpiar(this);

        }
        private void limpiar(dynamic item)
        {
            chk_dtv_h.Rows.Clear();
            //LIMPIA TODO ALV;
            foreach (Control c in item.Controls)
            {
                if (c is KryptonPanel p) limpiar(p); else if (c is KryptonTextBox t) t.Clear();
            }
            t_chk_ts.Focus();
            limpio = true;
        }
        private void boton_inout(object sender, EventArgs e)
        {
            cambiar_estado();
        }
        private void cambiar_estado()
        {
            inout = !inout; if (!limpio) limpiar(this);
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
            limpio = false;
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
                    foreach (habitacion_reservada r in habitaciones)
                    {
                        chk_dtv_h.Rows.Add(r.personas, r.piso, r.apt, $"${r.subtotal}");
                        total += int.Parse(r.subtotal);
                    }
                    t_chk_total.Text = $"${total}";
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
        {
            string url = $"http://localhost/alterar/{t_chk_ts.Text}_";
            /*Si esta en modo checkin cambia a ocupado las habitaciones\
            Caso contrario, la pondra en limpieza porque el cliente va
            de salida, y nimodo que dejemos bien puerco el cuarto*/
            if (inout) url += "2"; else url += "5";
            dynamic json = JsonConvert.DeserializeObject(_rest.consume(url));

        }
    }
}

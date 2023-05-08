using Krypton.Toolkit;
using proyecto.reserva;

namespace proyecto.usuario
{
    partial class checkin_out
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       // paleta p = new paleta();

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkin_out));
            this.b_chk_buscar = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.t_chk_ts = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.t_chk_cliente = new Krypton.Toolkit.KryptonTextBox();
            this.t_chk_checkin = new Krypton.Toolkit.KryptonTextBox();
            this.t_chk_checkout = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.chk_dtv_h = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.p_checkin = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.t_chk_total = new Krypton.Toolkit.KryptonTextBox();
            this.chk_btn_change = new Krypton.Toolkit.KryptonButton();
            this.l_estado = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chk_dtv_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_checkin)).BeginInit();
            this.p_checkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_chk_buscar
            // 
            this.b_chk_buscar.CornerRoundingRadius = -1F;
            this.b_chk_buscar.Location = new System.Drawing.Point(564, 20);
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
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_exit1;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_minus;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.kryptonPalette1.ButtonStyles.ButtonAlternate.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonButtonSpec.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonInputControl.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 35F;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 3;
            this.kryptonPalette1.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.DragDrop.SolidBorder = System.Drawing.Color.Lime;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.LemonChiffon;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Rounding = 10F;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 10F;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Rounding = 5F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.kryptonPalette1.InputControlStyles.InputControlCommon.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.InputControlStyles.InputControlCommon.StateActive.Border.Rounding = 10F;
            this.kryptonPalette1.InputControlStyles.InputControlCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonPalette1.InputControlStyles.InputControlCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.InputControlStyles.InputControlCommon.StateCommon.Border.Rounding = 5F;
            this.kryptonPalette1.InputControlStyles.InputControlCommon.StateCommon.Border.Width = 4;
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.LemonChiffon;
            this.kryptonPalette1.Ribbon.RibbonGroupButtonText.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // t_chk_ts
            // 
            this.t_chk_ts.Location = new System.Drawing.Point(404, 20);
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
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(174, 25);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Palette = this.kryptonPalette1;
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonLabel1.Size = new System.Drawing.Size(222, 32);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Codigo de reservacion";
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
            this.chk_dtv_h.Size = new System.Drawing.Size(411, 236);
            this.chk_dtv_h.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.chk_dtv_h.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_dtv_h.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_dtv_h.TabIndex = 3;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.CornerRoundingRadius = -1F;
            this.kryptonButton2.Location = new System.Drawing.Point(677, 20);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton2.Palette = this.kryptonPalette1;
            this.kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton2.Size = new System.Drawing.Size(107, 38);
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton2.TabIndex = 0;
            this.kryptonButton2.Values.Text = "Limpiar";
            this.kryptonButton2.Click += new System.EventHandler(this.limpiar_click);
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
            this.p_checkin.Name = "p_checkin";
            this.p_checkin.Palette = this.kryptonPalette1;
            this.p_checkin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.p_checkin.Size = new System.Drawing.Size(772, 280);
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
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.Location = new System.Drawing.Point(575, 350);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton1.Palette = this.kryptonPalette1;
            this.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(209, 38);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Guardar Cambios";
            this.kryptonButton1.Click += new System.EventHandler(this.boton_guardar_click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.p_checkin);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.t_chk_ts);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.chk_btn_change);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.b_chk_buscar);
            this.kryptonPanel1.Controls.Add(this.l_estado);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Palette = this.kryptonPalette1;
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel1.Size = new System.Drawing.Size(803, 414);
            this.kryptonPanel1.TabIndex = 5;
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
            // checkin_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkin_out";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.LemonChiffon;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "checkin_out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.checkin_out_FormClosing);
            this.Load += new System.EventHandler(this.checkin_out_Load);
            this.VisibleChanged += new System.EventHandler(this.reaparecer);
            ((System.ComponentModel.ISupportInitialize)(this.chk_dtv_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_checkin)).EndInit();
            this.p_checkin.ResumeLayout(false);
            this.p_checkin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonButton b_chk_buscar;
        private KryptonTextBox t_chk_ts;
        private KryptonLabel kryptonLabel1;
        private KryptonTextBox t_chk_cliente;
        private KryptonTextBox t_chk_checkin;
        private KryptonTextBox t_chk_checkout;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel4;
        private KryptonDataGridView chk_dtv_h;
        private KryptonButton kryptonButton2;
        private KryptonPanel p_checkin;
        private KryptonPalette kryptonPalette1;
        private KryptonButton chk_btn_change;
        private KryptonLabel l_estado;
        private KryptonLabel kryptonLabel5;
        private KryptonTextBox t_chk_total;
        private KryptonButton kryptonButton1;
        private KryptonPanel kryptonPanel1;
        private DataGridViewTextBoxColumn personas;
        private DataGridViewTextBoxColumn piso;
        private DataGridViewTextBoxColumn Apt;
        private DataGridViewTextBoxColumn subtotal;
    }
}
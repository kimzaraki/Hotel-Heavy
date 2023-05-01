using Krypton.Toolkit;
using proyecto.formsu;

namespace proyecto.reserva
{
    internal class panel_hab: KryptonPanel
    {
        KryptonPalette p = new paleta();
        public p_rooms linked;
        public habitacion room { get; set; }

        public KryptonTextBox t_p = new KryptonTextBox();
        private KryptonButton b_p_plus = new KryptonButton();
        private KryptonButton b_p_minus = new KryptonButton();
        private KryptonLabel l_p = new KryptonLabel();
        public  KryptonLabel l_room = new KryptonLabel();
        public KryptonButton b_delete = new KryptonButton();

        private int selected = 0;
        public panel_hab(string nhab, p_rooms p)
        {
            iniciar(nhab);linked = p;
        }
        void iniciar(string nhab)
        { 
            this.l_room.Palette = p;
            this.l_p.Palette = p;
            this.b_delete.Palette = p;
            this.b_p_plus.Palette = p;
            this.b_p_minus.Palette = p;
            this.t_p.Palette = p;


            this.b_delete.Click += B_delete_Click;
            this.b_p_minus.Click += presionado;
            this.b_p_plus.Click += presionado;

            this.l_room.Text = "Habitacion #"+nhab;

            // 
            // l_room
            // 
            this.l_room.Location = new System.Drawing.Point(15, 15);
            this.l_room.Name = "l_room";
            this.l_room.Size = new System.Drawing.Size(57, 23);
            this.l_room.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_room.TabIndex = 5;
            // 
            // l_adultos
            // 
            this.l_p.Location = new System.Drawing.Point(14, 76);
            this.l_p.Name = "l_adultos";
            this.l_p.Size = new System.Drawing.Size(75, 23);
            this.l_p.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_p.TabIndex = 5;
            this.l_p.Values.Text = "Personas";
            // 
            // b_adult_minus
            // 
            this.b_p_minus.CornerRoundingRadius = -1F;
            this.b_p_minus.Location = new System.Drawing.Point(109, 74);
            this.b_p_minus.Name = "b_adult_minus";
            this.b_p_minus.Size = new System.Drawing.Size(46, 23);
            this.b_p_minus.TabIndex = 2;
            this.b_p_minus.Values.Text = "-";
            // 
            // t_adult
            // 
            this.t_p.Location = new System.Drawing.Point(161, 67);
            this.t_p.Name = "t_adult";
            this.t_p.Size = new System.Drawing.Size(70, 29);
            this.t_p.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.t_p.TabIndex = 1;
            // 
            // b_adult_plus
            // 
            this.b_p_plus.CornerRoundingRadius = -1F;
            this.b_p_plus.Location = new System.Drawing.Point(237, 74);
            this.b_p_plus.Name = "b_adult_plus";
            this.b_p_plus.Size = new System.Drawing.Size(46, 23);
            this.b_p_plus.TabIndex = 2;
            this.b_p_plus.Values.Text = "+";
            // 
            // b_delete
            // 
            this.b_delete.CornerRoundingRadius = -1F;
            this.b_delete.Location = new System.Drawing.Point(235, 9);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(50, 50);
            this.b_delete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.b_delete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.b_delete.TabIndex = 6;
            this.b_delete.Values.Image = global::proyecto.Properties.Resources.basure;
            this.b_delete.Values.Text = "-";

            this.Controls.Add(this.l_room);
            this.Controls.Add(this.l_p);
            this.Controls.Add(this.b_p_minus);
            this.Controls.Add(this.t_p);
            this.Controls.Add(this.b_p_plus);
            this.Controls.Add(this.b_delete);
            this.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Size = new System.Drawing.Size(300, 150);
            this.TabIndex = 4;


            

            setcolors(Color.White);
            foreach (Control c in this.Controls)
                if (c is KryptonButton kb)
                    kb.StateCommon.Border.Color1 = Color.Black;
            this.b_p_plus.BackColor = Color.Green;
            this.b_p_minus.BackColor = Color.Red;
        }
        void setcolors(Color c)
        {
            this.StateCommon.Color1 = c;
            this.l_p.BackColor = c;
            this.l_room.BackColor = c;
        }
        private void B_delete_Click(object sender, EventArgs e)
        {
            linked.cambiar();
            Dispose();
        }
        private void presionado(object sender, EventArgs e)
        {
            operacion((KryptonButton)sender);
        }
        private void operacion(Control c)
        {
            KryptonTextBox control = new KryptonTextBox(); bool sum = true;
            if (c == b_p_plus) control = t_p;
            if (c == b_p_minus) { control = t_p; sum = !sum; }
            if (control.Text == "") control.Text = "0";
            int cant = int.Parse(control.Text);
            if (sum) cant++; else if (cant != 0) cant--;
            control.Text = cant.ToString();
        }

    }
}

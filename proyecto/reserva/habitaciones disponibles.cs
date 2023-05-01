using Krypton.Toolkit;
using proyecto.formsu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.reserva
{
    class p_rooms : KryptonPanel
    {
        public bool selected = false;

        public panel_hab linked;

        public habitacion room { get; set; }
        public KryptonLabel l_info;
        public KryptonLabel l_disponible;
        //private KryptonButton b_hide;
        public KryptonButton b_add;
        public p_rooms()
        {
            this.l_info= new KryptonLabel();
            this.l_disponible= new KryptonLabel();
            //this.b_hide = new KryptonButton();
            this.b_add = new KryptonButton();

            this.Controls.Add(l_info);
            this.Controls.Add(l_disponible);
            //this.Controls.Add(b_hide);
            this.Controls.Add(b_add);

            this.b_add.Click += alterarestado;
            //this.b_hide.Click += B_hide_Click;

            this.Size = new System.Drawing.Size(395,107);

            /*
            // 
            // b_hide
            // 
            this.b_hide.CornerRoundingRadius = -1F;
            this.b_hide.Location = new System.Drawing.Point(248, 62);
            this.b_hide.Name = "b_hide";
            this.b_hide.Size = new System.Drawing.Size(69, 25);
            this.b_hide.TabIndex = 9;
            this.b_hide.Values.Text = "Ocultar";
            */
            // 
            // b_add
            // 
            this.b_add.CornerRoundingRadius = -1F;
            this.b_add.Location = new System.Drawing.Point(240, 57);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(150, 30);
            this.b_add.TabIndex = 9;
            this.b_add.Values.Text = "Agregar";

            // 
            // l_disponible
            // 
            this.l_disponible.AutoSize = false;
            this.l_disponible.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.l_disponible.Location = new System.Drawing.Point(265, 3);
            this.l_disponible.Name = "l_disponible";
            this.l_disponible.Size = new System.Drawing.Size(127, 35);
            this.l_disponible.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.l_disponible.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.l_disponible.TabIndex = 8;
            this.l_disponible.Values.Text = "@disponibilidad";
            this.l_disponible.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 14f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // l_info
            // 
            this.l_info.AutoSize = false;
            this.l_info.Location = new System.Drawing.Point(3, 3);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(200, 100);
            this.l_info.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.l_info.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.l_info.TabIndex = 0;
            this.l_info.Values.Text = "@tipo                                                                   \r\n\r\nPiso " +
    "#@piso Apt.#@habitacion\r\n$@precio";
            this.l_info.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;


            cambiarcolores(Color.White);
        }

        private void B_hide_Click(object? sender, EventArgs e)
        {Dispose();}

        private void alterarestado(object sender, EventArgs e)
        { cambiar(); }
        private void cambiarcolores(Color c)
        {
            this.StateCommon.Color1 = c;
            this.l_disponible.BackColor = c;
            this.l_info.BackColor = c;
        }
        public void cambiar()
        {
            if (!selected) { cambiarcolores(Color.LightGreen); b_add.Text = "Cancelar"; linked = new panel_hab($"{room.id}\n{room.nombre}", this); }
            else { cambiarcolores(Color.White); b_add.Text = "Agregar"; linked.Dispose(); }
            selected = !selected;
        }
    }
}
